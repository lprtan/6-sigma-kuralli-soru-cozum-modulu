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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();  //DataBase sınıfından nesne oluşturuldu
        public void verileriGoster(string veriler)      
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            DataSet ds = new DataSet();
            dz.Fill(ds);
            dgvAdminSoruOnay.DataSource = ds.Tables[0];
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            db.baglanti.Open();
            string veriler = "Select * from Question where SoruOnay='" + 0 + "'";  //Question tablosundan SoruOnay false olan soruları getirir
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler);
        }

        private void btnGirisSayfası_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris(); //Giriş sayfasına yönlendirir
            giris.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();   //Programı kapatır
        }
        private void btnOnay_Click(object sender, EventArgs e)
        {
            db.baglanti.Open();
            foreach (DataGridViewRow dgrow in dgvAdminSoruOnay.SelectedRows)   //Datagridviev satırlarını tarar
            {
                if (dgvAdminSoruOnay.RowCount > 0)  //DatagridWievde seçilen satır indexi 0'dan büyük olmasına olanak sağlar
                {
                    string kayit = "update Question set SoruOnay=@soruonay where QuestionID=@SoruNo";  // Question Tablosunda QuestionID bilgisi kullanılarak Soruyu Admin onaylar
                    SqlCommand komut = new SqlCommand(kayit, db.baglanti);
                    komut.Parameters.AddWithValue("@SoruOnay", 1); //SoruOnay'ın değerini true yapar
                    komut.Parameters.AddWithValue("@SoruNo", dgvAdminSoruOnay.SelectedCells[0].Value); //Seçilen satırdaki sorununsorunun güncellemesi yapılır
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                }
            }
            MessageBox.Show("Soru Onaylandı!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgrow in dgvAdminSoruOnay.SelectedRows)  //Datagridviev satırlarını tarar
            {
                if (dgvAdminSoruOnay.RowCount > 0)  //DatagridWievde seçilen satır indexi 0'dan büyük olmasına olanak sağlar
                {
                    db.baglanti.Open();
                    string silinecek = "Delete from Question where QuestionID=@SoruNo "; // Question Tablosunda QuestionID bilgisi kullanılarak admin soruyu siler
                    SqlCommand komut = new SqlCommand(silinecek, db.baglanti);
                    komut.Parameters.AddWithValue("@SoruNo", dgvAdminSoruOnay.SelectedCells[0].Value);  //Seçilen satırdaki sorununsorunun silinme işlemi yapılır
                    komut.ExecuteNonQuery();
                    db.baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Silindi!");
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı!");
                }
            }
        }
    }
}
