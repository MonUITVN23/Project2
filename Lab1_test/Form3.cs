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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool Check(string s)
        {
            int num;
            return int.TryParse(s, out num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text.Trim();
            string s2 = textBox2.Text.Trim();
            string s3 = textBox3.Text.Trim();
            if (Check(s1) && Check(s2) && Check(s3))
            {
                int num1 = Int32.Parse(s1);
                int num2 = Int32.Parse(s2);
                int num3 = Int32.Parse(s3);

                int max = num1;
                int min = num1;
                if (num2 > max)
                    max = num2;
                if (num3 > max)
                    max = num3;
                if (num2 < min)
                    min = num2;
                if (num3 < min)
                    min = num3;
                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
            }
            else
                MessageBox.Show("Vui long nhap so nguyen: ");
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
