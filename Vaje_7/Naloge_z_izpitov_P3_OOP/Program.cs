using System;

namespace Naloge_z_izpitov_P3_OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TESTNI PROGRAM:
            //osnovni primer
            //========================
            Polonica polonica = new Polonica(1, 7);
            Console.WriteLine(polonica.Starost);
            Console.WriteLine(polonica.SteviloPik);
            Console.WriteLine(polonica);

            //izjeme
            //========================
            //polonica.Starost = 500;
            //polonica.SteviloPik = 22;
            //polonica.SteviloPik = 3;
            //polonica.SteviloPik = -1;
            //polonica.Starost = -5;

            //tabela pikapolonic
            //=============================
            Polonica[] tab_polonic = polonica * 10;
            Console.WriteLine("Tabela 1:");
            Console.WriteLine("===================");
            foreach (Polonica polonica1 in tab_polonic)
            {
                Console.WriteLine(polonica1);
            }
            Console.WriteLine("===================");

            Polonica[] tab_polonic2 = 10 * polonica;
            Console.WriteLine("Tabela 2:");
            Console.WriteLine("===================");
            foreach (Polonica polonica1 in tab_polonic)
            {
                Console.WriteLine(polonica1);
            }
            Console.WriteLine("===================");



        }
    }
}
