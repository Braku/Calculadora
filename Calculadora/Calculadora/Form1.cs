using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = restb;
            restb.Focus();
        }

        double a;
        double b;
        string c;
       // int bandera;

        private void B0_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "0";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "0";
                this.restb.Focus();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "1";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "1";
                this.restb.Focus();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "2";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "2";
                this.restb.Focus();
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "3";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "3";
                this.restb.Focus();
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "4";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "4";
                this.restb.Focus();
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "5";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "5";
                this.restb.Focus();
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "6";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "6";
                this.restb.Focus();
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "7";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "7";
                this.restb.Focus();
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "8";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "8";
                this.restb.Focus();
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "9";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + "9";
                this.restb.Focus();
            }
        }

        private void Bpunt_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = ".";
                this.restb.Focus();
            }
            else
            {
                restb.Text = restb.Text + ".";
                this.restb.Focus();
            }
        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.restb.Text);
            c = "/";
            this.restb.Clear();
            this.restb.Focus();
        }

        private void Bigu_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.restb.Text);
            switch (c)
            {
                case "+":
                    this.restb.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.restb.Text = Convert.ToString(b - a);
                    break;

                case "*":
                    this.restb.Text = Convert.ToString(b * a);
                    break;
                                       
                case "/":
                    this.restb.Text = Convert.ToString(b / a);
                    break;

            }

        }

        private void Bmult_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.restb.Text);
            c = "*";
            this.restb.Clear();
            this.restb.Focus();
        }

        private void Bres_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.restb.Text);
            c = "-";
            this.restb.Clear();
            this.restb.Focus();
        }

        private void Bmas_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.restb.Text);
            c = "+";
            this.restb.Clear();
            this.restb.Focus();
        }

        private void Bce_Click(object sender, EventArgs e)
        {

            if (restb.Text.Length == 1)
            {
                restb.Text = "";
            }
            else
            {
                restb.Text = restb.Text.Substring(0, restb.Text.Length - 1);
            }
        }

        private void Bpo_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.restb.Text);
            c = "%";
            this.restb.Text = Convert.ToString(a / 100);
            this.restb.Focus();
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble("0");
            b = Convert.ToDouble("0");
            this.restb.Text = "";
            this.restb.Focus();
        }

        private void Restb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bigu.PerformClick();
                this.restb.Focus();
            }
            if (e.KeyChar == 43)
            {
                bmas.PerformClick();
                this.restb.Focus();
            }
            else if (e.KeyChar == 45)
            {
                bres.PerformClick();
                this.restb.Focus();
            }
             else if (e.KeyChar == 42)
            {
                bmult.PerformClick();
                this.restb.Focus();
            }
            else if (e.KeyChar == 47)
            {
                bdiv.PerformClick();
                this.restb.Focus();
            }
            else if (e.KeyChar == 37)
            {
                bpo.PerformClick();
                this.restb.Focus();
            }
        }

    }
}
