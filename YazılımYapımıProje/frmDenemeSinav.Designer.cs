namespace YazılımYapımıProje
{
    partial class frmDenemeSinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDenemeSinav));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmrKronometre = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnGirisSayfası = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnSinavBitir = new System.Windows.Forms.Button();
            this.imgListInterfaces = new System.Windows.Forms.ImageList(this.components);
            this.btnSonraki = new System.Windows.Forms.Button();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.rtbSoru = new System.Windows.Forms.RichTextBox();
            this.lsvRapor = new System.Windows.Forms.ListView();
            this.btnRapor = new System.Windows.Forms.Button();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGirisSayfası)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tmrKronometre
            // 
            this.tmrKronometre.Tick += new System.EventHandler(this.tmrKronometre_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 382);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(876, 23);
            this.progressBar1.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(747, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(26, 22);
            this.dataGridView1.TabIndex = 60;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(792, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 28);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 58;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(860, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 57;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGirisSayfası
            // 
            this.btnGirisSayfası.BackColor = System.Drawing.Color.OldLace;
            this.btnGirisSayfası.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisSayfası.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisSayfası.Image")));
            this.btnGirisSayfası.Location = new System.Drawing.Point(826, 12);
            this.btnGirisSayfası.Name = "btnGirisSayfası";
            this.btnGirisSayfası.Size = new System.Drawing.Size(28, 28);
            this.btnGirisSayfası.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGirisSayfası.TabIndex = 56;
            this.btnGirisSayfası.TabStop = false;
            this.btnGirisSayfası.Click += new System.EventHandler(this.btnGirisSayfası_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(788, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(633, 283);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(39, 15);
            this.lblSure.TabIndex = 53;
            this.lblSure.Text = "Süre : ";
            this.lblSure.TextChanged += new System.EventHandler(this.lblSure_TextChanged);
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.LightYellow;
            this.txtD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtD.Location = new System.Drawing.Point(233, 336);
            this.txtD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(164, 41);
            this.txtD.TabIndex = 52;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.LightYellow;
            this.txtC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtC.Location = new System.Drawing.Point(12, 336);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(164, 41);
            this.txtC.TabIndex = 51;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.LightYellow;
            this.txtB.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(233, 273);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(164, 41);
            this.txtB.TabIndex = 50;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.LightYellow;
            this.txtA.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(12, 273);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(164, 41);
            this.txtA.TabIndex = 49;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSinavBitir
            // 
            this.btnSinavBitir.BackColor = System.Drawing.Color.Orange;
            this.btnSinavBitir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSinavBitir.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinavBitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinavBitir.ImageKey = "checked.png";
            this.btnSinavBitir.ImageList = this.imgListInterfaces;
            this.btnSinavBitir.Location = new System.Drawing.Point(521, 281);
            this.btnSinavBitir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSinavBitir.Name = "btnSinavBitir";
            this.btnSinavBitir.Size = new System.Drawing.Size(82, 30);
            this.btnSinavBitir.TabIndex = 48;
            this.btnSinavBitir.Text = "     Bitir";
            this.btnSinavBitir.UseVisualStyleBackColor = false;
            this.btnSinavBitir.Click += new System.EventHandler(this.btnSinavBitir_Click);
            // 
            // imgListInterfaces
            // 
            this.imgListInterfaces.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListInterfaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListInterfaces.ImageStream")));
            this.imgListInterfaces.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListInterfaces.Images.SetKeyName(0, "right-arrow.png");
            this.imgListInterfaces.Images.SetKeyName(1, "edit.png");
            this.imgListInterfaces.Images.SetKeyName(2, "checked.png");
            this.imgListInterfaces.Images.SetKeyName(3, "document.png");
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.Orange;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonraki.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonraki.ImageKey = "right-arrow.png";
            this.btnSonraki.ImageList = this.imgListInterfaces;
            this.btnSonraki.Location = new System.Drawing.Point(465, 281);
            this.btnSonraki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(50, 30);
            this.btnSonraki.TabIndex = 47;
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.BackColor = System.Drawing.Color.LightYellow;
            this.rdbD.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbD.Location = new System.Drawing.Point(402, 347);
            this.rdbD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(34, 19);
            this.rdbD.TabIndex = 46;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = false;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.BackColor = System.Drawing.Color.LightYellow;
            this.rdbC.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbC.Location = new System.Drawing.Point(182, 347);
            this.rdbC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(33, 19);
            this.rdbC.TabIndex = 45;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = false;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.BackColor = System.Drawing.Color.LightYellow;
            this.rdbB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbB.Location = new System.Drawing.Point(404, 283);
            this.rdbB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(33, 19);
            this.rdbB.TabIndex = 44;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = false;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.BackColor = System.Drawing.Color.LightYellow;
            this.rdbA.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbA.Location = new System.Drawing.Point(182, 283);
            this.rdbA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(34, 19);
            this.rdbA.TabIndex = 43;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = false;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(12, 45);
            this.pbResim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(320, 220);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 42;
            this.pbResim.TabStop = false;
            // 
            // rtbSoru
            // 
            this.rtbSoru.BackColor = System.Drawing.Color.LightYellow;
            this.rtbSoru.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbSoru.Location = new System.Drawing.Point(338, 45);
            this.rtbSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSoru.Name = "rtbSoru";
            this.rtbSoru.Size = new System.Drawing.Size(550, 220);
            this.rtbSoru.TabIndex = 41;
            this.rtbSoru.Text = "Soru:  ";
            // 
            // lsvRapor
            // 
            this.lsvRapor.Location = new System.Drawing.Point(338, 45);
            this.lsvRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvRapor.Name = "lsvRapor";
            this.lsvRapor.Size = new System.Drawing.Size(550, 220);
            this.lsvRapor.TabIndex = 62;
            this.lsvRapor.UseCompatibleStateImageBehavior = false;
            this.lsvRapor.Visible = false;
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.Orange;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRapor.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.ImageKey = "edit.png";
            this.btnRapor.ImageList = this.imgListInterfaces;
            this.btnRapor.Location = new System.Drawing.Point(465, 336);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(138, 30);
            this.btnRapor.TabIndex = 63;
            this.btnRapor.Text = "Rapor Al";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(659, 347);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(82, 15);
            this.lblDogruCevap.TabIndex = 54;
            this.lblDogruCevap.Text = "Doğru Cevap :";
            this.lblDogruCevap.Visible = false;
            // 
            // frmDenemeSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(900, 410);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.lsvRapor);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGirisSayfası);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnSinavBitir);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.rtbSoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDenemeSinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDenemeSinav";
            this.Load += new System.EventHandler(this.frmDenemeSinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGirisSayfası)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ProgressBar progressBar1;
        private DataGridView dataGridView1;
        private PictureBox btnBack;
        private PictureBox btnExit;
        private PictureBox btnGirisSayfası;
        private PictureBox pictureBox1;
        private Label lblSure;
        private TextBox txtD;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Button btnSinavBitir;
        private Button btnSonraki;
        private RadioButton rdbD;
        private RadioButton rdbC;
        private RadioButton rdbB;
        private RadioButton rdbA;
        private PictureBox pbResim;
        private RichTextBox rtbSoru;
        private System.Windows.Forms.Timer tmrKronometre;
        private ListView lsvRapor;
        private Button btnRapor;
        private ImageList imgListInterfaces;
        private Label lblDogruCevap;
    }
}