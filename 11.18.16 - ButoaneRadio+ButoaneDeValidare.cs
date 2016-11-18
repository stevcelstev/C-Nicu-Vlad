using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "Vom pleca in ";
            if (radioButton1.Checked) msg += radioButton1.Text;
            if (radioButton2.Checked) msg += radioButton2.Text;
            if (radioButton3.Checked) msg += radioButton3.Text;
            if (radioButton4.Checked) msg += radioButton4.Text;
            if (radioButton5.Checked) msg += radioButton5.Text;

            bool firstDest = false;
            if (checkBox1.Checked)
            {
                msg += " cu " + checkBox1.Text.ToLower() + "ul";
                firstDest = true;
            }
            if (checkBox2.Checked)
            {
                if (firstDest)
                    msg += " si cu " + checkBox2.Text.ToLower() + "ul";
                else
                    msg += " cu " + checkBox2.Text.ToLower() + "ul";
                
            }

            MessageBox.Show(msg + " !");
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
