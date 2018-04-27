using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180426_Pirminis_kaicius
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 2; i < 1000; i++)
            {
                int flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if ((i%j)==0)
                    {
                        flag++;
                    }

                }

                if(flag ==0)
                {
                    suma += i;
                }
            }
        }
    }
}
