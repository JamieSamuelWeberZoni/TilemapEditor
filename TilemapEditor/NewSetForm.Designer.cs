namespace TilemapEditor
{
    partial class NewSetForm
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.TilePbx = new System.Windows.Forms.PictureBox();
            this.ChooseTileBtn = new System.Windows.Forms.Button();
            this.ResetTileBtn = new System.Windows.Forms.Button();
            this.TileLbl = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TilePbx)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(12, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(134, 21);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Nouveau Tileset";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(12, 47);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(88, 15);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Nom du tileset:";
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(12, 65);
            this.NameTbx.MaxLength = 50;
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(145, 23);
            this.NameTbx.TabIndex = 2;
            // 
            // TilePbx
            // 
            this.TilePbx.Location = new System.Drawing.Point(12, 119);
            this.TilePbx.Name = "TilePbx";
            this.TilePbx.Size = new System.Drawing.Size(64, 64);
            this.TilePbx.TabIndex = 3;
            this.TilePbx.TabStop = false;
            // 
            // ChooseTileBtn
            // 
            this.ChooseTileBtn.Location = new System.Drawing.Point(82, 119);
            this.ChooseTileBtn.Name = "ChooseTileBtn";
            this.ChooseTileBtn.Size = new System.Drawing.Size(75, 32);
            this.ChooseTileBtn.TabIndex = 4;
            this.ChooseTileBtn.Text = "Choisir...";
            this.ChooseTileBtn.UseVisualStyleBackColor = true;
            this.ChooseTileBtn.Click += new System.EventHandler(this.ChooseTileBtn_Click);
            // 
            // ResetTileBtn
            // 
            this.ResetTileBtn.Location = new System.Drawing.Point(82, 151);
            this.ResetTileBtn.Name = "ResetTileBtn";
            this.ResetTileBtn.Size = new System.Drawing.Size(75, 32);
            this.ResetTileBtn.TabIndex = 5;
            this.ResetTileBtn.Text = "Fond noir";
            this.ResetTileBtn.UseVisualStyleBackColor = true;
            this.ResetTileBtn.Click += new System.EventHandler(this.ResetTileBtn_Click);
            // 
            // TileLbl
            // 
            this.TileLbl.AutoSize = true;
            this.TileLbl.Location = new System.Drawing.Point(12, 101);
            this.TileLbl.Name = "TileLbl";
            this.TileLbl.Size = new System.Drawing.Size(71, 15);
            this.TileLbl.TabIndex = 6;
            this.TileLbl.Text = "Tile de base:";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(12, 189);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(71, 28);
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Créer";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(86, 189);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(71, 28);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Annuler";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NewSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 225);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.TileLbl);
            this.Controls.Add(this.ResetTileBtn);
            this.Controls.Add(this.ChooseTileBtn);
            this.Controls.Add(this.TilePbx);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.TitleLbl);
            this.MaximizeBox = false;
            this.Name = "NewSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewSetForm_FormClosed);
            this.Load += new System.EventHandler(this.NewSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TilePbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLbl;
        private Label NameLbl;
        private TextBox NameTbx;
        private PictureBox TilePbx;
        private Button ChooseTileBtn;
        private Button ResetTileBtn;
        private Label TileLbl;
        private Button CreateBtn;
        private Button CancelBtn;
    }
}