using System;

namespace DopolniProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");
            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Nisi vnesel celo število!");
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Z nič ne moremo deliti");
            }
            catch (Exception e)
            {
                Console.WriteLine("Nekaj je šlo narobe:");
                Console.WriteLine(e.ToString());
                Console.WriteLine("Popravi program, da bo to izjemo obravnaval posebej.");
            }
        }
    }
}
