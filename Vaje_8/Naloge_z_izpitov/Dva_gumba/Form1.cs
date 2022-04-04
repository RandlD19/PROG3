using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dva_gumba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "<- pritisnjen";
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "pritisnjen ->";
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.label1.Text = "<- pritisnjen";
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            this.label1.Text = "pritisnjen ->";
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            this.label1.Text = "";
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            this.label1.Text = "";
        }
    }
}
