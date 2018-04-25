using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_20180424
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Deimante";
            string pavarde = "Unikaite";
            int amzius = 41;
            float ugis = 172;
            double svoris = 60;
            string aukstoji_mokykla = "KCS";
            string akademinis_grupes_kodas = "04/24";
            char kursas = '2';
            string studijuprogramospavadinimas = "programavimas C#";
            int atsiskaitytukredituskaicius = 120;
            Console.WriteLine("ToDo sąrašas:");
            Console.WriteLine("1.Pavedžioti šunį;");
            Console.WriteLine("2.Išnešti šiukšles;");
            Console.WriteLine("3.Nupirkti pieno;");
            
            Console.WriteLine("STUDENTES DUOMENYS");
            Console.Write("{0}", vardas);
            Console.WriteLine(" {0} ({1}m.)", pavarde, amzius);
            Console.WriteLine("Ugis yra "+ ugis + " cm , o svoris yra " + svoris + " kg");
            Console.WriteLine("Ji mokosi " + aukstoji_mokykla + " mokykloje");
            Console.WriteLine("Mokosi "+ studijuprogramospavadinimas);
            Console.WriteLine("Dabar yra kurse: " +kursas );
            Console.WriteLine("Atsiskaičiusi už {0} kreditų", atsiskaitytukredituskaicius);
            Console.ReadKey();





        }
    }
}
