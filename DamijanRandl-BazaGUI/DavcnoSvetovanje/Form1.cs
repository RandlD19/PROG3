using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavcnoSvetovanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Cyan;
            this.narocniki_listBox.BackColor = Color.Yellow;
            osvezi_narocnike();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dodaj_gumb_Click(object sender, EventArgs e)
        {
            string davcna_stevilka = this.davcna_testBox.Text;
            string ime = this.ime_textBox.Text;
            string priimek = this.priimek_textBox.Text;
            int status = int.Parse(this.status_comboBox.SelectedItem.ToString());

            Narocnik narocnik = new Narocnik(davcna_stevilka, ime, priimek, status);
            Model.DodajNarocnika(narocnik);

            this.davcna_testBox.Clear();
            this.ime_textBox.Clear();
            this.priimek_textBox.Clear();
            this.naslov_textBox.Clear();
            osvezi_narocnike();
        }

        private void osvezi_narocnike()
        {
            this.narocniki_listBox.Items.Clear();
            foreach (Narocnik narocnik in Model.IzpisiNarocnike())
            {
                string niz = $"{narocnik.Ime}  {narocnik.Priimek}  {narocnik.Status}  {narocnik.Davcna_stevilka}";
                this.narocniki_listBox.Items.Add(niz);
            }
        }

        private void osvezi_gumb_Click(object sender, EventArgs e)
        {
            osvezi_narocnike();
        }
    }
}
