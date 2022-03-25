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
    public partial class Form1 : Form
    {
        public int Authorize { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DELL-BILGISAYAR;Initial Catalog=Proje;Integrated Security=True;MultipleActiveResultSets=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKatıtOl_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  
            this.Hide();   
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand giris = new SqlCommand("select UserName=@Ad , Password=@Sifre  from Users where  UserTypeID=@UserID ", baglanti );
            giris.Parameters.AddWithValue("@Ad", textBox1.Text);
            giris.Parameters.AddWithValue("@Sifre", textBox2.Text);
            giris.Parameters.AddWithValue("@UserID", Authorize);
            SqlDataReader kontrol = giris.ExecuteReader();

            if (kontrol.Read()==true)
            {
              //  SqlCommand authorize = new SqlCommand("select * from Users where UserTypeID=@UserID",baglanti);
                
             //   SqlDataReader rd = authorize.ExecuteReader();
                
                    if (Authorize == 0)
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }
                    else if (Authorize == 1)
                    {
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                    }
                    else if (Authorize == 2)
                    {
                        Form5 form5 = new Form5();
                        form5.Show();
                        this.Hide();
                    }
 
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı tekrar giriniz");

            }
            baglanti.Close();
        }
    }
}