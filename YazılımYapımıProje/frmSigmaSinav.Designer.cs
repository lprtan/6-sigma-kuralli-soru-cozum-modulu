namespace YazılımYapımıProje
{
    partial class frmSigmaSinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSigmaSinav));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnHomePage = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.imgListInterface = new System.Windows.Forms.ImageList(this.components);
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rtbSoru = new System.Windows.Forms.RichTextBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.tmrKronometre = new System.Windows.Forms.Timer(this.components);
            this.lblKalanDakika = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.pnlA = new System.Windows.Forms.Panel();
            this.pnlB = new System.Windows.Forms.Panel();
            this.pnlC = new System.Windows.Forms.Panel();
            this.pnlD = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(792, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 28);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 88;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.Location = new System.Drawing.Point(826, 12);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(28, 28);
            this.btnHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHomePage.TabIndex = 87;
            this.btnHomePage.TabStop = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(860, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 86;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(860, 348);
            this.dgvList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 29;
            this.dgvList.Size = new System.Drawing.Size(21, 20);
            this.dgvList.TabIndex = 85;
            this.dgvList.Visible = false;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(584, 360);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(76, 15);
            this.lblDogruCevap.TabIndex = 84;
            this.lblDogruCevap.Text = "Doğru Cevap";
            this.lblDogruCevap.Visible = false;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblSure.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSure.ForeColor = System.Drawing.Color.Orange;
            this.lblSure.Location = new System.Drawing.Point(577, 279);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(52, 19);
            this.lblSure.TabIndex = 83;
            this.lblSure.Text = "Süre : ";
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.Orange;
            this.btnSonraki.Enabled = false;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonraki.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonraki.ImageKey = "right-arrow.png";
            this.btnSonraki.ImageList = this.imgListInterface;
            this.btnSonraki.Location = new System.Drawing.Point(465, 342);
            this.btnSonraki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(50, 30);
            this.btnSonraki.TabIndex = 82;
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // imgListInterface
            // 
            this.imgListInterface.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListInterface.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListInterface.ImageStream")));
            this.imgListInterface.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListInterface.Images.SetKeyName(0, "left.png");
            this.imgListInterface.Images.SetKeyName(1, "right-arrow.png");
            this.imgListInterface.Images.SetKeyName(2, "running (1).png");
            this.imgListInterface.Images.SetKeyName(3, "running (2).png");
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtD.Location = new System.Drawing.Point(233, 336);
            this.txtD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(164, 41);
            this.txtD.TabIndex = 81;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtD.Visible = false;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtC.Location = new System.Drawing.Point(12, 336);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(164, 41);
            this.txtC.TabIndex = 80;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtC.Visible = false;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtB.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(233, 273);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(164, 41);
            this.txtB.TabIndex = 79;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB.Visible = false;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtA.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(12, 273);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(164, 41);
            this.txtA.TabIndex = 78;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA.Visible = false;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Enabled = false;
            this.rdbD.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbD.Location = new System.Drawing.Point(402, 348);
            this.rdbD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(34, 19);
            this.rdbD.TabIndex = 4;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Enabled = false;
            this.rdbC.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbC.Location = new System.Drawing.Point(182, 348);
            this.rdbC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(33, 19);
            this.rdbC.TabIndex = 3;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Enabled = false;
            this.rdbB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbB.Location = new System.Drawing.Point(403, 283);
            this.rdbB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(33, 19);
            this.rdbB.TabIndex = 2;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Enabled = false;
            this.rdbA.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbA.Location = new System.Drawing.Point(182, 283);
            this.rdbA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(34, 19);
            this.rdbA.TabIndex = 1;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rtbSoru
            // 
            this.rtbSoru.BackColor = System.Drawing.Color.LemonChiffon;
            this.rtbSoru.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbSoru.Location = new System.Drawing.Point(338, 45);
            this.rtbSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSoru.Name = "rtbSoru";
            this.rtbSoru.Size = new System.Drawing.Size(550, 220);
            this.rtbSoru.TabIndex = 73;
            this.rtbSoru.Text = "Soru:  ";
            this.rtbSoru.Visible = false;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(12, 45);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(320, 220);
            this.pbResim.TabIndex = 72;
            this.pbResim.TabStop = false;
            this.pbResim.Visible = false;
            // 
            // tmrKronometre
            // 
            this.tmrKronometre.Interval = 60000;
            this.tmrKronometre.Tick += new System.EventHandler(this.tmrKronometre_Tick);
            // 
            // lblKalanDakika
            // 
            this.lblKalanDakika.AutoSize = true;
            this.lblKalanDakika.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblKalanDakika.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKalanDakika.ForeColor = System.Drawing.Color.Orange;
            this.lblKalanDakika.Location = new System.Drawing.Point(465, 279);
            this.lblKalanDakika.Name = "lblKalanDakika";
            this.lblKalanDakika.Size = new System.Drawing.Size(106, 19);
            this.lblKalanDakika.TabIndex = 89;
            this.lblKalanDakika.Text = "Kalan Dakika :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(788, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Orange;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBasla.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBasla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasla.ImageKey = "running (2).png";
            this.btnBasla.ImageList = this.imgListInterface;
            this.btnBasla.Location = new System.Drawing.Point(465, 306);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(82, 30);
            this.btnBasla.TabIndex = 91;
            this.btnBasla.Text = "    Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // pnlA
            // 
            this.pnlA.BackColor = System.Drawing.Color.LightYellow;
            this.pnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlA.Location = new System.Drawing.Point(12, 273);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(164, 41);
            this.pnlA.TabIndex = 92;
            // 
            // pnlB
            // 
            this.pnlB.BackColor = System.Drawing.Color.LightYellow;
            this.pnlB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlB.Location = new System.Drawing.Point(233, 273);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(164, 41);
            this.pnlB.TabIndex = 93;
            // 
            // pnlC
            // 
            this.pnlC.BackColor = System.Drawing.Color.LightYellow;
            this.pnlC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlC.Location = new System.Drawing.Point(12, 336);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(164, 41);
            this.pnlC.TabIndex = 93;
            // 
            // pnlD
            // 
            this.pnlD.BackColor = System.Drawing.Color.LightYellow;
            this.pnlD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlD.Location = new System.Drawing.Point(233, 336);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(164, 41);
            this.pnlD.TabIndex = 93;
            // 
            // frmSigmaSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(900, 410);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKalanDakika);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDogruCevap);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.rtbSoru);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlA);
            this.Controls.Add(this.pnlB);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.pnlD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSigmaSinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSigmaSınav";
            this.Load += new System.EventHandler(this.frmSigmaSınav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox btnBack;
        private PictureBox btnHomePage;
        private PictureBox btnExit;
        private DataGridView dgvList;
        private Label lblDogruCevap;
        private Label lblSure;
        private Button btnSonraki;
        private TextBox txtD;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private RadioButton rdbD;
        private RadioButton rdbC;
        private RadioButton rdbB;
        private RadioButton rdbA;
        private RichTextBox rtbSoru;
        private PictureBox pbResim;
        private System.Windows.Forms.Timer tmrKronometre;
        private Label lblKalanDakika;
        private PictureBox pictureBox1;
        private ImageList imgListInterface;
        private Button btnBasla;
        private Panel pnlA;
        private Panel pnlB;
        private Panel pnlC;
        private Panel pnlD;
    }
}