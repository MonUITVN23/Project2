using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool Check(string s)
        {
            int num;
            return int.TryParse(s, out num);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s1 = textBox1.Text.Trim();
            string s2 = textBox2.Text.Trim();
            long sum = 0;
            if (Check(s1) && Check(s2))
            {
                int num1 = Int32.Parse(s1);
                int num2 = Int32.Parse(s2);

                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
                MessageBox.Show("Vui long nhap so nguyen: ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
