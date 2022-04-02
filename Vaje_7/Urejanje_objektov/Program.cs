using System;
using System.Collections.Generic;

namespace Urejanje_objektov
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            int ind_prvega_praznega = 0;
            //List<Kolo_urejen> tab_koles = new List<Kolo_urejen>();

            Kolo_urejen[] tab_koles = new Kolo_urejen[10];

            string[] barve = new string[] { "rdeča", "modra", "zelena", "rumena" };
            string[] tipi = new string[] { "gorsko", "cestno", "treking" };
            Random nakljucna_st = new Random();

            for (int i = 0; i < 7; i++)
            {
                int prestave = nakljucna_st.Next(1, 30);
                string tip = tipi[nakljucna_st.Next(0, 2)];
                string barva = barve[nakljucna_st.Next(0, 3)];
                int leto = nakljucna_st.Next(1950, 2022);
                int koliko_ljudi = nakljucna_st.Next(1, 3);

                //tab_koles.Add(new Kolo_urejen(prestave, barva, tip, leto, koliko_ljudi, i));

                tab_koles[i] = new Kolo_urejen(prestave, barva, tip, leto, koliko_ljudi, i);
                ind_prvega_praznega++;
            }


            Console.WriteLine("Tabela:");
            Console.WriteLine("===================");
            int j = 0;
            foreach (Kolo_urejen kolo in tab_koles)
            {
                if (j == ind_prvega_praznega)
                {
                    break;
                }
                Console.WriteLine(kolo);
                j++;
            }
            Console.WriteLine("===================");

            tab_koles[7] = tab_koles[3];
            tab_koles[8] = tab_koles[5];
            tab_koles[9] = tab_koles[3];

            Array.Sort(tab_koles);

            Console.WriteLine("Tabela:");
            Console.WriteLine("===================");
            foreach (Kolo_urejen kolo in tab_koles)
            {
                Console.WriteLine(kolo);
            }
            Console.WriteLine("===================");



        }
    }
}
