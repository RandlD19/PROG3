using System;
using System.Collections.Generic;
using Razredi;


namespace Testi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Testi za razred Košarica:
            //Kosarica kosarica1 = new Kosarica();
            //kosarica1.Objekt = "objekt";

            //Kosarica kosarica2 = new Kosarica();
            //kosarica2.Objekt = 123;

            //Kosarica kosarica3 = new Kosarica();
            //kosarica3.Objekt = 1.23;

            //Kosarica kosarica4 = new Kosarica();
            //kosarica4.Objekt = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(kosarica1);
            //Console.WriteLine(kosarica2);
            //Console.WriteLine(kosarica3);
            //Console.WriteLine(kosarica4);

            // Kosarica kosarica5 = new Kosarica();
            // kosarica5.Objekt = "objekt";


            // Testi za Kolo:
            //string[] barve = new string[] { "rdeča", "modra", "zelena", "rumena" };
            //string[] tipi = new string[] { "gorsko", "cestno", "treking" };
            //Random nakljucna_st = new Random();
            //Kolo[] tab_koles = new Kolo[100];

            //for (int i = 0; i < 100; i++)
            //{
            //    int prestave = nakljucna_st.Next(1, 30);
            //    string tip = tipi[nakljucna_st.Next(0, 2)];
            //    string barva = barve[nakljucna_st.Next(0, 3)];
            //    int leto = nakljucna_st.Next(1950, 2022);
            //    int koliko_ljudi = nakljucna_st.Next(1, 3);

            //    tab_koles[i] = new Kolo(prestave, barva, tip, leto, koliko_ljudi);
            //}
            // zapis na datoteko
            //Kolo.dodaj_podatke(tab_koles);

            // branje iz datoteke
            //Kolo[] podatki = Kolo.preberi_podatke("podatkiKolesa.txt");

            // koliko je posameznih barv
            //Dictionary<string, int> slovar_barv = new Dictionary<string, int>();
            //int[] koliko = new int[barve.Length];
            //foreach (Kolo kolo in podatki)
            //{
            //    Console.WriteLine(kolo);
            //    if (slovar_barv.ContainsKey(kolo.Barva))
            //    {
            //        slovar_barv[kolo.Barva]++;
            //    }
            //    else
            //    {
            //        slovar_barv.Add(kolo.Barva, 1);
            //    }
            //}
            //foreach (string kljuc in slovar_barv.Keys)
            //{
            //    Console.WriteLine($"{kljuc}: {slovar_barv[kljuc]}");
            //}

            // "prebarvanje koles"
            //foreach (Kolo kolo in podatki)
            //{
            //    if (kolo.Barva == "rumena")
            //    {
            //        kolo.Barva = "rdeča";
            //    }
            //}



            // "koliko se jih lahko pelje s cestnimi kolesi"
            //int koliko_hkrati = 0;
            //foreach (Kolo kolo in podatki)
            //{
            //    if (kolo.Tip == "cestno")
            //    {
            //        koliko_hkrati += kolo.Koliko_ljudi;
            //    }
            //}
            //Console.WriteLine(koliko_hkrati);

            // odstranjevanje starih koles iz datoteke


            // Registracija

            foreach (Registracija registracija in Registracija.ustvari_tab())
            {
                Console.WriteLine(registracija);
            }



        }


    }
}
