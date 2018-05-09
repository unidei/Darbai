using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teleloto_imitatorius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<int> kamuoliukai = new List<int>();

        private void bGenerate_Click(object sender, EventArgs e)
        {
            //TextBox[] Mtexboxai = { tBM1, tBM2, tBM3, tBM4, tBM5 };
            kamuoliukai.Clear();
            TextBox[] Mtexboxai = { tBM1, tBM2, tBM3, tBM4, tBM5 };
            TextBox[] Rtexboxai = { tBR1, tBR2, tBR3, tBR4, tBR5 };
            TextBox[] Gtexboxai = { tBG1, tBG2, tBG3, tBG4, tBG5 };
            TextBox[] Ztexboxai = { tBZ1, tBZ2, tBZ3, tBZ4, tBZ5 };

            for (int i = 0; i < Mtexboxai.Length; i++)
            {
                Mtexboxai[i].Text = SugeneruojaKamuoliuka(1, 16).ToString();
            }
            tBJ1.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            tBJ2.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            tBJ3.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            tBJ4.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            tBJ5.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            PripildomiTexboxai(31, 46, Rtexboxai);
            PripildomiTexboxai(46, 61, Gtexboxai);
            PripildomiTexboxai(61, 76, Ztexboxai);
        }

        private void PripildomiTexboxai(int a, int b, TextBox[] textbox)
        {
            for (int i = 0; i < textbox.Length; i++)

            {
                textbox[i].Text = SugeneruojaKamuoliuka(a, b).ToString();

            }


        }
        private int SugeneruojaKamuoliuka(int a, int b)
        {
            Random rng = new Random();
            int temp = 0;
            int flag = 0;
            do
            {
                flag = 0;
                temp = rng.Next(a, b);
                foreach (var item in kamuoliukai)
                {
                    if (temp == item)
                    {
                        flag++;
                    }
                }

            } while (flag != 0);

            kamuoliukai.Add(temp);
            return temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            List <int> IstrauktiKamuoliukai = new List<int>();
            private void button1_Click(object sender, EventArgs e)
            Nutrinimas()

            int i = 0;
            Random rng = new Random();
            while (i < 45)
            {
                int temp = rng.Next(1, 76);
                int flag = 0;
                foreach (var item in IstrauktiKamuoliukai)
                {
                    if (item == temp)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    IstrauktiKamuoliukai.Add(temp);
                    textBox1.Text += temp.ToString() + " ";
                    i++;
                }
            }
        }
        private void Nutrinimas ()
        {
            TextBox[] texboxai = {
                tBM1, tBM2, tBM3, tBM4, tBM5,
                tBJ1, tBJ2, tBJ3, tBJ4, tBJ5,
                tBR1, tBR2, tBR3, tBR4, tBR5,
                tBG1, tBG2, tBG3, tBG4, tBG5,
                tBZ1, tBZ2, tBZ3, tBZ4, tBZ5 };
            foreach (var item in texboxai)
            {
            item.BackColor = Color.White;
            }
        }   
    }


private void Tinginyste(int Kamuoliuka)
        {
            TextBox[] texboxai = { tBM1, tBM2, tBM3, tBM4, tBM5, tBJ1, tBJ2, tBJ3, tBJ4, tBJ5, tBR1, tBR2, tBR3, tBR4, tBR5, tBG1, tBG2, tBG3, tBG4, tBG5, tBZ1, tBZ2, tBZ3, tBZ4, tBZ5 };
            foreach (var item in texboxai)
            {
                if (item.Text == Kamuoliuka.ToString())
                {
                    item.BackColor = Color.Green;
                }
            }
        }
    }
}




