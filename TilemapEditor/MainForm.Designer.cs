namespace TilemapEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TilesetListPage = new System.Windows.Forms.TabPage();
            this.ModifyTilesetPage = new System.Windows.Forms.TabPage();
            this.TilemapListPage = new System.Windows.Forms.TabPage();
            this.ModifyTilemapPage = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.TilesetListPage);
            this.MainTabControl.Controls.Add(this.ModifyTilesetPage);
            this.MainTabControl.Controls.Add(this.TilemapListPage);
            this.MainTabControl.Controls.Add(this.ModifyTilemapPage);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 574);
            this.MainTabControl.TabIndex = 0;
            // 
            // TilesetListPage
            // 
            this.TilesetListPage.Location = new System.Drawing.Point(4, 24);
            this.TilesetListPage.Name = "TilesetListPage";
            this.TilesetListPage.Padding = new System.Windows.Forms.Padding(3);
            this.TilesetListPage.Size = new System.Drawing.Size(792, 546);
            this.TilesetListPage.TabIndex = 0;
            this.TilesetListPage.Text = "Liste Tilesets";
            this.TilesetListPage.UseVisualStyleBackColor = true;
            // 
            // ModifyTilesetPage
            // 
            this.ModifyTilesetPage.Location = new System.Drawing.Point(4, 24);
            this.ModifyTilesetPage.Name = "ModifyTilesetPage";
            this.ModifyTilesetPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyTilesetPage.Size = new System.Drawing.Size(792, 546);
            this.ModifyTilesetPage.TabIndex = 1;
            this.ModifyTilesetPage.Text = "Modifier Tileset";
            this.ModifyTilesetPage.UseVisualStyleBackColor = true;
            // 
            // TilemapListPage
            // 
            this.TilemapListPage.Location = new System.Drawing.Point(4, 24);
            this.TilemapListPage.Name = "TilemapListPage";
            this.TilemapListPage.Padding = new System.Windows.Forms.Padding(3);
            this.TilemapListPage.Size = new System.Drawing.Size(792, 546);
            this.TilemapListPage.TabIndex = 2;
            this.TilemapListPage.Text = "Liste Tilemaps";
            this.TilemapListPage.UseVisualStyleBackColor = true;
            // 
            // ModifyTilemapPage
            // 
            this.ModifyTilemapPage.Location = new System.Drawing.Point(4, 24);
            this.ModifyTilemapPage.Name = "ModifyTilemapPage";
            this.ModifyTilemapPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyTilemapPage.Size = new System.Drawing.Size(792, 546);
            this.ModifyTilemapPage.TabIndex = 3;
            this.ModifyTilemapPage.Text = "Modifier Tilemap";
            this.ModifyTilemapPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "Tilemap Editor";
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage TilesetListPage;
        private TabPage ModifyTilesetPage;
        private TabPage TilemapListPage;
        private TabPage ModifyTilemapPage;
    }
}