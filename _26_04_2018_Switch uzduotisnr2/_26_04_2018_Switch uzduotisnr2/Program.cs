using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_04_2018_Switch_uzduotisnr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kavos aparatas MAX TURBO 5000");
            Console.WriteLine("Pasirinkite norima gerima");
            Console.WriteLine("1-Limonadas");
            Console.WriteLine("2-Arbata");
            Console.WriteLine("3-Kakava");
            Console.WriteLine("4-Kava");
            Console.WriteLine("5-Nieko");

            char pasirinkimas = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (pasirinkimas)
            {
                case '1':
                    Console.WriteLine("-jus pasirinkote limonada");
                    break;
                case '2':
                    Console.WriteLine("-jus pasirinkote arbata");
                    break;
                case '3':
                    Console.WriteLine("-jus pasirinkote kakava");
                    break;
                case '4':
                    Console.WriteLine("-jus pasirinkote kava");
                    break;
                case '5':
                    Console.WriteLine("-jus nieko nepasirinkote");
                    break;
                default:
                    Console.WriteLine("-neatpazinta komanda");
                    break;
            }
            
        }
    }
}

