using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        double PrimNumar;
        string Operatie;

        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bad_Click(object sender, EventArgs e)
        {
            PrimNumar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            PrimNumar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "-";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            PrimNumar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            PrimNumar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operatie = "/";
        }

        private void be_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operatie == "+")
            {
                Result = (PrimNumar + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                PrimNumar = Result;
            }

            if (Operatie == "-")
            {
                Result = (PrimNumar - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                PrimNumar = Result;
            }

            if (Operatie == "*")
            {
                Result = (PrimNumar * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                PrimNumar = Result;
            }

            if (Operatie == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "error / 0";
                }
                else
                {
                    Result = (PrimNumar + SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    PrimNumar = Result;
                }
            }
        }

        private void bp_Click(object sender, EventArgs e)
        {
            // TBC
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
