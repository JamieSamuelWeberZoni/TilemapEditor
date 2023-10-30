
using System.Data;
/**
* Project      : Tilemap Editor
* Description  : A C# program where you can modify and create tilesets and tilemaps with an access to a database
* File         : MainForm.cs
* Author       : Weber Jamie
* Date         : 13 October 2023
**/
namespace TilemapEditor
{
    /// <summary>
    /// The main form of the app
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The manager of the database
        /// </summary>
        DbManager db;

        /// <summary>
        /// The instance of this class
        /// </summary>
        private static MainForm? instance;

        /// <summary>
        /// The constructor of this class
        /// initialize the components and get the instance of DbManager
        /// </summary>
        private MainForm()
        {
            InitializeComponent();
            db = DbManager.Instance;
        }

        /// <summary>
        /// The singleton for this class to get only one instance
        /// </summary>
        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainForm();
                }
                return instance;
            }
        }

        /// <summary>
        /// When the form is loaded
        /// Get the list of tilesets and of tilemaps from the database
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshTilesets();
            RefreshTilemaps();
        }

        /// <summary>
        /// Get the list of tilesets from the database and show it in a DataGridView
        /// </summary>
        public void RefreshTilesets()
        {
            TilesetsDgv.DataSource = db.Tilesets;
        }

        /// <summary>
        /// Get the list of tilemaps from the database and show it in a DataGridView
        /// </summary>
        public void RefreshTilemaps()
        {
            TilemapsDgv.DataSource = db.Tilemaps;
        }

        /// <summary>
        /// When the preview tileset button is clicked
        /// show all the tiles of the tileset
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void PreviewTilesetBtn_Click(object sender, EventArgs e)
        {
            int id = (int)TilesetsDgv.CurrentRow.Cells[0].Value;
            TilesetForm form = new(db.GetTileset(id));
            form.Show();
        }

        /// <summary>
        /// When the preview tilemap button is clicked
        /// show the image of the tilemap
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void PreviewTilemapBtn_Click(object sender, EventArgs e)
        {
            int id = (int)TilemapsDgv.CurrentRow.Cells[0].Value;
            TilemapForm form = new(db.GetTilemap(id));
            form.Show();
        }

        /// <summary>
        /// When the new tileset button is clicked
        /// open a form to create a new tileset
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void newTilesetBtn_Click(object sender, EventArgs e)
        {
            new NewSetForm().Show();
            this.Enabled = false;
        }

        private void NewTilemapBtn_Click(object sender, EventArgs e)
        {
            new NewMapForm().Show();
            this.Enabled = false;
        }
    }
}