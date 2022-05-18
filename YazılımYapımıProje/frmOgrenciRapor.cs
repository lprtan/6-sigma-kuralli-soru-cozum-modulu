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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace YazılımYapımıProje
{
    public partial class frmOgrenciRapor : Form
    {
        DataBase db=new DataBase(); //DataBase sınıfından bir nesne oluşturulur
        frmSigmaSinav sigmaSinav = new frmSigmaSinav(); //frmSigmaSinav formundan bir nesne oluşturulur
        public int UserID { get; set; }
        public frmOgrenciRapor()
        {
            InitializeComponent();
        }
        public void verileriGoster(string veriler) // DataGridviev içine veileri yazdırır
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            DataSet ds = new DataSet();
            dz.Fill(ds);
            dvgOgrenciRapor.DataSource = ds.Tables[0];
        }
        
        private void frmOgrenciRapor_Load(object sender, EventArgs e)
        {
            UserID = sigmaSinav.UserIDCek(); //Kullanıcı girişine göre kullanıcının UserID bilgisi çekilir
            db.baglanti.Open();
            string RaporVerileri = "SELECT Units.UnitName, Sinav.CorrectAnswerCount*16.67 As BaşarıOranı From Question INNER JOIN Units ON Question.UnitID = Units.UnitID INNER JOIN Sinav ON  Question.QuestionID = Sinav.QuestionID where Sinav.UserID = '"+ UserID+"'"; // kullanıcının Ünitelerdeki doğru sayısana göre başarı oranını yazdırır
            SqlCommand OgrenciRaporAl = new SqlCommand(RaporVerileri, db.baglanti);
            OgrenciRaporAl.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(RaporVerileri);  //VerileriGoster fonksiyonu çağrılır
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:\\Users\\furka\\OneDrive\\Masaüstü\\Sigma Sınav Raporu.pdf", FileMode.Create)); //Raporun dosya yolunu belirler
            rapor.AddAuthor("Alptekin Bağ");
            rapor.AddCreationDate();
            rapor.AddCreator("Sigma Sınav Program");
            rapor.AddSubject("Sınav Sonucu");
            rapor.AddKeywords("Sigma Sınav");
            if (rapor.IsOpen() == false) //Raporun açılıp açılmadığı belirler
            {
                rapor.Open(); //Raporu açar
            }
            rapor.Add(new Paragraph("Bölüm         Basari Orani \n")); // //Raporda bulunacak bilgeleri rapora yazar
            for (int i = 0; i < dvgOgrenciRapor.Rows.Count-1; i++) // DatgridViev satır sayısı boyunca döngüye girmesini sağlar
            {
                rapor.Add(new Paragraph( dvgOgrenciRapor.Rows[i].Cells[0].Value.ToString() + "--------------->" + dvgOgrenciRapor.Rows[i].Cells[1].Value.ToString())); //Rapora verileri yazdırır
            }
            MessageBox.Show("Rapor Oluşturuldu");
            rapor.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatır
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris(); //Giriş Sayfasına yönlendirir
            frmGiris.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOgrenci frmOgrenci = new frmOgrenci();  //Öğrenci Sayfasına yönlendirir
            frmOgrenci.Show();
            this.Hide();
        }
    }
}
