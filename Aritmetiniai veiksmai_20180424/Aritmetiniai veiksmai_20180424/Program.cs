using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetiniai_veiksmai_20180424
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičius");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaicius");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            int suma = sk1 + sk2;
            int skirtumas = sk1 - sk2;
            int daugyba = sk1 * sk2;
            double dalmeni = (double)sk1 / sk2;

            Console.WriteLine("{0} + {1} = {2}", sk1, sk2, (sk1+sk2));
            Console.WriteLine("{0} - {1} = {2}", sk1, sk2, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", sk1, sk2, daugyba);
            Console.WriteLine("{0} / {1} = {2:0.00}", sk1, sk2, dalmeni);
            
           



        }
    }
}
