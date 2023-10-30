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
 * File         : NewSetForm.cs
 * Author       : Weber Jamie
 * Date         : 20-30 October 2023
**/
namespace TilemapEditor
{
    /// <summary>
    /// The form to create a new tileset
    /// </summary>
    public partial class NewSetForm : Form
    {
        /// <summary>
        /// The first tile of the tilemap
        /// </summary>
        Bitmap tile;

        /// <summary>
        /// The manager of the database
        /// </summary>
        DbManager db;

        /// <summary>
        /// The main form of the app
        /// </summary>
        MainForm main;

        /// <summary>
        /// The constructor of the class
        /// Set the main tile to all black and get the instance of DbManager and MainForm
        /// </summary>
        public NewSetForm()
        {
            InitializeComponent();
            tile = new Bitmap(16, 16);
            Graphics g = Graphics.FromImage(tile);
            g.Clear(Color.Black);
            g.Dispose();
            main = MainForm.Instance;
            db = DbManager.Instance;
        }

        /// <summary>
        /// When the form is loading
        /// Show the tile
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void NewSetForm_Load(object sender, EventArgs e)
        {
            ShowTile();
        }

        /// <summary>
        /// Show in the picture box the tile saved here
        /// </summary>
        private void ShowTile()
        {
            Bitmap bmp = new Bitmap(64, 64);
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(tile, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            TilePbx.Image = bmp;
        }

        /// <summary>
        /// When the reset button is pushed
        /// Set the tile to all black
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void ResetTileBtn_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(tile);
            g.Clear(Color.Black);
            g.Dispose();
            ShowTile();
        }

        /// <summary>
        /// When the choose button is pushed
        /// Open a file dialog and if the user choose an image check if it is 16x16
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void ChooseTileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "16x16 Images (*.png)|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                Bitmap bmp = new Bitmap(filepath);
                if (bmp.Width != 16 && bmp.Height != 16)
                {
                    MessageBox.Show("Veuillez s'il vous plait choisir une image 16x16 pixels");
                }
                else
                {
                    tile = bmp;
                    ShowTile();
                }
            }
        }

        /// <summary>
        /// When the create button is pressed
        /// Verify if there is a name given and create a new tileset in the database
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (NameTbx.Text != "")
            {
                db.AddTileset(NameTbx.Text, tile);
                main.RefreshTilesets();
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs svp");
            }
        }

        /// <summary>
        /// When the cancel button is pressed
        /// close this form
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When the form is closed
        /// Enable the main form
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void NewSetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = true;
        }
    }
}
