using System;
using System.Data;
using System.IO;


namespace Mnozimo_se
{
    class Program
    {
        /// <summary>
        /// Funkcija iz podanega niz prebere števec in imenovalec ulomka
        /// </summary>
        /// <param name="niz">niz ki predstavlja ulomek</param>
        /// <returns>vrne tabelo velikosti dva [stevec, imenovalec]</returns>
        static int[] Izlusci_stevec_in_imenovalec(string niz)
        {
            string stevec = "";
            string imenovalec = "";
            int i = 0;
            int imenovalec_st;
            while (i < niz.Length && niz[i] != '/')
            {
                stevec += niz[i];
                i++;
            }
            i++;
            while (i < niz.Length)
            {
                imenovalec += niz[i];
                i++;
            }
            int stevec_st = int.Parse(stevec);
            if (imenovalec == "")
            {
                imenovalec_st = 1;
            }
            else
            {
                imenovalec_st = int.Parse(imenovalec);
            }


            return new int[2] { stevec_st, imenovalec_st };
        }


        static void Main(string[] args)
        {
            // Za funkcijo eval
            DataTable dt = new DataTable();
            string dat = "stevila.txt";
            StreamReader branje = File.OpenText(dat);
            string vrstica = branje.ReadLine();
            int stevec = 1;
            int imenovalec = 1;
            stevec *= Izlusci_stevec_in_imenovalec(vrstica)[0];
            imenovalec *= Izlusci_stevec_in_imenovalec(vrstica)[1];
            while ((vrstica = branje.ReadLine()) != null)
            {
                stevec *= Izlusci_stevec_in_imenovalec(vrstica)[0];
                imenovalec *= Izlusci_stevec_in_imenovalec(vrstica)[1];
                Console.WriteLine(stevec);
                Console.WriteLine(imenovalec);
            }
            branje.Close();
            Console.WriteLine($"{stevec}/{imenovalec}");
        }
    }
}
