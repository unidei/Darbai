using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidurio_atsiskaitymas_Ketvirta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmaji skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                if (sk1 > sk3)
                {
                    Console.WriteLine("Pirmas skaicius yra didziausias");
                }
                else if (sk3 > sk1)
                {
                    Console.WriteLine("trecias skaicius yra didziausias");
                }
            }
            else if (sk1 < sk2)
            {
                if (sk2 > sk3)
                {
                    Console.WriteLine("Antras skaicius yra didziausias");
                }
                else if (sk2 < sk3)
                {
                    Console.WriteLine("trecias skaicius yra didziausias");
                }
            }
            else
            {
                Console.WriteLine("nei vienas skaicius nera didziausias");
            }


        }
    }
}
   


