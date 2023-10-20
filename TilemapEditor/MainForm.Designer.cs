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
            this.RefreshTilesetsBtn = new System.Windows.Forms.Button();
            this.newTilesetBtn = new System.Windows.Forms.Button();
            this.ModifyTilesetBtn = new System.Windows.Forms.Button();
            this.PreviewTilesetBtn = new System.Windows.Forms.Button();
            this.TilesetsDgv = new System.Windows.Forms.DataGridView();
            this.ModifyTilesetPage = new System.Windows.Forms.TabPage();
            this.TilemapListPage = new System.Windows.Forms.TabPage();
            this.RefreshTilemapsBtn = new System.Windows.Forms.Button();
            this.NewTilemapBtn = new System.Windows.Forms.Button();
            this.ModifyTilemapBtn = new System.Windows.Forms.Button();
            this.PreviewTilemapBtn = new System.Windows.Forms.Button();
            this.TilemapsDgv = new System.Windows.Forms.DataGridView();
            this.ModifyTilemapPage = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.TilesetListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TilesetsDgv)).BeginInit();
            this.TilemapListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TilemapsDgv)).BeginInit();
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
            this.TilesetListPage.Controls.Add(this.RefreshTilesetsBtn);
            this.TilesetListPage.Controls.Add(this.newTilesetBtn);
            this.TilesetListPage.Controls.Add(this.ModifyTilesetBtn);
            this.TilesetListPage.Controls.Add(this.PreviewTilesetBtn);
            this.TilesetListPage.Controls.Add(this.TilesetsDgv);
            this.TilesetListPage.Location = new System.Drawing.Point(4, 24);
            this.TilesetListPage.Name = "TilesetListPage";
            this.TilesetListPage.Padding = new System.Windows.Forms.Padding(3);
            this.TilesetListPage.Size = new System.Drawing.Size(792, 546);
            this.TilesetListPage.TabIndex = 0;
            this.TilesetListPage.Text = "Liste Tilesets";
            this.TilesetListPage.UseVisualStyleBackColor = true;
            // 
            // RefreshTilesetsBtn
            // 
            this.RefreshTilesetsBtn.Location = new System.Drawing.Point(624, 263);
            this.RefreshTilesetsBtn.Name = "RefreshTilesetsBtn";
            this.RefreshTilesetsBtn.Size = new System.Drawing.Size(128, 48);
            this.RefreshTilesetsBtn.TabIndex = 6;
            this.RefreshTilesetsBtn.Text = "Rafraishir";
            this.RefreshTilesetsBtn.UseVisualStyleBackColor = true;
            // 
            // newTilesetBtn
            // 
            this.newTilesetBtn.Location = new System.Drawing.Point(430, 263);
            this.newTilesetBtn.Name = "newTilesetBtn";
            this.newTilesetBtn.Size = new System.Drawing.Size(128, 48);
            this.newTilesetBtn.TabIndex = 5;
            this.newTilesetBtn.Text = "Nouveau Tileset";
            this.newTilesetBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyTilesetBtn
            // 
            this.ModifyTilesetBtn.Location = new System.Drawing.Point(624, 370);
            this.ModifyTilesetBtn.Name = "ModifyTilesetBtn";
            this.ModifyTilesetBtn.Size = new System.Drawing.Size(128, 48);
            this.ModifyTilesetBtn.TabIndex = 4;
            this.ModifyTilesetBtn.Text = "Modifier Tileset";
            this.ModifyTilesetBtn.UseVisualStyleBackColor = true;
            // 
            // PreviewTilesetBtn
            // 
            this.PreviewTilesetBtn.Location = new System.Drawing.Point(430, 370);
            this.PreviewTilesetBtn.Name = "PreviewTilesetBtn";
            this.PreviewTilesetBtn.Size = new System.Drawing.Size(128, 48);
            this.PreviewTilesetBtn.TabIndex = 3;
            this.PreviewTilesetBtn.Text = "Preview";
            this.PreviewTilesetBtn.UseVisualStyleBackColor = true;
            this.PreviewTilesetBtn.Click += new System.EventHandler(this.PreviewTilesetBtn_Click);
            // 
            // TilesetsDgv
            // 
            this.TilesetsDgv.AllowUserToAddRows = false;
            this.TilesetsDgv.AllowUserToDeleteRows = false;
            this.TilesetsDgv.AllowUserToResizeColumns = false;
            this.TilesetsDgv.AllowUserToResizeRows = false;
            this.TilesetsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TilesetsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TilesetsDgv.Location = new System.Drawing.Point(6, 6);
            this.TilesetsDgv.MultiSelect = false;
            this.TilesetsDgv.Name = "TilesetsDgv";
            this.TilesetsDgv.ReadOnly = true;
            this.TilesetsDgv.RowHeadersVisible = false;
            this.TilesetsDgv.RowTemplate.Height = 50;
            this.TilesetsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TilesetsDgv.Size = new System.Drawing.Size(380, 534);
            this.TilesetsDgv.TabIndex = 0;
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
            this.TilemapListPage.Controls.Add(this.RefreshTilemapsBtn);
            this.TilemapListPage.Controls.Add(this.NewTilemapBtn);
            this.TilemapListPage.Controls.Add(this.ModifyTilemapBtn);
            this.TilemapListPage.Controls.Add(this.PreviewTilemapBtn);
            this.TilemapListPage.Controls.Add(this.TilemapsDgv);
            this.TilemapListPage.Location = new System.Drawing.Point(4, 24);
            this.TilemapListPage.Name = "TilemapListPage";
            this.TilemapListPage.Padding = new System.Windows.Forms.Padding(3);
            this.TilemapListPage.Size = new System.Drawing.Size(792, 546);
            this.TilemapListPage.TabIndex = 2;
            this.TilemapListPage.Text = "Liste Tilemaps";
            this.TilemapListPage.UseVisualStyleBackColor = true;
            // 
            // RefreshTilemapsBtn
            // 
            this.RefreshTilemapsBtn.Location = new System.Drawing.Point(624, 263);
            this.RefreshTilemapsBtn.Name = "RefreshTilemapsBtn";
            this.RefreshTilemapsBtn.Size = new System.Drawing.Size(128, 48);
            this.RefreshTilemapsBtn.TabIndex = 10;
            this.RefreshTilemapsBtn.Text = "Rafraishir";
            this.RefreshTilemapsBtn.UseVisualStyleBackColor = true;
            // 
            // NewTilemapBtn
            // 
            this.NewTilemapBtn.Location = new System.Drawing.Point(430, 263);
            this.NewTilemapBtn.Name = "NewTilemapBtn";
            this.NewTilemapBtn.Size = new System.Drawing.Size(128, 48);
            this.NewTilemapBtn.TabIndex = 9;
            this.NewTilemapBtn.Text = "Nouveau Tilemap";
            this.NewTilemapBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyTilemapBtn
            // 
            this.ModifyTilemapBtn.Location = new System.Drawing.Point(624, 370);
            this.ModifyTilemapBtn.Name = "ModifyTilemapBtn";
            this.ModifyTilemapBtn.Size = new System.Drawing.Size(128, 48);
            this.ModifyTilemapBtn.TabIndex = 8;
            this.ModifyTilemapBtn.Text = "Modifier Tilemap";
            this.ModifyTilemapBtn.UseVisualStyleBackColor = true;
            // 
            // PreviewTilemapBtn
            // 
            this.PreviewTilemapBtn.Location = new System.Drawing.Point(430, 370);
            this.PreviewTilemapBtn.Name = "PreviewTilemapBtn";
            this.PreviewTilemapBtn.Size = new System.Drawing.Size(128, 48);
            this.PreviewTilemapBtn.TabIndex = 7;
            this.PreviewTilemapBtn.Text = "Preview";
            this.PreviewTilemapBtn.UseVisualStyleBackColor = true;
            this.PreviewTilemapBtn.Click += new System.EventHandler(this.PreviewTilemapBtn_Click);
            // 
            // TilemapsDgv
            // 
            this.TilemapsDgv.AllowUserToAddRows = false;
            this.TilemapsDgv.AllowUserToDeleteRows = false;
            this.TilemapsDgv.AllowUserToResizeColumns = false;
            this.TilemapsDgv.AllowUserToResizeRows = false;
            this.TilemapsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TilemapsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TilemapsDgv.Location = new System.Drawing.Point(6, 6);
            this.TilemapsDgv.MultiSelect = false;
            this.TilemapsDgv.Name = "TilemapsDgv";
            this.TilemapsDgv.ReadOnly = true;
            this.TilemapsDgv.RowHeadersVisible = false;
            this.TilemapsDgv.RowTemplate.Height = 50;
            this.TilemapsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TilemapsDgv.Size = new System.Drawing.Size(380, 534);
            this.TilemapsDgv.TabIndex = 1;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tilemap Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.TilesetListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TilesetsDgv)).EndInit();
            this.TilemapListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TilemapsDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage TilesetListPage;
        private TabPage ModifyTilesetPage;
        private TabPage TilemapListPage;
        private TabPage ModifyTilemapPage;
        private DataGridView TilesetsDgv;
        private DataGridView TilemapsDgv;
        private Button PreviewTilesetBtn;
        private Button ModifyTilesetBtn;
        private Button newTilesetBtn;
        private Button RefreshTilesetsBtn;
        private Button RefreshTilemapsBtn;
        private Button NewTilemapBtn;
        private Button ModifyTilemapBtn;
        private Button PreviewTilemapBtn;
    }
}