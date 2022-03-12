using System;

namespace Izpis_tabele
{
    class Program
    {

        public static void IzpisTabele<T>(T[] tab, int n, string niz)
        {
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{tab[i]}{niz}");
            }
            Console.WriteLine(tab[n - 1]);
        }

        public static Boolean Bisekcija<T>(T[] tab, T element) where T : IComparable<T>
        {
            int zacetek = 0;
            int konec = tab.Length - 1;
            if (element.CompareTo(tab[zacetek]) < 0 || (element.CompareTo(tab[konec]) > 0))
            {
                return false;
            }
            while (zacetek < konec)
            {
                if (tab[zacetek].Equals(element))
                {
                    return true;
                }
                if (tab[konec].Equals(element))
                {
                    return true;
                }
                int sredina = (konec + zacetek) / 2;
                if (zacetek.Equals(sredina) || konec.Equals(sredina))
                {
                    return false;
                }
                if (element.CompareTo(tab[sredina]) > 0)
                {
                    zacetek = sredina;
                }
                else
                {
                    konec = sredina;
                }

            }
            return false;

        }

        public static T[] MinMax1<T>(T[] tab) where T : IComparable<T>
        {
            T min = tab[0];
            T max = tab[0];

            foreach (T el in tab)
            {
                if (el.CompareTo(min) < 0)
                {
                    min = el;
                }
                if (el.CompareTo(max) > 0)
                {
                    max = el;
                }
            }

            return new T[] { min, max };
        }

        public static string[] MinMax1(string[] tab)
        {
            string min = tab[0];
            string max = tab[0];

            foreach (string el in tab)
            {
                if (min.Length > el.Length)
                {
                    min = el;
                }
                if (max.Length < el.Length)
                {
                    max = el;
                }
            }

            return new string[] { min, max };
        }

        public static T[] MinMax2<T>(T[] tab) where T : IComparable<T>
        {

            T min = tab[0];
            T max = tab[0];

            if (typeof(T).Equals(typeof(String))) // tab[0] is String
            {

                string min_s = min.ToString();
                string max_s = min.ToString();
                foreach (T el in tab)
                {
                    string t = el.ToString();
                    if (min_s.Length > t.Length)
                    {
                        min_s = t;
                        min = el;
                    }
                    if (max_s.Length < t.Length)
                    {
                        max_s = t;
                        max = el;
                    }
                }

                return new T[] { min, max };
            }

            foreach (T el in tab)
            {
                if (el.CompareTo(min) < 0)
                {
                    min = el;
                }
                if (el.CompareTo(max) > 0)
                {
                    max = el;
                }
            }

            return new T[] { min, max };
        }


        static void Main(string[] args)
        {
            //IzpisTabele(new int[] { 1, 3, 5, 6, 7, 8, 9 }, 5, " : ");
            //IzpisTabele(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }, 5, " : ");

            //Console.WriteLine(Bisekcija(new int[] { 1, 3, 5, 6, 7, 8, 9 }, 5));
            //Console.WriteLine(Bisekcija(new char[] { 'a', 'b', 'c', 'e', 'f', 'g' }, 'd'));

            Console.WriteLine(String.Join(" : ", MinMax2(new int[] { 1, 3, 5, 6, 7, 8, 9 })));
            Console.WriteLine(String.Join(" : ", MinMax2(new char[] { 'a', 'b', 'c', 'e', 'f', 'g' })));
            Console.WriteLine(String.Join(" : ", MinMax2(new string[] { "aasda", "b", "c", "e", "lkmff", "čldmfčlsdg" })));

        }
    }
}
