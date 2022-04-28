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
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblSifreGiris = new System.Windows.Forms.Label();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.txtGirisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGiris = new System.Windows.Forms.Button();
            this.lkbSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblKullaniciAdiGiris
            // 
            this.lblKullaniciAdiGiris.AllowDrop = true;
            this.lblKullaniciAdiGiris.AutoSize = true;
            this.lblKullaniciAdiGiris.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdiGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKullaniciAdiGiris.ImageKey = "user icon.ico";
            this.lblKullaniciAdiGiris.ImageList = this.ımageList2;
            this.lblKullaniciAdiGiris.Location = new System.Drawing.Point(56, 117);
            this.lblKullaniciAdiGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdiGiris.Name = "lblKullaniciAdiGiris";
            this.lblKullaniciAdiGiris.Size = new System.Drawing.Size(185, 32);
            this.lblKullaniciAdiGiris.TabIndex = 0;
            this.lblKullaniciAdiGiris.Text = "     Kullanıcı Adı:";
            this.lblKullaniciAdiGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKullaniciAdiGiris.Click += new System.EventHandler(this.lblKullaniciAdiGiris_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "user icon.ico");
            // 
            // lblSifreGiris
            // 
            this.lblSifreGiris.AutoSize = true;
            this.lblSifreGiris.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifreGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSifreGiris.ImageKey = "password icn.ico";
            this.lblSifreGiris.ImageList = this.ımageList3;
            this.lblSifreGiris.Location = new System.Drawing.Point(139, 162);
            this.lblSifreGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreGiris.Name = "lblSifreGiris";
            this.lblSifreGiris.Size = new System.Drawing.Size(102, 32);
            this.lblSifreGiris.TabIndex = 0;
            this.lblSifreGiris.Text = "     Şifre:";
            this.lblSifreGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSifreGiris.Click += new System.EventHandler(this.lblSifreGiris_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "password icn.ico");
            // 
            // txtGirisKullaniciAdi
            // 
            this.txtGirisKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGirisKullaniciAdi.Location = new System.Drawing.Point(248, 114);
            this.txtGirisKullaniciAdi.Name = "txtGirisKullaniciAdi";
            this.txtGirisKullaniciAdi.Size = new System.Drawing.Size(216, 39);
            this.txtGirisKullaniciAdi.TabIndex = 1;
            this.txtGirisKullaniciAdi.TextChanged += new System.EventHandler(this.txtGirisKullaniciAdi_TextChanged);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGirisSifre.Location = new System.Drawing.Point(248, 159);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(216, 39);
            this.txtGirisSifre.TabIndex = 2;
            this.txtGirisSifre.TextChanged += new System.EventHandler(this.txtGirisSifre_TextChanged);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtOl.ImageKey = "ne user ico.ico";
            this.btnKayıtOl.ImageList = this.ımageList1;
            this.btnKayıtOl.Location = new System.Drawing.Point(248, 204);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(105, 36);
            this.btnKayıtOl.TabIndex = 4;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKatıtOl_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ne user ico.ico");
            // 
            // btnGiris
            // 
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.ImageKey = "user icon.ico";
            this.btnGiris.ImageList = this.ımageList2;
            this.btnGiris.Location = new System.Drawing.Point(359, 204);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(105, 36);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lkbSifremiUnuttum
            // 
            this.lkbSifremiUnuttum.AutoSize = true;
            this.lkbSifremiUnuttum.Location = new System.Drawing.Point(301, 254);
            this.lkbSifremiUnuttum.Name = "lkbSifremiUnuttum";
            this.lkbSifremiUnuttum.Size = new System.Drawing.Size(126, 21);
            this.lkbSifremiUnuttum.TabIndex = 5;
            this.lkbSifremiUnuttum.TabStop = true;
            this.lkbSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lkbSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbSifremiUnuttum_LinkClicked);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lkbSifremiUnuttum);
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
            this.Text = "Ana Sayfa";
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
        private ImageList ımageList1;
        private ImageList ımageList2;
        private ImageList ımageList3;
        private LinkLabel lkbSifremiUnuttum;
    }
}