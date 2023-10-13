using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
/**
 * Project      : Tilemap Editor
 * Description  : A C# program where you can modify and create tilesets and tilemaps with an access to a database
 * File         : Tileset.cs
 * Author       : Weber Jamie
 * Date         : 13 October 2023
**/
namespace TilemapEditor
{
    /// <summary>
    /// A class of a tileset
    /// </summary>
    internal class Tileset
    {
        /// <summary>
        /// The id of the tileset
        /// </summary>
        private int id;

        /// <summary>
        /// The name of the tileset
        /// </summary>
        private string name;

        /// <summary>
        /// The list of tiles of the tileset
        /// </summary>
        private DataTable tiles;

        /// <summary>
        /// Get the id of the tileset
        /// </summary>
        public int Id { get { return id; } }

        /// <summary>
        /// Get the name of the tileset
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="id">The id of the tileset</param>
        /// <param name="name">The name of the tileset</param>
        /// <param name="tiles">The list of tiles of the tileset</param>
        public Tileset(int id, string name, DataTable tiles)
        {
            this.id = id;
            this.name = name;
            this.tiles = tiles;
        }

        /// <summary>
        /// Get a list of the images of each tiles
        /// </summary>
        public List<Bitmap> GetTiles
        {
            get
            {
                List<Bitmap> listTiles = new List<Bitmap>();
                foreach(DataRow tile in tiles.Rows)
                {
                    byte[] blob = (byte[])tile["image"];
                    MemoryStream ms = new MemoryStream(blob);
                    Bitmap image = (Bitmap)Bitmap.FromStream(ms);
                    listTiles.Add(image);
                }
                return listTiles;
            }
        }

        /// <summary>
        /// Return an image of all the tiles
        /// </summary>
        public Bitmap GetTilesImg
        {
            get
            {
                List<Bitmap> tiles = this.GetTiles;
                Bitmap img = new Bitmap(112, 512);
                Graphics g = Graphics.FromImage(img);
                g.Clear(Color.White);
                for(int i = 0; i < tiles.Count; i++)
                {
                    int x = (i % 7) * 16;
                    int y = Convert.ToInt32(Math.Floor(i / 7.0)) * 16;
                    g.DrawImage(tiles[i], x, y);
                }
                g.Dispose();
                return img;
            }
        }

    }
}
