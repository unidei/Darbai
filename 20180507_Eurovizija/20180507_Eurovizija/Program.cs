using System;
using System.Collections.Generic;
using System.Windows.Forms;//prisidedame sita//prisidedame prie references paspaudus desini "system windows forms"//pazymime
using System.IO;//prisidedame sita
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180507_Eurovizija
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string path = null;
            var ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;//cia nurodome is kur imame duomenis somis4-iomis eilutemis
                string temp = "Lithuania.txt";
                char[] triminimas = temp.ToCharArray();//triminimas - yra partumpinimas
                path = path.TrimEnd(triminimas);
            }
            List<List<int>> sarasai = new List<List<int>>();
            foreach (var file in Directory.EnumerateFiles(path))
            {
                StreamReader reader = new StreamReader(file);//cia jau imame duomenis siomis eilutemis zemiau
                List<int> duomenis = new List<int>();
                string readAll = reader.ReadToEnd();
                reader.Close();
                string[] duomenys_atskirai = readAll.Split(' ');
                foreach (var element in duomenys_atskirai)
                {
                    int t = Convert.ToInt32(element);
                    duomenis.Add(t);
                }
                sarasai.Add(duomenis);
                Console.WriteLine("Maziausiais balas yra: " + duomenis.Min());
                Console.WriteLine("Didziausias balas yra: " + duomenis.Max());
                Console.WriteLine("balų vidurkis yra: " + duomenis.Average());
                Console.WriteLine("Balu suma yra: " +duomenis.Sum());

            }
            double maxAverage = double.MinValue;
            foreach (var item in sarasai)
            {
                if (item.Average() > maxAverage)
                    maxAverage = item.Average();
            }
            Console.WriteLine("Didziausias vidurkis yra: " + maxAverage);
        }
    }
}
            
            
            
            
            
            
            
            //Console.WriteLine("Iveskite, kiek yra sarasu");
            //int kiek = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < kiek; i++)
            //{
               //int n = Convert.ToInt32(Console.ReadLine());
                //for (int i = 0; i < n; i++)
                //{
                    //Console.WriteLine("Iveskite balus");
                    //foreach (int balas in balai)
                    //{
                       //Console.WriteLine(balas);

                        //Console.WriteLine("Maziausiais balas yra: " + balai.Min());
                        //Console.WriteLine("Didziausias balas yra: " + balai.Max());
                        //Console.WriteLine("balų suma yra: " + balai.Average());
                        //int balusuma[] = balai.Average());
                    //}
                //}
            //Console.WriteLine("Maziausiais balas yra: " + balai.Min());
            //}

  
        
    
