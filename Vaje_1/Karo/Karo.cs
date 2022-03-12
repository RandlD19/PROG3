using System;

namespace Karo
{
    class Program
    {
        static void Karo_pomozna(int n)
        {
            int i = 1;
            string stevilo = $"{n}";
            int dolzina = stevilo.Length;
            int dolzina_niza = dolzina + dolzina - 1;
            while (i < dolzina+1)
            { 
                string niz = new string(' ', dolzina - i);
                string vmes = "";

                for (int j=1; j<=i; j++)
                {
                    if (j == i)
                    {
                        vmes += stevilo[j-1];
                    } else
                    {
                        vmes += stevilo[j-1] + " ";
                    }
                    
                }
                
                Console.WriteLine(niz + vmes + niz);

                i++;
            }

            i-=2;
            while (i > 0)
            {
                string niz = new string(' ', dolzina - i);
                string vmes = "";

                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                    {
                        vmes += stevilo[j - 1];
                    }
                    else
                    {
                        vmes += stevilo[j - 1] + " ";
                    }

                }

                Console.WriteLine(niz + vmes + niz);
                i--;
            }
            
        }

        static void Main(string[] args)
        {
            /* 
            Verzija 1:
            =================================
            string vnos = Console.ReadLine();

            char a = vnos[0];
            char b = vnos[1];
            char c = vnos[2];

            Console.WriteLine($"Vnešeno je število {vnos}");

            Console.WriteLine($"  {a}  ");
            Console.WriteLine($" {a} {b} ");
            Console.WriteLine($"{a} {b} {c}");
            Console.WriteLine($" {a} {b} ");
            Console.WriteLine($"  {a}  ");
            */

            int st_mest = int.Parse(Console.ReadLine());

            int st = new Random().Next((int)Math.Pow(10, st_mest-1), (int)Math.Pow(10, st_mest));

            Console.WriteLine($"Naključno število je {st}");

            Karo_pomozna(st);


        }
    }
}
