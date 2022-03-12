using System;
using System.IO;

namespace To_je_moja_datoteka
{
    class To_je_moja_datoteka
    {
        static void Main(string[] args)
        {
            Console.Write("Napiši ime nove datoteke: ");
            string ime_dat = Console.ReadLine();
            string f = $"{ime_dat}.txt";
            if (!File.Exists(f))
            {
                StreamWriter pisanje = File.CreateText(f);
                pisanje.WriteLine("To je moja datoteka");
                pisanje.Close();
            }

            StreamReader branje = File.OpenText(f);
            string vrstica = branje.ReadLine();
            branje.Close();

            Console.WriteLine(vrstica);

            StreamWriter dodajanje = File.AppendText(f);
            Console.Write("Vnesi ime: ");
            string ime = Console.ReadLine();

            dodajanje.WriteLine(ime);
            dodajanje.Close();

            StreamReader novobranje = File.OpenText(f);
            int i = 0;
            while ((vrstica = novobranje.ReadLine()) != null)
            {
                i++;
                Console.WriteLine($"{i} :  {vrstica}");
            }
            novobranje.Close();

        }
    }
}
