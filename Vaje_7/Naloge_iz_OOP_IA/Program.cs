using System;
using System.IO;

namespace Naloge_iz_OOP_IA
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            //TESTI:
            //string datoteka = "Bagri.txt";

            Bager[] tab_bagrov = new Bager[100];
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Bager bager = new Bager(random.Next(1000, 100000), $"Bager{i}", random.Next(1990, DateTime.Now.Year), random.Next(1, 1000000));
                tab_bagrov[i] = bager;
            }

            // NAREDI DATOTEKO:
            //Bager.TvoriDatoteko(datoteka, 100);
            //Bager.IzpisiDatoteko(datoteka);
            //(Bager[], int) par_podatkov = Bager.PreberiZDatoteke(datoteka);
            //Bager[] tab_bagrov = par_podatkov.Item1;
            //int ind_zasedenosti = par_podatkov.Item2;
            //IzpisiTabelo(tab_bagrov, ind_zasedenosti);

            //NAJTEŽJI BAGER
            Bager najtezji_bager = tab_bagrov[0];
            foreach (Bager bager in tab_bagrov)
            {
                if (bager.Teza > najtezji_bager.Teza)
                {
                    najtezji_bager = bager;
                }
            }

            Console.WriteLine(najtezji_bager.Teza);

            //SPREMENI CENO:
            //foreach (Bager bager in tab_bagrov)
            //{
            //    if (bager.Cena > 20000)
            //    {
            //        bager.Cena = (int)(bager.Cena - bager.Cena * 0.1);
            //    }
            //}
            //IzpisiTabelo(tab_bagrov);

            //UREDI PO LETU:
            //Array.Sort(tab_bagrov);
            //IzpisiTabelo(tab_bagrov);

            //IZLOČI STAREJŠE BAGRE:
            //Bager[] tab_bagrov2 = new Bager[tab_bagrov.Length];
            //int j = 0;
            //foreach (Bager bager in tab_bagrov)
            //{
            //    if (DateTime.Now.Year - bager.Leto <= 12)
            //    {
            //        tab_bagrov2[j] = bager;
            //        j++;
            //    }

            //}
            //tab_bagrov = tab_bagrov2;

            //IzpisiTabelo(tab_bagrov, ind_zasedenosti);

            //IZPIŠI NA VEČ DATOTEK (ŠE NE DELJUJE)
            //for (int i = 0; i < tab_bagrov.Length; i++)
            //{
            //    int leto = tab_bagrov[i].Leto;
            //    string dat = $"Bagri{leto}.txt";
            //    StreamWriter pisanje = File.CreateText(dat);
            //    int j = i;
            //    while (tab_bagrov[j].Leto == leto)
            //    {
            //        Bager bager = tab_bagrov[j];
            //        bager.DodajNaDatoteko($"Bagri{bager.Leto}.txt", pisanje);
            //        j++;
            //    }
            //    i = j;
            //    pisanje.Close();
            //}


        }
        public static void IzpisiTabelo(Bager[] tab_bagrov, int ind_zasedenosti)
        {
            Console.WriteLine("Tabela 2:");
            Console.WriteLine("===================");
            int ind = 0;
            foreach (Bager bager in tab_bagrov)
            {
                if (ind > ind_zasedenosti)
                {
                    break;
                }
                Console.WriteLine(bager);
                ind++;
            }
            Console.WriteLine("===================");
        }
    }
}
