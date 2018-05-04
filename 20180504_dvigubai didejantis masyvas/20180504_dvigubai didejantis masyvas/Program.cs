using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180504_dvigubai_didejantis_masyvas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int temp = 1;
            while (temp < n)
            {
                k++;
                temp *= 2;
            }

            int[] masyvas = new int[k];
            masyvas[0] = 1;
            for (int i = 1; i < masyvas.Length; i++)
            {
                masyvas[i] = masyvas[i - 1]*2;
                Console.WriteLine(masyvas[i]);
            }
        }
    }
}
