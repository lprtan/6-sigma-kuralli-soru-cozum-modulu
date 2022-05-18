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
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase(); //DateBase sınıfdan nesne oluşturur

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into Users (UserName,Name,Surname,Mail,Password,UserTypeID) values (@p1,@p2,@p3,@p4,@p5,@p6)", db.baglanti); //Kullanıcıdan aldığı verileri veritabanına gönderir

            kayitekle.Parameters.AddWithValue("@p1", txtKullaniciAdiKayit.Text);  //Kullanıcı adını veritabanına ekler
            kayitekle.Parameters.AddWithValue("@p2", txtAd.Text); //Adı veritabanına ekler
            kayitekle.Parameters.AddWithValue("@p3", txtSoyad.Text);  //Soyadı veritabanına ekler
            kayitekle.Parameters.AddWithValue("@p4", txtMail.Text);  //E Mail adrfesini veritabanına ekler
            kayitekle.Parameters.AddWithValue("@p5", txtSifre.Text);  //Şifreyi veritabanına ekler
            kayitekle.Parameters.AddWithValue("@p6", (cbxKullaniciType.SelectedIndex) + 1); //Kullanıcı tipi veritabanınına ekler 

            kayitekle.ExecuteNonQuery();
            db.baglanti.Close();

            MessageBox.Show("Kaydınız Başarıyla Alınmıştır...");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frmGiris GirisEkran = new frmGiris(); //Giriş ekranına yönlendirir
            GirisEkran.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamayı kapatır
        }
    }
}
