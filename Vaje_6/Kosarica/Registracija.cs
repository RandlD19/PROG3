using System;
using System.Linq;
namespace Razredi
{
    public class Registracija
    {
        private string[] obmocja = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
        private string prvi_del;
        private string drugi_del;

        public Registracija(string prvi_del, string drugi_del)
        {
            this.Prvi_del = prvi_del;
            this.Drugi_del = drugi_del;
        }

        public override string ToString()
        {
            return $"{this.Prvi_del} {this.Drugi_del}";
        }

        public string[] Obmocja
        {
            get { return obmocja; }
            set { obmocja = value; }
        }

        public string Prvi_del
        {
            get { return prvi_del; }
            set
            {
                if (!Obmocja.Contains(value))
                {
                    Console.WriteLine("Napačna izbira območja. Avtomatsko nastavljeno na CE :)");
                    prvi_del = "CE";
                }
                else { prvi_del = value; }

            }
        }

        public string Drugi_del
        {
            get { return drugi_del; }
            set
            {
                try
                {
                    string[] tab = value.Split('-');
                    if ((tab[0].Length == 2) && (tab[1].Length == 3))
                    {
                        drugi_del = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Neveljavna registracija (2. del). Nastavljeno na 00-000");
                    drugi_del = "00-000";
                }

            }
        }

        /// <summary>
        /// metoda, ki za dano tabelo reg. številk izpiše tiste reg. številke, ki so iz določenega območja, ki je parameter metode.
        /// </summary>
        /// <param name="tab"> tabela registracijskih stevilk </param>
        /// <param name="obmocje"> niz območje </param>
        public static void Registracije_iz_obmocja(Registracija[] tab, string obmocje)
        {
            foreach (Registracija registracija in tab)
            {
                if (registracija.Prvi_del == obmocje)
                {
                    Console.WriteLine(registracija);
                }

            }

        }

        public static Registracija[] ustvari_tab()
        {
            Registracija[] tab = new Registracija[100];
            string[] znaki = "Z,X,C,V,B,N,M,A,S,D,F,G,H,J,K,L,Q,W,E,R,T,Y,U,I,O,P,1,2,3,4,5,6,7,8,9,0".Split(',');
            Random naklucno_st = new Random();
            string[] obmocja = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };

            for (int i = 0; i < 100; i++)
            {
                string prvi_del = obmocja[naklucno_st.Next(0, 10)];
                string drugi_del = $"{znaki[naklucno_st.Next(0, 35)]}{znaki[naklucno_st.Next(0, 35)]}-{znaki[naklucno_st.Next(0, 35)]}{znaki[naklucno_st.Next(0, 35)]}{znaki[naklucno_st.Next(0, 35)]}";
                Registracija registracija = new Registracija(prvi_del, drugi_del);
                tab[i] = registracija;

            }

            return tab;
        }

    }

}
