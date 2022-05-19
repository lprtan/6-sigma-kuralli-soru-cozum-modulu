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
        DataBase db = new DataBase();
        public int UserID { get; set; }
        public int QuestionID { get; set; }
        public int CAC { get; set; }
        private string x = null!;
        int buttonIndex = 0;
        int zamansayac = 0;
        int sayac = 0;
        public void UserIDCek()
        {
            db.baglanti.Open();
            SqlCommand UserIDAl = new SqlCommand("select * from Users where UserName='" + frmGiris.AlinanKullaniciAdi.ToString() + "'", db.baglanti);
            UserIDAl.Connection = db.baglanti;
            SqlDataReader kontrol = UserIDAl.ExecuteReader();
            if (kontrol.Read())
            {
                UserID = Convert.ToInt16(kontrol["UserID"]);
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
        public void CorrectAnswerCount()
        {
            db.baglanti.Open();
            SqlCommand DogruSoruSayisi = new SqlCommand("SELECT * from Sinav where QuestionID='" + x + "' AND UserID= '" + UserID + "' ", db.baglanti);
            DogruSoruSayisi.Connection = db.baglanti;
            SqlDataReader DogruSoruSayisiKontrol = DogruSoruSayisi.ExecuteReader();

            if (DogruSoruSayisiKontrol.Read())
            {
                CAC = Convert.ToInt32(DogruSoruSayisiKontrol["CorrectAnswerCount"]);

                if (rdbA.Checked == true)
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = x;
                    string VerilenCevap = rdbA.Text;
                    string DogruCevap = lblDogruCevap.Text;
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                }
                else if (rdbB.Checked == true)
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = x;
                    string VerilenCevap = rdbB.Text;
                    string DogruCevap = lblDogruCevap.Text;
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };
                    listView1.Items.Add(new ListViewItem(bilgiler));

                }
                else if (rdbC.Checked == true)
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = x;
                    string VerilenCevap = rdbC.Text;
                    string DogruCevap = lblDogruCevap.Text;
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                }
                else if (rdbD.Checked == true)
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = x;
                    string VerilenCevap = rdbD.Text;
                    string DogruCevap = lblDogruCevap.Text;
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                }
                else
                {
                    DogruSoruSayisiKontrol.Close();
                    string Soru = x;
                    string VerilenCevap = "Cevap Verilmedi";
                    string DogruCevap = lblDogruCevap.Text;
                    string[] bilgiler = { Soru, VerilenCevap, DogruCevap };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                }
            }
            else
            {
                MessageBox.Show("Sınav bitmiştir \n Öğrenci sayfasına yönlendiriliyorsunuz....");
                frmOgrenci frmOgrenci = new frmOgrenci();
                frmOgrenci.Show();
                this.Close();
            }
            db.baglanti.Close();
        }
        public void SiraylaGetir()
        {

            if (buttonIndex >= dataGridView1.Rows.Count || dataGridView1.Rows[buttonIndex].IsNewRow)
                buttonIndex = 0;

            if (dataGridView1.AllowUserToAddRows == true)
            {
                if (dataGridView1.RowCount > 1)
                {
                    x = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();
                    buttonIndex++;
                    return;
                }
                else if (dataGridView1.RowCount > 0)
                {

                    x = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();
                    return;
                }
            }
        }
        public void SoruCek()
        {
            db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT QuestionID,QuestionText,PicturePath,RightAnswer,a,b,c,d FROM Question where QuestionID='" + x + "' ", db.baglanti); ;

            cmd.Connection = db.baglanti;
            SqlDataReader kontrol = cmd.ExecuteReader();

            if (kontrol.Read())
            {
                rtbSoru.Text = kontrol["QuestionText"].ToString();
                pbResim.ImageLocation = kontrol["PicturePath"].ToString();
                txtA.Text = kontrol["a"].ToString();
                txtB.Text = kontrol["b"].ToString();
                txtC.Text = kontrol["c"].ToString();
                txtD.Text = kontrol["d"].ToString();
                lblDogruCevap.Text = kontrol["RightAnswer"].ToString();


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
            CorrectAnswerCount();

            sayac++;
            SiraylaGetir();
            if (dataGridView1.Rows.Count == sayac)
            {
                btnSonraki.Text = "Sınavı Bitir";
                btnSonraki.Enabled = false;
                listView1.Visible = true;
                tmrKronometre.Stop();
                return;
            }
            rdbA.Checked = false; rdbB.Checked = false; rdbC.Checked = false; rdbD.Checked = false;
        }

        private void btnSinavBitir_Click(object sender, EventArgs e)
        {
            frmOgrenci ogrnci = new frmOgrenci();
            ogrnci.Show();
            this.Hide();
        }

        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            zamansayac--;
            lblSure.Text = zamansayac.ToString();
        }

        private void lblSure_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = zamansayac * 10;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisSayfası_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOgrenci frmOgrenci = new frmOgrenci();
            frmOgrenci.Show();
            this.Hide();
        }

        private void frmDenemeSinav_Load(object sender, EventArgs e)
        {
            UserIDCek();
            db.baglanti.Open();
            string veriler = "SELECT Question.QuestionID From Question INNER JOIN Sections ON Question.SectionID = Sections.SectionID INNER JOIN Sinav ON  Question.QuestionID = Sinav.QuestionID where Sinav.UserID = '" + UserID + "' and Sinav.CorrectAnswerCount < 4";
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler);
            SiraylaGetir();
            lblSure.Text = "0";
            tmrKronometre.Interval = 60000;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            tmrKronometre.Start();
            dataGridView1.Visible = true;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Soru", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("VerilenCevap", 105, HorizontalAlignment.Center);
            listView1.Columns.Add("DogruCevap", 100, HorizontalAlignment.Center);
            listView1.View = View.Details;
            listView1.Visible = false;
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:\\Users\\Alptekin\\Desktop\\Deneme Sınav Raporu.pdf", FileMode.Create));
            rapor.AddAuthor("Alptekin Bağ");
            rapor.AddCreationDate();
            rapor.AddCreator("Sigma Sınav Program");
            rapor.AddSubject("Sınav Sonucu");
            rapor.AddKeywords("Sigma Sınav");
            if (rapor.IsOpen() == false)
            {
                rapor.Open();
            }
            rapor.Add(new Paragraph(listView1.Columns[0].Text + "        " + listView1.Columns[1].Text + "            " + listView1.Columns[2].Text));
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                rapor.Add(new Paragraph(" " + listView1.Items[i].Text + "            " + listView1.Items[i].SubItems[1].Text + "                      " + listView1.Items[i].SubItems[2].Text));
            }
            rapor.Close();
        }
    }
}
