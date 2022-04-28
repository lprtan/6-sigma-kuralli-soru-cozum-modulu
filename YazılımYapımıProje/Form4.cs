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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();

        public void verileriGoster(string veriler)
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            DataSet ds = new DataSet();
            dz.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            db.baglanti.Open();
            string veriler = "Select * from Question where SoruOnay='" + 0 + "'";
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            foreach (DataGridViewRow dgrow in dataGridView1.SelectedRows)
            {
                if (dataGridView1.RowCount > 0)
               {
                    string kayit = "update Question set SoruOnay=@soruonay where QuestionID=@a1";
                    SqlCommand komut = new SqlCommand(kayit, db.baglanti);
                    komut.Parameters.AddWithValue("@SoruOnay", 1);
                    komut.Parameters.AddWithValue("@a1", dataGridView1.SelectedCells[0].Value);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                }
            }

            MessageBox.Show("Soru Onaylandı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgrow in dataGridView1.SelectedRows)
            {
                if (dataGridView1.RowCount > 0)
                {
                    db.baglanti.Open();
                    string silinecek = "Delete from Question where QuestionID=@frkn ";
                    SqlCommand komut = new SqlCommand(silinecek, db.baglanti);
                    komut.Parameters.AddWithValue("@frkn", dataGridView1.SelectedCells[0].Value);
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Silindi");

                }
                else
                {
                    MessageBox.Show("Veritabanı Hatası");
                }
            }
        }
    }
}
