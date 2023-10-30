using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TilemapEditor
{
    public partial class NewMapForm : Form
    {
        /// <summary>
        /// The manager of the database
        /// </summary>
        DbManager db;

        /// <summary>
        /// The main form of the app
        /// </summary>
        MainForm main;

        Tileset[] tilesets;

        /// <summary>
        /// The constructor of the class
        /// Initialize the component and get an instance of DbManager and MainForm and get the list of tilesets
        /// </summary>
        public NewMapForm()
        {
            InitializeComponent();
            db = DbManager.Instance;
            main = MainForm.Instance;
            DataTable tilesetsDt = db.Tilesets;
            tilesets = new Tileset[tilesetsDt.Rows.Count];
            int i = 0;
            foreach(DataRow tileset in tilesetsDt.Rows)
            {
                tilesets[i] = new Tileset((int)tileset["Id"], (string)tileset["Nom"], new DataTable());
                i++;
            }
        }

        /// <summary>
        /// When the form is loaded
        /// get the tileset in the combobox
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void NewMapForm_Load(object sender, EventArgs e)
        {
            TilesetCbx.DataSource = tilesets;
            TilesetCbx.DisplayMember = "Name";
        }

        /// <summary>
        /// When the form is closed
        /// Enable the main form
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void NewMapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = true;
        }

        /// <summary>
        /// When the cancel button is clicked
        /// closes the form
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (NameTbx.Text != "")
            {
                Tileset tileset = (Tileset)TilesetCbx.SelectedItem;
                db.AddTilemap(NameTbx.Text, tileset.Id);
                main.RefreshTilemaps();
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs svp");
            }
        }
    }
}
