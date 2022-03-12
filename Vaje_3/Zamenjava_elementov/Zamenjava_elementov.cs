using System;

namespace Zamenjava_elementov
{
    class Zamenjava_elementov
    {
        static int[] Kopija(int[] t)
        {
            int dolzina = t.Length;
            int[] t_kopija = new int[dolzina];
            int i = 0;
            foreach (int el in t)
            {
                t_kopija[i] = el;
                i++;
            }
            return t_kopija;
        }

        static void Izpisi(string ime, int[] t) {
            Console.Write(ime);
            Console.Write("\t");
            foreach (int el in t)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 }; int[] b = Kopija(a);
            Console.WriteLine("Prej: "); Izpisi("a", a); Izpisi("b", b);
            a[1] = b[2]; a[2] = b[1];
            Console.WriteLine("Potem: "); Izpisi("a", a); Izpisi("b", b);
        }
    }
}
