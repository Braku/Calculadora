using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        string c;

        private void B0_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "0";
            }
            else
            {
                restb.Text = restb.Text + "0";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "1";
            }
            else
            {
                restb.Text = restb.Text + "1";
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "2";
            }
            else
            {
                restb.Text = restb.Text + "2";
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "3";
            }
            else
            {
                restb.Text = restb.Text + "3";
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "4";
            }
            else
            {
                restb.Text = restb.Text + "4";
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "5";
            }
            else
            {
                restb.Text = restb.Text + "5";
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "6";
            }
            else
            {
                restb.Text = restb.Text + "6";
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "7";
            }
            else
            {
                restb.Text = restb.Text + "7";
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "8";
            }
            else
            {
                restb.Text = restb.Text + "8";
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "9";
            }
            else
            {
                restb.Text = restb.Text + "9";
            }
        }

        private void Bpunt_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = ".";
            }
            else
            {
                restb.Text = restb.Text + ".";
            }
        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.restb.Text);
            c = "/";
            this.restb.Clear();
            this.restb.Focus();
        }
    }
}
