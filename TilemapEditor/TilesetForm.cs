using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Project      : Tilemap Editor
 * Description  : A C# program where you can modify and create tilesets and tilemaps with an access to a database
 * File         : TilesetForm.cs
 * Author       : Weber Jamie
 * Date         : 20 October 2023
**/
namespace TilemapEditor
{
    /// <summary>
    /// The form to show the tiles of a tileset
    /// </summary>
    public partial class TilesetForm : Form
    {
        /// <summary>
        /// The tileset
        /// </summary>
        Tileset set;

        /// <summary>
        /// The constructor of the class
        /// Initializes the component and get the tileset
        /// </summary>
        /// <param name="set">The tileset</param>
        public TilesetForm(Tileset set)
        {
            InitializeComponent();
            this.set = set;
        }

        /// <summary>
        /// When loading the form
        /// Show the tileset and change the titles
        /// </summary>
        /// <param name="sender">the sender of the event</param>
        /// <param name="e">The event</param>
        private void TilesetForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Tileset : {this.set.Name}";
            TitleLbl.Text = $"Tileset : {this.set.Name}";
            MainPbx.Image = this.set.GetImage;
        }
    }
}
