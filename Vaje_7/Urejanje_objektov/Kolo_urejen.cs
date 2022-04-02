using System;
using System.IO;
using System.Collections;

namespace Urejanje_objektov
{
    public class Kolo_urejen : IComparable<Kolo_urejen>
    {
        private int prestave;
        private string barva;
        private string tip;
        private int leto_izdelave;
        private int koliko_ljudi;
        private int indeks;

        public Kolo_urejen(int prestave, string barva, string tip, int leto_izdelave, int koliko_ljudi, int indeks)
        {
            this.Prestave = prestave;
            this.Barva = barva;
            this.Tip = tip;
            this.Leto_izdelave = leto_izdelave;
            this.Koliko_ljudi = koliko_ljudi;
            this.Indeks = indeks;
        }

        public static void dodaj_podatke(Kolo_urejen[] podatki)
        {
            string datoteka = "podatkiKolesa.txt";
            if (!File.Exists(datoteka))
            {
                StreamWriter pisanje = File.CreateText(datoteka);
                int i = 1;
                foreach (Kolo_urejen podatek in podatki)
                {
                    pisanje.WriteLine($"{i}.) {podatek.Prestave} {podatek.Barva} {podatek.Tip} {podatek.Leto_izdelave} {podatek.Koliko_ljudi}");
                    i++;
                }
                pisanje.Close();
            }
        }

        public static Kolo_urejen[] preberi_podatke(string datoteka)
        {
            StreamReader branje = File.OpenText(datoteka);
            string vrstica = "";
            Kolo_urejen[] tab_koles = new Kolo_urejen[100];
            int i = 0;
            while ((vrstica = branje.ReadLine()) != null)
            {
                string[] podatki = vrstica.Split(' ');
                tab_koles[i] = new Kolo_urejen(int.Parse(podatki[1]), podatki[2], podatki[3], int.Parse(podatki[4]), int.Parse(podatki[5]), i);
                i++;
            }
            branje.Close();
            return tab_koles;
        }

        public int CompareTo(Kolo_urejen nov)
        {
            if (this.Leto_izdelave < nov.Leto_izdelave)
            {
                return -1;
            }
            else if (this.Leto_izdelave == nov.Leto_izdelave)
            {
                if (this.Indeks < nov.Indeks)
                {
                    return -1;
                }
                else { return 1; }
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return $"Število prestav: {this.Prestave} ; Barva: {this.Barva} ; Tip: {this.Tip} ; Leto izdelave: {this.Leto_izdelave} ; Za koliko ljudi je namenjeno: {this.Koliko_ljudi}";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
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

        public int Indeks
        {
            get { return indeks; }
            set { indeks = value; }
        }

    }
}
