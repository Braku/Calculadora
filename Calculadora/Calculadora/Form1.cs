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
        double d;
        double f;
        double g;
        double h;
        string c;
       // int bandera;

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

        private void Bigu_Click(object sender, EventArgs e)
        {

            b = Convert.ToDouble(this.restb.Text);
           // d = Convert.ToDouble(this.restb.Text);
           // f = Convert.ToDouble(this.restb.Text);
          //  g = Convert.ToDouble(this.restb.Text);
           // h = Convert.ToDouble(this.restb.Text);

            switch (c)

            {

                case "+":

                    //d = Convert.ToDouble(this.restb.Text);
                   // f = Convert.ToDouble(this.restb.Text);
                    this.restb.Text = Convert.ToString(b + a);
                   // this.restb.Text = Convert.ToString(b + a + d);
                    //this.restb.Text = Convert.ToString(b + a + d + f);
                   // this.restb.Text = Convert.ToString(b + a + d + f + g);
                  //  this.restb.Text = Convert.ToString(b + a + d + f + g + h);

                    break;



                case "-":

                    this.restb.Text = Convert.ToString(b - a - d - f - g - h);

                    break;



                case "*":

                    this.restb.Text = Convert.ToString(b * a * d * f * g * h);

                    break;



                case "/":

                    this.restb.Text = Convert.ToString(b / a / d / f / g / h);

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
            a = Convert.ToDouble("");
            b = Convert.ToDouble("");
            this.restb.Text = "";
        }

        private void B1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49)
            {
                B1_Click(sender, e);
            }

        }

        private void B2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 50)
            {
                B2_Click(sender, e);
            }

        }

        private void B3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 51)
            {
                B3_Click(sender, e);
            }

        }

        private void B4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 52)
            {
                B4_Click(sender, e);
            }

        }

        private void B5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 53)
            {
                B5_Click(sender, e);
            }

        }

        private void B6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 54)
            {
                B6_Click(sender, e);
            }

        }

        private void B7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 55)
            {
                B7_Click(sender, e);
            }

        }

        private void B8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 56)
            {
                B8_Click(sender, e);
            }

        }

        private void B9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 57)
            {
                B9_Click(sender, e);
            }

        }

        private void Bpunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                Bpunt_Click(sender, e);
            }

        }

        private void Bpo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 37)
            {
                Bpo_Click(sender, e);
            }

        }

        private void Bmas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 43)
            {
                Bigu_Click(sender, e);
            }

        }

        private void Bres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45)
            {
                Bres_Click(sender, e);
            }

        }

        private void Bdiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 47)
            {
                Bdiv_Click(sender, e);
            }

        }

        private void Bmult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 42)
            {
                Bmult_Click(sender, e);
            }

        }

        private void Bigu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Bigu_Click(sender, e);
            }

        }

        private void B0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48)
            {
                Bigu_Click(sender, e);
            }
        }

        private void Bpo_Click(object sender, EventArgs e)
        {
            if (restb.Text == "")
            {
                restb.Text = "%";
            }
            else
            {
                restb.Text = restb.Text + "%";
            }
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            this.restb.Text = ;
        }

        //private void Bc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 127)
            {
                Bc_Click(sender, e);
            }
        }
    }
}
