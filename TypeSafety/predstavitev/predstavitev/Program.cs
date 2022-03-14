using System;

namespace predstavitev
{
    class Program
    {

        public static int sestej(int[] tab)
        {
            int vsota = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                vsota += tab[i];
            }
            return vsota;
        }
        static void Main(string[] args)
        {

            // TODO Primer
            // OPTIMIZIRAJ Primer 2
            //int[] t = new int[] { 1, 2, 3 };
            //Console.WriteLine("1");
            //dynamic x = sestej(t);
            //x = "abc";
            //string[] t = new string[]{"abc", "def","ghi"};
            //int a = x[9];
            //Console.WriteLine("2");
            //object[] x = new object[] { 1, 2, "3" };
            //int a = sestej(x);

            // Rešitev:
            Console.Write("Poljuben vnos: ");
            var vnos = Console.ReadLine();
            bool neNiz = false;
            try
            {
                int vnos1 = int.Parse(vnos);
                Console.WriteLine(test(vnos1));
                neNiz = true;
            }
            catch (Exception ex)
            {
                try
                {
                    double vnos1 = double.Parse(vnos);
                    Console.WriteLine(test(vnos1));
                    neNiz = true;
                }
                catch (Exception ex1)
                {
                    try
                    {

                        bool vnos1 = bool.Parse(vnos);
                        Console.WriteLine(test(vnos1));
                        neNiz = true;
                    }
                    catch (Exception ex2)
                    {
                    }
                }
            }





            if (!neNiz)
            {
                Console.WriteLine(test(vnos));
            }


        }



















































        public static int[] sestej(int[] prva, int[] druga)
        {
            int[] vrni = new int[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i] + druga[i];
            }

            return vrni;
        }


        public static string[] sestej(string[] prva, int[] druga)
        {
            string[] vrni = new string[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i] + druga[i].ToString();
            }

            return vrni;
        }


        public static string[] sestej(int[] prva, string[] druga)
        {
            string[] vrni = new string[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i].ToString() + druga[i];
            }

            return vrni;
        }

        public static string[] sestej(string[] prva, string[] druga)
        {
            string[] vrni = new string[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i] + druga[i];
            }

            return vrni;
        }

        public static string[] sestej(bool[] prva, int[] druga)
        {
            string[] vrni = new string[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i].ToString() + druga[i].ToString();
            }

            return vrni;
        }

        public static double[] sestej(int[] prva, double[] druga)
        {
            double[] vrni = new double[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i] + druga[i];
            }

            return vrni;
        }

        public static double[] sestej(float[] prva, int[] druga)
        {
            double[] vrni = new double[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i] + druga[i];
            }

            return vrni;
        }



        public static string[] sestej<T, M>(T[] prva, M[] druga)
        {
            string[] vrni = new string[prva.Length];

            for (int i = 0; i < prva.Length; i++)
            {
                vrni[i] = prva[i].ToString() + druga[i].ToString();
            }

            return vrni;
        }






















        public static int test(int x)
        {
            return x * 2 + 1;
        }

        public static string test(string x)
        {
            return x + x + "1";
        }

        public static double test(double x)
        {
            return x * 2 + 1;
        }

        public static bool test(bool x)
        {
            return !(x);
        }




    }
}
