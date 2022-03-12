using System;

namespace Gremo_v_krog1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vnos = BranjeTabele();
            Console.Write("Vnesi pomik: ");
            int pomik = int.Parse(Console.ReadLine());

            string[] tab_st = vnos.Split(" ");

            Console.Write("Tabela pred pomikom: ");
            IzpisTabele(tab_st);

            NarediPremik(pomik, tab_st);

            Console.Write("Tabela po pomiku: ");
            IzpisTabele(tab_st);

        }

        /// <summary>
        /// Funkcija naredi krožni premik elementov v tabeli v levo
        /// </summary>
        /// <param name="pomik">Predstavlja število premikov v levo</param>
        /// <param name="tab_st">tabela nizov katere elemente premaknemo</param>
        private static void NarediPremik(int pomik, string[] tab_st)
        {
            for (int j = 0; j < pomik; j++)
            {
                string pomozna = tab_st[0];
                for (int i = 1; i < tab_st.Length; i++)
                {
                    tab_st[i - 1] = tab_st[i];
                }
                tab_st[tab_st.Length - 1] = pomozna;
            }
        }

        /// <summary>
        /// Funkcija uporabnika vpraša po zaporedju števil
        /// </summary>
        /// <returns>Vrne niz ki predstavlja zaporedje števil</returns>
        private static string BranjeTabele()
        {
            Console.Write("Vnesi elemente tabele: ");
            string vnos = Console.ReadLine();
            return vnos;
        }

        /// <summary>
        /// Fukcija "lepo" izpiše tabelo 
        /// </summary>
        /// <param name="tab_st">Vhodna tabela nizov</param>
        private static void IzpisTabele(string[] tab_st)
        {
            foreach (string st in tab_st)
            {
                Console.Write($"{st} ");
            }
            Console.WriteLine();
        }
    }
}
