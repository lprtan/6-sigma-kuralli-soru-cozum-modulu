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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        public static string AlinanKullaniciAdi = "";

        private void frmGiris_Load(object sender, EventArgs e)
        {
            txtGirisSifre.UseSystemPasswordChar = true; //Girelen şifreye karakter atayarak gizliliği sağlanır
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            frmKayitOl KayitOl = new frmKayitOl(); //Kayıt ol ekranına yönlendirir
            KayitOl.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase(); //DataBase sınıfndan nesne oluşturulur

            SqlCommand giris = new SqlCommand("SELECT * FROM Users where UserName='" + txtGirisKullaniciAdi.Text + "' AND Password='" + txtGirisSifre.Text + "'"); // Girilen kullanıcı adı ve şifre bilgis veritbanından çekilir
            db.baglanti.Open();
            giris.Connection = db.baglanti;
            SqlDataReader kontrol = giris.ExecuteReader();

            if (kontrol.Read()) //Girilen Kullanıcı adı ve şifre bilgisinin olup olmadığını kontrol eder
            {

                switch (kontrol["UserTypeID"]) //Kullanıcın tipine göre sayfalara yönlendirilir
                {
                    case 1:
                        AlinanKullaniciAdi = txtGirisKullaniciAdi.Text; //Girilen kullanıcı adı bilgisini atar
                        frmDenemeSinav sinavForm = new frmDenemeSinav(); //Atanan veri Deneme Sınavı ekranına yolanır

                        frmOgrenci OgrenciEkran = new frmOgrenci(); //Öğrenci ekranına yönlendirilir
                        OgrenciEkran.Show();
                        this.Hide();
                        break;
                    case 3:
                        frmAdmin AdminEkran = new frmAdmin(); //Admin ekranına yönlendirilir
                        AdminEkran.Show();
                        this.Hide();
                        break;
                    case 2:
                        frmSoruEkle OgretmenEkran = new frmSoruEkle();  ////Öğretmen ekranına yönlendirilir
                        OgretmenEkran.Show();
                        this.Hide();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı! Lütfen Tekrar Deneyiniz.");

            }
            db.baglanti.Close();
        }

        private void lkbSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum SifremiUnuttum = new frmSifremiUnuttum(); ////Şifremi unuttum  ekranına yönlendirilir
            SifremiUnuttum.Show();
            this.Hide();
        }

        private void ckbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {

            {
                {
                    if (ckbSifreyiGoster.Checked) //ChekBox işaretlenip işaretlenmediği kontol edilir
                    {
                        txtGirisSifre.UseSystemPasswordChar = false; //Girelen şifreye karakter atayarak gizliliği sağlanır
                    }
                    else
                    {
                        txtGirisSifre.UseSystemPasswordChar = true;  //Girilen şifrenin gizliliği kaldırılır
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamadan Çıkış Yapar
        }
    }
}
