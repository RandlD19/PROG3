using System;

namespace Pek
{
    class Pek
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi predpisano tezo hlebca: ");
            double tezaPredpis = double.Parse(Console.ReadLine());
            Console.Write("Vnesi stevilo hlebcev v pekarni: ");
            int steviloHlebcev = int.Parse(Console.ReadLine());
            int stevecNapacnih = 0;
            double minTeza = tezaPredpis * 0.8;

            double maxTeza = tezaPredpis * 1.2;

            stevecNapacnih = Preberi2(steviloHlebcev, stevecNapacnih, minTeza, maxTeza);
            //računamo ali bo pek pil vodo
            AliGoljuf(steviloHlebcev, stevecNapacnih);
        }

        /// <summary>
        /// Preveri ali je pek Goljuf
        /// </summary>
        /// <param name="steviloHlebcev">koliko imamo hlebcev</param>
        /// <param name="stevecNapacnih">koliko je napačnih hlebcev</param>
        private static void AliGoljuf(int steviloHlebcev, int stevecNapacnih)
        {
            if (stevecNapacnih > steviloHlebcev * 0.15)
            {
                Console.WriteLine("Peka v vodo takoj!!!!");
            }
            else
            {
                Console.WriteLine("Pek ima dobro mero");
            }
        }

        /// <summary>
        /// Funkcija vrne število hlebcev, ki so napačni
        /// </summary>
        /// <param name="steviloHlebcev">Povemo, koliko bo hlebcev</param>
        /// <param name="stevecNapacnih">Na začetku je 0</param>
        /// <param name="minTeza">Spodnja meja</param>
        /// <param name="maxTeza">Zgornja meja</param>
        /// <returns></returns>
        private static int Preberi2(int steviloHlebcev, int stevecNapacnih, double minTeza, double maxTeza)
        {
            for (int i = 1; i < steviloHlebcev+1; i++)
            {
                Console.Write("Vnesi tezo: " + i + ". hlebca ");
                double dejanskaTeza = double.Parse(Console.ReadLine());
                //Če je teža hlebca 20% manjša od predpisa, ga štej med napačne hlebce
                if ((dejanskaTeza < minTeza) || (dejanskaTeza > maxTeza))
                {
                    stevecNapacnih++;
                }
            }

            return stevecNapacnih;
        }
    }
}
