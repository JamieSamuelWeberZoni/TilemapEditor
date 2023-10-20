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
 * File         : TilemapForm.cs
 * Author       : Weber Jamie
 * Date         : 20 October 2023
**/
namespace TilemapEditor
{
    /// <summary>
    /// The form to show a tilemap
    /// </summary>
    public partial class TilemapForm : Form
    {
        /// <summary>
        /// The tilemap
        /// </summary>
        Tilemap map;

        /// <summary>
        /// The constructor of the class
        /// Initializes the component and get the tilemap
        /// </summary>
        /// <param name="map">The tilemap</param>
        public TilemapForm(Tilemap map)
        {
            InitializeComponent();
            this.map = map;
        }

        /// <summary>
        /// When loading the form
        /// Show the tilemap and change the titles
        /// </summary>
        /// <param name="sender">the sender of the event</param>
        /// <param name="e">The event</param>
        private void TilemapForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Tilemap : {this.map.Name}";
            TitleLbl.Text = $"Tilemap : {this.map.Name}";
            MainPbx.Image = this.map.GetImage;
        }
    }
}
