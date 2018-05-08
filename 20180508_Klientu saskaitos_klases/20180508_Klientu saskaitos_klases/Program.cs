using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180508_Klientu_saskaitos_klases
{
    class Klientas
    {
        public string vardas;
        public string pavarde;
        public int ID;
        public double saskaita;

        public virtual void KiekMoketi()
        {
            saskaita = ID * 10;
        }
        public Klientas(string vardas, string pavarde, int ID)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.ID = ID;
        }
    }


class VIP: Klientas
{
    public override void KiekMoketi()
    {
        base.KiekMoketi();
        saskaita *= 0.7;
    }
    public VIP(string vardas, string pavarde, int ID):base(vardas, pavarde, ID)
    {

    }
}
class Silver: Klientas
{
    public override void KiekMoketi()
    {
        base.KiekMoketi();
        saskaita *= 0.9;    
    }
    public Silver(string vardas, string pavarde, int ID):base(vardas, pavarde, ID)
    {

    }
}
class Simpler : Klientas
{
     public Simpler(string vardas, string pavarde, int ID) : base(vardas, pavarde, ID)
    {

    }
}
class Program
    {
        static void Main(string[] args)
        {
        VIP vipinis = new VIP("Jonas", "Jonaitis", 1);
        Silver silveris = new Silver("Petras", "Petraitis", 2);
        Simpler simplas = new Simpler("Sigitas", "Sigitaitis", 3);
        List<Klientas> klientai = new List<Klientas>() {vipinis, silveris, simplas };
        foreach (var item in klientai)
        {
            item.KiekMoketi();
            Console.WriteLine("Moketi reikia: " +item.saskaita);
        }
        }
    }
}
