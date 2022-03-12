using System;
namespace Pi_in_Monte_Carlo
{
    public class Pi_in_MonteCarlo
    {
        static void Main(string[] args)
        {
            long n = Int64.Parse(Console.ReadLine());

            double st_tock = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x = new Random().NextDouble();
                double y = new Random().NextDouble();

                if (Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)) <= 1) {
                    st_tock++;
                }

            }

            Console.WriteLine((st_tock / n) * 4);

        }
    }
}
