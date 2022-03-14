using System;

namespace Zoprna_sedmica
{
    class Program
    {
        /// <summary>
        /// za dano tabelo celih števil vrne tabelo z dvema elementoma
        /// (število števil, ki so deljiva s 7, in vsoto preostalih števil),
        /// iz dane tabele pa pobriše vsa števila, ki so deljiva s 7.
        /// </summary>
        /// <param name="tab"> tabela celih števil </param>
        /// <returns> vrne tabelo velikosti 2 </returns>
        public static int[] PoisciVII(int[] tab)
        {
            int[] vrni = new int[] { 0, 0 };
            foreach (int st in tab)
            {
                if (st % 7 == 0)
                {
                    vrni[0] += 1;
                }
                else
                {
                    vrni[1] += st;
                }
            }
            return vrni;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("TESTNI PRIMERI: ");
            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 1:");
                Console.WriteLine("Pričakovan rezultat: 0 : 0");
                Console.WriteLine("Rezultat: " + String.Join(" : ", PoisciVII(new int[] { })));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 2:");
                Console.WriteLine("Pričakovan rezultat: 0 : 10");
                Console.WriteLine("Rezultat: " + String.Join(" : ", PoisciVII(new int[] { 10 })));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 3:");
                Console.WriteLine("Pričakovan rezultat: 3 : 23");
                Console.WriteLine("Rezultat: " + String.Join(" : ", PoisciVII(new int[] { 1, 7, 5, 6, 7, 14, 4, 5, 2 })));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Testni primer 4:");
                Console.WriteLine("Pričakovan rezultat: 3 : 0");
                Console.WriteLine("Rezultat: " + String.Join(" : ", PoisciVII(new int[] { 0, 0, 0 })));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
