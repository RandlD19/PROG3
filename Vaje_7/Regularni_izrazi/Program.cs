using System;
using System.Text.RegularExpressions;

namespace Regularni_izrazi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Vnesi emšo: ");
            string vnos = Console.ReadLine();

            string vzorec = @"[0-3][0-9][0-1][0-9][0-9][0-9][0-9][5][0][0-5][0-9][0-9][0-9]";
            Regex rx = new Regex(vzorec);

            if (rx.IsMatch(vnos))
            {
                Console.WriteLine("Pravilen vnos");
            }
            else
            {
                Console.WriteLine("Nepravilen vnos");
            }
        }
    }
}
