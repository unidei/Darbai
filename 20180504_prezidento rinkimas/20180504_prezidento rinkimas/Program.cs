using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180504_prezidento_rinkimas
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Console.WriteLine("iveskite visus kandidatus");
            OpenFileDialog ofd = new OpenFileDialog();
            string path = null;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            StreamReader reader = new StreamReader(path);
            string duomenys = reader.ReadLine();
            string[] kandidatai = duomenys.Split(' ').ToArray();
            int max = 0;
            int indeksas = -1;
            int i = 0;
            foreach (var kandidata in kandidatai)
            {
                char[] raides = kandidata.ToLower().ToCharArray();
                int temp = RaidziuKiekis(raides);
                if (temp > max)
                {
                    max = temp;
                    indeksas = i;
                }
                i++;
            }
            Console.WriteLine("prezidentu tapo: " + kandidatai[indeksas]);
        }
        static int RaidziuKiekis(char[] raides)
        {
            int suma = 0;
            for (int i = 0; i < raides.Length; i++)
            {
                int flag = 0;
                for (int j = i + 1; j < raides.Length; j++)
                {
                    if (raides[i] == raides[j])
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    suma++;
                }
            }
            return suma;
            {
            }
        }
    }
}



