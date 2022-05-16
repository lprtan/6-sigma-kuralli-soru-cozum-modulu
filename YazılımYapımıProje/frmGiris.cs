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
            txtGirisSifre.UseSystemPasswordChar = true;
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl KayitOl = new FrmKayitOl();
            KayitOl.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            SqlCommand giris = new SqlCommand("SELECT * FROM Users where UserName='" + txtGirisKullaniciAdi.Text + "' AND Password='" + txtGirisSifre.Text + "'");
            db.baglanti.Open();
            giris.Connection = db.baglanti;
            SqlDataReader kontrol = giris.ExecuteReader();

            if (kontrol.Read())
            {

                switch (kontrol["UserTypeID"])
                {
                    case 1:
                        AlinanKullaniciAdi = txtGirisKullaniciAdi.Text;
                        frmSinav sinavForm = new frmSinav();

                        FrmOgrenci OgrenciEkran = new FrmOgrenci();
                        OgrenciEkran.Show();
                        this.Hide();
                        break;
                    case 3:
                        frmAdmin AdminEkran = new frmAdmin();
                        AdminEkran.Show();
                        this.Hide();
                        break;
                    case 2:
                        frmSoruEkle OgretmenEkran = new frmSoruEkle();
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
            FrmSifremiUnuttum SifremiUnuttum = new FrmSifremiUnuttum();
            SifremiUnuttum.Show();
            this.Hide();
        }

        private void ckbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {

            {
                {
                    if (ckbSifreyiGoster.Checked)
                    {
                        txtGirisSifre.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        txtGirisSifre.UseSystemPasswordChar = true;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
