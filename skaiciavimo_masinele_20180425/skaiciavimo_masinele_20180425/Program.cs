using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciavimo_masinele_20180425
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            double sk1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite zenkla");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite antra skaiciu");
            double sk2 = Convert.ToDouble(Console.ReadLine());
            if (zenklas == '+')

            {
                Console.WriteLine(sk1 + sk2);
            }
            else if (zenklas == '-')
            {
                Console.WriteLine(sk1 - sk2);
            }
            else if (zenklas == '*')
            {
                Console.WriteLine(sk1 * sk2);
            }
            else if (zenklas == '/')
            {
                if (sk2 != 0)
                {
                    Console.WriteLine(sk1 / sk2);
                }
                else
                {
                    Console.WriteLine("Dalyba is 0 negalima");
                }
            }
            else
            {
                Console.WriteLine("Neatpazintas zenklas");

            }



        }
    }
}
