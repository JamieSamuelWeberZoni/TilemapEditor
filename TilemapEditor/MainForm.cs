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

        private void testBtn_Click(object sender, EventArgs e)
        {
            Tilemap map = db.GetTilemap(1);
            testPbx.Image = map.GetImage;
        }
    }
}