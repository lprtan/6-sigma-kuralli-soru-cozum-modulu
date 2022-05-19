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
    public partial class frmSigmaSinav : Form
    {
        public frmSigmaSinav()
        {
            InitializeComponent();
        }
        public int QuestionID { get; set; }
        public int UserID { get; set; }
        public int CAC { get; set; }
        public int nGun { get; set; }
        public int nHafta { get; set; }
        public int nAy { get; set; }
        public DateTime BugununTarihi { get; set; }
        public DateTime SorununCozulduguTarih { get; set; }

        DataBase db = new DataBase();
        DataSet ds = new DataSet();

        private string x = null!;
        int buttonIndex = 0;
        int sayac = 1;
        int zamansayac = 10;
        int DogruSayisi;
        int timeInterval = 60000;
        int btnClickSayac = 10;

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
                nAy = Convert.ToInt32(Ayarkontrol["Ay"]);
            }
            db.baglanti.Close();
        }
        public void SoruYazdir()
        {
            SqlCommand DogruSoruCek = new SqlCommand("SELECT Question.QuestionID, RightAnswer, QuestionText, SectionID, UnitID, PicturePath, a, b, c, d FROM" +
            " Question INNER JOIN Sinav ON Question.QuestionID = Sinav.QuestionID AND UserID='" + UserID + "'  where CorrectAnswerCount='" + DogruSayisi + "'", db.baglanti);

            DogruSoruCek.Connection = db.baglanti;
            SqlDataReader DogruSoruCekKontrol = DogruSoruCek.ExecuteReader();

            if (DogruSoruCekKontrol.Read())
            {
                rtbSoru.Text = DogruSoruCekKontrol["QuestionText"].ToString();
                pbResim.ImageLocation = DogruSoruCekKontrol["PicturePath"].ToString();
                txtA.Text = DogruSoruCekKontrol["a"].ToString();
                txtB.Text = DogruSoruCekKontrol["b"].ToString();
                txtC.Text = DogruSoruCekKontrol["c"].ToString();
                txtD.Text = DogruSoruCekKontrol["d"].ToString();
                lblDogruCevap.Text = DogruSoruCekKontrol["RightAnswer"].ToString();
                QuestionID = Convert.ToInt32(DogruSoruCekKontrol["QuestionID"]);
                DogruSoruCekKontrol.Close();
            }
            else
            {
                MessageBox.Show("Sınav bitmiştir \n Öğrenci sayfasına yönlendiriliyorsunuz....");
                frmOgrenci frmOgrenci = new frmOgrenci();
                frmOgrenci.Show();
                this.Close();
            }
            db.baglanti.Close();
        }
        public void DogruSoruCek()
        {
            Ayarlar();

            db.baglanti.Open();
            SqlCommand CozumTarihi = new SqlCommand("select * from Sinav where UserID='" + UserID + "' and QuestionID='" + QuestionID + "'", db.baglanti);
            CozumTarihi.Connection = db.baglanti;
            SqlDataReader Tarihkontrol = CozumTarihi.ExecuteReader();
            if (Tarihkontrol.Read())
            {
                SorununCozulduguTarih = Convert.ToDateTime(Tarihkontrol["CozumTarihi"]);
            }
            BugununTarihi = DateTime.Now;

            TimeSpan GunSayisi = BugununTarihi - SorununCozulduguTarih;

            if (Math.Abs(GunSayisi.Days) >= nGun && Math.Abs(GunSayisi.Days) < 7)
            {
                DogruSayisi = 1;
                Tarihkontrol.Close();
                SoruYazdir();
                tmrKronometre.Interval = timeInterval + 6000;
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= nHafta && Math.Abs(GunSayisi.Days) < 30)
            {
                DogruSayisi = 2;
                Tarihkontrol.Close();
                SoruYazdir();
                tmrKronometre.Interval = timeInterval + 6000;
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= nAy && Math.Abs(GunSayisi.Days) < 90)
            {
                DogruSayisi = 3;
                Tarihkontrol.Close();
                SoruYazdir();
                tmrKronometre.Interval = timeInterval + 6000;
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= 90 && Math.Abs(GunSayisi.Days) < 180)
            {
                DogruSayisi = 4;
                Tarihkontrol.Close();
                SoruYazdir();
                tmrKronometre.Interval = timeInterval + 6000;
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= 180 && Math.Abs(GunSayisi.Days) < 365)
            {
                DogruSayisi = 5;
                Tarihkontrol.Close();
                SoruYazdir();
                tmrKronometre.Interval = timeInterval + 6000;
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= 365)
            {
                DogruSayisi = 6;
                Tarihkontrol.Close();
                SoruYazdir();
                tmrKronometre.Interval = timeInterval + 6000;
                zamansayac += 1;
            }
            else
            {
                MessageBox.Show("Sınavınız Bitmiştir." + "\n" + " Öğrenci Ekranına Yönlendiriliyorsunuz...");
                frmOgrenci frmOgrenci = new frmOgrenci();
                frmOgrenci.Show();
                this.Hide();
            }
            db.baglanti.Close();
        }
        public void SiraylaGetir()
        {
            if (buttonIndex >= dgvList.Rows.Count || dgvList.Rows[buttonIndex].IsNewRow)
                buttonIndex = 0;

            if (dgvList.AllowUserToAddRows == true)
            {
                if (dgvList.RowCount > 1)
                {
                    x = dgvList.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();
                }
                else if (dgvList.RowCount > 0 || dgvList.RowCount < 1)
                {
                    DogruSoruCek();
                    return;
                }
            }
            buttonIndex++;
        }
        public void YanlısSoruGuncelle()
        {
            SqlCommand YanlisGuncelle = new SqlCommand("Update Sinav set CorrectAnswer=@p1, CorrectAnswerCount=@p2 where QuestionID='" + QuestionID + "' AND UserID= '" + UserID + "'", db.baglanti);
            YanlisGuncelle.Parameters.AddWithValue("@p1", 0);
            YanlisGuncelle.Parameters.AddWithValue("@p2", 0);
            YanlisGuncelle.ExecuteNonQuery();
        }
        public void DogruSoruGuncelle()
        {
            SqlCommand CACGuncelle = new SqlCommand("update Sinav set CorrectAnswerCount=@p1 where QuestionID='" + QuestionID + "' AND UserID= '" + UserID + "'", db.baglanti);
            CACGuncelle.Parameters.AddWithValue("@p1", (CAC + 1));
            CACGuncelle.ExecuteNonQuery();
        }
        public int UserIDCek()
        {
            db.baglanti.Open();
            SqlCommand UserIDAl = new SqlCommand("select * from Users where UserName='" + frmGiris.AlinanKullaniciAdi.ToString() + "'", db.baglanti);
            UserIDAl.Connection = db.baglanti;
            SqlDataReader UserIDKontrol = UserIDAl.ExecuteReader();
            if (UserIDKontrol.Read())
            {
                UserID = Convert.ToInt16(UserIDKontrol["UserID"]);
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }
            UserIDKontrol.Close();
            db.baglanti.Close();
            return UserID;
        }
        public void SoruKontrol()
        {
            SqlCommand sinavekle = new SqlCommand("insert into Sinav " +
        "(QuestionID,UserID,CorrectAnswer,CozumTarihi) " +
        "values (@c1,@c2,@c3,@c4)", db.baglanti);

            sinavekle.Parameters.AddWithValue("@c1", QuestionID);
            sinavekle.Parameters.AddWithValue("@c2", UserID);
            sinavekle.Parameters.AddWithValue("@c4", DateTime.Now);

            if (rdbA.Checked == true)
            {
                if (rdbA.Text == lblDogruCevap.Text)
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
            else if (rdbB.Checked == true)
            {
                if (rdbB.Text == lblDogruCevap.Text)
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
            else if (rdbC.Checked == true)
            {
                if (rdbC.Text == lblDogruCevap.Text)
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
            else if (rdbD.Checked == true)
            {
                if (rdbD.Text == lblDogruCevap.Text)
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
            SqlCommand DogruSoruSayisi = new SqlCommand("SELECT * from Sinav where QuestionID='" + QuestionID + "' AND UserID= '" + UserID + "' ", db.baglanti);
            DogruSoruSayisi.Connection = db.baglanti;
            SqlDataReader DogruSoruSayisiKontrol = DogruSoruSayisi.ExecuteReader();

            if (DogruSoruSayisiKontrol.Read())
            {
                CAC = Convert.ToInt32(DogruSoruSayisiKontrol["CorrectAnswerCount"]);

                if (rdbA.Checked == true)
                {
                    if (rdbA.Text == lblDogruCevap.Text)
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle();
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else if (rdbB.Checked == true)
                {
                    if (rdbB.Text == lblDogruCevap.Text)
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle();
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else if (rdbC.Checked == true)
                {
                    if (rdbC.Text == lblDogruCevap.Text)
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle();
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else if (rdbD.Checked == true)
                {
                    if (rdbD.Text == lblDogruCevap.Text)
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle();
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle();
                    }
                }
                else
                {
                    DogruSoruSayisiKontrol.Close();
                    YanlısSoruGuncelle();
                }
            }
            else
            {
                DogruSoruSayisiKontrol.Close();
                SoruKontrol();
            }
            db.baglanti.Close();
        }
        public void SoruCek()
        {
            db.baglanti.Open();
            string veriler = "SELECT QuestionID,QuestionText,PicturePath,RightAnswer,a,b,c,d,QuestionID FROM Question where QuestionID='" + x + "'";
            SqlCommand SoruCek = new SqlCommand(veriler, db.baglanti);
            SoruCek.Connection = db.baglanti;
            SqlDataReader SoruCekKontrol = SoruCek.ExecuteReader();

            if (SoruCekKontrol.Read())
            {
                rtbSoru.Text = SoruCekKontrol["QuestionText"].ToString();
                pbResim.ImageLocation = SoruCekKontrol["PicturePath"].ToString();
                txtA.Text = SoruCekKontrol["a"].ToString();
                txtB.Text = SoruCekKontrol["b"].ToString();
                txtC.Text = SoruCekKontrol["c"].ToString();
                txtD.Text = SoruCekKontrol["d"].ToString();
                lblDogruCevap.Text = SoruCekKontrol["RightAnswer"].ToString();
                QuestionID = Convert.ToInt32(SoruCekKontrol["QuestionID"]);
            }
            else
            {
                MessageBox.Show("Soru Bulunamadı!");
            }
            db.baglanti.Close();
        }
        public void verileriGoster(string veriler)
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            dz.Fill(ds);
            dgvList.DataSource = ds.Tables[0];
        }
        private void frmSigmaSınav_Load(object sender, EventArgs e)
        {
            UserIDCek();
            db.baglanti.Open();
            string veriler = "Select top 10 QuestionID from Question order by NEWID()";
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler);
            SiraylaGetir();
            lblSure.Text = "10";
            tmrKronometre.Start();
        }
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnClickSayac--;
            CorrectAnswerCount();
            SiraylaGetir();
            if (zamansayac==0)
            {
                MessageBox.Show("Süreniz Bitmiştir");
            }
            sayac++;
            if (dgvList.Rows.Count == sayac)
            {
                btnSonraki.Text = "Sınavı Bitir";
                ds.Tables[0].Rows.Clear();
                SiraylaGetir();
                return;
            }

            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOgrenci frmOgrenci = new frmOgrenci();
            frmOgrenci.Show();
            this.Hide();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            frmGiris ogrnci = new frmGiris();
            ogrnci.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            zamansayac--;
            lblSure.Text = zamansayac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (--btnClickSayac>0)
            {
                btnSonraki_Click(btnSonraki, new EventArgs());
            }
        }
    }
}
