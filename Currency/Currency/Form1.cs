using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox7.Text.Tryparse(usd);
            Convert(textBox7.Text);
        }
        public void Convert(string input)
        {
            double usd = 0;
            double.TryParse(input, out usd);
            double eur = usd * 1.00;
            double gbp = usd * 0.85;
            double krw = usd * 0.00075;
            double jpy = usd * 137.08;
            double cad = usd * 1.30;
            double rub = usd * 60.38;

            textBox1.Text = eur.ToString();
            textBox2.Text = gbp.ToString();
            textBox3.Text = krw.ToString();
            textBox4.Text = jpy.ToString();
            textBox5.Text = cad.ToString();
            textBox6.Text = rub.ToString();
        }
    }
}
