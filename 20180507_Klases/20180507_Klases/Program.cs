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

    public Automobilis(string Marke, string Modelis, int Gamybosmetai, int Rida)//cia yra konstruktoriu, ir jo deka mes konstruojame objekta
    {
            this.Marke = Marke;
            this.Modelis = Modelis;
            this.Gamybosmetai = Gamybosmetai;
            this.Rida = Rida;
    }
        public Automobilis()//susikureme nauja klase - tuscia
        {

        }
}
    class Program
    {
        static void Main(string[] args)
        {
        Automobilis auto = new Automobilis("VW", "Passat", 1997, 287235);//surasius sioje eiluteje parametrus, zemiau esanciu eiluciu - nebereikia
        Automobilis Auto1 = new Automobilis(Marke: "audi", Modelis: "A8", Gamybosmetai: 2014, Rida: 10000);
        Automobilis auto2 = new Automobilis("Audi", "A4", 2005, 10000);
        Automobilis auto3 = new Automobilis("BMW", "E39", 1998, 354000);
        Automobilis auto4 = new Automobilis("Porsche", "911", 2011, 5000);
        auto.Gamybosmetai = 1997;//
        auto.Marke = "VW";//
        auto.Modelis = "Passat";//
        auto.Rida = 287235;//
        Console.WriteLine(auto.KiekPerMetusNuvaziuoja());
        Console.WriteLine(Auto1.KiekPerMetusNuvaziuoja());
        Console.WriteLine(auto2.KiekPerMetusNuvaziuoja());
        Console.WriteLine(auto3.KiekPerMetusNuvaziuoja());
        Console.WriteLine(auto4.KiekPerMetusNuvaziuoja());
        Automobilis automo = new Automobilis() //galimi keli pasirinkimo variantai;

        }
    }
}
