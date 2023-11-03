
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
        private DbManager db;

        /// <summary>
        /// The instance of this class
        /// </summary>
        private static MainForm? instance;

        /// <summary>
        /// The selected tile in the modify tileset tab
        /// </summary>
        private int selectTileset;

        private Tileset? currSet;

        /// <summary>
        /// The selected tile in the modify tilemap tab
        /// </summary>
        private int selectTilemap;

        private Tilemap? currMap;

        /// <summary>
        /// The constructor of this class
        /// initialize the components and get the instance of DbManager
        /// </summary>
        private MainForm()
        {
            InitializeComponent();
            db = DbManager.Instance;
            selectTilemap = 0;
            selectTileset = 0;
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
            ModifyTilesetPage.Enabled = false;
            ModifyTilemapPage.Enabled = false;
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

        /// <summary>
        /// When the new tilemap button is clicked
        /// open a form to create a new tilemap
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void NewTilemapBtn_Click(object sender, EventArgs e)
        {
            new NewMapForm().Show();
            this.Enabled = false;
        }

        /// <summary>
        /// When the refresh tilemaps button is clicked
        /// Refresh the list of tilemaps
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void RefreshTilemapsBtn_Click(object sender, EventArgs e)
        {
            RefreshTilemaps();
        }

        /// <summary>
        /// When the refresh tilesets button is clicked
        /// Refresh the list of tilesets
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void RefreshTilesetsBtn_Click(object sender, EventArgs e)
        {
            RefreshTilesets();
        }

        /// <summary>
        /// When the modify tileset button is pressed
        /// Get all the infos of the selected tileset and go to the modify tileset tab
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void ModifyTilesetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)TilesetsDgv.CurrentRow.Cells[0].Value;
                currSet = db.GetTileset(id);
                TilesetNameLbl.Text = $"Tileset : \"{currSet.Name}\"";
                TilesetSizeLbl.Text = $"Tiles : {currSet.Size}/112";
                selectTileset = 0;
                DrawSelectedTile();
                MainTabControl.SelectedIndex = 1;
                ModifyTilesetPage.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Erreur");
            }
        }

        /// <summary>
        /// When the tileset image PictureBox is clicked
        /// Verify if we chose a correct tile and change the selected tile to it
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void TilesetPbx_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = (int)Math.Floor(me.X / 32.0d);
            int y = (int)Math.Floor(me.Y / 32.0d);
            int nbr = x + y * 7;
            if (nbr >= currSet!.Size)
            {
                return;
            }
            selectTileset = nbr;
            DrawSelectedTile();
        }

        /// <summary>
        /// Redraw the selected tile and the tileset image in the modify image tab to the current selected tile
        /// </summary>
        private void DrawSelectedTile()
        {
            Bitmap tile = new Bitmap(64, 64);
            Graphics g = Graphics.FromImage(tile);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(currSet!.GetTiles[selectTileset], 0, 0, 65, 65);
            g.Dispose();
            TileTilesetPbx.Image = tile;
            TilesetPbx.Image = currSet.GetSelectedImage(selectTileset);
        }

        /// <summary>
        /// When the modify tile button is pressed
        /// Get a 16x16 image from a file and modify in the database an existing tile with the current image
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void ModifyTileBtn_Click(object sender, EventArgs e)
        {
            Bitmap? img = GetTileFromFile();
            if (img != null)
            {
                db.ModifyTile(currSet!.Id, selectTileset, img);
                currSet = db.GetTileset(currSet.Id);
                DrawSelectedTile();
            }
        }

        /// <summary>
        /// When the add tile button is clicked
        /// Get multipleor one 16x16 image from a file and add them to the database as tiles
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void AddTileBtn_Click(object sender, EventArgs e)
        {
            Bitmap[]? img = GetMultipleTilesFromFile();
            if (img != null)
            {
                foreach(Bitmap tile in img)
                {
                    db.AddTile(currSet!.Id, tile);
                }
                DrawSelectedTile();
            }
        }

        /// <summary>
        /// Get a 16x16 image from a file
        /// </summary>
        /// <returns>A 16x16 image</returns>
        private Bitmap? GetTileFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "16x16 Images (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                Bitmap bmp = new Bitmap(filepath);
                if (bmp.Width != 16 && bmp.Height != 16)
                {
                    MessageBox.Show("Veuillez s'il vous plait choisir une image 16x16 pixels");
                    return null;
                }
                else
                {
                    return bmp;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get multiple or one 16x16 image from a file
        /// </summary>
        /// <returns>A 16x16 image</returns>
        private Bitmap[]? GetMultipleTilesFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "16x16 Images/Image de Tileset (multiple de 16) (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                Bitmap bmp = new Bitmap(filepath);
                if (bmp.Width % 16 != 0 && bmp.Height % 16 != 0)
                {
                    MessageBox.Show("Veuillez s'il vous plait choisir une image 16x16 pixels");
                    return null;
                }
                else
                {
                    int width = bmp.Width / 16;
                    int height = bmp.Height / 16;
                    Bitmap[] tiles = new Bitmap[width * height];
                    for (int i = 0; i < width; i++)
                    {
                        for (int ii = 0; ii < height; ii++)
                        {
                            tiles[i + ii * width] = bmp.Clone(new Rectangle(i * 16, ii * 16, 16, 16), bmp.PixelFormat);
                        }
                    }
                    return tiles;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// When the Modify Tilemap Button is pressed
        /// Get all the infos of the selected tilemap and go to the modify tilemap tab
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void ModifyTilemapBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)TilemapsDgv.CurrentRow.Cells[0].Value;
                currMap = db.GetTilemap(id);
                TilemapLbl.Text = $"Tilemap : {currMap.Name} - Tileset : {currMap.GetTileset.Name}";
                selectTilemap = 0;
                DrawTileTilemap();
                TilemapPbx.Image = currMap.GetImage;
                MainTabControl.SelectedIndex = 3;
                ModifyTilemapPage.Enabled = true;
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        /// <summary>
        /// Draw the tileset pbx of the Modify Tilemap tab
        /// </summary>
        private void DrawTileTilemap()
        {
            TilemapTilesetPbx.Image = currMap!.GetTileset.GetSelectedImage(selectTilemap);
        }

        /// <summary>
        /// When the tileset picturebox of the modify tilemap tab is clicked
        /// Verify if we chose a correct tile and change the selected tile to it
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event</param>
        private void TilemapTilesetPbx_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = (int)Math.Floor(me.X / 32.0d);
            int y = (int)Math.Floor(me.Y / 32.0d);
            int nbr = x + y * 7;
            if (nbr >= currMap!.GetTileset.Size)
            {
                return;
            }
            selectTilemap = nbr;
            DrawTileTilemap();
        }

        private void TilemapPbx_Click(object sender, EventArgs e)
        {

            MouseEventArgs me = (MouseEventArgs)e;
            int x = (int)Math.Floor(me.X / 16.0d);
            int y = (int)Math.Floor(me.Y / 16.0d);
            currMap!.setTiles(y, x, selectTilemap);
            TilemapPbx.Image = currMap!.GetImage;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            db.ModifyMap(currMap!.Id, currMap.GetTiles);
            currMap = db.GetTilemap(currMap.Id);
            TilemapPbx.Image = currMap!.GetImage;
            DrawTileTilemap();
        }
    }
}