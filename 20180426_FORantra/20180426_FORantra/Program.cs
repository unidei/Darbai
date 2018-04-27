using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180426_FORantra
{
    class Program
    {
        static void Main(string[] args)
        {
            int sandauga = 1;
            for (int i = 0; i < 100; i++)
            {
                if (i>0 && (i%7)==0)
                {
                    sandauga *= i;
                }
            }
            for (int i = 7; i < 100; i += 7)
            {
                sandauga *= i
            }
        }
    }
}
