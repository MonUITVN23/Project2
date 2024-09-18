namespace Lab1_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 Lab1_Bai1 = new Form2();
            Lab1_Bai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Lab1_Bai2 = new Form3();
            Lab1_Bai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Lab1_Bai3 = new Form4();
            Lab1_Bai3.ShowDialog();
        }
    }
}
