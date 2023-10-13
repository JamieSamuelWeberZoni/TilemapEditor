using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Project      : Tilemap Editor
 * Description  : A C# program where you can modify and create tilesets and tilemaps with an access to a database
 * File         : Tilemap.cs
 * Author       : Weber Jamie
 * Date         : 13 October 2023
**/
namespace TilemapEditor
{
    /// <summary>
    /// The class for a tilemap
    /// </summary>
    internal class Tilemap
    {
        /// <summary>
        /// The id of the tilemap
        /// </summary>
        private int id;

        /// <summary>
        /// The name of the tilemap
        /// </summary>
        private string name;

        /// <summary>
        /// The tileset the tilemap uses
        /// </summary>
        private Tileset tileset;

        /// <summary>
        /// The tile number for each positions
        /// </summary>
        private int[,] tiles;

        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="id">The id of the tilemap</param>
        /// <param name="name">The name of the tilemap</param>
        /// <param name="tileset">The tileset the tilemap uses</param>
        /// <param name="tiles">The tile number for each positions</param>
        public Tilemap(int id, string name, Tileset tileset, DataTable tiles)
        {
            this.id = id;
            this.name = name;
            this.tileset = tileset;
            this.tiles = new int[32, 32];
            foreach(DataRow tile in tiles.Rows)
            {
                int x = (int)tile["posX"];
                int y = (int)tile["posY"];
                int nbr = (int)tile["number"];
                this.tiles[x, y] = nbr;
            }
        }

        /// <summary>
        /// Get the image of the map
        /// </summary>
        public Bitmap GetImage
        {
            get
            {
                List<Bitmap> tiles = this.tileset.GetTiles;
                Bitmap img = new Bitmap(512, 512);
                Graphics g = Graphics.FromImage(img);
                for (int x = 0; x < 32; x++)
                {
                    for (int y = 0; y < 32; y++)
                    {
                        int nbr = this.tiles[x, y];
                        g.DrawImage(tiles[nbr], new Point(y * 16, x * 16));
                    }
                }
                g.Dispose();
                return img;
            }
        }
    }
}
