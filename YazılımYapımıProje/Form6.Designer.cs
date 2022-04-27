namespace YazılımYapımıProje
{
    partial class FrmSifremiUnuttum
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
            this.txtSifremiUnuttumMail = new System.Windows.Forms.TextBox();
            this.txtSifremiUnuttumSifre = new System.Windows.Forms.TextBox();
            this.lblSifremiUnuttumSifre = new System.Windows.Forms.Label();
            this.lblSifremiUnuttumMail = new System.Windows.Forms.Label();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifremiUnuttumMail
            // 
            this.txtSifremiUnuttumMail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifremiUnuttumMail.Location = new System.Drawing.Point(279, 81);
            this.txtSifremiUnuttumMail.Name = "txtSifremiUnuttumMail";
            this.txtSifremiUnuttumMail.Size = new System.Drawing.Size(132, 25);
            this.txtSifremiUnuttumMail.TabIndex = 0;
            // 
            // txtSifremiUnuttumSifre
            // 
            this.txtSifremiUnuttumSifre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifremiUnuttumSifre.Location = new System.Drawing.Point(279, 123);
            this.txtSifremiUnuttumSifre.Name = "txtSifremiUnuttumSifre";
            this.txtSifremiUnuttumSifre.Size = new System.Drawing.Size(132, 25);
            this.txtSifremiUnuttumSifre.TabIndex = 0;
            // 
            // lblSifremiUnuttumSifre
            // 
            this.lblSifremiUnuttumSifre.AutoSize = true;
            this.lblSifremiUnuttumSifre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifremiUnuttumSifre.Location = new System.Drawing.Point(189, 126);
            this.lblSifremiUnuttumSifre.Name = "lblSifremiUnuttumSifre";
            this.lblSifremiUnuttumSifre.Size = new System.Drawing.Size(67, 19);
            this.lblSifremiUnuttumSifre.TabIndex = 1;
            this.lblSifremiUnuttumSifre.Text = "Yeni şifre:";
            // 
            // lblSifremiUnuttumMail
            // 
            this.lblSifremiUnuttumMail.AutoSize = true;
            this.lblSifremiUnuttumMail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifremiUnuttumMail.Location = new System.Drawing.Point(207, 81);
            this.lblSifremiUnuttumMail.Name = "lblSifremiUnuttumMail";
            this.lblSifremiUnuttumMail.Size = new System.Drawing.Size(49, 19);
            this.lblSifremiUnuttumMail.TabIndex = 1;
            this.lblSifremiUnuttumMail.Text = "E Mail:";
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSifreGuncelle.Location = new System.Drawing.Point(322, 181);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(89, 31);
            this.btnSifreGuncelle.TabIndex = 2;
            this.btnSifreGuncelle.Text = " Şifre Yenile";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnSifreGuncelle_Click);
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSifreGuncelle);
            this.Controls.Add(this.lblSifremiUnuttumMail);
            this.Controls.Add(this.lblSifremiUnuttumSifre);
            this.Controls.Add(this.txtSifremiUnuttumSifre);
            this.Controls.Add(this.txtSifremiUnuttumMail);
            this.Name = "FrmSifremiUnuttum";
            this.Text = "ŞİFREMİ UNUTTUM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSifremiUnuttumMail;
        private TextBox txtSifremiUnuttumSifre;
        private Label lblSifremiUnuttumSifre;
        private Label lblSifremiUnuttumMail;
        private Button btnSifreGuncelle;
    }
}