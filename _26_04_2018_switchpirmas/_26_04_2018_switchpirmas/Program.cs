using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_04_2018_switchpirmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            switch (sk1)
            {
                case 1:
                    Console.WriteLine(sk1+sk2+sk3);
                    break;
                case 2:
                    Console.WriteLine(sk1-sk3);
                    break;
                case 3:
                    Console.WriteLine(sk2*sk3);
                    break;
            }
        }
    }
}
