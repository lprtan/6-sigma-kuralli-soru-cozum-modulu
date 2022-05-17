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
        public void SoruSıklıgıAyar()
        {
            DataBase db = new DataBase();

            frmSigmaSinav sinav = new frmSigmaSinav();

            int UserID = sinav.UserIDCek();

            AyarlarGun = Convert.ToInt32(cbxGun.SelectedItem);
            AyarlarHafta = Convert.ToInt32(cbxHafta.SelectedItem);
            AyarlarAy = Convert.ToInt32(cbxAy.SelectedItem);

            db.baglanti.Open();
            SqlCommand AyarlarCek = new SqlCommand("SELECT * from Sinav where  UserID= '" + UserID + "' ", db.baglanti);
            AyarlarCek.Connection = db.baglanti;
            SqlDataReader kontrol = AyarlarCek.ExecuteReader();

            if (kontrol.Read())
            {
                SqlCommand AyarlarGuncelle = new SqlCommand("update Settings set Gun=@G,Hafta=@H,Ay=@A where UserID= '" + UserID + "' ", db.baglanti);
                AyarlarGuncelle.Parameters.AddWithValue("@G", AyarlarGun);
                AyarlarGuncelle.Parameters.AddWithValue("@H", AyarlarHafta);
                AyarlarGuncelle.Parameters.AddWithValue("@A", AyarlarAy);
                kontrol.Close();
                AyarlarGuncelle.ExecuteNonQuery();

                MessageBox.Show("Soru kontrol sıklığınız başarıyla güncellenmiştir :)");
            }
            else
            {
                SqlCommand AyarlarEkle = new SqlCommand("insert into Settings (UserID,Gun,Hafta,Ay) values (@Kullanici,@Gun,@Hafta,@Ay)", db.baglanti);
                AyarlarEkle.Parameters.AddWithValue("@Kullanici", UserID);
                AyarlarEkle.Parameters.AddWithValue("@Gun", AyarlarGun);
                AyarlarEkle.Parameters.AddWithValue("@Hafta", AyarlarHafta);
                AyarlarEkle.Parameters.AddWithValue("@Ay", AyarlarAy);
                kontrol.Close();
                AyarlarEkle.ExecuteNonQuery();

                MessageBox.Show("Soru kontrol sıklığınız başarıyla kaydedilmiştir :)");
            }
            db.baglanti.Close();

        }

        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
            SoruSıklıgıAyar();
        }

        private void btnSigma6_Click(object sender, EventArgs e)
        {
            frmSigmaSinav ss = new frmSigmaSinav();
            ss.Show();
            this.Hide();
        }

        private void btnDenemeSinavi_Click(object sender, EventArgs e)
        {
            frmDenemeSinav s = new frmDenemeSinav();
            s.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            giris.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            
            sayac++;
            if (sayac % 2 == 0)
                grpAyarlar.Visible = false;
            else
                grpAyarlar.Visible = true;
        }

        private void btnOgrenciRaporAl_Click(object sender, EventArgs e)
        {
            frmOgrenciRapor frmOgrenciRapor = new frmOgrenciRapor();
            frmOgrenciRapor.Show();
            this.Hide();
        }
    }
}
