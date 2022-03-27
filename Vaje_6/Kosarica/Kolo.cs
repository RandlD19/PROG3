using System;
using System.IO;

namespace Razredi
{
    public class Kolo
    {
        private int prestave;
        private string barva;
        private string tip;
        private int leto_izdelave;
        private int koliko_ljudi;

        public Kolo(int prestave, string barva, string tip, int leto_izdelave, int koliko_ljudi)
        {
            this.Prestave = prestave;
            this.Barva = barva;
            this.Tip = tip;
            this.Leto_izdelave = leto_izdelave;
            this.Koliko_ljudi = koliko_ljudi;
        }

        public static void dodaj_podatke(Kolo[] podatki)
        {
            string datoteka = "podatkiKolesa.txt";
            if (!File.Exists(datoteka))
            {
                StreamWriter pisanje = File.CreateText(datoteka);
                int i = 1;
                foreach (Kolo podatek in podatki)
                {
                    pisanje.WriteLine($"{i}.) {podatek.Prestave} {podatek.Barva} {podatek.Tip} {podatek.Leto_izdelave} {podatek.Koliko_ljudi}");
                    i++;
                }
                pisanje.Close();
            }
        }

        public static Kolo[] preberi_podatke(string datoteka)
        {
            StreamReader branje = File.OpenText(datoteka);
            string vrstica = "";
            Kolo[] tab_koles = new Kolo[100];
            int i = 0;
            while ((vrstica = branje.ReadLine()) != null)
            {
                string[] podatki = vrstica.Split(' ');
                tab_koles[i] = new Kolo(int.Parse(podatki[1]), podatki[2], podatki[3], int.Parse(podatki[4]), int.Parse(podatki[5]));
                i++;
            }
            branje.Close();
            return tab_koles;
        }

        public override string ToString()
        {
            return $"Število prestav: {this.Prestave} ; Barva: {this.Barva} ; Tip: {this.Tip} ; Leto izdelave: {this.Leto_izdelave} ; Za koliko ljudi je namenjeno: {this.Koliko_ljudi}";
        }

        public int Prestave
        {
            get { return prestave; }
            set { prestave = value; }
        }

        public string Barva
        {
            get { return barva; }
            set { barva = value; }
        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public int Leto_izdelave
        {
            get { return leto_izdelave; }
            set { leto_izdelave = value; }
        }

        public int Koliko_ljudi
        {
            get { return koliko_ljudi; }
            set { koliko_ljudi = value; }
        }
    }
}
