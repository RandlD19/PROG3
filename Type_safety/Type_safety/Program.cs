using System;

namespace Type_safety
{
    class Program
    {

        public static string[] sestej<T>(T[] tab1, T[] tab2)
        {
            string[] tab = new string[tab1.Length];
            int i = 0;
            foreach (var item in tab1)
            {
                string niz1 = item.ToString();
                string niz2 = tab2[i].ToString();
                tab[i] = niz1 + niz2;
                i++;
            }
            return tab;
        }

        public static int[] sestej(int[] tab1, int[] tab2)
        {
            int[] tab = new int[tab1.Length];
            int i = 0;
            foreach (int st1 in tab1)
            {
                int st2 = tab2[i];
                tab[i] = st1 + st2;
                i++;
            }
            return tab;

        }


        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" : ", sestej(new int[] { 1, 3, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3 })));
            Console.WriteLine(String.Join(" : ", sestej(new string[] { "1", "3", "5", "6", "7", "8", "9" }, new string[] { "9", "8", "7", "6", "5", "4", "3" })));
            Console.WriteLine(String.Join(" : ", sestej(new char[] { '1', '3', '5', '6', '7', '8', '9' }, new char[] { '9', '8', '7', '6', '5', '4', '3' })));
            Console.WriteLine(String.Join(" : ", sestej(new bool[] { true, false, true, true }, new bool[] { false, false, true, true })));

        }
    }
}
