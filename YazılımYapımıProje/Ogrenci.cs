using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıProje
{
    public partial class FrmOgrenci : Form
    {
        DataBase db = new DataBase();
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Sinav s = new Sinav();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SigmaSinav ss = new SigmaSinav();
            ss.Show();
            this.Hide();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(dateTimePicker2.Value.Year ,dateTimePicker2.Value.Month ,dateTimePicker2.Value.Day);/*
            dateTimePicker4.Value = new DateTime(dateTimePicker3.Value.Year,dateTimePicker3.Value.Month+1,dateTimePicker3.Value.Day+30);
            dateTimePicker5.Value = new DateTime(dateTimePicker4.Value.Year,dateTimePicker4.Value.Month+2 ,dateTimePicker4.Value.Day+60);
            dateTimePicker6.Value = new DateTime(dateTimePicker5.Value.Year,dateTimePicker5.Value.Month+5 ,dateTimePicker5.Value.Day+90);*/

            if (dateTimePicker1.Value==monthCalendar1.TodayDate)
            {
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
                button2.Text = "Sigma sınav sürenizi değiştiriniz";
            }

        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == monthCalendar1.TodayDate)
            {
                button2.Enabled = true;

            }
            else
            {
                button2.Enabled = false;
                button2.Text = "Sigma sınav sürenizi değiştiriniz";
            }
        }
    }
}
