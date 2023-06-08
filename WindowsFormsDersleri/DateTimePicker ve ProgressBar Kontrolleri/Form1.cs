using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker_ve_ProgressBar_Kontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "İki tarih arasında " + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString()+ "dün vardır.";
            MessageBox.Show("iki tarih arasında " + (dateTimePicker2.Value - dateTimePicker1.Value).Days.ToString() + "dün vardırr.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int sayi = Convert.ToInt32(textBox2.Text);
                progressBar1.Maximum = sayi;
                for (int i = 0; i < sayi; i++)
                {
                    progressBar1.Value = i;
                }

            }
            else MessageBox.Show("Bir sayı giriniz!");
        }
    }
}
