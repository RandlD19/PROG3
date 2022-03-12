using System;

namespace Nakljucna_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Random st = new Random();
            int nakljucno = st.Next(100, 1000);
            Console.WriteLine(nakljucno);
        }
    }
}
