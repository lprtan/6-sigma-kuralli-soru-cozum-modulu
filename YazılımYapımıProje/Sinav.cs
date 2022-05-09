using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YazılımYapımıProje
{
    public partial class Sinav : Form
    {
        public Sinav()
        {
            InitializeComponent();
        }
        public int ID { get; set; }
        public int UserID { get; set; }
        public int CAC { get; set; }

        DataBase db = new DataBase();
        public void Gunncelle()
        {
            SqlCommand CACGuncelle = new SqlCommand("update Sinav set CorrectAnswerCount=@p1 where QuestionID='" + ID + "' AND UserID= '" + UserID + "'", db.baglanti);
            CACGuncelle.Parameters.AddWithValue("@p1", (CAC + 1));
            CACGuncelle.ExecuteNonQuery();
        }
        public void UserIDCek()
        {
            db.baglanti.Open();
            SqlCommand UserIDAl = new SqlCommand("select * from Users where UserName='" + FrmGiris.AlinanKullaniciAdi.ToString() + "'", db.baglanti);
            UserIDAl.Connection = db.baglanti;
            SqlDataReader kontrol = UserIDAl.ExecuteReader();
            if (kontrol.Read())
            {
                UserID = Convert.ToInt16(kontrol["UserID"]);
            }
            else
            {
                MessageBox.Show("Veritabanı hatası!!!");
            }
            kontrol.Close();
            db.baglanti.Close();
        }
        public void SoruKontrol()
        {

            SqlCommand sinavekle = new SqlCommand("insert into Sinav " +
        "(QuestionID,UserID,CorrectAnswer,CorrectAnswerCount) " +
        "values (@c1,@c2,@c3,@c4)", db.baglanti);

            sinavekle.Parameters.AddWithValue("@c1", ID);
            sinavekle.Parameters.AddWithValue("@c2", UserID);

            if (radioButton1.Checked == true)
            {
                if (radioButton1.Text == label2.Text)
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1);
                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0);
                    sinavekle.Parameters.AddWithValue("@c4", 0);
                    sinavekle.ExecuteNonQuery();
                }

            }
            else if (radioButton2.Checked == true)
            {
                if (radioButton2.Text == label2.Text)
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1);
                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0);
                    sinavekle.Parameters.AddWithValue("@c4", 0);
                    sinavekle.ExecuteNonQuery();
                    sinavekle.ExecuteNonQuery();

                }
            }
            else if (radioButton3.Checked == true)
            {
                if (radioButton3.Text == label2.Text)
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1);
                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0);
                    sinavekle.Parameters.AddWithValue("@c4", 0);
                    sinavekle.ExecuteNonQuery();
                }
            }
            else if (radioButton4.Checked == true)
            {
                if (radioButton4.Text == label2.Text)
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1);


                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0);
                    sinavekle.Parameters.AddWithValue("@c4", 0);
                    sinavekle.ExecuteNonQuery();
                }
            }
            else
            {
                sinavekle.Parameters.AddWithValue("@c3", 0);
                sinavekle.Parameters.AddWithValue("@c4", 0);
                sinavekle.ExecuteNonQuery();
            }

        }

        public void CorrectAnswerCount()
        {
            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Sinav where QuestionID='" + ID + "' AND UserID= '" + UserID + "' ", db.baglanti);
            cmd.Connection = db.baglanti;
            SqlDataReader kontrol = cmd.ExecuteReader();


            if (kontrol.Read())
            {
                CAC = Convert.ToInt32(kontrol["CorrectAnswerCount"]);
                kontrol.Close();
                Gunncelle();

            }
            else
            {
                kontrol.Close();
                SoruKontrol();
            }
            db.baglanti.Close();

        }
        public void SoruCek()
        {
            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 QuestionID,QuestionText,PicturePath,RightAnswer,a,b,c,d,QuestionID FROM Question where SoruOnay='true' ORDER BY NEWID()", db.baglanti);

            cmd.Connection = db.baglanti;
            SqlDataReader kontrol = cmd.ExecuteReader();

            if (kontrol.Read())
            {
                rtbSoru.Text = kontrol["QuestionText"].ToString();
                pbResim.ImageLocation = kontrol["PicturePath"].ToString();
                txtA.Text = kontrol["a"].ToString();
                txtB.Text = kontrol["b"].ToString();
                txtC.Text = kontrol["c"].ToString();
                txtD.Text = kontrol["d"].ToString();
                label2.Text = kontrol["RightAnswer"].ToString();
                ID = Convert.ToInt32(kontrol["QuestionID"]);
                label3.Text = ID.ToString();
            }
            else
            {
                MessageBox.Show("veritabanı hatası");
            }
            db.baglanti.Close();
        }
        private void Sinav_Load_1(object sender, EventArgs e)
        {
            UserIDCek();
            SoruCek();

        }
        private void button2_Click(object sender, EventArgs e)
        {

            CorrectAnswerCount();
            SoruCek();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}