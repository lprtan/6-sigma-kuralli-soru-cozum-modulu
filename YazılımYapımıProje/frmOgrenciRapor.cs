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
        DataBase db=new DataBase();
        frmSigmaSinav sigmaSinav = new frmSigmaSinav();
        public int UserID { get; set; }
        public frmOgrenciRapor()
        {
            InitializeComponent();
        }
        public void verileriGoster(string veriler)
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            DataSet ds = new DataSet();
            dz.Fill(ds);
            dvgOgrenciRapor.DataSource = ds.Tables[0];
        }
        
        private void frmOgrenciRapor_Load(object sender, EventArgs e)
        {
            UserID = sigmaSinav.UserIDCek();
            db.baglanti.Open();
            string RaporVerileri = "SELECT Units.UnitName, Sinav.CorrectAnswerCount*16.67 As BaşarıOranı From Question INNER JOIN Units ON Question.UnitID = Units.UnitID INNER JOIN Sinav ON  Question.QuestionID = Sinav.QuestionID where Sinav.UserID = '"+ UserID+"'";
            SqlCommand OgrenciRaporAl = new SqlCommand(RaporVerileri, db.baglanti);
            OgrenciRaporAl.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(RaporVerileri);  
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:\\Users\\Alptekin\\Desktop\\Sigma Sınav Raporu.pdf", FileMode.Create));
            rapor.AddAuthor("Alptekin Bağ");
            rapor.AddCreationDate();
            rapor.AddCreator("Sigma Sınav Program");
            rapor.AddSubject("Sınav Sonucu");
            rapor.AddKeywords("Sigma Sınav");
            if (rapor.IsOpen() == false)
            {
                rapor.Open();
            }
            rapor.Add(new Paragraph("Bölüm         Basari Orani \n"));
            for (int i = 0; i < dvgOgrenciRapor.Rows.Count-1; i++)
            {
                rapor.Add(new Paragraph( dvgOgrenciRapor.Rows[i].Cells[0].Value.ToString() + "--------------->" + dvgOgrenciRapor.Rows[i].Cells[1].Value.ToString()));
            }
            MessageBox.Show("Rapor Oluşturuldu");
            rapor.Close();
        }
    }
}
