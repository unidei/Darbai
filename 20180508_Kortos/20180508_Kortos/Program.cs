using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180508_Kortos
{
    class Korta
    {
        public char zenklas { get; } // galima naudoti string
        public string skaicius { get; }

        public Korta(char zenklas, int skaicius)
        {
            this.zenklas = zenklas;
            this.skaicius = MakesSign(skaicius); //skaicius.ToString(); - buvo pries pakeiciant
        }
        private string MakesSign(int sk)
        {
            if (sk == 1)
            {
                return "A";
            }
            else if (sk == 11)
            {
                return "J";
            }
            else if (sk == 12)
            {
                return "Q";
            }
            else if (sk == 13)
            {
                return "K";
            }
            else
            {
                return sk.ToString();
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Korta> kalade = new List<Korta>();
            char[] zenklai = { 'K', 'S', 'B', 'V' };
            Random rng = new Random();
            int i = 0;
            while (i < 52)
            {
                Korta korta = new Korta(zenklai[rng.Next(zenklai.Length)], rng.Next(1, 14));
                int flag = 0;
                foreach (var item in kalade)
                {
                    if (item.skaicius == korta.skaicius && item.zenklas == korta.zenklas)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    kalade.Add(korta);
                    i++;
                }

                foreach (var item in kalade)
                {
                    Console.WriteLine(item.skaicius + " " + item.zenklas);
                }
            }
        }
    }
}

   
 
        
            