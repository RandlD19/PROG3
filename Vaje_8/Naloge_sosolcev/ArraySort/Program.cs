using System;
using System.Collections;
using System.Linq;

namespace ArraySort
{
    public class UrediPoSteviluA : IComparer
    {
        public int prestejA(string niz)
        {
            int stevec = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                char znak = niz[i];
                if ((znak == 'a') || (znak == 'A'))
                {
                    stevec++;
                }
            }
            return stevec;
        }
        public int Compare(Object prvi, Object drugi)
        {
            //int st_prvi = prvi.ToString().Count(f => ((f == 'a') || (f == 'A')));
            int st_prvi = prestejA(prvi.ToString());
            Console.WriteLine($"{prvi.ToString()}: {st_prvi}");
            //int st_drugi = prvi.ToString().Count(f => ((f == 'a') || (f == 'A')));
            int st_drugi = prestejA(drugi.ToString());
            Console.WriteLine($"{drugi.ToString()}: {st_drugi}");

            if (st_prvi > st_drugi)
            {
                return -1;
            }
            else if (st_prvi == st_drugi)
            {
                if (prvi.ToString().Length > drugi.ToString().Length)
                {
                    return -1;
                }
                else if (prvi.ToString().Length == drugi.ToString().Length)
                {
                    if (prvi.ToString().CompareTo(drugi.ToString()) == 1)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList imena = new ArrayList();
            imena.Add("Marija");
            imena.Add("Ana");
            imena.Add("Maja");
            imena.Add("Irena");
            imena.Add("Mojca");
            imena.Add("Nina");
            imena.Add("Mateja");
            imena.Add("Nataša");
            imena.Add("Andreja");
            imena.Add("Barbara");
            IComparer comparer = new UrediPoSteviluA();

            imena.Sort(comparer);

            foreach (var ime in imena)
            {
                Console.WriteLine(ime);
            }
        }
    }
}
