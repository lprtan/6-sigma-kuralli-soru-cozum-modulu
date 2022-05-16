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
        frmDenemeSinav sinav = new frmDenemeSinav();
        DataSet ds = new DataSet();
        public int UserID { get; set; }
        public frmOgrenciRapor()
        {
            InitializeComponent();
        }
        public void verileriGoster(string veriler)
        {
            SqlDataAdapter dz = new SqlDataAdapter(veriler, db.baglanti);
            dz.Fill(ds);
            dvgOgrenciRapor.DataSource = ds.Tables[0];
        }
        
        private void frmOgrenciRapor_Load(object sender, EventArgs e)
        {
            UserID = sinav.UserIDCek();
            db.baglanti.Open();
            string RaporVerileri = "SELECT Sections.SectionName,Sinav.CorrectAnswerCount*16.67 As BaşarıOranı From Question INNER JOIN Sections ON Question.SectionID = Sections.SectionID INNER JOIN Sinav ON  Question.QuestionID = Sinav.QuestionID where Sinav.UserID ='" + UserID + "'";
            SqlCommand OgrenciRaporAl = new SqlCommand(RaporVerileri, db.baglanti);
            OgrenciRaporAl.ExecuteNonQuery();
            db.baglanti.Close();
            verileriGoster(RaporVerileri);  
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("RAPOR" + ".pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(dvgOgrenciRapor.Columns.Count);

            for (int j = 0; j < dvgOgrenciRapor.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dvgOgrenciRapor.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < dvgOgrenciRapor.Rows.Count; i++)
            {
                for (int k = 0; k < dvgOgrenciRapor.Columns.Count; k++)
                {
                    if (dvgOgrenciRapor[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dvgOgrenciRapor[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            doc.Close();
        }
    }
}
