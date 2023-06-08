using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statikKullaniciGirişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanici.Text))//txtkullanici boşsa 
            {
                MessageBox.Show("Kullanıcı adı boş geçilmez");

            }

            else if(string.IsNullOrWhiteSpace(txtsifre.Text))//txtsifre boşsa{
            {
                MessageBox.Show("Şİfre boş geçilmez");
              
            }
            else if (string.IsNullOrWhiteSpace(txtkullanicikodu.Text))//txtkullanıcıkodu boşsa 
            {
                MessageBox.Show("kullanıcı kodu boş geçilmez");
            }

            else
            {
                string DbkullaniciAdi = "Admin";
                string DbSifre = "1234";
                string DbKullaniciKodu = "ABC";
                if(txtkullanici.Text==DbkullaniciAdi && txtkullanicikodu.Text == DbKullaniciKodu && txtsifre.Text == DbSifre)
                {
                    MessageBox.Show("Hoşgeldin" + txtkullanici.Text);
                    groupBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Girilen bilgilerle eşleşen bir kullanıcı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }


            }

        }
    }
}
