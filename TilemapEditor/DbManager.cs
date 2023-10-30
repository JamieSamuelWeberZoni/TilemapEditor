using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Project      : Tilemap Editor
 * Description  : A C# program where you can modify and create tilesets and tilemaps with an access to a database
 * File         : DbManager.cs
 * Author       : Weber Jamie
 * Date         : 13 October 2023
**/
namespace TilemapEditor
{
    /// <summary>
    /// The class that manages the discussions with the database
    /// </summary>
    public class DbManager
    {
        /// <summary>
        /// The connection to the database
        /// </summary>
        private MySqlConnection connection;

        /// <summary>
        /// The instance of the class
        /// </summary>
        private static DbManager? instance;

        /// <summary>
        /// The constructor of the class
        /// Create the connection to the database and open it
        /// </summary>
        private DbManager()
        {
            string server = "localhost";
            string database = "TilemapEditor";
            string uid = "dbTilemapEditor";
            string password = "tilePassword";
            string connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        /// <summary>
        /// The singleton pattern to get only one instance of this class
        /// </summary>
        public static DbManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbManager();
                }
                return instance;
            }
        }

        /// <summary>
        /// If a SELECT request is needed, call this function
        /// Get the requested data from the database by using the sql query given in parameter and put it in a DataTable
        /// </summary>
        /// <param name="sql">The sql query to execute</param>
        /// <param name="options">The options if needed</param>
        /// <returns>A datatable of the data returned from the database</returns>
        private DataTable GetTable(string sql, Dictionary<string, (object, MySqlDbType)>? options = null)
        {
            MySqlCommand query = new(sql, connection);
            if (options != null)
            {
                foreach (KeyValuePair<string, (object, MySqlDbType)> option in options)
                {
                    query.Parameters.Add(option.Key, option.Value.Item2).Value = option.Value.Item1;
                }
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter(query);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// If an Update or Insert request is needed, call this function
        /// Change the data from the database
        /// </summary>
        /// <param name="sql">The sql query to execute</param>
        /// <param name="options">The options if needed</param>
        private void ChangeDatabase(string sql, Dictionary<string, (object, MySqlDbType)>? options = null)
        {
            MySqlCommand query = new(sql, connection);
            if (options != null)
            {
                foreach(KeyValuePair<string, (object, MySqlDbType)> option in options)
                {
                    query.Parameters.Add(option.Key, option.Value.Item2).Value = option.Value.Item1;
                }
            }
            query.ExecuteNonQuery();
        }

        /// <summary>
        /// Get the list of tilesets from the database
        /// </summary>
        public DataTable Tilesets { get { return GetTable("SELECT Tilesets.idTileset AS 'Id', Tilesets.name AS 'Nom', COUNT(Tiles.idTileset) as 'Tiles' FROM Tilesets, Tiles WHERE Tilesets.idTileset = Tiles.idTileset GROUP BY Tilesets.idTileset"); } }

        /// <summary>
        /// Get the list of tilemaps from the database
        /// </summary>
        public DataTable Tilemaps { get { return GetTable("SELECT Tilemaps.idTilemap AS 'Id', Tilemaps.name AS 'Nom', Tilesets.name AS 'Tileset' FROM Tilemaps, Tilesets WHERE Tilemaps.idTileset = Tilesets.idTileset;"); } }


        /// <summary>
        /// Get a tileset depending on the given id
        /// </summary>
        /// <param name="id">The id of the tileset</param>
        /// <returns>A Tileset instance</returns>
        public Tileset GetTileset(int id)
        {
            Dictionary<string, (object, MySqlDbType)> opt = new()
            {
                ["@id"] = (id, MySqlDbType.Int32)
            };
            DataRow tileset = GetTable("SELECT * FROM Tilesets WHERE idTileset = @id;", opt).Rows[0];
            DataTable tiles = GetTable("SELECT image, number FROM Tiles WHERE idTileset = @id ORDER BY number;", opt);
            return new Tileset((int)tileset["idTileset"], (string)tileset["name"], tiles);
        }

        /// <summary>
        /// Get a tilemap depending on the given id
        /// </summary>
        /// <param name="id">The id of the tilemap</param>
        /// <returns>A Tilemap instance</returns>
        public Tilemap GetTilemap(int id)
        {
            Dictionary<string, (object, MySqlDbType)> opt = new()
            {
                ["@id"] = (id, MySqlDbType.Int32)
            };
            DataRow tilemap = GetTable("SELECT * FROM Tilemaps WHERE idTilemap = @id;", opt).Rows[0];
            Tileset tileset = GetTileset((int)tilemap["idTileset"]);
            DataTable tiles = GetTable("SELECT posX, posY, number FROM TilesPosition WHERE idTilemap = @id ORDER BY posX, posY;", opt);
            return new Tilemap((int)tilemap["idTilemap"], (string)tilemap["name"], tileset, tiles);
        }

        /// <summary>
        /// Create a new tileset for the database
        /// </summary>
        /// <param name="name">The name of the tileset</param>
        /// <param name="tile">The base tile of the tileset</param>
        public void AddTileset(string name, Bitmap tile)
        {
            MemoryStream ms = new MemoryStream();
            tile.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Dictionary<string, (object, MySqlDbType)> opt = new Dictionary<string, (object, MySqlDbType)>()
            {
                ["@name"] = (ms.ToArray(), MySqlDbType.VarChar)
            };
            ChangeDatabase("INSERT INTO Tilesets (name) VALUES (@name);", opt);
            int id = (int)(GetTable("SELECT Tilesets.idTileset AS 'id' FROM Tilesets WHERE Tilesets.name = @name;", opt).Rows[0]["id"]);
            opt = new Dictionary<string, (object, MySqlDbType)>() {
                ["@img"] = (ms.ToArray(), MySqlDbType.LongBlob),
                ["@id"] = (Convert.ToString(id), MySqlDbType.Int32)
            };
            ChangeDatabase("INSERT INTO Tiles (number, image, idTileset) VALUES (0, @img, @id);", opt);
        }

        /// <summary>
        /// Create a new tilemap for the database
        /// </summary>
        /// <param name="name">The name of the tilemap</param>
        /// <param name="idTileset">The tileset the tilemap uses</param>
        public void AddTilemap(string name, int idTileset)
        {
            Dictionary<string, (object, MySqlDbType)> opt = new()
            {
                ["@name"] = (name, MySqlDbType.VarChar),
                ["@id"] = (idTileset, MySqlDbType.Int32)
            };
            ChangeDatabase("INSERT INTO Tilemaps (name, idTileset) VALUES (@name, @id);", opt);
            opt = new()
            {
                ["@name"] = (name, MySqlDbType.VarChar)
            };
            int id = (int)(GetTable("SELECT idTilemap AS 'id' FROM Tilemaps WHERE name = @name;", opt).Rows[0]["id"]);
            opt = new()
            {
                ["@id"] = (id, MySqlDbType.Int32),
                ["@posX"] = (0, MySqlDbType.Int32),
                ["@posY"] = (0, MySqlDbType.Int32)
            };
            for (int i = 0; i < 32; i++)
            {
                opt["@posX"] = (i, MySqlDbType.Int32);
                for (int ii = 0; ii < 32; ii++)
                {
                    opt["@posY"] = (ii, MySqlDbType.Int32);
                    ChangeDatabase("INSERT INTO TilesPosition (idTilemap, posX, posY, number) VALUES (@id, @posX, @posY, 0);", opt);
                }
            }
        }

        /// <summary>
        /// Add a tile to the given tileset
        /// </summary>
        /// <param name="idTileset">The id of the tileset</param>
        /// <param name="tile">The image of the tile</param>
        public void AddTile(int idTileset, Bitmap tile)
        {
            MemoryStream ms = new MemoryStream();
            tile.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Dictionary<string, (object, MySqlDbType)> opt = new()
            {
                ["@id"] = (idTileset, MySqlDbType.Int32)
            };
            int number = (int)(GetTable("SELECT COUNT(idTile) AS 'number' FROM Tiles WHERE idTileset = @id;", opt).Rows[0]["number"]);
            opt = new()
            {
                ["@id"] = (idTileset, MySqlDbType.Int32),
                ["@img"] = (ms.ToArray(), MySqlDbType.LongBlob),
                ["@number"] = (number, MySqlDbType.Int32)
            };
            ChangeDatabase("INSERT INTO Tiles (idTileset, image, number) VALUES (@id, @img, @number);", opt);
        }

        /// <summary>
        /// Modify a given tile from a given tileset
        /// </summary>
        /// <param name="idTileset">The id of the tileset</param>
        /// <param name="number">The number of the tile in the tileset</param>
        /// <param name="tile">The new image of the tile</param>
        public void ModifyTile(int idTileset, int number, Bitmap tile)
        {
            MemoryStream ms = new MemoryStream();
            tile.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Dictionary<string, (object, MySqlDbType)> opt = new()
            {
                ["@img"] = (ms.ToArray(), MySqlDbType.LongBlob),
                ["@id"] = (idTileset, MySqlDbType.Int32),
                ["@number"] = (number, MySqlDbType.Int32)
            };
            ChangeDatabase("UPDATE tiles SET image = @img WHERE idTileset = @id AND number = @number;", opt);
        }

        /// <summary>
        /// Modify The tilemap in the database
        /// </summary>
        /// <param name="idTilemap">The id of the tilemap</param>
        /// <param name="tiles">An array of the number of the tiles of the tilemap</param>
        public void ModifyMap(int idTilemap, int[,] tiles)
        {
            Dictionary<string, (object, MySqlDbType)> opt = new()
            {
                ["@id"] = (idTilemap, MySqlDbType.Int32),
                ["@posX"] = (0, MySqlDbType.Int32),
                ["@posY"] = (0, MySqlDbType.Int32),
                ["@number"] = (0, MySqlDbType.Int32)
            };
            for (int i = 0; i < 32; i++)
            {
                opt["@posX"] = (i, MySqlDbType.Int32);
                for (int ii = 0; ii < 32; ii++)
                {
                    opt["@posY"] = (ii, MySqlDbType.Int32);
                    opt["@number"] = (tiles[i,ii], MySqlDbType.Int32);
                    ChangeDatabase("UPDATE tilesPosition SET number = @number WHERE idTilemap = @id AND posX = @posX AND posY = @posY;", opt);
                }
            }
        }
    }
}
