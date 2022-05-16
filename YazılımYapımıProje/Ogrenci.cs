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
    public partial class FrmOgrenci : Form
    {
        DataBase db = new DataBase();
        DataSet ds = new DataSet();
        Sinav sinav = new Sinav();
        public int AyarlarGun { get; set; }
        public int AyarlarHafta { get; set; }
        public int AyarlarAy { get; set; }
        public int UserID { get; set; }
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        public void SoruSıklıgıAyar()
        {
            UserID = sinav.UserIDCek();

            AyarlarGun = Convert.ToInt32(cbxGun.SelectedItem);
            AyarlarHafta= Convert.ToInt32(cbxHafta.SelectedItem);
            AyarlarAy=Convert.ToInt32(cbxAy.SelectedItem);

            db.baglanti.Open();
            SqlCommand AyarlarCek = new SqlCommand("SELECT * from Sinav where  UserID= '" + UserID + "' ", db.baglanti);
            AyarlarCek.Connection = db.baglanti;
            SqlDataReader kontrol = AyarlarCek.ExecuteReader();
   
            if (kontrol.Read())
            {
                
                SqlCommand AyarlarGuncelle = new SqlCommand("update Settings set Gun=@G,Hafta=@H,Ay=@A where UserID= '" + UserID + "' ",db.baglanti);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Sinav s = new Sinav();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SigmaSinav ss = new SigmaSinav();
            ss.Show();
            this.Hide();
        }
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {

        }
        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
           
            SoruSıklıgıAyar();

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmOgrenciRapor frmOgrenciRapor = new frmOgrenciRapor();
            frmOgrenciRapor.Show();
            this.Show();
        }
    }
}
