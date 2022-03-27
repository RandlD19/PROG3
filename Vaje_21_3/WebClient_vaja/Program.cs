using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace WebClient_vaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string vsebina = client.DownloadString("http://bos.zrc-sazu.si/sbsj.html");

            string[] besede1 = vsebina.Split(new string[] { "<br>" }, StringSplitOptions.None);
            Console.WriteLine(besede1);
            List<string> ts = besede1.ToList();
            for (int i = 0; i < 5; i++)
            {
                ts.RemoveAt(0);
                ts.RemoveAt(ts.Count - 1);
            }
            List<string> besede = new List<string>();
            foreach (string s in ts)
            {
                besede.Add(s.Substring(2, s.Length - 2));
            }
            Console.WriteLine(besede[0]);
            Console.WriteLine(besede[ts.Count - 1]);

            string vnos = Console.ReadLine();
            foreach (string s in besede)
            {
                try
                {
                    if (s.Substring(0, vnos.Length) == vnos)
                    {
                        Console.WriteLine(s);
                    }

                }
                catch { }


            }
        }
    }
}

