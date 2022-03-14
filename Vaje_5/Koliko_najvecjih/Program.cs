using System;

namespace Koliko_najvecjih
{
    class Program
    {
        /// <summary>
        /// Funkcija prešteje število največjih elementov v podani tabeli
        /// </summary>
        /// <typeparam name="T"> generični tip, pri katerem obstaja primerjanje </typeparam>
        /// <param name="tab"> tabela </param>
        /// <returns> vrne celo število </returns>
        public static int Koliko_najvecjih<T>(T[] tab) where T : IComparable<T>
        {
            T najvecji = tab[0];
            int koliko = 0;

            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i].CompareTo(najvecji) > 0)
                {
                    najvecji = tab[i];
                    koliko = 1;
                }
                else if (tab[i].CompareTo(najvecji) == 0)
                {
                    koliko++;
                }
            }
            return koliko;
        }


        static void Main(string[] args)
        {
            // Testi za Koliko največjih:
            try
            {
                Console.WriteLine("Testni primer 1:");
                Console.WriteLine(Koliko_najvecjih(new int[] { 1, 3, 5, 5, 5 }));
                Console.WriteLine(Koliko_najvecjih(new int[] { 1, 3, 5 }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Testni primer 2:");
                Console.WriteLine(Koliko_najvecjih(new char[] { '1', '3', '5' }));
                Console.WriteLine(Koliko_najvecjih(new char[] { '1', '3', '5', '5', '5' }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Testni primer 3:");
                Console.WriteLine(Koliko_najvecjih(new string[] { "asdf", "asdf", "kjof" }));
                Console.WriteLine(Koliko_najvecjih(new string[] { "asdf", "kjof" }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
