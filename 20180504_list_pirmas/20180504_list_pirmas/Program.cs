using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180504_list_pirmas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int> { 10, 6, 5, 4, 5, 4, 8, 7, 9 };
            Console.WriteLine("Maziausiais pazymys yra: " + pazymiai.Min());
            Console.WriteLine("Didziausias pazymys yra: " + pazymiai.Max());
            Console.WriteLine("pazymiu vidurkis yra: " + pazymiai.Average());
            Console.WriteLine("Pirma reiksme yra yra: " + pazymiai.First());
            Console.WriteLine("Paskutine reiksme yra yra: " + pazymiai.Last());


            //Console.WriteLine("iveskite kiek yra pazymiu");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("iveskite pazymi");
                //List<int> pazymys = Convert.ToInt32(Console.ReadLine());
                //List<int> pazymys = Convert.ToInt32(Console.ReadLine());

            }

      }
    }
    }

