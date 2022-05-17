namespace YazılımYapımıProje
{
    partial class frmKayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKayitOl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgListInterface = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pbKayitOlIcon = new System.Windows.Forms.PictureBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnKullaniciKayit = new System.Windows.Forms.Button();
            this.cbxKullaniciType = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiKayit = new System.Windows.Forms.TextBox();
            this.lblSifreKayit = new System.Windows.Forms.Label();
            this.lblKullaniciType = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSoyism = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblKullaniciAdiKayit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayitOlIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imgListInterface
            // 
            this.imgListInterface.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListInterface.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListInterface.ImageStream")));
            this.imgListInterface.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListInterface.Images.SetKeyName(0, "user (6).png");
            this.imgListInterface.Images.SetKeyName(1, "user (7).png");
            this.imgListInterface.Images.SetKeyName(2, "user (8).png");
            this.imgListInterface.Images.SetKeyName(3, "user (9).png");
            this.imgListInterface.Images.SetKeyName(4, "user (10).png");
            this.imgListInterface.Images.SetKeyName(5, "user (11).png");
            this.imgListInterface.Images.SetKeyName(6, "user (12).png");
            this.imgListInterface.Images.SetKeyName(7, "user (13).png");
            this.imgListInterface.Images.SetKeyName(8, "user (14).png");
            this.imgListInterface.Images.SetKeyName(9, "user (15).png");
            this.imgListInterface.Images.SetKeyName(10, "user (16).png");
            this.imgListInterface.Images.SetKeyName(11, "user (17).png");
            this.imgListInterface.Images.SetKeyName(12, "user (18).png");
            this.imgListInterface.Images.SetKeyName(13, "user (19).png");
            this.imgListInterface.Images.SetKeyName(14, "user (20).png");
            this.imgListInterface.Images.SetKeyName(15, "user (21).png");
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OldLace;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(460, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 26;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbKayitOlIcon
            // 
            this.pbKayitOlIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbKayitOlIcon.Image")));
            this.pbKayitOlIcon.Location = new System.Drawing.Point(202, 12);
            this.pbKayitOlIcon.Name = "pbKayitOlIcon";
            this.pbKayitOlIcon.Size = new System.Drawing.Size(100, 100);
            this.pbKayitOlIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKayitOlIcon.TabIndex = 22;
            this.pbKayitOlIcon.TabStop = false;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Orange;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGirisYap.ImageKey = "user (14).png";
            this.btnGirisYap.ImageList = this.imgListInterface;
            this.btnGirisYap.Location = new System.Drawing.Point(202, 349);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(145, 27);
            this.btnGirisYap.TabIndex = 25;
            this.btnGirisYap.Text = "   Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKullaniciKayit
            // 
            this.btnKullaniciKayit.BackColor = System.Drawing.Color.Orange;
            this.btnKullaniciKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKullaniciKayit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKullaniciKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciKayit.ImageKey = "user (17).png";
            this.btnKullaniciKayit.ImageList = this.imgListInterface;
            this.btnKullaniciKayit.Location = new System.Drawing.Point(202, 316);
            this.btnKullaniciKayit.Name = "btnKullaniciKayit";
            this.btnKullaniciKayit.Size = new System.Drawing.Size(145, 27);
            this.btnKullaniciKayit.TabIndex = 24;
            this.btnKullaniciKayit.Text = "  Kayıt Ol";
            this.btnKullaniciKayit.UseVisualStyleBackColor = false;
            this.btnKullaniciKayit.Click += new System.EventHandler(this.btnKullaniciKayit_Click);
            // 
            // cbxKullaniciType
            // 
            this.cbxKullaniciType.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbxKullaniciType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxKullaniciType.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxKullaniciType.FormattingEnabled = true;
            this.cbxKullaniciType.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretmen"});
            this.cbxKullaniciType.Location = new System.Drawing.Point(202, 283);
            this.cbxKullaniciType.Name = "cbxKullaniciType";
            this.cbxKullaniciType.Size = new System.Drawing.Size(145, 27);
            this.cbxKullaniciType.TabIndex = 23;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSifre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.Location = new System.Drawing.Point(202, 250);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(145, 27);
            this.txtSifre.TabIndex = 21;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtMail.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Location = new System.Drawing.Point(202, 217);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(145, 27);
            this.txtMail.TabIndex = 20;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSoyad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoyad.Location = new System.Drawing.Point(202, 184);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(145, 27);
            this.txtSoyad.TabIndex = 19;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtAd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAd.Location = new System.Drawing.Point(202, 151);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(145, 27);
            this.txtAd.TabIndex = 18;
            // 
            // txtKullaniciAdiKayit
            // 
            this.txtKullaniciAdiKayit.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtKullaniciAdiKayit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdiKayit.Location = new System.Drawing.Point(202, 118);
            this.txtKullaniciAdiKayit.Name = "txtKullaniciAdiKayit";
            this.txtKullaniciAdiKayit.Size = new System.Drawing.Size(145, 27);
            this.txtKullaniciAdiKayit.TabIndex = 17;
            // 
            // lblSifreKayit
            // 
            this.lblSifreKayit.AutoSize = true;
            this.lblSifreKayit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifreKayit.ForeColor = System.Drawing.Color.Teal;
            this.lblSifreKayit.Location = new System.Drawing.Point(141, 250);
            this.lblSifreKayit.Name = "lblSifreKayit";
            this.lblSifreKayit.Size = new System.Drawing.Size(55, 23);
            this.lblSifreKayit.TabIndex = 11;
            this.lblSifreKayit.Text = "Şifre:";
            // 
            // lblKullaniciType
            // 
            this.lblKullaniciType.AutoSize = true;
            this.lblKullaniciType.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciType.ForeColor = System.Drawing.Color.Teal;
            this.lblKullaniciType.Location = new System.Drawing.Point(75, 283);
            this.lblKullaniciType.Name = "lblKullaniciType";
            this.lblKullaniciType.Size = new System.Drawing.Size(121, 23);
            this.lblKullaniciType.TabIndex = 12;
            this.lblKullaniciType.Text = "Kullanıcı Tipi:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMail.ForeColor = System.Drawing.Color.Teal;
            this.lblMail.Location = new System.Drawing.Point(144, 217);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(52, 23);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail:";
            // 
            // lblSoyism
            // 
            this.lblSoyism.AutoSize = true;
            this.lblSoyism.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoyism.ForeColor = System.Drawing.Color.Teal;
            this.lblSoyism.Location = new System.Drawing.Point(114, 184);
            this.lblSoyism.Name = "lblSoyism";
            this.lblSoyism.Size = new System.Drawing.Size(82, 23);
            this.lblSoyism.TabIndex = 14;
            this.lblSoyism.Text = "Soyisim:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAd.ForeColor = System.Drawing.Color.Teal;
            this.lblAd.Location = new System.Drawing.Point(146, 151);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(50, 23);
            this.lblAd.TabIndex = 15;
            this.lblAd.Text = "İsim:";
            // 
            // lblKullaniciAdiKayit
            // 
            this.lblKullaniciAdiKayit.AutoSize = true;
            this.lblKullaniciAdiKayit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdiKayit.ForeColor = System.Drawing.Color.Teal;
            this.lblKullaniciAdiKayit.Location = new System.Drawing.Point(78, 118);
            this.lblKullaniciAdiKayit.Name = "lblKullaniciAdiKayit";
            this.lblKullaniciAdiKayit.Size = new System.Drawing.Size(118, 23);
            this.lblKullaniciAdiKayit.TabIndex = 16;
            this.lblKullaniciAdiKayit.Text = "Kullanıcı Adı:";
            // 
            // frmKayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbKayitOlIcon);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.btnKullaniciKayit);
            this.Controls.Add(this.cbxKullaniciType);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtKullaniciAdiKayit);
            this.Controls.Add(this.lblSifreKayit);
            this.Controls.Add(this.lblKullaniciType);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblSoyism);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblKullaniciAdiKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKayitOl";
            this.Load += new System.EventHandler(this.frmKayitOl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKayitOlIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox btnExit;
        private PictureBox pbKayitOlIcon;
        private Button btnGirisYap;
        private ImageList imgListInterface;
        private Button btnKullaniciKayit;
        private ComboBox cbxKullaniciType;
        private TextBox txtSifre;
        private TextBox txtMail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtKullaniciAdiKayit;
        private Label lblSifreKayit;
        private Label lblKullaniciType;
        private Label lblMail;
        private Label lblSoyism;
        private Label lblAd;
        private Label lblKullaniciAdiKayit;
    }
}