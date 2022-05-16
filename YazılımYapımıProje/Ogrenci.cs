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
        public int AyarlarGun { get; set; }
        public int AyarlarHafta { get; set; }
        public int AyarlarAy { get; set; }
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        public void SoruSıklıgıAyar()
        {
            DataBase db = new DataBase();

            Sinav sinav = new Sinav();

            int UserID = sinav.UserIDCek();

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
            dateTimePicker1.Value = new DateTime(dateTimePicker2.Value.Year ,dateTimePicker2.Value.Month ,dateTimePicker2.Value.Day);/*
            dateTimePicker4.Value = new DateTime(dateTimePicker3.Value.Year,dateTimePicker3.Value.Month+1,dateTimePicker3.Value.Day+30);
            dateTimePicker5.Value = new DateTime(dateTimePicker4.Value.Year,dateTimePicker4.Value.Month+2 ,dateTimePicker4.Value.Day+60);
            dateTimePicker6.Value = new DateTime(dateTimePicker5.Value.Year,dateTimePicker5.Value.Month+5 ,dateTimePicker5.Value.Day+90);*/

            if (dateTimePicker1.Value==monthCalendar1.TodayDate)
            {
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
                button2.Text = "Sigma sınav sürenizi değiştiriniz";
            }

        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == monthCalendar1.TodayDate)
            {
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
                button2.Text = "Sigma sınav sürenizi değiştiriniz";
            }
        }


        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
           
            SoruSıklıgıAyar();

        }

        
       
    }
}
