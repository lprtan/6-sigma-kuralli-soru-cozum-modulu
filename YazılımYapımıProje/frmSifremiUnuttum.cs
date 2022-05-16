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
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.baglanti.Open();

            SqlCommand SifreGuncelle = new SqlCommand("update Users set Password=@Sifre where Mail=@Email", db.baglanti);

            SifreGuncelle.Parameters.AddWithValue("@Sifre", txtSifremiUnuttumSifre.Text);
            SifreGuncelle.Parameters.AddWithValue("@Email", txtSifremiUnuttumMail.Text);

            SifreGuncelle.ExecuteNonQuery();
            db.baglanti.Close();
            MessageBox.Show("Şifreniz Başarıyla Güncellendi.");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            giris.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
