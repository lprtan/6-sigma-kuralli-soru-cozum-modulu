namespace YazılımYapımıProje
{
    partial class FrmGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.lblKullaniciAdiGiris = new System.Windows.Forms.Label();
            this.lblSifreGiris = new System.Windows.Forms.Label();
            this.txtGirisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblSifeyiUnuttum = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblKullaniciAdiGiris
            // 
            this.lblKullaniciAdiGiris.AllowDrop = true;
            this.lblKullaniciAdiGiris.AutoSize = true;
            this.lblKullaniciAdiGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdiGiris.Location = new System.Drawing.Point(142, 125);
            this.lblKullaniciAdiGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdiGiris.Name = "lblKullaniciAdiGiris";
            this.lblKullaniciAdiGiris.Size = new System.Drawing.Size(98, 21);
            this.lblKullaniciAdiGiris.TabIndex = 0;
            this.lblKullaniciAdiGiris.Text = "Kullanıcı Adı:";
            this.lblKullaniciAdiGiris.Click += new System.EventHandler(this.lblKullaniciAdiGiris_Click);
            // 
            // lblSifreGiris
            // 
            this.lblSifreGiris.AutoSize = true;
            this.lblSifreGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifreGiris.Location = new System.Drawing.Point(195, 156);
            this.lblSifreGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreGiris.Name = "lblSifreGiris";
            this.lblSifreGiris.Size = new System.Drawing.Size(45, 21);
            this.lblSifreGiris.TabIndex = 0;
            this.lblSifreGiris.Text = "Şifre:";
            this.lblSifreGiris.Click += new System.EventHandler(this.lblSifreGiris_Click);
            // 
            // txtGirisKullaniciAdi
            // 
            this.txtGirisKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGirisKullaniciAdi.Location = new System.Drawing.Point(247, 125);
            this.txtGirisKullaniciAdi.Name = "txtGirisKullaniciAdi";
            this.txtGirisKullaniciAdi.Size = new System.Drawing.Size(216, 25);
            this.txtGirisKullaniciAdi.TabIndex = 1;
            this.txtGirisKullaniciAdi.TextChanged += new System.EventHandler(this.txtGirisKullaniciAdi_TextChanged);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGirisSifre.Location = new System.Drawing.Point(247, 156);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(216, 25);
            this.txtGirisSifre.TabIndex = 1;
            this.txtGirisSifre.TextChanged += new System.EventHandler(this.txtGirisSifre_TextChanged);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtOl.ImageKey = "ne user ico.ico";
            this.btnKayıtOl.ImageList = this.ımageList1;
            this.btnKayıtOl.Location = new System.Drawing.Point(247, 187);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(105, 36);
            this.btnKayıtOl.TabIndex = 2;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKatıtOl_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.ImageKey = "user icon.ico";
            this.btnGiris.ImageList = this.ımageList2;
            this.btnGiris.Location = new System.Drawing.Point(358, 187);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(105, 36);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblSifeyiUnuttum
            // 
            this.lblSifeyiUnuttum.AutoSize = true;
            this.lblSifeyiUnuttum.Location = new System.Drawing.Point(288, 226);
            this.lblSifeyiUnuttum.Name = "lblSifeyiUnuttum";
            this.lblSifeyiUnuttum.Size = new System.Drawing.Size(120, 21);
            this.lblSifeyiUnuttum.TabIndex = 3;
            this.lblSifeyiUnuttum.Text = "Şifreyi Unuttum";
            this.lblSifeyiUnuttum.Click += new System.EventHandler(this.lblSifeyiUnuttum_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ne user ico.ico");
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "user icon.ico");
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lblSifeyiUnuttum);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.txtGirisKullaniciAdi);
            this.Controls.Add(this.lblSifreGiris);
            this.Controls.Add(this.lblKullaniciAdiGiris);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.RightToLeftLayout = true;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKullaniciAdiGiris;
        private Label lblSifreGiris;
        private TextBox txtGirisKullaniciAdi;
        private TextBox txtGirisSifre;
        private Button btnKayıtOl;
        private Button btnGiris;
        private Label lblSifeyiUnuttum;
        private ImageList ımageList1;
        private ImageList ımageList2;
    }
}