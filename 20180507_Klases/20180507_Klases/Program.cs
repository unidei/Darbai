using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180507_Klases
{
    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int Gamybosmetai;
        public int Rida;
        public int Galingumas;
        public string Spalva;

        public double KiekPerMetusNuvaziuoja()
        {
            int praejoMetu = DateTime.Today.Year - Gamybosmetai;
            return ((double)Rida /praejoMetu);
        }

    public Automobilis()//cia yra konstruktoriu, ir jo deka mes konstruojame objekta
    {

    }
}
    class Program
    {
        static void Main(string[] args)
        {
        Automobilis auto = new Automobilis();
        auto.Gamybosmetai = 1997;
        auto.Marke = "VW";
        auto.Modelis = "Passat";
        auto.Rida = 287235;
        Console.WriteLine(auto.KiekPerMetusNuvaziuoja());
        }
    }
}
