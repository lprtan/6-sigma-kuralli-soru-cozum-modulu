namespace YazılımYapımıProje
{
    partial class frmSoruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoruEkle));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnGirisSayfası = new System.Windows.Forms.PictureBox();
            this.pbSoruEkleIcon = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnResim = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.txtCevap4 = new System.Windows.Forms.TextBox();
            this.txtCevap3 = new System.Windows.Forms.TextBox();
            this.txtCevap2 = new System.Windows.Forms.TextBox();
            this.txtCevap1 = new System.Windows.Forms.TextBox();
            this.pictureSoru = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGirisSayfası)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoruEkleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // pbSoruEkleIcon
            // 
            this.pbSoruEkleIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbSoruEkleIcon.Image")));
            this.pbSoruEkleIcon.Location = new System.Drawing.Point(754, 296);
            this.pbSoruEkleIcon.Name = "pbSoruEkleIcon";
            this.pbSoruEkleIcon.Size = new System.Drawing.Size(100, 100);
            this.pbSoruEkleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSoruEkleIcon.TabIndex = 55;
            this.pbSoruEkleIcon.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(10, 16);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 15);
            this.lblPath.TabIndex = 54;
            this.lblPath.Visible = false;
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.Color.Orange;
            this.btnResim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResim.Location = new System.Drawing.Point(631, 16);
            this.btnResim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(31, 22);
            this.btnResim.TabIndex = 53;
            this.btnResim.Text = "...";
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmbUnit.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Ünite1",
            "Ünite2",
            "Ünite3"});
            this.cmbUnit.Location = new System.Drawing.Point(741, 189);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(133, 23);
            this.cmbUnit.TabIndex = 52;
            // 
            // cmbbolum
            // 
            this.cmbbolum.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmbbolum.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Items.AddRange(new object[] {
            "Bölüm1",
            "Bölüm2",
            "Bölüm3"});
            this.cmbbolum.Location = new System.Drawing.Point(741, 162);
            this.cmbbolum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(133, 23);
            this.cmbbolum.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(684, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Ünite :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(677, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Bölüm :";
            // 
            // txtSoru
            // 
            this.txtSoru.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoru.Location = new System.Drawing.Point(12, 309);
            this.txtSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(659, 87);
            this.txtSoru.TabIndex = 48;
            this.txtSoru.Text = "Soru :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Orange;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(741, 216);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 28);
            this.btnEkle.TabIndex = 47;
            this.btnEkle.Text = "Soru Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.BackColor = System.Drawing.Color.LemonChiffon;
            this.rdbD.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbD.Location = new System.Drawing.Point(702, 136);
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
            this.rdbC.BackColor = System.Drawing.Color.LemonChiffon;
            this.rdbC.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbC.Location = new System.Drawing.Point(702, 109);
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
            this.rdbB.BackColor = System.Drawing.Color.LemonChiffon;
            this.rdbB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbB.Location = new System.Drawing.Point(702, 82);
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
            this.rdbA.BackColor = System.Drawing.Color.LemonChiffon;
            this.rdbA.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbA.Location = new System.Drawing.Point(702, 56);
            this.rdbA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(34, 19);
            this.rdbA.TabIndex = 43;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = false;
            // 
            // txtCevap4
            // 
            this.txtCevap4.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCevap4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCevap4.Location = new System.Drawing.Point(741, 135);
            this.txtCevap4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCevap4.Name = "txtCevap4";
            this.txtCevap4.Size = new System.Drawing.Size(133, 23);
            this.txtCevap4.TabIndex = 42;
            // 
            // txtCevap3
            // 
            this.txtCevap3.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCevap3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCevap3.Location = new System.Drawing.Point(741, 108);
            this.txtCevap3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCevap3.Name = "txtCevap3";
            this.txtCevap3.Size = new System.Drawing.Size(133, 23);
            this.txtCevap3.TabIndex = 41;
            // 
            // txtCevap2
            // 
            this.txtCevap2.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCevap2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCevap2.Location = new System.Drawing.Point(741, 81);
            this.txtCevap2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCevap2.Name = "txtCevap2";
            this.txtCevap2.Size = new System.Drawing.Size(133, 23);
            this.txtCevap2.TabIndex = 40;
            // 
            // txtCevap1
            // 
            this.txtCevap1.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCevap1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCevap1.Location = new System.Drawing.Point(741, 54);
            this.txtCevap1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCevap1.Name = "txtCevap1";
            this.txtCevap1.Size = new System.Drawing.Size(133, 23);
            this.txtCevap1.TabIndex = 39;
            // 
            // pictureSoru
            // 
            this.pictureSoru.Location = new System.Drawing.Point(12, 11);
            this.pictureSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSoru.Name = "pictureSoru";
            this.pictureSoru.Size = new System.Drawing.Size(659, 294);
            this.pictureSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSoru.TabIndex = 38;
            this.pictureSoru.TabStop = false;
            // 
            // frmSoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(900, 410);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGirisSayfası);
            this.Controls.Add(this.pbSoruEkleIcon);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.txtCevap4);
            this.Controls.Add(this.txtCevap3);
            this.Controls.Add(this.txtCevap2);
            this.Controls.Add(this.txtCevap1);
            this.Controls.Add(this.pictureSoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSoruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSoruEkle";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGirisSayfası)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoruEkleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox btnExit;
        private PictureBox btnGirisSayfası;
        private PictureBox pbSoruEkleIcon;
        private Label lblPath;
        private Button btnResim;
        private ComboBox cmbUnit;
        private ComboBox cmbbolum;
        private Label label2;
        private Label label1;
        private TextBox txtSoru;
        private Button btnEkle;
        private RadioButton rdbD;
        private RadioButton rdbC;
        private RadioButton rdbB;
        private RadioButton rdbA;
        private TextBox txtCevap4;
        private TextBox txtCevap3;
        private TextBox txtCevap2;
        private TextBox txtCevap1;
        private PictureBox pictureSoru;
        private OpenFileDialog openFileDialog1;
    }
}