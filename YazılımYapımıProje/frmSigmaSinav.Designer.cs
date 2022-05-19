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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
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
            this.btnBack.Location = new System.Drawing.Point(905, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 88;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.Location = new System.Drawing.Point(944, 16);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(32, 37);
            this.btnHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHomePage.TabIndex = 87;
            this.btnHomePage.TabStop = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(983, 16);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 37);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 86;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(602, 473);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 29;
            this.dgvList.Size = new System.Drawing.Size(24, 27);
            this.dgvList.TabIndex = 85;
            this.dgvList.Visible = false;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(531, 399);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(96, 20);
            this.lblDogruCevap.TabIndex = 84;
            this.lblDogruCevap.Text = "Doğru Cevap";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(642, 366);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(49, 20);
            this.lblSure.TabIndex = 83;
            this.lblSure.Text = "Süre : ";
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.Orange;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonraki.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonraki.Location = new System.Drawing.Point(531, 448);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(64, 52);
            this.btnSonraki.TabIndex = 82;
            this.btnSonraki.Text = ">";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.LightYellow;
            this.txtD.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtD.Location = new System.Drawing.Point(266, 448);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(187, 53);
            this.txtD.TabIndex = 81;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.LightYellow;
            this.txtC.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtC.Location = new System.Drawing.Point(14, 448);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(187, 53);
            this.txtC.TabIndex = 80;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.LightYellow;
            this.txtB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(266, 364);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(187, 53);
            this.txtB.TabIndex = 79;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.LightYellow;
            this.txtA.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(14, 364);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(187, 53);
            this.txtA.TabIndex = 78;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbD.Location = new System.Drawing.Point(459, 464);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(43, 25);
            this.rdbD.TabIndex = 77;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbC.Location = new System.Drawing.Point(208, 464);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(41, 25);
            this.rdbC.TabIndex = 76;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbB.Location = new System.Drawing.Point(461, 377);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(42, 25);
            this.rdbB.TabIndex = 75;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbA.Location = new System.Drawing.Point(208, 377);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(42, 25);
            this.rdbA.TabIndex = 74;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rtbSoru
            // 
            this.rtbSoru.BackColor = System.Drawing.Color.LightYellow;
            this.rtbSoru.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbSoru.Location = new System.Drawing.Point(386, 60);
            this.rtbSoru.Name = "rtbSoru";
            this.rtbSoru.Size = new System.Drawing.Size(628, 292);
            this.rtbSoru.TabIndex = 73;
            this.rtbSoru.Text = "Soru:  ";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(14, 60);
            this.pbResim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(366, 293);
            this.pbResim.TabIndex = 72;
            this.pbResim.TabStop = false;
            // 
            // tmrKronometre
            // 
            this.tmrKronometre.Interval = 60000;
            this.tmrKronometre.Tick += new System.EventHandler(this.tmrKronometre_Tick);
            // 
            // lblKalanDakika
            // 
            this.lblKalanDakika.AutoSize = true;
            this.lblKalanDakika.Location = new System.Drawing.Point(532, 366);
            this.lblKalanDakika.Name = "lblKalanDakika";
            this.lblKalanDakika.Size = new System.Drawing.Size(102, 20);
            this.lblKalanDakika.TabIndex = 89;
            this.lblKalanDakika.Text = "Kalan Dakika :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 90;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSigmaSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1029, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKalanDakika);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvList);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSigmaSinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSigmaSınav";
            this.Load += new System.EventHandler(this.frmSigmaSınav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
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
        private Button button1;
    }
}