using System;


namespace Obrati
{
    class Program
    {
        static void Main(string[] args)
        {
            string vnos1 = Console.ReadLine();
            string vnos2 = Console.ReadLine();

            int st1 = int.Parse(vnos1);
            int st2 = int.Parse(vnos2);

            int stotice1 = st1 / 100;
            int desetice1 = (st1 / 10) % 10;
            int enice1 = (st1 % 10);

            int stotice2 = st2 / 100;
            int desetice2 = (st2 / 10) % 10;
            int enice2 = (st2 % 10);

            string obrnjeno1 = $"{enice1}{desetice1}{stotice1}";
            string obrnjeno2 = $"{enice2}{desetice2}{stotice2}";

            int obrnjeno1_int = int.Parse(obrnjeno1);
            int obrnjeno2_int = int.Parse(obrnjeno2);

            Console.WriteLine($"{obrnjeno1} - {obrnjeno2} = {obrnjeno1_int - obrnjeno2_int}");
        }
    }
}
