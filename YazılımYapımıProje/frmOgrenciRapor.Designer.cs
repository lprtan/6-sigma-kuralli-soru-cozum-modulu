namespace YazılımYapımıProje
{
    partial class frmOgrenciRapor
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
            this.dvgOgrenciRapor = new System.Windows.Forms.DataGridView();
            this.btnYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOgrenciRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgOgrenciRapor
            // 
            this.dvgOgrenciRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgOgrenciRapor.Location = new System.Drawing.Point(133, 70);
            this.dvgOgrenciRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgOgrenciRapor.Name = "dvgOgrenciRapor";
            this.dvgOgrenciRapor.RowHeadersWidth = 51;
            this.dvgOgrenciRapor.RowTemplate.Height = 29;
            this.dvgOgrenciRapor.Size = new System.Drawing.Size(373, 150);
            this.dvgOgrenciRapor.TabIndex = 0;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(424, 235);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(82, 22);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // frmOgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 315);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dvgOgrenciRapor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOgrenciRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenciRapor";
            this.Load += new System.EventHandler(this.frmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgOgrenciRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dvgOgrenciRapor;
        private Button btnYazdir;
    }
}