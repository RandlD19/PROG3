using System;
using System.IO;

namespace Datoteka_nakljucnih_stevil
{
    class Datoteka_nakljucnih_stevil
    {
        public static void Ustvari(string ime, int maxvrstic, int maxstevil, int maxvrednost)
        {
            string ime_pom = $"{ime}.txt";
            if (!File.Exists(ime_pom))
            {
                StreamWriter dat = File.CreateText(ime_pom);
                Random vr_rand = new Random();
                Random st_rand = new Random();
                Random stevilo = new Random();

                for (int vr = 0; vr < vr_rand.Next(maxvrstic); vr++)
                {
                    string niz = "";
                    for (int st = 0; st < st_rand.Next(maxstevil); st++)
                    {
                       
                        niz += stevilo.Next(maxvrednost);
                        niz += " ";
                    }
                    dat.WriteLine(niz);
                }
                dat.Close();
            }
            else
            {
                Console.WriteLine("Ta datoteka že obstaja!");
            }
            
        }
        


        static void Main(string[] args)
        {
            Console.Write("Vnesi ime datoteke: ");
            string ime = Console.ReadLine();
            Console.Write("Vnesi maksimalno število vrstic: ");
            int maxvrstic = int.Parse(Console.ReadLine());
            Console.Write("Vnesi maksimalno število števil v vrstici: ");
            int maxstevil = int.Parse(Console.ReadLine());
            Console.Write("Vnesi maksimalno število vrednosti: ");
            int maxvrednost = int.Parse(Console.ReadLine());
            Ustvari(ime, maxvrstic, maxstevil, maxvrednost);

            StreamReader sr = File.OpenText($"{ime}.txt");
            string vrst = sr.ReadLine();
            while (vrst != null)
            {
                Console.WriteLine(vrst);
                vrst = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
