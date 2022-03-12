using System;

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int r1 = int.Parse(split[0]);
            int s = int.Parse(split[1]);
            int r2 = 2 * s - r1;
            Console.WriteLine(r2);
        }
    }
}
