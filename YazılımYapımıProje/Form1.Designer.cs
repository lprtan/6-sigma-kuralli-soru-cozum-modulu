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
            this.lblKullaniciAdiGiris = new System.Windows.Forms.Label();
            this.lblSifreGiris = new System.Windows.Forms.Label();
            this.txtGirisKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblKullaniciAdiGiris
            // 
            this.lblKullaniciAdiGiris.AllowDrop = true;
            this.lblKullaniciAdiGiris.AutoSize = true;
            this.lblKullaniciAdiGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdiGiris.Location = new System.Drawing.Point(206, 126);
            this.lblKullaniciAdiGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdiGiris.Name = "lblKullaniciAdiGiris";
            this.lblKullaniciAdiGiris.Size = new System.Drawing.Size(98, 21);
            this.lblKullaniciAdiGiris.TabIndex = 0;
            this.lblKullaniciAdiGiris.Text = "Kullanıcı Adı:";
            // 
            // lblSifreGiris
            // 
            this.lblSifreGiris.AutoSize = true;
            this.lblSifreGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifreGiris.Location = new System.Drawing.Point(259, 182);
            this.lblSifreGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreGiris.Name = "lblSifreGiris";
            this.lblSifreGiris.Size = new System.Drawing.Size(45, 21);
            this.lblSifreGiris.TabIndex = 0;
            this.lblSifreGiris.Text = "Şifre:";
            // 
            // txtGirisKullaniciAdi
            // 
            this.txtGirisKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGirisKullaniciAdi.Location = new System.Drawing.Point(334, 122);
            this.txtGirisKullaniciAdi.Name = "txtGirisKullaniciAdi";
            this.txtGirisKullaniciAdi.Size = new System.Drawing.Size(166, 25);
            this.txtGirisKullaniciAdi.TabIndex = 1;
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGirisSifre.Location = new System.Drawing.Point(334, 182);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(166, 25);
            this.txtGirisSifre.TabIndex = 1;
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Location = new System.Drawing.Point(334, 234);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(80, 29);
            this.btnKayıtOl.TabIndex = 2;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKatıtOl_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(420, 234);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(80, 29);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(519, 242);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Şifremi Unuttum";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.checkBox1);
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
        private CheckBox checkBox1;
    }
}