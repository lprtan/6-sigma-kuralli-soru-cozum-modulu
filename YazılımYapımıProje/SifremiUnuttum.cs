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
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
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
    }
}
