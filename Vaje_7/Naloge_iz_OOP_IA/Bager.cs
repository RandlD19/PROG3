using System;
using System.IO;
namespace Naloge_iz_OOP_IA
{
    public class Bager : IComparable<Bager>
    {
        private int teza;
        private string ime;
        private int leto;
        private int cena;

        public Bager()
        {
            this.teza = 10000;
            this.Ime = "Bager";
            this.leto = 2020;
            this.Cena = 50000;
        }

        public Bager(string niz)
        {
            string[] tab_podatkov = niz.Split(';');
            try
            {
                this.teza = int.Parse(tab_podatkov[0].Trim());
                this.Ime = tab_podatkov[1].Trim();
                this.leto = int.Parse(tab_podatkov[2].Trim());
                this.Cena = int.Parse(tab_podatkov[3].Trim());
            }
            catch (Exception ex)
            {
                throw new Exception("Napačni vnos. Vnos je oblike: \"teža; ime; leto_izdelave; cena\"");
            }
        }

        public Bager(int teza, string ime, int leto, int cena)
        {
            if (teza <= 0)
            {
                throw new Exception("Teža bagra mora biti pozitivno celo število!");
            }

            if (leto < 1990 || leto > DateTime.Now.Year)
            {
                throw new Exception("Leto izdelave mora biti pozitivno celo število med 1990 in letošnjim letom!");
            }

            this.teza = teza;
            this.Ime = ime;
            this.leto = leto;
            this.Cena = cena;
        }

        public int Teza
        {
            get { return teza; }
            set {; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public int Leto
        {
            get { return leto; }
            set {; }
        }

        public int Cena
        {
            get { return cena; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Cena bagra mora biti pozitivno celo število!");
                }
                cena = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Teza}; {this.Ime}; {this.Leto}; {this.Cena}";
        }

        public int CompareTo(Bager drugi)
        {
            if (this.Leto > drugi.Leto)
            {
                return 1;
            }
            else if (this.Leto == drugi.Leto)
            {
                if (this.Teza < drugi.Teza)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public void DodajNaDatoteko(string imeDatoteke, StreamWriter pisanje)
        {
            pisanje.WriteLine(this.ToString());
        }

        public static (Bager[], int) PreberiZDatoteke(string imeDatoteke)
        {
            int indeks_zasedenosti = 0;
            Bager[] tab_bagrov = new Bager[1000];
            StreamReader branje = File.OpenText(imeDatoteke);
            string vrstica;

            int i = 0;
            while ((vrstica = branje.ReadLine()) != null && i < 1000)
            {
                Bager bager = new Bager(vrstica);
                tab_bagrov[i] = bager;
                i++;
                indeks_zasedenosti++;
            }

            branje.Close();

            if (i == 1000)
            {
                throw new Exception("Preveliko število vrstic v datoteki");
            }

            return (tab_bagrov, indeks_zasedenosti);
        }

        public static void IzpisiDatoteko(string imeDatoteke)
        {
            StreamReader branje = File.OpenText(imeDatoteke);
            string vrstica;

            int i = 0;
            while ((vrstica = branje.ReadLine()) != null)
            {
                Bager bager = new Bager(vrstica);
                Console.WriteLine(bager);
                i++;
            }
            branje.Close();
        }

        public static void TvoriDatoteko(string imeDatoteke, int stElementov)
        {
            Random random = new Random();
            if (!File.Exists(imeDatoteke))
            {
                StreamWriter pisanje = File.CreateText(imeDatoteke);
                for (int i = 0; i < stElementov; i++)
                {
                    Bager bager = new Bager(random.Next(1000, 100000), $"Bager{i}", random.Next(1990, DateTime.Now.Year), random.Next(1, 1000000));
                    pisanje.WriteLine(bager);
                }
                pisanje.Close();

            }

        }

    }
}
