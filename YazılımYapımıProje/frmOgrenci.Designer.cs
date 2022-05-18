namespace YazılımYapımıProje
{
    partial class frmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenci));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgListInterface = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOgrenciRaporAl = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnDenemeSinavi = new System.Windows.Forms.Button();
            this.btnSigma6 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.grpAyarlar = new System.Windows.Forms.GroupBox();
            this.lblGun = new System.Windows.Forms.Label();
            this.btnAyarKaydet = new System.Windows.Forms.Button();
            this.cbxGun = new System.Windows.Forms.ComboBox();
            this.lblAy = new System.Windows.Forms.Label();
            this.cbxHafta = new System.Windows.Forms.ComboBox();
            this.lblHafta = new System.Windows.Forms.Label();
            this.cbxAy = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.grpAyarlar.SuspendLayout();
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
            this.imgListInterface.Images.SetKeyName(0, "bin.png");
            this.imgListInterface.Images.SetKeyName(1, "edit.png");
            this.imgListInterface.Images.SetKeyName(2, "lock.png");
            this.imgListInterface.Images.SetKeyName(3, "refresh.png");
            this.imgListInterface.Images.SetKeyName(4, "save.png");
            this.imgListInterface.Images.SetKeyName(5, "setting.png");
            this.imgListInterface.Images.SetKeyName(6, "share.png");
            this.imgListInterface.Images.SetKeyName(7, "process.png");
            this.imgListInterface.Images.SetKeyName(8, "web.png");
            this.imgListInterface.Images.SetKeyName(9, "artificial-intelligence.png");
            this.imgListInterface.Images.SetKeyName(10, "assessment.png");
            this.imgListInterface.Images.SetKeyName(11, "book (1).png");
            this.imgListInterface.Images.SetKeyName(12, "book.png");
            this.imgListInterface.Images.SetKeyName(13, "brain.png");
            this.imgListInterface.Images.SetKeyName(14, "learning.png");
            this.imgListInterface.Images.SetKeyName(15, "smart-human.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.btnOgrenciRaporAl);
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.btnDenemeSinavi);
            this.panel1.Controls.Add(this.btnSigma6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 400);
            this.panel1.TabIndex = 25;
            // 
            // btnOgrenciRaporAl
            // 
            this.btnOgrenciRaporAl.BackColor = System.Drawing.Color.Orange;
            this.btnOgrenciRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOgrenciRaporAl.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciRaporAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciRaporAl.ImageKey = "web.png";
            this.btnOgrenciRaporAl.ImageList = this.imgListInterface;
            this.btnOgrenciRaporAl.Location = new System.Drawing.Point(5, 255);
            this.btnOgrenciRaporAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgrenciRaporAl.Name = "btnOgrenciRaporAl";
            this.btnOgrenciRaporAl.Size = new System.Drawing.Size(210, 38);
            this.btnOgrenciRaporAl.TabIndex = 4;
            this.btnOgrenciRaporAl.Text = "     Rapor Görüntüle";
            this.btnOgrenciRaporAl.UseVisualStyleBackColor = false;
            this.btnOgrenciRaporAl.Click += new System.EventHandler(this.btnOgrenciRaporAl_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Orange;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyarlar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.ImageKey = "setting.png";
            this.btnAyarlar.ImageList = this.imgListInterface;
            this.btnAyarlar.Location = new System.Drawing.Point(5, 126);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(210, 38);
            this.btnAyarlar.TabIndex = 1;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnDenemeSinavi
            // 
            this.btnDenemeSinavi.BackColor = System.Drawing.Color.Orange;
            this.btnDenemeSinavi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDenemeSinavi.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDenemeSinavi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDenemeSinavi.ImageKey = "process.png";
            this.btnDenemeSinavi.ImageList = this.imgListInterface;
            this.btnDenemeSinavi.Location = new System.Drawing.Point(5, 213);
            this.btnDenemeSinavi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDenemeSinavi.Name = "btnDenemeSinavi";
            this.btnDenemeSinavi.Size = new System.Drawing.Size(210, 38);
            this.btnDenemeSinavi.TabIndex = 3;
            this.btnDenemeSinavi.Text = "     Deneme Sınavı";
            this.btnDenemeSinavi.UseVisualStyleBackColor = false;
            this.btnDenemeSinavi.Click += new System.EventHandler(this.btnDenemeSinavi_Click);
            // 
            // btnSigma6
            // 
            this.btnSigma6.BackColor = System.Drawing.Color.Orange;
            this.btnSigma6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSigma6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSigma6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSigma6.ImageKey = "learning.png";
            this.btnSigma6.ImageList = this.imgListInterface;
            this.btnSigma6.Location = new System.Drawing.Point(5, 170);
            this.btnSigma6.Name = "btnSigma6";
            this.btnSigma6.Size = new System.Drawing.Size(210, 38);
            this.btnSigma6.TabIndex = 2;
            this.btnSigma6.Text = "     Sigma 6 Sınavı";
            this.btnSigma6.UseVisualStyleBackColor = false;
            this.btnSigma6.Click += new System.EventHandler(this.btnSigma6_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(426, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 28);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 24;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(460, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 23;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpAyarlar
            // 
            this.grpAyarlar.Controls.Add(this.lblGun);
            this.grpAyarlar.Controls.Add(this.btnAyarKaydet);
            this.grpAyarlar.Controls.Add(this.cbxGun);
            this.grpAyarlar.Controls.Add(this.lblAy);
            this.grpAyarlar.Controls.Add(this.cbxHafta);
            this.grpAyarlar.Controls.Add(this.lblHafta);
            this.grpAyarlar.Controls.Add(this.cbxAy);
            this.grpAyarlar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAyarlar.Location = new System.Drawing.Point(228, 95);
            this.grpAyarlar.Name = "grpAyarlar";
            this.grpAyarlar.Size = new System.Drawing.Size(262, 214);
            this.grpAyarlar.TabIndex = 22;
            this.grpAyarlar.TabStop = false;
            this.grpAyarlar.Text = "Ayarlar";
            this.grpAyarlar.Visible = false;
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGun.Location = new System.Drawing.Point(51, 48);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(50, 23);
            this.lblGun.TabIndex = 16;
            this.lblGun.Text = "Gün:";
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.BackColor = System.Drawing.Color.Orange;
            this.btnAyarKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyarKaydet.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAyarKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarKaydet.ImageKey = "save.png";
            this.btnAyarKaydet.ImageList = this.imgListInterface;
            this.btnAyarKaydet.Location = new System.Drawing.Point(37, 160);
            this.btnAyarKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(189, 38);
            this.btnAyarKaydet.TabIndex = 8;
            this.btnAyarKaydet.Text = "       Ayarları Kaydet";
            this.btnAyarKaydet.UseVisualStyleBackColor = false;
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // cbxGun
            // 
            this.cbxGun.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbxGun.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxGun.FormattingEnabled = true;
            this.cbxGun.Items.AddRange(new object[] {
            "1",
            "3"});
            this.cbxGun.Location = new System.Drawing.Point(107, 45);
            this.cbxGun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGun.Name = "cbxGun";
            this.cbxGun.Size = new System.Drawing.Size(121, 31);
            this.cbxGun.TabIndex = 5;
            // 
            // lblAy
            // 
            this.lblAy.AutoSize = true;
            this.lblAy.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAy.Location = new System.Drawing.Point(64, 118);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(37, 23);
            this.lblAy.TabIndex = 14;
            this.lblAy.Text = "Ay:";
            // 
            // cbxHafta
            // 
            this.cbxHafta.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbxHafta.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxHafta.FormattingEnabled = true;
            this.cbxHafta.Items.AddRange(new object[] {
            "7",
            "14"});
            this.cbxHafta.Location = new System.Drawing.Point(107, 80);
            this.cbxHafta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxHafta.Name = "cbxHafta";
            this.cbxHafta.Size = new System.Drawing.Size(121, 31);
            this.cbxHafta.TabIndex = 6;
            // 
            // lblHafta
            // 
            this.lblHafta.AutoSize = true;
            this.lblHafta.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHafta.Location = new System.Drawing.Point(39, 83);
            this.lblHafta.Name = "lblHafta";
            this.lblHafta.Size = new System.Drawing.Size(62, 23);
            this.lblHafta.TabIndex = 15;
            this.lblHafta.Text = "Hafta:";
            // 
            // cbxAy
            // 
            this.cbxAy.BackColor = System.Drawing.Color.LemonChiffon;
            this.cbxAy.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxAy.FormattingEnabled = true;
            this.cbxAy.Items.AddRange(new object[] {
            "30",
            "60"});
            this.cbxAy.Location = new System.Drawing.Point(107, 115);
            this.cbxAy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAy.Name = "cbxAy";
            this.cbxAy.Size = new System.Drawing.Size(121, 31);
            this.cbxAy.TabIndex = 7;
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpAyarlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenci";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.grpAyarlar.ResumeLayout(false);
            this.grpAyarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel1;
        private Button btnAyarlar;
        private ImageList imgListInterface;
        private Button btnDenemeSinavi;
        private Button btnSigma6;
        private PictureBox btnBack;
        private PictureBox btnExit;
        private GroupBox grpAyarlar;
        private Label lblGun;
        private Button btnAyarKaydet;
        private ComboBox cbxGun;
        private Label lblAy;
        private ComboBox cbxHafta;
        private Label lblHafta;
        private ComboBox cbxAy;
        private Button btnOgrenciRaporAl;
    }
}