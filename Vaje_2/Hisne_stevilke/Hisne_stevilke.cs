using System;

namespace Hisne_stevilke
{
    class Hisne_stevilke
    {

        static void Main(string[] args)
        {
            Console.Write("Vnesi prvo številko: ");
            int prvo_st = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zadnjo številko: ");
            int zadnja_st = int.Parse(Console.ReadLine());

            int[] tab_stevk = new int[10];

            for (int i = prvo_st; i<=zadnja_st; i++)
            {
                string niz = i.ToString();
                for (int j = 0; j<niz.Length; j++)
                {
                    string stevka = niz[j].ToString();
                    tab_stevk[int.Parse(stevka)] += 1;
                }

            }

            for (int i = 0; i < tab_stevk.Length; i++)
            {
                Console.WriteLine($"{i}: {tab_stevk[i]}x");
            }

        }
    }
}
