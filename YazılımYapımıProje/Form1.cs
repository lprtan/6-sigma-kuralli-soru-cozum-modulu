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
    public partial class FrmGiris : Form
    {

        public FrmGiris()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKatıtOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl KayitOl = new FrmKayitOl();
            KayitOl.Show();  
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=DELL-BILGISAYAR;Initial Catalog=Proje;Integrated Security=True");
            SqlCommand giris = new SqlCommand("SELECT * FROM dbo.Users where UserName='" + txtGirisKullaniciAdi.Text + "' AND Password='" + txtGirisSifre.Text + "'" );
            baglanti.Open();
            giris.Connection = baglanti;
            SqlDataReader kontrol = giris.ExecuteReader();

            if (kontrol.Read())
            {              
                switch (kontrol["UserTypeID"])
                {
                    case 1:
                        FrmOgrenci OgrenciEkran = new FrmOgrenci();
                        OgrenciEkran.Show();
                        this.Hide();
                        break;
                    case 2:
                        FrmAdmin AdminEkran = new FrmAdmin();
                        AdminEkran.Show();
                        this.Dispose();
                        break;
                    case 3:
                        FrmOgretmen OgretmenEkran = new FrmOgretmen();
                        OgretmenEkran.Show();
                        this.Dispose();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı tekrar giriniz");

            }
            baglanti.Close();
        }

        private void lblSifeyiUnuttum_Click(object sender, EventArgs e)
        {
            
        }

        private void lblKullaniciAdiGiris_Click(object sender, EventArgs e)
        {

        }

        private void lblSifreGiris_Click(object sender, EventArgs e)
        {

        }

        private void txtGirisKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGirisSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}