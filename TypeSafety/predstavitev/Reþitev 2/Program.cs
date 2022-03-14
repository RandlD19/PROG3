using System;

namespace Rešitev_2
{
    class Program
    {

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



        static void Main(string[] args)
        {
            Console.Write("Vnesi nekaj: ");
            string s = Console.ReadLine();
            try
            {
                int a = Int32.Parse(s);
                Console.WriteLine(test(a));
            }
            catch
            {
                try
                {
                    double a = Double.Parse(s);
                    Console.WriteLine(test(a));
                }
                catch
                {
                    try
                    {
                        bool a = Convert.ToBoolean(s);
                        Console.WriteLine(test(a));
                    }
                    catch
                    {
                        Console.WriteLine(test(s));
                    }
                }
            }
            
        }
    }
}
