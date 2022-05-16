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
    public partial class frmSigmaSinav : Form
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

        public void deneme() {

            if (buttonIndex >= dataGridView1.Rows.Count || dataGridView1.Rows[buttonIndex].IsNewRow)
                buttonIndex = 0;

            if (dataGridView1.AllowUserToAddRows == true)
            {
                if (dataGridView1.RowCount > 1)
                {
                    x = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();
                }

                else
                    textBox1.Text = "";
            }
            else
            {
                if (dataGridView1.RowCount > 0)
                {

                    x = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[buttonIndex].Cells["QuestionID"].Value.ToString();
                    SoruCek();

                }

                else
                    textBox1.Text = "";
            }
            buttonIndex++;

        }
        public void SoruCek()
        {
             db.baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select QuestionText,PicturePath,RightAnswer,a,b,c,d from Sinav INNER JOIN  Question on Question.QuestionID=Sinav.QuestionID where UserID = 20 and CorrectAnswerCount < 4", db.baglanti); 

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
                 label2.Text = kontrol["RightAnswer"].ToString();

             }
             else
             {
                 MessageBox.Show("veritabanı hatası");
             }
             db.baglanti.Close();
        }
        public frmSigmaSinav()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOgrenci ogrnci=new frmOgrenci();
            ogrnci.Show();
            this.Hide();
        }

        private void SigmaSinav_Load(object sender, EventArgs e)
        {
            UserIDCek();
            db.baglanti.Open();
            string veriler = "SELECT Question.QuestionID From Question INNER JOIN Sections ON Question.SectionID = Sections.SectionID INNER JOIN Sinav ON  Question.QuestionID = Sinav.QuestionID where Sinav.UserID = 20 and Sinav.CorrectAnswerCount < 4";
            SqlCommand komut = new SqlCommand(veriler, db.baglanti);
            komut.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(veriler);
            deneme();
            label1.Text = "0";
            timer1.Interval = 60000;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            dataGridView1.Visible = true;
        }
        int zamansayac = 0;
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            sayac++;
            deneme();
            timer1.Start();
           
            if (dataGridView1.Rows.Count == sayac)
            {
                button1.Text = "Sınavı Bitir";
                button1.Enabled = false;
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zamansayac++;
            label1.Text = zamansayac.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

            progressBar1.Value = zamansayac * 10;
        }
    }
}
