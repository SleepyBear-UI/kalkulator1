using System.Drawing.Imaging;

namespace kalkulator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 0, b = 0, hasil = 0;
        string angka;
        bool ples = false;
        private void button1_Click(object sender, EventArgs e)
        {
            a = 1;
            label1.Text += " 1 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 2;
            label1.Text += " 2 ";
            if (ples)
            {
                hasil += a;
            }
            label1.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 3;
            label1.Text += " 3 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = 4;
            label1.Text += " 4 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = 5;
            label1.Text += " 5 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = 6;
            label1.Text += " 6 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = 8;
            label1.Text += " 8 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = 7;
            label1.Text += " 7 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = 9;
            label1.Text += " 9 ";
            if (ples)
            {
                hasil += a;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            a = 0;
            label1.Text += " 0 ";
            if (ples)
            {
                hasil += a;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

            hasil = Convert.ToInt32(label1.Text);
            a += hasil;
            ples = true;
            label1.Text += " + ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil = a + b;
            label1.Text = hasil.ToString();
        }
    }
}
