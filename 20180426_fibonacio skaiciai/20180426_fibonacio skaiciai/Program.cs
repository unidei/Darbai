using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180426_fibonacio_skaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite kiek fibonacio skaiciu norite isvesti i ekrana");

            int n = Convert.ToInt32(Console.ReadLine());
            int sk1 = 5;
            int sk2 = 6;
            int sk3 = 0;
            Console.WriteLine(sk1);
            Console.WriteLine(sk2);
            for (int i = 2; i < n; i++)
            {
                sk3 = sk1 + sk2;
                Console.WriteLine(sk3);
                sk1 = sk2;
                sk2 = sk3;
                Console.ReadKey();

            }

        }
    }
}
