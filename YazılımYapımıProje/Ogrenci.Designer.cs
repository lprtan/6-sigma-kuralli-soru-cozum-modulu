namespace YazılımYapımıProje
{
    partial class FrmOgrenci
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxGun = new System.Windows.Forms.ComboBox();
            this.cbxHafta = new System.Windows.Forms.ComboBox();
            this.cbxAy = new System.Windows.Forms.ComboBox();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblHafta = new System.Windows.Forms.Label();
            this.lblAy = new System.Windows.Forms.Label();
            this.btnAyarKaydet = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Deneme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sigma Sınav sistemi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxGun
            // 
            this.cbxGun.FormattingEnabled = true;
            this.cbxGun.Items.AddRange(new object[] {
            "1",
            "3"});
            this.cbxGun.Location = new System.Drawing.Point(760, 72);
            this.cbxGun.Name = "cbxGun";
            this.cbxGun.Size = new System.Drawing.Size(151, 28);
            this.cbxGun.TabIndex = 4;
            // 
            // cbxHafta
            // 
            this.cbxHafta.FormattingEnabled = true;
            this.cbxHafta.Items.AddRange(new object[] {
            "7",
            "14"});
            this.cbxHafta.Location = new System.Drawing.Point(760, 129);
            this.cbxHafta.Name = "cbxHafta";
            this.cbxHafta.Size = new System.Drawing.Size(151, 28);
            this.cbxHafta.TabIndex = 5;
            // 
            // cbxAy
            // 
            this.cbxAy.FormattingEnabled = true;
            this.cbxAy.Items.AddRange(new object[] {
            "30",
            "60"});
            this.cbxAy.Location = new System.Drawing.Point(760, 183);
            this.cbxAy.Name = "cbxAy";
            this.cbxAy.Size = new System.Drawing.Size(151, 28);
            this.cbxAy.TabIndex = 6;
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(694, 72);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(38, 20);
            this.lblGun.TabIndex = 7;
            this.lblGun.Text = "Gün:";
            // 
            // lblHafta
            // 
            this.lblHafta.AutoSize = true;
            this.lblHafta.Location = new System.Drawing.Point(694, 137);
            this.lblHafta.Name = "lblHafta";
            this.lblHafta.Size = new System.Drawing.Size(49, 20);
            this.lblHafta.TabIndex = 7;
            this.lblHafta.Text = "Hafta:";
            // 
            // lblAy
            // 
            this.lblAy.AutoSize = true;
            this.lblAy.Location = new System.Drawing.Point(694, 191);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(29, 20);
            this.lblAy.TabIndex = 7;
            this.lblAy.Text = "Ay:";
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Location = new System.Drawing.Point(783, 231);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(128, 37);
            this.btnAyarKaydet.TabIndex = 8;
            this.btnAyarKaydet.Text = "Ayarları Kaydet";
            this.btnAyarKaydet.UseVisualStyleBackColor = true;
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(100, 337);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(94, 29);
            this.btnRapor.TabIndex = 9;
            this.btnRapor.Text = "Rapor Al";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1078, 621);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.lblHafta);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.cbxAy);
            this.Controls.Add(this.cbxHafta);
            this.Controls.Add(this.cbxGun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOgrenci";
            this.Text = "ÖĞRENCİ EKRANI";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox cbxGun;
        private ComboBox cbxHafta;
        private ComboBox cbxAy;
        private Label lblGun;
        private Label lblHafta;
        private Label lblAy;
        private Button btnAyarKaydet;
        private Button btnRapor;
    }
}