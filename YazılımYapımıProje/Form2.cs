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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DELL-BILGISAYAR;Initial Catalog=Proje;Integrated Security=True;MultipleActiveResultSets=True");
        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into Users (UserName,Name,Surname,Mail,Password,UserTypeID) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);


            kayitekle.Parameters.AddWithValue("@p1",txtKullaniciAdiKayit.Text);
            kayitekle.Parameters.AddWithValue("@p2",txtAd.Text);
            kayitekle.Parameters.AddWithValue("@p3",txtSoyad.Text);
            kayitekle.Parameters.AddWithValue("@p4",txtMail.Text);
            kayitekle.Parameters.AddWithValue("@p5",txtSifre.Text);
            kayitekle.Parameters.AddWithValue("@p6",cbxKullaniciType.SelectedIndex);
         
            kayitekle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kaydınız Başarıyla alınmıştır");

        }
    }
}
