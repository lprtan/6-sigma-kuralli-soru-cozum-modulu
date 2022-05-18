namespace YazılımYapımıProje
{
    partial class frmOgrenciRapor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciRapor));
            this.dvgOgrenciRapor = new System.Windows.Forms.DataGridView();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.imgListInterface = new System.Windows.Forms.ImageList(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnGiris = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOgrenciRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgOgrenciRapor
            // 
            this.dvgOgrenciRapor.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dvgOgrenciRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOgrenciRapor.Location = new System.Drawing.Point(12, 58);
            this.dvgOgrenciRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgOgrenciRapor.Name = "dvgOgrenciRapor";
            this.dvgOgrenciRapor.RowHeadersWidth = 51;
            this.dvgOgrenciRapor.RowTemplate.Height = 29;
            this.dvgOgrenciRapor.Size = new System.Drawing.Size(476, 278);
            this.dvgOgrenciRapor.TabIndex = 0;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.Orange;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdir.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdir.ImageKey = "printer.png";
            this.btnYazdir.ImageList = this.imgListInterface;
            this.btnYazdir.Location = new System.Drawing.Point(190, 349);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(120, 40);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "    Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // imgListInterface
            // 
            this.imgListInterface.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListInterface.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListInterface.ImageStream")));
            this.imgListInterface.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListInterface.Images.SetKeyName(0, "printer.png");
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(460, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(426, 12);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(28, 28);
            this.btnGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGiris.TabIndex = 3;
            this.btnGiris.TabStop = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(392, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 28);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmOgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dvgOgrenciRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOgrenciRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenciRapor";
            this.Load += new System.EventHandler(this.frmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOgrenciRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgOgrenciRapor;
        private Button btnYazdir;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox btnExit;
        private PictureBox btnGiris;
        private PictureBox btnBack;
        private ImageList imgListInterface;
    }
}