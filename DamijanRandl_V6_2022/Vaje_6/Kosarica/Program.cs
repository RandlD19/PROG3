using System;
using System.Collections.Generic;
using System.Linq;
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
            Registracija[] testna_tab = Registracija.ustvari_tab();
            Console.WriteLine("TESTNA_TAB:");
            Console.WriteLine("===================:");
            foreach (Registracija registracija in testna_tab)
            {
                Console.WriteLine(registracija);
            }
            Console.WriteLine();
            Console.WriteLine("REGISTRACIJE_IZ_OBMOCJA:");
            Console.WriteLine("===================:");
            Registracija.Registracije_iz_obmocja(testna_tab, "CE");

            Console.WriteLine("MIN_MAX:");
            Console.WriteLine("===================:");
            string[] min_max = Registracija.min_max_obmocje(testna_tab);
            Console.WriteLine(min_max);
            string[] stara_obmocja = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };

            string[] nova_obmocja = new string[stara_obmocja.Length];

            Console.WriteLine("NOVA_OBMOCJA:");
            Console.WriteLine("===================:");
            int i = 0;
            foreach (string obmocje in stara_obmocja)
            {
                if (!min_max.Contains(obmocje))
                {
                    nova_obmocja[i] = obmocje;
                    Console.WriteLine(obmocje);
                    i++;
                }

            }

            Registracija[] nova_tab = Registracija.Nova_tab_brez(nova_obmocja, testna_tab);
            Console.WriteLine("NOVA_TAB_BREZ:");
            Console.WriteLine("===================:");
            foreach (Registracija registracija1 in nova_tab)
            {
                Console.WriteLine(registracija1);
            }

        }


    }
}
