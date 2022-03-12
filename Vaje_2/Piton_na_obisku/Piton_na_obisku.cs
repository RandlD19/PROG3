using System;
using System.Linq;

namespace Piton_na_obisku
{
    class Piton_na_obisku
    {
        /// <summary>
        /// Funkcija presteje kolikokrat se pojavi znak znak v nizu niz
        /// </summary>
        /// <param name="znak">Znake iščemo v tem nizu</param>
        /// <param name="niz">Iščemo ta znak</param>
        /// <returns>Vrne število iskanih znakov v nizu</returns>
        public static int PrestejZnake(char znak, string niz)
        {
            int koliko = 0;
            for (int i=0; i < niz.Length; i++)
            {
                if (niz[i] == znak)
                {
                    koliko++;
                }
            }
            return koliko;
        }
         /// <summary>
         /// Funkcija stakne tabelo znakov v niz
         /// </summary>
         /// <param name="tab">tabela znakov</param>
         /// <returns>Vrne staknjen niz</returns>
        public static string StakniBrezNicel(char[] tab)
        {
            string rez = "";
            for (int i = 0; i < tab.Length; i++)
            {
                rez += tab[i];
            }
            return rez;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Prestej(string s, string t)
        {
            int[] c = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                char z = t[i];
                c[i] = PrestejZnake(z, s);

            }
            int m = c.Max();

            char[] u = new char[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
                if (c[i] == m)
                {
                    u[i] = t[i];
                }
            }

            return StakniBrezNicel(u);
        }
        static void Main(string[] args)
        {
            string s = "neznani tekst";
            string t = "taei";
            Console.WriteLine(Prestej(s, t));
        }
    }
}
