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
        DataBase db = new DataBase();

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into Users (UserName,Name,Surname,Mail,Password,UserTypeID) values (@p1,@p2,@p3,@p4,@p5,@p6)", db.baglanti);

            kayitekle.Parameters.AddWithValue("@p1", txtKullaniciAdiKayit.Text);
            kayitekle.Parameters.AddWithValue("@p2", txtAd.Text);
            kayitekle.Parameters.AddWithValue("@p3", txtSoyad.Text);
            kayitekle.Parameters.AddWithValue("@p4", txtMail.Text);
            kayitekle.Parameters.AddWithValue("@p5", txtSifre.Text);
            kayitekle.Parameters.AddWithValue("@p6", (cbxKullaniciType.SelectedIndex) + 1);

            kayitekle.ExecuteNonQuery();
            db.baglanti.Close();

            MessageBox.Show("Kaydınız Başarıyla Alınmıştır...");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frmGiris GirisEkran = new frmGiris();
            GirisEkran.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
