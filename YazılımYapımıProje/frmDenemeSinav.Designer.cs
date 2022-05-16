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
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnGirisSayfası = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDogruCevap = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnSinavBitir = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.rtbSoru = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRapor = new System.Windows.Forms.Button();
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
            this.tmrKronometre.Interval = 1000;
            this.tmrKronometre.Tick += new System.EventHandler(this.tmrKronometre_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 509);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1001, 31);
            this.progressBar1.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(733, 473);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(30, 29);
            this.dataGridView1.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Süre: ";
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
            this.btnBack.TabIndex = 58;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnExit.TabIndex = 57;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGirisSayfası
            // 
            this.btnGirisSayfası.BackColor = System.Drawing.Color.OldLace;
            this.btnGirisSayfası.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisSayfası.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisSayfası.Image")));
            this.btnGirisSayfası.Location = new System.Drawing.Point(944, 16);
            this.btnGirisSayfası.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGirisSayfası.Name = "btnGirisSayfası";
            this.btnGirisSayfası.Size = new System.Drawing.Size(32, 37);
            this.btnGirisSayfası.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGirisSayfası.TabIndex = 56;
            this.btnGirisSayfası.TabStop = false;
            this.btnGirisSayfası.Click += new System.EventHandler(this.btnGirisSayfası_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(862, 369);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // lblDogruCevap
            // 
            this.lblDogruCevap.AutoSize = true;
            this.lblDogruCevap.Location = new System.Drawing.Point(586, 364);
            this.lblDogruCevap.Name = "lblDogruCevap";
            this.lblDogruCevap.Size = new System.Drawing.Size(103, 20);
            this.lblDogruCevap.TabIndex = 54;
            this.lblDogruCevap.Text = "Doğru Cevap :";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(531, 364);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(49, 20);
            this.lblSure.TabIndex = 53;
            this.lblSure.Text = "Süre : ";
            this.lblSure.TextChanged += new System.EventHandler(this.lblSure_TextChanged);
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.LightYellow;
            this.txtD.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtD.Location = new System.Drawing.Point(266, 448);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(187, 53);
            this.txtD.TabIndex = 52;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.LightYellow;
            this.txtC.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtC.Location = new System.Drawing.Point(14, 448);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(187, 53);
            this.txtC.TabIndex = 51;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.LightYellow;
            this.txtB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(266, 364);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(187, 53);
            this.txtB.TabIndex = 50;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.LightYellow;
            this.txtA.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(14, 364);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(187, 53);
            this.txtA.TabIndex = 49;
            // 
            // btnSinavBitir
            // 
            this.btnSinavBitir.BackColor = System.Drawing.Color.Orange;
            this.btnSinavBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavBitir.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinavBitir.Location = new System.Drawing.Point(531, 473);
            this.btnSinavBitir.Name = "btnSinavBitir";
            this.btnSinavBitir.Size = new System.Drawing.Size(194, 29);
            this.btnSinavBitir.TabIndex = 48;
            this.btnSinavBitir.Text = "Bitir";
            this.btnSinavBitir.UseVisualStyleBackColor = false;
            this.btnSinavBitir.Click += new System.EventHandler(this.btnSinavBitir_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.Orange;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonraki.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSonraki.Location = new System.Drawing.Point(632, 439);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(94, 29);
            this.btnSonraki.TabIndex = 47;
            this.btnSonraki.Text = ">";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.BackColor = System.Drawing.Color.LightYellow;
            this.rdbD.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbD.Location = new System.Drawing.Point(459, 463);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(43, 25);
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
            this.rdbC.Location = new System.Drawing.Point(208, 463);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(41, 25);
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
            this.rdbB.Location = new System.Drawing.Point(462, 377);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(42, 25);
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
            this.rdbA.Location = new System.Drawing.Point(208, 377);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(42, 25);
            this.rdbA.TabIndex = 43;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = false;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(14, 60);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(366, 293);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 42;
            this.pbResim.TabStop = false;
            // 
            // rtbSoru
            // 
            this.rtbSoru.BackColor = System.Drawing.Color.LightYellow;
            this.rtbSoru.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbSoru.Location = new System.Drawing.Point(386, 60);
            this.rtbSoru.Name = "rtbSoru";
            this.rtbSoru.Size = new System.Drawing.Size(628, 292);
            this.rtbSoru.TabIndex = 41;
            this.rtbSoru.Text = "Soru:  ";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1021, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(196, 293);
            this.listView1.TabIndex = 62;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(531, 439);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(94, 29);
            this.btnRapor.TabIndex = 63;
            this.btnRapor.Text = "Rapor Al";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // frmDenemeSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1252, 547);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Label label3;
        private PictureBox btnBack;
        private PictureBox btnExit;
        private PictureBox btnGirisSayfası;
        private PictureBox pictureBox1;
        private Label lblDogruCevap;
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
        private ListView listView1;
        private Button btnRapor;
    }
}