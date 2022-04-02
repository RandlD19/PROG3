using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            var prva = new int[5,2];
            Console.WriteLine("Izberi med intervali:");
            for (int i = 0; i < 5; i++)
            {
                int sp_meja = a.Next(0,100);
                int zg_meja = a.Next(sp_meja, 100);
                prva[i,0] = sp_meja;
                prva[i,1] = zg_meja;
                Console.WriteLine($"{i+1}) interval [{sp_meja}, {zg_meja}]");

            }

            int vnos;

            nanovo:
            try
            {
                Console.WriteLine("Vnesi število: ");
                vnos = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                goto nanovo;
            }

            switch (vnos)
            {
                case 1:
                    {
                        for (int i = prva[0, 0]; i <= prva[0, 1]; i++)
                        {
                            Console.Write(i + " ");
                        }
                        break; 
                    }

                case 2:
                    {
                        for (int i = prva[1, 0]; i <= prva[1, 1]; i++)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    }

                case 3:
                    {
                        for (int i = prva[2, 0]; i <= prva[2, 1]; i++)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    }


                case 4:
                    {
                        for (int i = prva[3, 0]; i <= prva[3, 1]; i++)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    }

                case 5:
                    {
                        for (int i = prva[4, 0]; i <= prva[4, 1]; i++)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    }

                default:
                    {
                        goto nanovo;
                    }


            }

            
            
            // Napiši program, ki nam ponudi 5 naključnih intervalov naravnih števil med 0 in 100. Uporabnik nato izbere enega in zanj izpiši vsa naravna
            // števila, torej od spodnje do zgornje meje. 
            //
            // Primer1:
            // Izberi med intervali:
            // 1) interval [19,38]
            // 2) interval [2,100]
            // 3) interval [28,87]
            // 4) interval [49,50]
            // 5) interval [39,82]
            // Vnesi število: 4
            // 49,50
            //
            // Primer2:
            // Izberi med intervali:
            // 1) interval [19,38]
            // 2) interval [2,100]
            // 3) interval [28,87]
            // 4) interval [49,50]
            // 5) interval [39,82]
            // Vnesi število: bla
            // To ni celo ptevilo med 1 in 5!
            // Vnesi število: 1
            // 19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38
            //
            // Program naj se po eni ponovitvi ne ustavi, vendar naj teče naprej in generira nove intervale.
            // Da se bomo pri nalogi naučili uporabljati switch in goto, skušaj izbiro v conzoli napisati s switch in potek programa ter izjeme z goto stavkom.
            //
            //
        }
    }
}
