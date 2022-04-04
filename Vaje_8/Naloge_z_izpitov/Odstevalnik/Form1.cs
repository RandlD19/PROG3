using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odstevalnik
{
    public partial class Casovnik : Form
    {
        public Casovnik()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int st = int.Parse(this.cas.Text);
            st--;
            if (st==0)
            {
                Zacni_gumb.Hide();
                timer1.Stop();
            }
            cas.Text = st.ToString();
        }

        private void Ustavi_gumb_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Ponastavi_gumb_Click(object sender, EventArgs e)
        {
            this.cas.Text = "9";
            Zacni_gumb.Show();
        }
    }
}
