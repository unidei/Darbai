using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidurio_atsiskaitymas_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite pirkinius is saraso");
            Console.WriteLine("Galite rinktis iki 10 pirkiniu, pradekite. uzbaige pasirinkima, spauskite 0");
            Console.WriteLine("1 -Vanduo");
            Console.WriteLine("2 -Kava");
            Console.WriteLine("3 -Sausainiai");
            Console.WriteLine("4 -Duona");
            Console.WriteLine("5 -Kiausinai");
            Console.WriteLine("6 -Bulves");
            Console.WriteLine("7 -Pienas");
            Console.WriteLine("8 -Darzoves");

            int suma = 0;
            int kiekis = 0;
            while (kiekis < 10)
            char pasirinkimas = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (pasirinkimas)         
                     
            {

            } (int i = 0; i < 9; i++)
                Console.WriteLine(case[i]);
        
                case '1':
                    Console.WriteLine(" - Vanduo");
                    
                case '2':
                    Console.WriteLine(" - Kava");
                    
                case '3':
                    Console.WriteLine(" - Sausainiai");
                    
                case '4':
                    Console.WriteLine(" - Duona");
                    
                case '5':
                    Console.WriteLine(" - Kiausinai");
                    
                case '6':
                    Console.WriteLine(" - Bulves");
                    
                case '7':
                    Console.WriteLine(" - Pienas");
                    
                case '8':
                    Console.WriteLine(" - Darzoves");

            default:
                    Console.WriteLine("- klaidingas pasirinkimas");
                    
                case '0':
                    Console.WriteLine("jusu pirkiniai yra:");
            Console.WriteLine("Jūsų pirkinių suma yra" + suma);
            //break;
        }

        }
    }


        }
    }
}


        
    
