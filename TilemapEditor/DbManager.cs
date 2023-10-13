using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    internal class DbManager
    {
        private MySqlConnection connection;
        private static DbManager? dbManager;

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

        public static DbManager Instance
        {
            get
            {
                if (dbManager == null)
                {
                    dbManager = new DbManager();
                }
                return dbManager;
            }
        }
    }
}
