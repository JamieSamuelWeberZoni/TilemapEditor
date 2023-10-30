namespace TilemapEditor
{
    partial class NewMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TilesetLbl = new System.Windows.Forms.Label();
            this.TilesetCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(86, 138);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(71, 28);
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "Annuler";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(12, 138);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(71, 28);
            this.CreateBtn.TabIndex = 12;
            this.CreateBtn.Text = "Créer";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(12, 65);
            this.NameTbx.MaxLength = 50;
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(145, 23);
            this.NameTbx.TabIndex = 11;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(12, 47);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(97, 15);
            this.NameLbl.TabIndex = 10;
            this.NameLbl.Text = "Nom du tilemap:";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(12, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(146, 21);
            this.TitleLbl.TabIndex = 9;
            this.TitleLbl.Text = "Nouveau Tilemap";
            // 
            // TilesetLbl
            // 
            this.TilesetLbl.AutoSize = true;
            this.TilesetLbl.Location = new System.Drawing.Point(12, 91);
            this.TilesetLbl.Name = "TilesetLbl";
            this.TilesetLbl.Size = new System.Drawing.Size(43, 15);
            this.TilesetLbl.TabIndex = 14;
            this.TilesetLbl.Text = "Tileset:";
            // 
            // TilesetCbx
            // 
            this.TilesetCbx.FormattingEnabled = true;
            this.TilesetCbx.Location = new System.Drawing.Point(12, 109);
            this.TilesetCbx.Name = "TilesetCbx";
            this.TilesetCbx.Size = new System.Drawing.Size(145, 23);
            this.TilesetCbx.TabIndex = 15;
            // 
            // NewMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 177);
            this.Controls.Add(this.TilesetCbx);
            this.Controls.Add(this.TilesetLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewMapForm_FormClosed);
            this.Load += new System.EventHandler(this.NewMapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelBtn;
        private Button CreateBtn;
        private TextBox NameTbx;
        private Label NameLbl;
        private Label TitleLbl;
        private Label TilesetLbl;
        private ComboBox TilesetCbx;
    }
}