using System;

namespace Lovljenje_napak
{
    class Program
    {
        public static int f(int i)
        {
            return 100 / (i % 3);
        }

        public static int[] tabeliraj(int n)
        {
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                try
                {
                    tab[i] = f(i);
                }
                catch (Exception ex)
                {
                    tab[i] = 0;
                }

            }
            return tab;
        }

        public static int preberiInt(string sporocilo)
        {
            bool konec = false;
            int vrni = 0;
            while (!konec)
            {
                Console.Write(sporocilo);
                string beri = Console.ReadLine();
                try
                {
                    int st = int.Parse(beri);
                    konec = true;
                    vrni = st;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"NAPAKA: {beri} ni celo število.");
                }

            }
            return vrni;

        }


        static void Main(string[] args)
        {
            // Console.WriteLine($"[{String.Join(", ", tabeliraj(10))}]");
            Console.WriteLine(preberiInt("Vnesi celo število: "));


        }
    }
}
