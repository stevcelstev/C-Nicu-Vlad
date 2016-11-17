using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackgroundTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.BackColor = Color.Green;
            InitializeComponent();
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var colors = new[] { Color.CornflowerBlue, Color.Green, Color.Aqua, Color.Azure, Color.CadetBlue, Color.Pink };
            var index = DateTime.Now.Second % colors.Length;
            this.BackColor = colors[index];
        }
    }
}
