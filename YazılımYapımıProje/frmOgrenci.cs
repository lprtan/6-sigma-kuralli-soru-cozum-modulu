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

namespace YazılımYapımıProje
{
    public partial class frmOgrenci : Form
    {
        public int AyarlarGun { get; set; }
        public int AyarlarHafta { get; set; }
        public int AyarlarAy { get; set; }
        int sayac = 0;
        public frmOgrenci()
        {
            InitializeComponent();
        }
        public void SoruSikligiAyar()
        {
            DataBase db = new DataBase(); //Databese sınıfdan nesne oluşturur

            frmSigmaSinav sinav = new frmSigmaSinav();  //frmSigmaSınav formundan nesne oluşturur

            int UserID = sinav.UserIDCek(); //UserIDCek fonksiyonundan UserID verisi aktarılır

            AyarlarGun = Convert.ToInt32(cbxGun.SelectedItem); //Öğrencinin seçtiği gün verisi atanır
            AyarlarHafta = Convert.ToInt32(cbxHafta.SelectedItem);  //Öğrencinin seçtiği hafta verisi atanır
            AyarlarAy = Convert.ToInt32(cbxAy.SelectedItem);   //Öğrencinin seçtiği ay verisi atanır

            db.baglanti.Open();
            SqlCommand AyarlarCek = new SqlCommand("SELECT * from Sinav where  UserID= '" + UserID + "' ", db.baglanti); //Veritabnından kullanıcının UserID bilgisene göre veri çekilir
            AyarlarCek.Connection = db.baglanti;
            SqlDataReader AyarlarCekKontrol = AyarlarCek.ExecuteReader();

            if (AyarlarCekKontrol.Read()) //Kullanıcının ayarlardığı verilerin olup olmadığını kontrol eder
            {
                SqlCommand AyarlarGuncelle = new SqlCommand("update Settings set Gun=@G,Hafta=@H,Ay=@A where UserID= '" + UserID + "' ", db.baglanti); //Kullanıcının önceden kaydedilmiş ayalar verisi varsa verileri günceller
                AyarlarGuncelle.Parameters.AddWithValue("@G", AyarlarGun); //Güncellenen gün bilgisi veritabanına aktarılır
                AyarlarGuncelle.Parameters.AddWithValue("@H", AyarlarHafta); //Güncellenen hafta bilgisi veritabanına aktarılır
                AyarlarGuncelle.Parameters.AddWithValue("@A", AyarlarAy);  //Güncellenen ay bilgisi veritabanına aktarılır
                AyarlarCekKontrol.Close();
                AyarlarGuncelle.ExecuteNonQuery();

                MessageBox.Show("Soru kontrol sıklığınız başarıyla güncellenmiştir :)");
            }
            else
            {
                SqlCommand AyarlarEkle = new SqlCommand("insert into Settings (UserID,Gun,Hafta,Ay) values (@Kullanici,@Gun,@Hafta,@Ay)", db.baglanti); //Eğer kullanıcı ayar verisi yoksa yeni ayar biligisini veitablosuna ekler
                AyarlarEkle.Parameters.AddWithValue("@Kullanici", UserID); //Kullanıcının UserID bilgisine eklenecek
                AyarlarEkle.Parameters.AddWithValue("@Gun", AyarlarGun); //Güncellenen gün bilgisi veritabanına aktarılır
                AyarlarEkle.Parameters.AddWithValue("@Hafta", AyarlarHafta); //Güncellenen hafta bilgisi veritabanına aktarılır
                AyarlarEkle.Parameters.AddWithValue("@Ay", AyarlarAy); //Güncellenen ay bilgisi veritabanına aktarılır
                AyarlarCekKontrol.Close();
                AyarlarEkle.ExecuteNonQuery();

                MessageBox.Show("Soru kontrol sıklığınız başarıyla kaydedilmiştir :)");
            }
            db.baglanti.Close();

        }

        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
            SoruSikligiAyar(); //SoruSikligiAyar fonksiyonu buton tetiklenince çağrılır
        }

        private void btnSigma6_Click(object sender, EventArgs e)
        {
            frmSigmaSinav frmSigmaSinav = new frmSigmaSinav(); //Sigma Sınav Ekranına yönlendirir
            frmSigmaSinav.Show();
            this.Hide();
        }

        private void btnDenemeSinavi_Click(object sender, EventArgs e)
        {
            frmDenemeSinav frmDenemeSinav = new frmDenemeSinav();  //Deneme sınav ekranına yönlendirir
            frmDenemeSinav.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamayı kapatır
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris(); //Giriş ekranına yönlendirir
            frmGiris.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {   
            //Ayarların bulunduğu bölümü gösterir
            sayac++;
            if (sayac % 2 == 0)
                grpAyarlar.Visible = false; 
            else
                grpAyarlar.Visible = true;
        }
        private void btnOgrenciRaporAl_Click(object sender, EventArgs e)
        {
            frmOgrenciRapor frmOgrenciRapor = new frmOgrenciRapor(); //Öğrenci rapor ekranına yönlendirir
            frmOgrenciRapor.Show();
            this.Hide();
        }

    }
}
