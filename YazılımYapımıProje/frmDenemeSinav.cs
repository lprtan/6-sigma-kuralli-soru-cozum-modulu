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
    public partial class frmDenemeSinav : Form
    {

        DataBase db = new DataBase();
        public void verileriGoster(string veriler)
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            DataSet ds = new DataSet();
            dz.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private string x = null!;
        int buttonIndex = 0;
        int zamansayac = 0;
        int sayac = 0;
        public int UserID { get; set; }
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
                    return;
                }
            }
            else
            {
                if (dataGridView1.RowCount > 0)
                {

                    x = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();
                    return;
                }
            }
            buttonIndex++;
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
            sayac++;
            SiraylaGetir();
            if (dataGridView1.Rows.Count == sayac)
            {
                btnSonraki.Text = "Sınavı Bitir";
                btnSonraki.Enabled = false;
                tmrKronometre.Stop();
                return;
            }
        }

        private void btnSinavBitir_Click(object sender, EventArgs e)
        {
            frmOgrenci ogrnci = new frmOgrenci();
            ogrnci.Show();
            this.Hide();
        }

        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            zamansayac++;
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
            string veriler = "SELECT Question.QuestionID From Question INNER JOIN Sections ON Question.SectionID = Sections.SectionID INNER JOIN Sinav ON  Question.QuestionID = Sinav.QuestionID where Sinav.UserID = 20 and Sinav.CorrectAnswerCount < 4";
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler);
            SiraylaGetir();
            lblSure.Text = "0";
            tmrKronometre.Interval = 6000;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            tmrKronometre.Start();
            dataGridView1.Visible = true;
        }
    }
}
