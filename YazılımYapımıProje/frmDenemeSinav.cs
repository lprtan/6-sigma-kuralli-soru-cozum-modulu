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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace YazılımYapımıProje
{
    public partial class frmDenemeSinav : Form
    {
        DataBase db = new DataBase();  //DataBase sınıfından nesne oluşturur
        public int UserID { get; set; }  //Users Tablosunda UserID bilgisi 
      //  public int QuestionID { get; set; } // Question tablosunda QuestionID bigisi
        public int CAC { get; set; }  //Sinav tablosunda CorrectAnswerCount bilgisini 
        private string SoruNo = null!;
        int buttonIndex = 0;
        int sayac = 0;
        int devir = 0;

        public void UserIDCek()  // Giriş yapan kullanıcının UserID bilgisini almaya yarayan fonksiyon
        {
            db.baglanti.Open();
            SqlCommand UserIDAl = new SqlCommand("select * from Users where UserName='" + frmGiris.AlinanKullaniciAdi.ToString() + "'", db.baglanti); //Giriş sayfasında girilen kullanıcı adının UserName bilgisini veritabanından alınır
            UserIDAl.Connection = db.baglanti;
            SqlDataReader kontrol = UserIDAl.ExecuteReader();
            if (kontrol.Read())  //Users Tablosunda veri olup olmadığını kontrol eder
            {
                UserID = Convert.ToInt16(kontrol["UserID"]); //Users tablosunda UserID bilgisi çekilir
            }
            else
            {
                MessageBox.Show("Veritabanı hatası!!!");
            }
            kontrol.Close();
            db.baglanti.Close();
        }
        public void verileriGoster(string veriler)
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            DataSet ds = new DataSet();
            dz.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        public void CorrectAnswerCount() //Sinav tablosundaki CorrectAnswerCount biligisni çeker ve Deneme rapor için öğrencinin cevapları ve doğru cevap biligilerini yazdırır
        {
            db.baglanti.Open();
            SqlCommand DogruSoruSayisi = new SqlCommand("SELECT * from Sinav where QuestionID='" + SoruNo + "' AND UserID= '" + UserID + "' ", db.baglanti); //Sinav tablosundan QustionId ve UserID bilgilerine göre veri çeker 
            DogruSoruSayisi.Connection = db.baglanti;
            SqlDataReader DogruSoruSayisiKontrol = DogruSoruSayisi.ExecuteReader();

            if (DogruSoruSayisiKontrol.Read())  //Sinav tablosunda veri olup omadığını kontrol eder
            {
                CAC = Convert.ToInt32(DogruSoruSayisiKontrol["CorrectAnswerCount"]);  //UserID ve QuestionID bilgilerine göre CorrectAnswerCount bilgisini çeker

                if (rdbA.Checked == true) //Radiobutton tıklanmasını kontrol eder
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = SoruNo; // QuestionID bilgisini Tutar
                    string VerilenCevap = rdbA.Text;  //Ögrencinin verdiği cevap bilgisini tutar
                    string DogruCevap = lblDogruCevap.Text; //Doğru cevap bilgisini tutar
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap }; //Raporda olacak biligileri dizide tutar
                    lsvRapor.Items.Add(new ListViewItem(bilgiler)); //dizi içindeki bilgileri ListWiev'e aktarır
                }
                else if (rdbB.Checked == true)  //Radiobutton tıklanmasını kontrol eder
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = SoruNo;  // QuestionID bilgisini Tutar
                    string VerilenCevap = rdbB.Text;  //Ögrencinin verdiği cevap bilgisini tutar
                    string DogruCevap = lblDogruCevap.Text;  //Doğru cevap bilgisini tutar
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };  //Raporda olacak biligileri dizide tutar
                    lsvRapor.Items.Add(new ListViewItem(bilgiler));   //dizi içindeki bilgileri ListWiev'e aktarır

                }
                else if (rdbC.Checked == true)   //Radiobutton tıklanmasını kontrol eder
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = SoruNo;   // QuestionID bilgisini Tutar
                    string VerilenCevap = rdbC.Text;  //Ögrencinin verdiği cevap bilgisini tutar
                    string DogruCevap = lblDogruCevap.Text;  //Doğru cevap bilgisini tutar
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };  //Raporda olacak biligileri dizide tutar
                    lsvRapor.Items.Add(new ListViewItem(bilgiler)); //dizi içindeki bilgileri ListWiev'e aktarır
                }
                else if (rdbD.Checked == true)  //Radiobutton tıklanmasını kontrol eder
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = SoruNo;   // QuestionID bilgisini Tutar
                    string VerilenCevap = rdbD.Text;   //Ögrencinin verdiği cevap bilgisini tutar
                    string DogruCevap = lblDogruCevap.Text;   //Doğru cevap bilgisini tutar
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };   //Raporda olacak biligileri dizide tutar
                    lsvRapor.Items.Add(new ListViewItem(bilgiler));   //dizi içindeki bilgileri ListWiev'e aktarır
                }
                else
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = SoruNo;   // QuestionID bilgisini Tutar
                    string VerilenCevap = "Cevap Verilmedi"; //Boş Geçşlen soruyu belirtir
                    string DogruCevap = lblDogruCevap.Text;  //Doğru cevap bilgisini tutar
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };  //Raporda olacak biligileri dizide tutar
                    lsvRapor.Items.Add(new ListViewItem(bilgiler));  //dizi içindeki bilgileri ListWiev'e aktarır
                }
            }
            else
            {
                MessageBox.Show("Sınav bitmiştir \n Öğrenci sayfasına yönlendiriliyorsunuz....");
                frmOgrenci frmOgrenci = new frmOgrenci();  //Öğrenci ekranına yönlendirir
                frmOgrenci.Show();
                this.Close();
            }
            db.baglanti.Close();
        }
        public void SiraylaGetir() //Datagridviev'e çıkacak rastgele 10 soruyu listeler
        {
            //buttonındex datagridview deki row sayısından büyük yada eşitse yada rowu buttonindex olan yeni row olduğunu kontrol et 
            if (buttonIndex >= dataGridView1.Rows.Count || dataGridView1.Rows[buttonIndex].IsNewRow)
                buttonIndex = 0;
            //datagridviewe soruno eklendiyse 
            if (dataGridView1.AllowUserToAddRows == true)
            {//row sayısı birden büyük olduğunda rowu buttonindex e eşit olan soruidsini sorunoya eşitle
                if (dataGridView1.RowCount > 1)
                {
                    SoruNo = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();  //SoruCek fonksiyonunu çağırır
                    buttonIndex++;
                    return;
                }
                //row sayısı birden büyük olduğunda rowu buttonindex e eşit olan soruidsini sorunoya eşitle
                else if (dataGridView1.RowCount > 0)
                {

                    SoruNo = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();  
                    SoruCek();  //SoruCek fonksiyonunu çağırır
                    return;
                }
            }
        }
        public void SoruCek() //Veritabanından soru çeker
        {
            db.baglanti.Open();
            SqlCommand soruCek = new SqlCommand("SELECT QuestionID,QuestionText,PicturePath,RightAnswer,a,b,c,d FROM Question where QuestionID='" + SoruNo + "' ", db.baglanti); ; //Question Tablosunda QuestionID verisene göre soru bilgilerini çeker

            soruCek.Connection = db.baglanti;
            SqlDataReader soruCekKontrol = soruCek.ExecuteReader();

            if (soruCekKontrol.Read()) //Question tablosunda veri olup olmadığı kontrol eder
            {
                rtbSoru.Text = soruCekKontrol["QuestionText"].ToString(); //Soru metnini çeker
                pbResim.ImageLocation = soruCekKontrol["PicturePath"].ToString(); //Soru resmini çeker
                txtA.Text = soruCekKontrol["a"].ToString(); //A şıkkının metnini öçeker
                txtB.Text = soruCekKontrol["b"].ToString(); //B şıkkının metnini öçeker
                txtC.Text = soruCekKontrol["c"].ToString(); //C şıkkının metnini öçeker
                txtD.Text = soruCekKontrol["d"].ToString(); //D şıkkının metnini öçeker
                lblDogruCevap.Text = soruCekKontrol["RightAnswer"].ToString(); //Doğru Cevap bilgisini çeker
            }
            else
            {
                MessageBox.Show("veritabanı hatası");
            }
            db.baglanti.Close();
        }

        public frmDenemeSinav()
        {
            InitializeComponent();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            CorrectAnswerCount(); // CorrectAnswerCount fonksiyonu çağrılır

            sayac++;
            SiraylaGetir(); //SiraylaGetir fonksiyonu çağrılır
            if (dataGridView1.Rows.Count == sayac) //Sayaç sayısnın datagridviev satır sayısına eşit olup olmadığı kontrol eder
            {
                //Radiobuttonları her tıklamasını engeller
                rdbA.Enabled = false;
                rdbB.Enabled = false;
                rdbC.Enabled = false;
                rdbD.Enabled = false;

                btnSonraki.Enabled = false; //sonraki butonunu tıklanmasını engeller
                btnSinavBitir.Enabled = false;  //Sınav bitir butonunu tıklanmasını engeller
                btnBasla.Enabled = false;  //Başla butonunu tıklanmasını engeller
                lsvRapor.Visible = true; //Listviev görünürlüğünü engeller
                btnRapor.Enabled = true; //Rapor butonunu tıklanmasını engeller
                return;
            }
            rdbA.Checked = false; rdbB.Checked = false; rdbC.Checked = false; rdbD.Checked = false;  //Radiobuttonları her tıklamadan sonra temizler
        }

        private void btnSinavBitir_Click(object sender, EventArgs e)
        {
            //Radiobuttonları her tıklamasını engeller
            rdbA.Enabled = false;
            rdbB.Enabled = false;
            rdbC.Enabled = false;
            rdbD.Enabled = false;

            btnRapor.Enabled = true; //Rapor butonunu tıklanmasını engeller
            btnSonraki.Enabled = false; //sonraki butonunu tıklanmasını engeller
            lsvRapor.Visible = true;    //Listviev görünürlüğünü engeller
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamayı kapatır
        }

        private void btnGirisSayfası_Click(object sender, EventArgs e)
        {
            //Giriş sayfasına yönlendirir
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Öğrenci sayfasına yönlendirir
            frmOgrenci frmOgrenci = new frmOgrenci();
            frmOgrenci.Show();
            this.Hide();
        }

        private void frmDenemeSinav_Load(object sender, EventArgs e)
        {
            UserIDCek(); //UserIDCek fonksiyonu çağrılır

            db.baglanti.Open();
            string veriler = "SELECT Question.QuestionID From Question INNER JOIN Sections ON Question.SectionID = Sections.SectionID INNER JOIN Sinav ON  Question.QuestionID = Sinav.QuestionID where Sinav.UserID = '" + UserID + "' and Sinav.CorrectAnswerCount < 4"; //Soru doğru sayısı 4'ten küçük olan soruların Kullanıcı bilgisine veritabanından çeker
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler); //VerileriGoster fonksiyonu çağrılır
            SiraylaGetir();  //Sirayla fonksiyonu çağrılır
            dataGridView1.Visible = true; //Datagridviev'in görünürlüğünü engeller
            lsvRapor.View = View.Details;
            lsvRapor.FullRowSelect = true;
            //Listvievdeki bilgilerinin konum ve genişlik bilgileri ayarlanır
            lsvRapor.Columns.Add("Soru", 50, HorizontalAlignment.Center);
            lsvRapor.Columns.Add("VerilenCevap", 105, HorizontalAlignment.Center);
            lsvRapor.Columns.Add("DogruCevap", 100, HorizontalAlignment.Center);
            lsvRapor.View = View.Details;

            lsvRapor.Visible = false;  //Listviev görünürlüğünü engeller
            rtbSoru.ReadOnly = true; // Soru Texte kullanıcı tarafından veri girmesini engeller
            // RadioButton Texte kullanıcı tarafından veri girmesini engeller
            txtA.ReadOnly = true;
            txtB.ReadOnly = true;
            txtC.ReadOnly = true;
            txtD.ReadOnly = true;
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:\\Users\\Alptekin\\Desktop\\Deneme Sınav Raporu.pdf", FileMode.Create)); //Raporun oluşacağı dosya yolunu belirtir
            rapor.AddAuthor("Alptekin Bağ");
            rapor.AddCreationDate();
            rapor.AddCreator("Sigma Sınav Program");
            rapor.AddSubject("Sınav Sonucu");
            rapor.AddKeywords("Sigma Sınav");
            if (rapor.IsOpen() == false)  //Raporun Açılıp Açılmadığını kontrol eder
            {
                rapor.Open(); //Raporu açar
            }
            rapor.Add(new Paragraph(lsvRapor.Columns[0].Text + "        " + lsvRapor.Columns[1].Text + "            " + lsvRapor.Columns[2].Text)); //Raporda bulunacak bilgeleri rapora yazar
            for (int i = 0; i < lsvRapor.Items.Count; i++)
            {
                rapor.Add(new Paragraph(" " + lsvRapor.Items[i].Text + "            " + lsvRapor.Items[i].SubItems[1].Text + "                      " + lsvRapor.Items[i].SubItems[2].Text)); //Rapora veri ekler
            }
            rapor.Close();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            pbResim.Visible = true; //PictureBox görünğrlüğünü engeller
            rtbSoru.Visible = true; //Soru text görünğrlüğünü engeller
            btnRapor.Visible = true;  //Rapor butonun görünğrlüğünü engeller
            btnSinavBitir.Enabled = true; //Sınavı bitir butonunun tıklanılmasını engeller
            btnSinavBitir.Visible = true; //Sınavı bitir butonun görünğrlüğünü engeller
            btnSonraki.Enabled = true;  //sonraki butonunun tıklanılmasını engeller
            btnSonraki.Visible = true;  //sonraki butonunun Görünürlüğü engeller
            //RadioButton görünürlüğü engellenir
            txtA.Visible = true;
            txtB.Visible = true;
            txtC.Visible = true;
            txtD.Visible = true;
            // RadioButton tıklanılmasını engeller
            rdbA.Enabled = true;
            rdbB.Enabled = true;
            rdbC.Enabled = true;
            rdbD.Enabled = true;

            btnBasla.Enabled = false;  //başla butonunun tıklanılmasını engeller
        }
    }
}
