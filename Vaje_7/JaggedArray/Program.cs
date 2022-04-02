using System;

namespace JaggedArray
{
    class MainClass
    {
        static void Main(string[] args)
        {
            /*
            * S pomočjo zank izpiši naslednjo tabelo po vrsticah, ter nato določi največje število v glavni tabeli.
            * Preštej, koliko je vseh elementov v spodnji tabeli.
            */
            int[][] tabela = new int[4][];

            tabela[0] = new int[7] { 14, 25, 163, 44, 89, 334, 414 };
            tabela[1] = new int[5] { 22, 57, 77, 86, 23 };
            tabela[2] = new int[4] { 345, 56, 442, 135 };
            tabela[3] = new int[6] { 263, 144, 88, 55, 265, 248 };

            foreach (int[] tab in tabela)
            {
                string niz = String.Join(" : ", tab);
                Console.WriteLine(niz);
            }

            int max = tabela[0][0];
            int koliko = 0;
            foreach (int[] i in tabela)
            {
                foreach (int j in i)
                {
                    koliko++;
                    if (j > max)
                    {
                        max = j;
                    }
                }
            }
            Console.WriteLine(koliko);
            Console.WriteLine(max);

        }
    }
}
