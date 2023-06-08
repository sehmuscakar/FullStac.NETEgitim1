using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip_ve_Trackbar_Kontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //trackbar kontrolü değer artış ya da azalış işlemleri yaptırmamızı sağlar
            trackBar1.Minimum= 10;
            trackBar1.Maximum= 20;
         trackBar1.TickFrequency= 2;
            textBox1.Text = "trackbar kullanımı";



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Tahoma", trackBar1.Value);
        }
    }
}
