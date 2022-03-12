using System;

namespace Knjiznica_metod
{
    class Knjiznica_metod
    {
        public static void PodvojiVelikost(ref int[] tab)
        {
            int dolzina = tab.Length;
            int[] nova_tab = new int[dolzina*2];
            int i = 0;
            foreach (int el in tab)
            {
                nova_tab[i] = el;
                i++;
            }
            tab = nova_tab;

        }

        public static int[] NakljucnaTabela(int d, int m)
        {
            int[] tab = new int[d];
            Random nak_st = new Random();

            for (int i = 0; i<tab.Length; i++)
            {
                tab[i] = nak_st.Next(1,m); 
            }
            return tab;
        }

        static void Main(string[] args)
        {
            /*
            int[] tab = { 1, 2, 3, 4 };
            Console.WriteLine($"Dolžina na začetku: {tab.Length}");
            PodvojiVelikost(ref tab);
            Console.WriteLine($"Dolžina na koncu: {tab.Length}");
            */

            int d = 6;
            int m = 100;
            int[] tab2 = NakljucnaTabela(d, m);
            Console.Write("Naključna tabela: ");
            foreach (int el in tab2)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();


        }
    }
}
