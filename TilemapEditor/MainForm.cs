
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
    public partial class MainForm : Form
    {
        DbManager db;

        public MainForm()
        {
            InitializeComponent();
            db = DbManager.Instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshTilesets();
            RefreshTilemaps();
        }

        private void RefreshTilesets()
        {
            TilesetsDgv.DataSource = db.Tilesets;
        }

        private void RefreshTilemaps()
        {
            TilemapsDgv.DataSource = db.Tilemaps;
        }

        private void PreviewTilesetBtn_Click(object sender, EventArgs e)
        {
            int id = (int)TilesetsDgv.CurrentRow.Cells[0].Value;
            TilesetForm form = new(db.GetTileset(id));
            form.Show();
        }

        private void PreviewTilemapBtn_Click(object sender, EventArgs e)
        {
            int id = (int)TilemapsDgv.CurrentRow.Cells[0].Value;
            TilemapForm form = new(db.GetTilemap(id));
            form.Show();
        }
    }
}