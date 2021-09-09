using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖRNEK3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            sonuç = sayı2 + sayı1;
            label1.Text =Convert.ToString( sonuç);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            sonuç = sayı1 - sayı2;
            label1.Text = Convert.ToString(sonuç);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            sonuç = sayı2 * sayı1;
            label1.Text = Convert.ToString(sonuç);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            sonuç = sayı1 / sayı2;
            label1.Text = Convert.ToString(sonuç);
        }
    }
}
