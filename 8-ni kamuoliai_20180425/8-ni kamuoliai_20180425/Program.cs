using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ni_kamuoliai_20180425
{
    class Program
    {
        static void Main(string[] args)
        {
            int kamuolys1 = 1;
            int kamuolys2 = 1;
            int kamuolys3 = 1;
            int kamuolys4 = 1;
            int kamuolys5 = 0;
            int kamuolys6 = 1;
            int kamuolys7 = 1;
            int kamuolys8 = 1;

            if ((kamuolys1+kamuolys2+kamuolys3)>(kamuolys4+kamuolys5+kamuolys6))
            {
                if (kamuolys4>kamuolys5)
                {
                    Console.WriteLine("Defektuotas yra penktas kamuoliukas");
                }
                else if (kamuolys5>kamuolys4)
                {
                    Console.WriteLine("Defektuotas yra 4-as kamuolys");
                }
                else
                {
                    Console.WriteLine("Defektuotas yra 6-as kamuolys");
                }
            }
            else if ((kamuolys1+kamuolys2+kamuolys3) < (kamuolys4+kamuolys5+kamuolys6))
            {
                if (kamuolys1>kamuolys2)
                {
                    Console.WriteLine("Defektuotas yra antras kamuolys");
                }
                else if (kamuolys1<kamuolys2)
                {
                    Console.WriteLine("Defektuotas yra pirmas kamuolys");
                }
                else
                {
                    Console.WriteLine("Defektuotas yra trecias kamuolys");
                }
            }
            else
            {
                if (kamuolys7>kamuolys8)
                {
                    Console.WriteLine("defektuotas yra 8 kamuolys");
                }
                else
                {
                    Console.WriteLine("Defektuotas yra 7 kamuolys");
                }
            }
            {

            }
        }
    }
}
