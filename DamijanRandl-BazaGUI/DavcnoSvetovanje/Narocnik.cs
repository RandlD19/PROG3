using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavcnoSvetovanje
{
    public class Narocnik
    {
        private string davcna_stevilka;
        private string priimerk;
        private string ime;
        private string naslov;
        private string telefonska_st;
        private string elektronska_posta;
        private string datum;
        private int status;

        public Narocnik(string davcna_stevilka, string ime, string priimek, int status)
        {
            this.Davcna_stevilka = davcna_stevilka;
            this.Ime = ime;
            this.Priimek = priimek;
            this.Status = status;

        }

        public string Davcna_stevilka { get; set; }

        public string Ime { get; set; }

        public string Priimek { get; set; }

        public int Status { get; set; }
    }
}
