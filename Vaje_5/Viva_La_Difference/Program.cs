using System;

namespace Viva_La_Difference
{
    class Program
    {
        static void Main(string[] args)
        {

            string zmanjsevanec;
            string odstevanec;
            double zmanj_d;
            double odst_d;
            try
            {
                Console.Write("Zmanjševanec: ");
                zmanjsevanec = Console.ReadLine();
                zmanj_d = double.Parse(zmanjsevanec);
                if (zmanj_d < 0)
                {
                    throw new Exception("Zmanjševanec mora biti nenegativno število!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Zmanjševanec mora biti celo število!");
                return;
            }

            try
            {
                Console.Write("Odštevanec: ");
                odstevanec = Console.ReadLine();
                odst_d = double.Parse(odstevanec);
                if (odst_d < 0)
                {
                    throw new Exception("Odštevanec mora biti nenegativno število!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Odštevanec mora biti celo število!");
                return;
            }

            if (zmanj_d - odst_d < 0)
            {
                throw new Exception("Odštevanec mora biti manjši od zmanjševanca!");
            }
            Console.WriteLine(zmanj_d - odst_d);
        }
    }
}
