using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180508_bazines_ir_paveldincios_klases
{
    class Maistas
    {
        public string kilme;
        public string skonis;
        public int maistingumas; //kalorijos

        public virtual void Isvedimas()//cia sukūrėme virtualų metodą, kurį galėsime iššsikviesti zemesnėse klasėse
        {
            Console.WriteLine("Kilme yra: " +kilme);
        }

        public Maistas(string kilme, string skonis, int maistingumas)
        {
            this.kilme = kilme;
            this.skonis = skonis;
            this.maistingumas = maistingumas;
        }
    }

    class Desertas: Maistas
    {
        public string tipas;
        public int temperatura;
        public string sviezumas;

        public override void Isvedimas()//
        {
            base.Isvedimas();
            Console.WriteLine("Isikiso desertas");
        }
        public Desertas(string tipas, int temperatura, string sviezumas, string kilme, string skonis, int maistingumas)
            :base(kilme, skonis, maistingumas)
        {

        }
    }
    class salotos : Maistas
    {
        public string pavadinimas;
        public int temperatura;
        public string padazotipas;
        public double kaina;

        public salotos(string pavadinimas, int temperatura, string padazotipas, double kaina, string kilme, string skonis, int maistingumas)
            : base(kilme, skonis, maistingumas)
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Desertas desertas = new _20180508_bazines_ir_paveldincios_klases.Desertas("tortas", 4, "Sviezias", "Vokietija", "Geras", 5000);
            desertas.Isvedimas();
            Maistas maistas = new _20180508_bazines_ir_paveldincios_klases.Maistas("Lietuva", "Geras", 1000);
            maistas.Isvedimas();
        } 
    }
}
