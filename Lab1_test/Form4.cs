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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textSoNguyen.Text.Trim());
            switch (num)
            {
                case 0:
                    textKetQua.Text = "Không"; break;
                case 1:
                    textKetQua.Text = "Một"; break;
                case 2:
                    textKetQua.Text = "Hai"; break;
                case 3:
                    textKetQua.Text = "Ba"; break;
                case 4:
                    textKetQua.Text = "Bốn"; break;
                case 5:
                    textKetQua.Text = "Năm"; break;
                case 6:
                    textKetQua.Text = "Sáu"; break;
                case 7:
                    textKetQua.Text = "Bảy"; break;
                case 8:
                    textKetQua.Text = "Tám"; break;
                case 9:
                    textKetQua.Text = "Chín"; break;
                default:
                    MessageBox.Show("Vui lòng nhập số từ 0 đến 9"); break;
            }
        }
    }
}
