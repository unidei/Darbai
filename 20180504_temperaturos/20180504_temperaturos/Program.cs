using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180504_temperaturos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek norite duomenu?");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] temperaturos = new double[n];
            for (int i = 0; i < temperaturos.Length; i++)
            {
            Console.WriteLine("iveskite temperaturos duomenis");
            temperaturos[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("didziausia temperatura yra " + temperaturos.Max());
            Console.WriteLine("maziausia temperatura yra " + temperaturos.Min());
            Console.WriteLine("vidurkis yra: " + temperaturos.Average());

            double suma = 0;
            //for (int i = 0; i < temperaturos.Length; i++)
            //if (temperaturos[i] < temperaturos.Average())
            //{
                //suma += temperaturos[i];
            //}


            foreach (var item in temperaturos)
            {
                if (item < temperaturos.Average())
                {
                    suma += item;
                }
           
            
            }
            Console.WriteLine("suma elementu mazesniu uz vidurki yra: " +suma);
            }
        }
    }


