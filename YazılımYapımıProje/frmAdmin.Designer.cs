namespace YazılımYapımıProje
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnGirisSayfası = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.imgListInterface = new System.Windows.Forms.ImageList(this.components);
            this.btnOnay = new System.Windows.Forms.Button();
            this.dgvAdminSoruOnay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGirisSayfası)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminSoruOnay)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OldLace;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(760, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 14;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGirisSayfası
            // 
            this.btnGirisSayfası.BackColor = System.Drawing.Color.OldLace;
            this.btnGirisSayfası.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisSayfası.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisSayfası.Image")));
            this.btnGirisSayfası.Location = new System.Drawing.Point(726, 12);
            this.btnGirisSayfası.Name = "btnGirisSayfası";
            this.btnGirisSayfası.Size = new System.Drawing.Size(28, 28);
            this.btnGirisSayfası.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGirisSayfası.TabIndex = 13;
            this.btnGirisSayfası.TabStop = false;
            this.btnGirisSayfası.Click += new System.EventHandler(this.btnGirisSayfası_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(682, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Orange;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "bin.png";
            this.btnSil.ImageList = this.imgListInterface;
            this.btnSil.Location = new System.Drawing.Point(674, 194);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 27);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "  Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // imgListInterface
            // 
            this.imgListInterface.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListInterface.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListInterface.ImageStream")));
            this.imgListInterface.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListInterface.Images.SetKeyName(0, "bin.png");
            this.imgListInterface.Images.SetKeyName(1, "save.png");
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.Orange;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnay.ImageKey = "save.png";
            this.btnOnay.ImageList = this.imgListInterface;
            this.btnOnay.Location = new System.Drawing.Point(674, 161);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(114, 27);
            this.btnOnay.TabIndex = 10;
            this.btnOnay.Text = "    Onayla";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // dgvAdminSoruOnay
            // 
            this.dgvAdminSoruOnay.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvAdminSoruOnay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAdminSoruOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminSoruOnay.Location = new System.Drawing.Point(12, 55);
            this.dgvAdminSoruOnay.Name = "dgvAdminSoruOnay";
            this.dgvAdminSoruOnay.RowHeadersWidth = 51;
            this.dgvAdminSoruOnay.RowTemplate.Height = 25;
            this.dgvAdminSoruOnay.Size = new System.Drawing.Size(656, 333);
            this.dgvAdminSoruOnay.TabIndex = 9;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGirisSayfası);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.dgvAdminSoruOnay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGirisSayfası)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminSoruOnay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox btnExit;
        private PictureBox btnGirisSayfası;
        private PictureBox pictureBox1;
        private Button btnSil;
        private Button btnOnay;
        private DataGridView dgvAdminSoruOnay;
        private ImageList imgListInterface;
    }
}