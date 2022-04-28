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
    public partial class SoruEkle : Form
    {
        public SoruEkle()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void button1_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlCommand Soruekle = new SqlCommand("insert into Question " +
            "(QuestionText,SectionID,UnitID,RightAnswer,WrongAnswer1,WrongAnswer2,WrongAnswer3,PicturePath) " +
            "values (@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8)", db.baglanti);

            if (rdbA.Checked == true)
            {

                Soruekle.Parameters.AddWithValue("@c4", txtCevap1.Text);
                Soruekle.Parameters.AddWithValue("@c5", txtCevap2.Text);
                Soruekle.Parameters.AddWithValue("@c6", txtCevap3.Text);
                Soruekle.Parameters.AddWithValue("@c7", txtCevap4.Text);

            }
            else if (rdbB.Checked == true)
            {
                Soruekle.Parameters.AddWithValue("@c5", txtCevap1.Text);
                Soruekle.Parameters.AddWithValue("@c4", txtCevap2.Text);
                Soruekle.Parameters.AddWithValue("@c6", txtCevap3.Text);
                Soruekle.Parameters.AddWithValue("@c7", txtCevap4.Text);
                
            }
            else if (rdbC.Checked == true)
            {
                Soruekle.Parameters.AddWithValue("@c5", txtCevap1.Text);
                Soruekle.Parameters.AddWithValue("@c6", txtCevap2.Text);
                Soruekle.Parameters.AddWithValue("@c4", txtCevap3.Text);
                Soruekle.Parameters.AddWithValue("@c7", txtCevap4.Text);

            }
            else if (rdbD.Checked == true)
            {
                Soruekle.Parameters.AddWithValue("@c5", txtCevap1.Text);
                Soruekle.Parameters.AddWithValue("@c6", txtCevap2.Text);
                Soruekle.Parameters.AddWithValue("@c7", txtCevap3.Text);
                Soruekle.Parameters.AddWithValue("@c4", txtCevap4.Text);
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız!!!");
            
            }

            Soruekle.Parameters.AddWithValue("@c1", txtSoru.Text);
            Soruekle.Parameters.AddWithValue("@c2", (cmbbolum.SelectedIndex) + 1);
            Soruekle.Parameters.AddWithValue("@c3", (cmbUnit.SelectedIndex) + 1);

            if(pictureSoru.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");

            }
            else
            {
               Soruekle.Parameters.AddWithValue("@c8", lblPath.Text);
            }

            Soruekle.ExecuteNonQuery();
            db.baglanti.Close();

            MessageBox.Show("Kaydınız Başarıyla alınmıştır");
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            pictureSoru.ImageLocation = openFileDialog1.FileName;
            lblPath.Text = openFileDialog1.FileName;
        }
    }
}
