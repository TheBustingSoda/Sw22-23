using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            double amt = 0;
            double.TryParse(textBox1.Text, out amt);
            this.BackColor = SystemColors.Control;
            if (amt < 500)
            {
                this.BackColor = Color.Red;
                clear();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            double amt = 0;

            double.TryParse(textBox5.Text, out amt);
            label1.Text = (amt * 0.03).ToString();
            this.BackColor = SystemColors.Control;
            if (amt > 500)
                this.BackColor = Color.Red;
            clear();
        }

    }

}
