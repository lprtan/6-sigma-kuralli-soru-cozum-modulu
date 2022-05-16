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
    public partial class frmSinav : Form
    {
        public frmSinav()
        {
            InitializeComponent();
        }
        public int ID { get; set; }
        public int UserID { get; set; }
        public int CAC { get; set; }
        public int nGun { get; set; }
        public int nHafta { get; set; }
        public int nAy { get; set; }
        public DateTime BugununTarihi { get; set; }
        public DateTime SorununCozulduguTarih { get; set; }

        DataBase db = new DataBase();
        private string x = null!;
        int buttonIndex = 0;
        int sayac=1;
        int DogruSayisi;
        DataSet ds = new DataSet();

        public void Ayarlar()
        {
            db.baglanti.Open();
            SqlCommand Ayarlar = new SqlCommand("select Gun,Hafta,Ay from Settings where UserID='" + UserID + "'", db.baglanti);
            Ayarlar.Connection = db.baglanti;
            SqlDataReader Ayarkontrol = Ayarlar.ExecuteReader();

            if (Ayarkontrol.Read())
            {
                 nGun = Convert.ToInt32(Ayarkontrol["Gun"]);
                 nHafta = Convert.ToInt32(Ayarkontrol["Hafta"]);
                 nAy = Convert.ToInt32(Ayarkontrol["AY"]);
            }
            db.baglanti.Close();
        }
        public void SoruYazdir()
        {
            //db.baglanti.Open();
            SqlCommand DogruSoruCek = new SqlCommand("SELECT Question.QuestionID, RightAnswer, QuestionText, SectionID, UnitID, PicturePath, a, b, c, d FROM"+
            " Question INNER JOIN Sinav ON Question.QuestionID = Sinav.QuestionID AND UserID='" + UserID + "'  where CorrectAnswerCount='" + DogruSayisi + "'", db.baglanti);

            DogruSoruCek.Connection = db.baglanti;
            SqlDataReader kontrol3 = DogruSoruCek.ExecuteReader();

            if (kontrol3.Read())
            {
                rtbSoru.Text = kontrol3["QuestionText"].ToString();
                pbResim.ImageLocation = kontrol3["PicturePath"].ToString();
                txtA.Text = kontrol3["a"].ToString();
                txtB.Text = kontrol3["b"].ToString();
                txtC.Text = kontrol3["c"].ToString();
                txtD.Text = kontrol3["d"].ToString();
                label2.Text = kontrol3["RightAnswer"].ToString();
                ID = Convert.ToInt32(kontrol3["QuestionID"]);
                label3.Text = ID.ToString();
                kontrol3.Close();
            }
            else
            {
                button2.Enabled=true;
                MessageBox.Show("Sınav bitti ");
            }
           db.baglanti.Close();
        }
        public void DogruSoruCek()
        {

            Ayarlar();

            db.baglanti.Open();
            SqlCommand CozumTarihi = new SqlCommand("select * from Sinav where UserID='" + UserID + "' and QuestionID='"+ID+"'", db.baglanti);
            CozumTarihi.Connection = db.baglanti;
            SqlDataReader Tarihkontrol = CozumTarihi.ExecuteReader();
            if (Tarihkontrol.Read())
            {
                SorununCozulduguTarih = Convert.ToDateTime(Tarihkontrol["CozumTarihi"]);
            }
            BugununTarihi =DateTime.Now;
           

            TimeSpan GunSayisi = BugununTarihi - SorununCozulduguTarih;
           

            if (Math.Abs(GunSayisi.Days)>=nGun && Math.Abs(GunSayisi.Days) <7)
            {
                DogruSayisi = 1;
                Tarihkontrol.Close();
                SoruYazdir();  
            }
            else if (Math.Abs(GunSayisi.Days) >= nHafta && Math.Abs(GunSayisi.Days) < 30)
            {              
                DogruSayisi = 2;
                Tarihkontrol.Close();
                SoruYazdir();
            }
            else if (Math.Abs(GunSayisi.Days) >= nAy && Math.Abs(GunSayisi.Days) < 90)
            {
                DogruSayisi = 3;
                Tarihkontrol.Close();
                SoruYazdir();
            }
            else if (Math.Abs(GunSayisi.Days) >= 90 && Math.Abs(GunSayisi.Days) < 180)
            {
                DogruSayisi = 4;
                Tarihkontrol.Close();
                SoruYazdir();
            }
            else if (Math.Abs(GunSayisi.Days) >= 180 && Math.Abs(GunSayisi.Days) < 365)
            {
                DogruSayisi = 5;
                Tarihkontrol.Close();
                SoruYazdir();
            }
            else if (Math.Abs(GunSayisi.Days) >= 365)
            {
                DogruSayisi = 6;
                Tarihkontrol.Close();
                SoruYazdir();
            }
            else
            {
                //db.baglanti.Close();
                MessageBox.Show("CAC hatası");
            }
            db.baglanti.Close();
        }
        public void SiraylaGetir()
        {

            if (buttonIndex >= dataGridView1.Rows.Count || dataGridView1.Rows[buttonIndex].IsNewRow)
                buttonIndex = 0;

            if (dataGridView1.AllowUserToAddRows == true)
            {
                 if (dataGridView1.RowCount > 1)
                {
                    x = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();
                }
                else if(dataGridView1.RowCount >0 || dataGridView1.RowCount <1)
                {
                 DogruSoruCek();
                }
                else
                textBox1.Text = "";
            }
            buttonIndex++;
        }
        public  void YanlısSoruGuncelle()
        {
           SqlCommand YanlisGuncelle = new SqlCommand("Update Sinav set CorrectAnswer=@p1, CorrectAnswerCount=@p2 where QuestionID='" + ID + "' AND UserID= '" + UserID + "'", db.baglanti);
            YanlisGuncelle.Parameters.AddWithValue("@p1", 0);
            YanlisGuncelle.Parameters.AddWithValue("@p2", 0);
            YanlisGuncelle.ExecuteNonQuery();
        }
        public void Guncelle()
        {
            SqlCommand CACGuncelle = new SqlCommand("update Sinav set CorrectAnswerCount=@p1 where QuestionID='" + ID + "' AND UserID= '" + UserID + "'", db.baglanti);
            CACGuncelle.Parameters.AddWithValue("@p1", (CAC + 1));
            CACGuncelle.ExecuteNonQuery();
        }
        public int UserIDCek()
        {
            db.baglanti.Open();
            SqlCommand UserIDAl = new SqlCommand("select * from Users where UserName='" + frmGiris.AlinanKullaniciAdi.ToString() + "'", db.baglanti);
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
            return UserID;
        }
        public void SoruKontrol()
        {
            SqlCommand sinavekle = new SqlCommand("insert into Sinav " +
        "(QuestionID,UserID,CorrectAnswer,CozumTarihi) " +
        "values (@c1,@c2,@c3,@c4)", db.baglanti);

            sinavekle.Parameters.AddWithValue("@c1", ID);
            sinavekle.Parameters.AddWithValue("@c2", UserID);
            sinavekle.Parameters.AddWithValue("@c4", DateTime.Now);

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
                    sinavekle.ExecuteNonQuery();
                }
            }
            else
            {
                sinavekle.Parameters.AddWithValue("@c3", 0);
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

                if (radioButton1.Checked == true)
                {
                    if (radioButton1.Text == label2.Text)
                    {
                        kontrol.Close();
                        Guncelle();
                    }
                    else
                    {
                        kontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (radioButton2.Text == label2.Text)
                    {
                        kontrol.Close();
                        Guncelle();
                    }
                    else
                    {
                        kontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    if (radioButton3.Text == label2.Text)
                    {
                        kontrol.Close();
                        Guncelle();
                    }
                    else
                    {
                        kontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else if (radioButton4.Checked == true)
                {
                    if (radioButton4.Text == label2.Text)
                    {
                        kontrol.Close();
                        Guncelle();
                    }
                    else
                    {
                        kontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else
                {
                    kontrol.Close();
                    YanlısSoruGuncelle();
                }
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
            string veriler = "SELECT QuestionID,QuestionText,PicturePath,RightAnswer,a,b,c,d,QuestionID FROM Question where QuestionID='" + x + "'";
            SqlCommand cmd = new SqlCommand(veriler, db.baglanti);

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
        public void verileriGoster(string veriler)
        {

            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            dz.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Sinav_Load_1(object sender, EventArgs e)
        {
            UserIDCek();
            db.baglanti.Open();
            string veriler = "Select top 10 QuestionID from Question order by NEWID()";
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler);
            SiraylaGetir();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CorrectAnswerCount();
            SiraylaGetir();
            sayac++;
            if (dataGridView1.Rows.Count == sayac)
            {
                button2.Text = "Sınavı Bitir";
                ds.Tables[0].Rows.Clear();
                SiraylaGetir();
                return;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmOgrenci ogrnci = new frmOgrenci();
            ogrnci.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // CorrectAnswerCount();
          //  DogruSoruCek();
        }
    }
}