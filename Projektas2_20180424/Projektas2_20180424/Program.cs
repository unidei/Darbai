using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2_20180424
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tekstą arba žodį");
            string tekstas = Console.ReadLine();
            Console.WriteLine("Jūsų įvestas tekstas: ");
            Console.WriteLine(tekstas);
            
            
            Console.WriteLine("Įveskite vardą");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite mėgstamiausios spalvos pirmą raidę");
            Char raide = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nĮveskite atsitiktinį skaičių");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite kitą atsitiktinį skaičių");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūsų vardas yra  " + vardas
            + " jūsų mėgstamiausios spalvos pirma raidė yra " + raide
            + " atsitiktinis skaičius yra " + skaicius
            + " atsitiktinis skaičius yra " + skaicius1);
            Console.ReadKey();

        }
    }
}
