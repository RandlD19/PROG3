using System;
using System.Linq;

namespace Osamljeni_sumniki
{
    class Program
    {
        /// <summary>
        /// Funkcija vrne število osamljenih šumnikov
        /// </summary>
        /// <param name="niz"> poljuben niz</param>
        /// <returns>vrne število</returns>
        static int OsamljeniSumniki(string niz)
        {
            int koliko;

            koliko = 0;

            char[] sumniki = new char[6] { 'č', 'ž', 'š', 'Č', 'Ž', 'Š' };

            if (niz.Length == 0)
            {
                return 0;
            }

            if (sumniki.Contains(niz[0]) && niz.Length == 1)
            {
                return 1;
            }

            if (sumniki.Contains(niz[0]) && !sumniki.Contains(niz[1]))
            {
                koliko++;
            }

            for (int i = 1; i < niz.Length - 1; i++)
            {
                if (sumniki.Contains(niz[i]) && !sumniki.Contains(niz[i - 1]) && !sumniki.Contains(niz[i + 1]))
                {
                    koliko++;
                }
            }

            if (sumniki.Contains(niz[niz.Length - 1]) && !sumniki.Contains(niz[niz.Length - 2]))
            {
                koliko++;
            }

            return koliko;
        }

        static void Main(string[] args)
        {
            // Testi za Osamljeni šumniki:
            Console.WriteLine("TESTNI PRIMERI: ");
            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 1: \"\" ");
                Console.WriteLine("Pričakovan rezultat: 0");
                Console.WriteLine(OsamljeniSumniki(""));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 2: \"k\"");
                Console.WriteLine("Pričakovan rezultat: 0");
                Console.WriteLine(OsamljeniSumniki("k"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 3: \"š\"");
                Console.WriteLine("Pričakovan rezultat: 1");
                Console.WriteLine(OsamljeniSumniki("š"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 4: \"abšdsščlusždč\"");
                Console.WriteLine("Pričakovan rezultat: 3");
                Console.WriteLine(OsamljeniSumniki("abšdsščlusždč"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 1: \"šš\"");
                Console.WriteLine("Pričakovan rezultat: 0");
                Console.WriteLine(OsamljeniSumniki("šš"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
