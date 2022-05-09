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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into Users (UserName,Name,Surname,Mail,Password,UserTypeID) values (@p1,@p2,@p3,@p4,@p5,@p6)", db.baglanti);

            kayitekle.Parameters.AddWithValue("@p1",txtKullaniciAdiKayit.Text);
            kayitekle.Parameters.AddWithValue("@p2",txtAd.Text);
            kayitekle.Parameters.AddWithValue("@p3",txtSoyad.Text);
            kayitekle.Parameters.AddWithValue("@p4",txtMail.Text);
            kayitekle.Parameters.AddWithValue("@p5",txtSifre.Text);
            kayitekle.Parameters.AddWithValue("@p6",(cbxKullaniciType.SelectedIndex)+1);
         
            kayitekle.ExecuteNonQuery();
            db.baglanti.Close();

            MessageBox.Show("Kaydınız Başarıyla alınmıştır");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris GirisEkran = new FrmGiris();
            GirisEkran.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }
    }
}
