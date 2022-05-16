namespace YazılımYapımıProje
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.ckbSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.pbGirisIcon = new System.Windows.Forms.PictureBox();
            this.lkbSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.imgListIntrefaces = new System.Windows.Forms.ImageList(this.components);
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.txtGirisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifreGiris = new System.Windows.Forms.Label();
            this.lblKullaniciAdiGiris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisIcon)).BeginInit();
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
            this.btnExit.Location = new System.Drawing.Point(460, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 19;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ckbSifreyiGoster
            // 
            this.ckbSifreyiGoster.AutoSize = true;
            this.ckbSifreyiGoster.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbSifreyiGoster.ForeColor = System.Drawing.Color.Teal;
            this.ckbSifreyiGoster.Location = new System.Drawing.Point(265, 257);
            this.ckbSifreyiGoster.Name = "ckbSifreyiGoster";
            this.ckbSifreyiGoster.Size = new System.Drawing.Size(123, 25);
            this.ckbSifreyiGoster.TabIndex = 17;
            this.ckbSifreyiGoster.Text = "Şifreyi Göster";
            this.ckbSifreyiGoster.UseVisualStyleBackColor = true;
            this.ckbSifreyiGoster.CheckedChanged += new System.EventHandler(this.ckbSifreyiGoster_CheckedChanged);
            // 
            // pbGirisIcon
            // 
            this.pbGirisIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbGirisIcon.Image")));
            this.pbGirisIcon.Location = new System.Drawing.Point(200, 50);
            this.pbGirisIcon.Name = "pbGirisIcon";
            this.pbGirisIcon.Size = new System.Drawing.Size(100, 100);
            this.pbGirisIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGirisIcon.TabIndex = 18;
            this.pbGirisIcon.TabStop = false;
            // 
            // lkbSifremiUnuttum
            // 
            this.lkbSifremiUnuttum.AutoSize = true;
            this.lkbSifremiUnuttum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lkbSifremiUnuttum.LinkColor = System.Drawing.Color.Teal;
            this.lkbSifremiUnuttum.Location = new System.Drawing.Point(265, 327);
            this.lkbSifremiUnuttum.Name = "lkbSifremiUnuttum";
            this.lkbSifremiUnuttum.Size = new System.Drawing.Size(126, 21);
            this.lkbSifremiUnuttum.TabIndex = 16;
            this.lkbSifremiUnuttum.TabStop = true;
            this.lkbSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lkbSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbSifremiUnuttum_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Orange;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.ImageKey = "user (14).png";
            this.btnGiris.ImageList = this.imgListIntrefaces;
            this.btnGiris.Location = new System.Drawing.Point(223, 288);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(105, 36);
            this.btnGiris.TabIndex = 14;
            this.btnGiris.Text = "      Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // imgListIntrefaces
            // 
            this.imgListIntrefaces.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListIntrefaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIntrefaces.ImageStream")));
            this.imgListIntrefaces.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIntrefaces.Images.SetKeyName(0, "user (6).png");
            this.imgListIntrefaces.Images.SetKeyName(1, "user (7).png");
            this.imgListIntrefaces.Images.SetKeyName(2, "user (8).png");
            this.imgListIntrefaces.Images.SetKeyName(3, "user (9).png");
            this.imgListIntrefaces.Images.SetKeyName(4, "user (11).png");
            this.imgListIntrefaces.Images.SetKeyName(5, "user (12).png");
            this.imgListIntrefaces.Images.SetKeyName(6, "user (13).png");
            this.imgListIntrefaces.Images.SetKeyName(7, "user (14).png");
            this.imgListIntrefaces.Images.SetKeyName(8, "user (15).png");
            this.imgListIntrefaces.Images.SetKeyName(9, "user (16).png");
            this.imgListIntrefaces.Images.SetKeyName(10, "user (17).png");
            this.imgListIntrefaces.Images.SetKeyName(11, "user (17).png");
            this.imgListIntrefaces.Images.SetKeyName(12, "user (18).png");
            this.imgListIntrefaces.Images.SetKeyName(13, "user (19).png");
            this.imgListIntrefaces.Images.SetKeyName(14, "user (20).png");
            this.imgListIntrefaces.Images.SetKeyName(15, "user (21).png");
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.Orange;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayıtOl.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKayıtOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtOl.ImageKey = "user (17).png";
            this.btnKayıtOl.ImageList = this.imgListIntrefaces;
            this.btnKayıtOl.Location = new System.Drawing.Point(334, 288);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(105, 36);
            this.btnKayıtOl.TabIndex = 15;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.BackColor = System.Drawing.Color.LightYellow;
            this.txtGirisSifre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGirisSifre.Location = new System.Drawing.Point(223, 214);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(216, 37);
            this.txtGirisSifre.TabIndex = 13;
            // 
            // txtGirisKullaniciAdi
            // 
            this.txtGirisKullaniciAdi.BackColor = System.Drawing.Color.LightYellow;
            this.txtGirisKullaniciAdi.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGirisKullaniciAdi.Location = new System.Drawing.Point(223, 171);
            this.txtGirisKullaniciAdi.Name = "txtGirisKullaniciAdi";
            this.txtGirisKullaniciAdi.Size = new System.Drawing.Size(216, 37);
            this.txtGirisKullaniciAdi.TabIndex = 12;
            // 
            // lblSifreGiris
            // 
            this.lblSifreGiris.AutoSize = true;
            this.lblSifreGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSifreGiris.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifreGiris.ForeColor = System.Drawing.Color.Teal;
            this.lblSifreGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSifreGiris.ImageKey = "user (8).png";
            this.lblSifreGiris.ImageList = this.imgListIntrefaces;
            this.lblSifreGiris.Location = new System.Drawing.Point(114, 217);
            this.lblSifreGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreGiris.Name = "lblSifreGiris";
            this.lblSifreGiris.Size = new System.Drawing.Size(102, 29);
            this.lblSifreGiris.TabIndex = 10;
            this.lblSifreGiris.Text = "       Şifre:";
            this.lblSifreGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKullaniciAdiGiris
            // 
            this.lblKullaniciAdiGiris.AllowDrop = true;
            this.lblKullaniciAdiGiris.AutoSize = true;
            this.lblKullaniciAdiGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKullaniciAdiGiris.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdiGiris.ForeColor = System.Drawing.Color.Teal;
            this.lblKullaniciAdiGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKullaniciAdiGiris.ImageKey = "user (12).png";
            this.lblKullaniciAdiGiris.ImageList = this.imgListIntrefaces;
            this.lblKullaniciAdiGiris.Location = new System.Drawing.Point(39, 174);
            this.lblKullaniciAdiGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdiGiris.Name = "lblKullaniciAdiGiris";
            this.lblKullaniciAdiGiris.Size = new System.Drawing.Size(177, 29);
            this.lblKullaniciAdiGiris.TabIndex = 11;
            this.lblKullaniciAdiGiris.Text = "      Kullanıcı Adı:";
            this.lblKullaniciAdiGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ckbSifreyiGoster);
            this.Controls.Add(this.pbGirisIcon);
            this.Controls.Add(this.lkbSifremiUnuttum);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.txtGirisKullaniciAdi);
            this.Controls.Add(this.lblSifreGiris);
            this.Controls.Add(this.lblKullaniciAdiGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGirisIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox btnExit;
        private CheckBox ckbSifreyiGoster;
        private PictureBox pbGirisIcon;
        private LinkLabel lkbSifremiUnuttum;
        private Button btnGiris;
        private ImageList imgListIntrefaces;
        private Button btnKayıtOl;
        private TextBox txtGirisSifre;
        private TextBox txtGirisKullaniciAdi;
        private Label lblSifreGiris;
        private Label lblKullaniciAdiGiris;
    }
}