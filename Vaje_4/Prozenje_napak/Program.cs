using System;
using Lovljenje_napak;

namespace Prozenje_napak
{
    class Program
    {
        public static int preberiInt(string sporocilo)
        {
            bool konec = false;
            int vrni = 0;
            while (!konec)
            {
                Console.WriteLine(sporocilo);
                string beri = Console.ReadLine();
                try
                {
                    int st = int.Parse(beri);
                    konec = true;
                    vrni = st;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"NAPAKA: {beri} ni celo število!");
                }

            }

            return vrni;

        }

        public static void racunanje(int i)
        {
            int prvo;
            int drugo;
            string o;
            int rez;
            for (int j = 0; j < i; j++)
            {
                Random random = new Random();
                int operacija = random.Next(1, 4);

                if (operacija == 1)
                {
                    prvo = random.Next(1, 99);
                    drugo = random.Next(1, 100 - prvo);
                    o = " + ";
                    rez = prvo + drugo;
                }
                else if (operacija == 2)
                {
                    prvo = random.Next(1, 100);
                    drugo = random.Next(1, prvo);
                    o = " - ";
                    rez = prvo - drugo;
                }
                else
                {
                    prvo = random.Next(1, 20);
                    drugo = random.Next(1, 100 / prvo);
                    o = " * ";
                    rez = prvo * drugo;

                }
                string izpisi = prvo + o + drugo;



                while (preberiInt("Koliko je? " + izpisi) != rez)
                {
                    Console.WriteLine("Poskusi ponovno!");

                }
            }

        }
        public static bool vsebuje(int st, int[] tab)
        {

            foreach (int el in tab)
            {
                if (el.Equals(st))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Funkcija preverja ali je podana permutacija prava
        /// </summary>
        /// <param name="niz"> zacetni niz </param>
        /// <param name="n"> dolzina permutacije </param>
        /// <returns>Vrne true ali false</returns>
        public static bool prava_permutacija(string niz, int n)
        {
            int[] tab_st = new int[n];
            for (int i = 1; i < n + 1; i++)
            {
                tab_st[i - 1] = i;
            }

            string[] tab_nizov = niz.Split(", ");
            if (!tab_nizov.Length.Equals(n)) return false;
            foreach (string st_niz in tab_nizov)
            {
                try
                {
                    int st = int.Parse(st_niz);
                    if (vsebuje(st, tab_st))
                    {
                        tab_st[st - 1] = 0;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            foreach (int el in tab_st)
            {
                if (!el.Equals(0))
                {
                    return false;
                }

            }
            return true;
        }
        /// <summary>
        /// Verjetno ne najbolj optimalna funkcija:)
        /// </summary>
        /// <param name="n">Sprejeme stevilo n, ki pove katero permutacijo zelimo</param>
        /// <returns>Vrne permutacijo, ki je prava</returns>
        public static string Permutacija(int n)
        {
            while (true)
            {
                Console.Write($"Napiši permutacijo od 1 do {n}: ");
                string niz = Console.ReadLine();
                if (!prava_permutacija(niz, n))
                {
                    Console.WriteLine("Napaka, poskusi znova!");
                }
                else
                {
                    return niz;
                }
            }
        }

        static void Main(string[] args)
        {
            //racunanje(5);
            Console.WriteLine(Permutacija(5));
        }
    }
}
