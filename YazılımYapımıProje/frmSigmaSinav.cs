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

        DataBase db = new DataBase(); //DataBase sınıfdan nesne oluşturulur
        DataSet ds = new DataSet();

        private string SoruNo = null!;
        int buttonIndex = 0;
        int sayac = 1;
        int zamansayac = 10;
        int DogruSayisi;
        int timeInterval = 60000;
        int btnClickSayac = 10;

        public void Ayarlar()
        {
            db.baglanti.Open();
            SqlCommand Ayarlar = new SqlCommand("select Gun,Hafta,Ay from Settings where UserID='" + UserID + "'", db.baglanti); //Veritabaındaki ayarlar verilerini getirir
            Ayarlar.Connection = db.baglanti;
            SqlDataReader Ayarkontrol = Ayarlar.ExecuteReader();

            if (Ayarkontrol.Read()) //Settings tablosunda veri olup olmadığını kontrol eder
            {
                nGun = Convert.ToInt32(Ayarkontrol["Gun"]); //Gün verisi atanır
                nHafta = Convert.ToInt32(Ayarkontrol["Hafta"]); //Hafta verisi atanır
                nAy = Convert.ToInt32(Ayarkontrol["Ay"]); //ay verisi atanır
            }
            db.baglanti.Close();
        }
        public void SoruYazdir() //veritabındaki soruyu çeken fonksiyondur
        {
            SqlCommand DogruSoruCek = new SqlCommand("SELECT Question.QuestionID, RightAnswer, QuestionText, SectionID, UnitID, PicturePath, a, b, c, d FROM" +
            " Question INNER JOIN Sinav ON Question.QuestionID = Sinav.QuestionID AND UserID='" + UserID + "'  where CorrectAnswerCount='" + DogruSayisi + "'", db.baglanti); //İstenilen koşulu sağlayan doğru sayısına göre veritabnından verileri çeker

            DogruSoruCek.Connection = db.baglanti;
            SqlDataReader DogruSoruCekKontrol = DogruSoruCek.ExecuteReader();

            if (DogruSoruCekKontrol.Read()) //Belirtielen tablolaların boş olup olmadığını kontrol eder
            {
                rtbSoru.Text = DogruSoruCekKontrol["QuestionText"].ToString(); //Soru metnini getirir
                pbResim.ImageLocation = DogruSoruCekKontrol["PicturePath"].ToString(); //Soru resminin dosya yolunu getirir
                txtA.Text = DogruSoruCekKontrol["a"].ToString(); //A şıkkının metnini getirir
                txtB.Text = DogruSoruCekKontrol["b"].ToString(); //B şıkkının metnini getirir
                txtC.Text = DogruSoruCekKontrol["c"].ToString(); //C şıkkının metnini getirir
                txtD.Text = DogruSoruCekKontrol["d"].ToString(); //D şıkkının metnini getirir
                lblDogruCevap.Text = DogruSoruCekKontrol["RightAnswer"].ToString(); //Doğru cevabı getirir
                QuestionID = Convert.ToInt32(DogruSoruCekKontrol["QuestionID"]); //Soru ID'sini getirir
                DogruSoruCekKontrol.Close();
            }
            else
            {
                MessageBox.Show("Sınav bitmiştir \n Öğrenci sayfasına yönlendiriliyorsunuz....");
                frmOgrenci frmOgrenci = new frmOgrenci(); //Öğrenci sayfasına yönlendirir
                frmOgrenci.Show();
                this.Close();
            }
            db.baglanti.Close();
        }
        public void DogruSoruCek() //Doğru özülen soruları öğrencicinin karşısına çıkaran fonksiyon
        {
            Ayarlar(); //Ayarlar fonksiyonu çağırılır

            db.baglanti.Open();
            SqlCommand CozumTarihi = new SqlCommand("select * from Sinav where UserID='" + UserID + "' and QuestionID='" + QuestionID + "'", db.baglanti); // Giriş yapan kullanıcı ve çözülen soruya göre veritbnından veri çekilir
            CozumTarihi.Connection = db.baglanti;
            SqlDataReader Tarihkontrol = CozumTarihi.ExecuteReader();
            if (Tarihkontrol.Read()) //Sinav tablosunun boş olup olmadığını kontrol eder
            {
                SorununCozulduguTarih = Convert.ToDateTime(Tarihkontrol["CozumTarihi"]); //Sorunun çözüldüğü tarihi getirir
            }
            BugununTarihi = DateTime.Now; // Bugünün tarih bilgisi alınır

            TimeSpan GunSayisi = BugununTarihi - SorununCozulduguTarih; // İki tarihi arasında gün farkı alınır

            if (Math.Abs(GunSayisi.Days) >= nGun && Math.Abs(GunSayisi.Days) < 7) //gün sayısınına göre kontrol eder
            {
                DogruSayisi = 1; //Dogru sayısınına atama yapılır 
                Tarihkontrol.Close();
                SoruYazdir(); //Doğru sayısına göre soru yazdırır
                tmrKronometre.Interval = timeInterval + 6000; // Bir sorunun süresi tutulur
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= nHafta && Math.Abs(GunSayisi.Days) < 30) //gün sayısınına göre kontrol eder
            {
                DogruSayisi = 2; //Dogru sayısınına atama yapılır 
                Tarihkontrol.Close();
                SoruYazdir(); //Doğru sayısına göre soru yazdırır
                tmrKronometre.Interval = timeInterval + 6000; // Bir sorunun süresi tutulur
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= nAy && Math.Abs(GunSayisi.Days) < 90) //gün sayısınına göre kontrol eder
            {
                DogruSayisi = 3; //Dogru sayısınına atama yapılır 
                Tarihkontrol.Close();
                SoruYazdir(); //Doğru sayısına göre soru yazdırır
                tmrKronometre.Interval = timeInterval + 6000; // Bir sorunun süresi tutulur
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= 90 && Math.Abs(GunSayisi.Days) < 180) //gün sayısınına göre kontrol eder
            {
                DogruSayisi = 4; //Dogru sayısınına atama yapılır 
                Tarihkontrol.Close();
                SoruYazdir(); //Doğru sayısına göre soru yazdırır
                tmrKronometre.Interval = timeInterval + 6000; // Bir sorunun süresi tutulur
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= 180 && Math.Abs(GunSayisi.Days) < 365) //gün sayısınına göre kontrol eder
            {
                DogruSayisi = 5; //Dogru sayısınına atama yapılır 
                Tarihkontrol.Close();
                SoruYazdir(); //Doğru sayısına göre soru yazdırır
                tmrKronometre.Interval = timeInterval + 6000; // Bir sorunun süresi tutulur
                zamansayac += 1;
            }
            else if (Math.Abs(GunSayisi.Days) >= 365) //gün sayısınına göre kontrol eder
            {
                DogruSayisi = 6; //Dogru sayısınına atama yapılır 
                Tarihkontrol.Close();
                SoruYazdir(); //Doğru sayısına göre soru yazdırır
                tmrKronometre.Interval = timeInterval + 6000; // Bir sorunun süresi tutulur
                zamansayac += 1;
            }
            else
            {
                MessageBox.Show("Sınavınız Bitmiştir." + "\n" + " Öğrenci Ekranına Yönlendiriliyorsunuz...");
                frmOgrenci frmOgrenci = new frmOgrenci(); //Öğrenci sayfasına yönlendirir
                frmOgrenci.Show();
                this.Hide();
            }
            db.baglanti.Close();
        }
        public void SiraylaGetir()
        {
            //buttonındex datagridview deki row sayısından büyük yada eşitse yada rowu buttonindex olan yeni row olduğunu kontrol et 
            if (buttonIndex >= dgvList.Rows.Count || dgvList.Rows[buttonIndex].IsNewRow)
                buttonIndex = 0;
            //datagridviewe soruno eklendiyse 
            if (dgvList.AllowUserToAddRows == true)
            {
                //row sayısı birden büyük olduğunda rowu buttonindex e eşit olan soruidsini sorunoya eşitle 
                if (dgvList.RowCount > 1)
                {
                    SoruNo = dgvList.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek(); //SoruCek fonksiyonu çağrılır
                }
                //datagridviewin içinde soruid yoksa dogru soru cek
                else if (dgvList.RowCount > 0 || dgvList.RowCount < 1)
                {
                    DogruSoruCek(); //DogruCek fonksiyonu çağrılır
                    return;
                }
            }
            buttonIndex++;
        }
        public void YanlısSoruGuncelle()
        {
            SqlCommand YanlisGuncelle = new SqlCommand("Update Sinav set CorrectAnswer=@p1, CorrectAnswerCount=@p2 where QuestionID='" + QuestionID + "' AND UserID= '" + UserID + "'", db.baglanti); // Giriş yapan kullanıcı ve çözülen soruya göre veritbanında güncelleme yapar
            YanlisGuncelle.Parameters.AddWithValue("@p1", 0); //Sorunun cevabını false güncller
            YanlisGuncelle.Parameters.AddWithValue("@p2", 0); //Sorunun doğru sayısını 0 yapar
            YanlisGuncelle.ExecuteNonQuery();
        }
        public void DogruSoruGuncelle()
        {
            SqlCommand CACGuncelle = new SqlCommand("update Sinav set CorrectAnswerCount=@p1 where QuestionID='" + QuestionID + "' AND UserID= '" + UserID + "'", db.baglanti);  // Giriş yapan kullanıcı ve çözülen soruya göre veritbanında güncelleme yapar
            CACGuncelle.Parameters.AddWithValue("@p1", (CAC + 1)); // Sorunun doğru çözülme sayısını 1 artırır
            CACGuncelle.ExecuteNonQuery();
        }
        public int UserIDCek() //Kullanıcının UserID bilgisini çeken fonksiyondur
        {
            db.baglanti.Open();
            SqlCommand UserIDAl = new SqlCommand("select * from Users where UserName='" + frmGiris.AlinanKullaniciAdi.ToString() + "'", db.baglanti); //Giriş yapan kullanıcı adını kullanarak veritabanından bilgi çeker
            UserIDAl.Connection = db.baglanti;
            SqlDataReader UserIDKontrol = UserIDAl.ExecuteReader();
            if (UserIDKontrol.Read()) //Users tablosunun boş olup olmadığını kontrol eder
            {
                UserID = Convert.ToInt16(UserIDKontrol["UserID"]); //UserID bilgisini çeker
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
        "values (@c1,@c2,@c3,@c4)", db.baglanti); //Sinav tablosuna çözülen soruların verileri gönderilir

            sinavekle.Parameters.AddWithValue("@c1", QuestionID); //QuestionID verisi veritabnına eklenir
            sinavekle.Parameters.AddWithValue("@c2", UserID); //UserID verisi veritabnına eklenir
            sinavekle.Parameters.AddWithValue("@c4", DateTime.Now); //Çözülen sorunun tarihin verisi veritabnına eklenir

            if (rdbA.Checked == true) //RadioButton işaretlediği kontrol eder
            {
                if (rdbA.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1); //Çözülen soru doğru ise Sorunun cevabını true yapar
                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0); //Çözülen soru yanlış ise Sorunun cevabını false yapar
                    sinavekle.ExecuteNonQuery();
                }
            }
            else if (rdbB.Checked == true)  //RadioButton işaretlediği kontrol eder
            {
                if (rdbB.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1); //Çözülen soru doğru ise Sorunun cevabını true yapar
                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0); //Çözülen soru yanlış ise Sorunun cevabını false yapar
                    sinavekle.ExecuteNonQuery();
                }
            }
            else if (rdbC.Checked == true) //RadioButton işaretlediği kontrol eder
            {
                if (rdbC.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1); //Çözülen soru doğru ise Sorunun cevabını true yapar
                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0); //Çözülen soru yanlış ise Sorunun cevabını false yapar
                    sinavekle.ExecuteNonQuery();
                }
            }
            else if (rdbD.Checked == true) //RadioButton işaretlediği kontrol eder
            {
                if (rdbD.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                {
                    sinavekle.Parameters.AddWithValue("@c3", 1); //Çözülen soru doğru ise Sorunun cevabını true yapar
                    sinavekle.ExecuteNonQuery();
                }
                else
                {
                    sinavekle.Parameters.AddWithValue("@c3", 0); //Çözülen soru yanlış ise Sorunun cevabını false yapar
                    sinavekle.ExecuteNonQuery();
                }
            }
            else
            {
                sinavekle.Parameters.AddWithValue("@c3", 0); //Çözülen soru yanlış ise Sorunun cevabını false yapar
                sinavekle.ExecuteNonQuery();
            }
        }
        public void CorrectAnswerCount()
        {
            db.baglanti.Open();
            SqlCommand DogruSoruSayisi = new SqlCommand("SELECT * from Sinav where QuestionID='" + QuestionID + "' AND UserID= '" + UserID + "' ", db.baglanti); // Giriş yapan kullanıcı ve çözülen soruya göre veritabanından veri çekilir
            DogruSoruSayisi.Connection = db.baglanti;
            SqlDataReader DogruSoruSayisiKontrol = DogruSoruSayisi.ExecuteReader();

            if (DogruSoruSayisiKontrol.Read()) //Sinav tablosunun boş olup olmadığını kontrol eder
            {
                CAC = Convert.ToInt32(DogruSoruSayisiKontrol["CorrectAnswerCount"]); //Sorunun kaç kez doğru çözüldüğünü getirir

                if (rdbA.Checked == true) //RadioButton işaretlediği kontrol eder
                {
                    if (rdbA.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle(); //Dogru olan soruyu DogruSoruGuncelle fonksiyonuyla doğru çözüm sayısı bir arttırılır
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle(); //Yanlış olan soruyu YanlısSoruGuncelle fonksiyonuyla doğru çözüm sayısı 0 yapılır
                    }
                }
                else if (rdbB.Checked == true) //RadioButton işaretlediği kontrol eder
                {
                    if (rdbB.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle(); //Dogru olan soruyu DogruSoruGuncelle fonksiyonuyla doğru çözüm sayısı bir arttırılır
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle(); //Yanlış olan soruyu YanlısSoruGuncelle fonksiyonuyla doğru çözüm sayısı 0 yapılır
                    }
                }
                else if (rdbC.Checked == true) //RadioButton işaretlediği kontrol eder
                {
                    if (rdbC.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle(); //Dogru olan soruyu DogruSoruGuncelle fonksiyonuyla doğru çözüm sayısı bir arttırılır
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle(); //Yanlış olan soruyu YanlısSoruGuncelle fonksiyonuyla doğru çözüm sayısı 0 yapılır
                    }
                }
                else if (rdbD.Checked == true) //RadioButton işaretlediği kontrol eder
                {
                    if (rdbD.Text == lblDogruCevap.Text) //Şıkkın doğru olup olmadığını kontrol eder
                    {
                        DogruSoruSayisiKontrol.Close();
                        DogruSoruGuncelle(); //Dogru olan soruyu DogruSoruGuncelle fonksiyonuyla doğru çözüm sayısı bir arttırılır
                    }
                    else
                    {
                        DogruSoruSayisiKontrol.Close();
                        YanlısSoruGuncelle(); //Yanlış olan soruyu YanlısSoruGuncelle fonksiyonuyla doğru çözüm sayısı 0 yapılır
                    }
                }
                else
                {
                    DogruSoruSayisiKontrol.Close();
                    YanlısSoruGuncelle(); //Yanlış olan soruyu YanlısSoruGuncelle fonksiyonuyla doğru çözüm sayısı 0 yapılır
                }
            }
            else
            {
                DogruSoruSayisiKontrol.Close();
                SoruKontrol(); //SoruKontrol fonksiyonu çağrılır
            }
            db.baglanti.Close();
        }
        public void SoruCek()
        {
            db.baglanti.Open();
            string veriler = "SELECT QuestionID,QuestionText,PicturePath,RightAnswer,a,b,c,d,QuestionID FROM Question where QuestionID='" + SoruNo + "'"; //Çözülen QuestionID'sine göre veritabanından soru verileri çekilir
            SqlCommand SoruCek = new SqlCommand(veriler, db.baglanti);
            SoruCek.Connection = db.baglanti;
            SqlDataReader SoruCekKontrol = SoruCek.ExecuteReader();

            if (SoruCekKontrol.Read()) //Questşon tablosunun boş olup olmadığı kontrol edilir
            {
                rtbSoru.Text = SoruCekKontrol["QuestionText"].ToString(); //Sorunun metni çekilir 
                pbResim.ImageLocation = SoruCekKontrol["PicturePath"].ToString();  //Sorunun resminin dosya yolu çekilir 
                txtA.Text = SoruCekKontrol["a"].ToString(); //Sorunun A şıkkı çekilir 
                txtB.Text = SoruCekKontrol["b"].ToString(); //Sorunun B şıkkı çekilir
                txtC.Text = SoruCekKontrol["c"].ToString(); //Sorunun C şıkkı çekilir
                txtD.Text = SoruCekKontrol["d"].ToString(); //Sorunun D şıkkı çekilir
                lblDogruCevap.Text = SoruCekKontrol["RightAnswer"].ToString(); //Sorunun doğru cevabı çekilir
                QuestionID = Convert.ToInt32(SoruCekKontrol["QuestionID"]); //Sorunun ID'si çekilir
            }
            else
            {
                MessageBox.Show("Soru Bulunamadı!");
            }
            db.baglanti.Close();
        }
        public void verileriGoster(string veriler) //DataGridview'e verileri yazdırır
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            dz.Fill(ds);
            dgvList.DataSource = ds.Tables[0];
        }
        private void frmSigmaSınav_Load(object sender, EventArgs e)
        {
            UserIDCek(); //UserIDCek fonksiyonu çağrılır
            db.baglanti.Open();
            string veriler = "Select top 10 QuestionID from Question order by NEWID()"; //Veritabınından rasstgele 10 soru çekilir
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler); //VerileriGoster fonksiyonu Çağrılır
            SiraylaGetir(); //SiraylaGetir fonksiyonu Çağrılır
            lblSure.Text = "10"; //Süre bilgisi ekrana yazılır
            tmrKronometre.Start(); //Sınav süresini başlatır
            //Kullanıcı RadioButton text verilerini değiştiremmez
            rtbSoru.ReadOnly = true;
            txtA.ReadOnly = true;
            txtB.ReadOnly = true;
            txtC.ReadOnly = true;
            txtD.ReadOnly = true;
        }
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnClickSayac--;
            CorrectAnswerCount(); //CorrectAnswerCount fonksiyonu Çağrılır
            SiraylaGetir(); //SiraylaGetir fonksiyonu Çağrılır
            if (zamansayac==0) //Süre konrolünü yapar
            {
                MessageBox.Show("Süreniz Bitmiştir");
            }
            sayac++;
            if (dgvList.Rows.Count == sayac) 
            {
                ds.Tables[0].Rows.Clear();
                SiraylaGetir();
                return;
            }
            //RadioButton işaretlenmlerini temizler
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOgrenci frmOgrenci = new frmOgrenci(); //Öğrenci sayfasına yönlendirir
            frmOgrenci.Show();
            this.Hide();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris(); //Giriş sayfasına yönlendirir
            frmGiris.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamayı kapatır
        }
        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            zamansayac--; //Verilen Sürenin azlmasını sağlar 
            lblSure.Text = zamansayac.ToString(); //Kalan süreyi ekrana yazdırır
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            //Soru şıklarının görünürlüğünü sağlar
            txtA.Visible = true;
            txtB.Visible = true;
            txtC.Visible = true;
            txtD.Visible = true;
            //RadioButton işaretlenmesini sağlar
            rdbA.Enabled = true;
            rdbB.Enabled = true;
            rdbC.Enabled = true;
            rdbD.Enabled = true;

            rtbSoru.Visible = true; //Sorun metninin görünürlüğünü sağlar
            pbResim.Visible = true; //Sorun resminin görünürlüğünü sağlar
            btnSonraki.Enabled = true; //Sonraki butonunun tıklanma özelliğini sağlar
            btnBasla.Enabled = false; //Başla butonunun tıklanmasını engeller
        }
    }
}
