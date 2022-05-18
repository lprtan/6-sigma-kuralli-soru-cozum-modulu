using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace YazılımYapımıProje
{
    public partial class frmSoruEkle : Form
    {
        public frmSoruEkle()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase(); //DataBase sınıfından nesne oLuşturulur

        private void btnEkle_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlCommand Soruekle = new SqlCommand("insert into Question " +
            "(QuestionText,SectionID,UnitID,RightAnswer,a,b,c,d,PicturePath) " +
            "values (@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8,@c9)", db.baglanti); //Veritabanına sorunun verileri gönderilir

            //şıkkın text verisi veritabanına gönderilir
            Soruekle.Parameters.AddWithValue("@c5", txtCevap1.Text); 
            Soruekle.Parameters.AddWithValue("@c6", txtCevap2.Text); 
            Soruekle.Parameters.AddWithValue("@c7", txtCevap3.Text);
            Soruekle.Parameters.AddWithValue("@c8", txtCevap4.Text);

            if (rdbA.Checked == true)
            {
                Soruekle.Parameters.AddWithValue("@c4", rdbA.Text); //A şıkkı doğru cevap ise veritabnına gönderilir
            }
            else if (rdbB.Checked == true)
            {
                Soruekle.Parameters.AddWithValue("@c4", rdbB.Text); //B şıkkı doğru cevap ise veritabnına gönderilir
            }
            else if (rdbC.Checked == true)
            {
                Soruekle.Parameters.AddWithValue("@c4", rdbC.Text); //C şıkkı doğru cevap ise veritabnına gönderilir
            }
            else if (rdbD.Checked == true)
            {
                Soruekle.Parameters.AddWithValue("@c4", rdbD.Text); //D şıkkı doğru cevap ise veritabnına gönderilir
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız!!!");

            }

            Soruekle.Parameters.AddWithValue("@c1", txtSoru.Text); //Soru text veritabanına gönderilir
            Soruekle.Parameters.AddWithValue("@c2", (cmbbolum.SelectedIndex) + 1); //Ders adı veritabanına gönderilir
            Soruekle.Parameters.AddWithValue("@c3", (cmbUnit.SelectedIndex) + 1);  //Konu adı veritabanına gönderilir

            if (pictureSoru.Image != null) //Sorunun fotoğrafının olup olmadığını kontrol eder
            {
                Soruekle.Parameters.AddWithValue("@c9", lblPath.Text); //Sorunun resmi veritabanına gönderilir

            }

            Soruekle.ExecuteNonQuery();
            db.baglanti.Close();

            MessageBox.Show("Kaydınız Başarıyla alınmıştır");
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            //Fotoğrafın dosya yolunu getirir
            openFileDialog1.ShowDialog(this);
            pictureSoru.ImageLocation = openFileDialog1.FileName;
            lblPath.Text = openFileDialog1.FileName;
        }

        private void btnGirisSayfası_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris(); //Girş sayfasyına yönlendirilir
            frmGiris.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamyı kapatır
        }
    }
}
