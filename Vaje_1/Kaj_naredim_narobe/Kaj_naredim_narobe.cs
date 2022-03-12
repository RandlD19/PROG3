using System;

namespace Kaj_naredim_narobe
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            Console.WriteLine($"Za števila a, b in c seveda velja a+(b+c)=(a+b)+c, saj je {a} + ({b} + {c}) = ({a} + {b}) + {c}.");
        }
    }
}
