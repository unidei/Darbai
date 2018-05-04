using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180504_List_antra
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> atsitiktiniai = new List<int>();
            for (int i = 0; i < rng.Next(1000000); i++)
            {
                atsitiktiniai.Add(rng.Next(1000));
            }

            foreach (int atsitiktinis in atsitiktiniai)
            {
                Console.WriteLine(atsitiktinis);
            }
                Console.WriteLine("Maziausiais  yra: " + atsitiktiniai.Min());
                Console.WriteLine("Didziausias  yra: " + atsitiktiniai.Max());
                Console.WriteLine(" vidurkis yra: " + atsitiktiniai.Average());
                Console.WriteLine("Pirma reiksme yra yra: " + atsitiktiniai.First());
                Console.WriteLine("Paskutine reiksme yra yra: " + atsitiktiniai.Last());
                Console.WriteLine(atsitiktiniai.ElementAt(rng.Next(100)));
                Console.WriteLine(atsitiktiniai.Capacity);

            }
        }
    }
