using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            HighScore high = new HighScore();//antikeimeno klasis
            high.highscore();//meso tou anitkeimeno kalo tin synarthsh
            label1.Text = high.players[0] + "   " + high.scores[0];//high.gh blepo to stoixeipu tou pinaka p tokane h synarthsh
            label2.Text = high.players[1] + "   " + high.scores[1];
            label3.Text = high.players[2] + "   " + high.scores[2];
            label4.Text = high.players[3] + "   " + high.scores[3];
            label5.Text = high.players[4] + "   " + high.scores[4];
            label6.Text = high.players[5] + "   " + high.scores[5];
            label7.Text = high.players[6] + "   " + high.scores[6];
            label8.Text = high.players[7] + "   " + high.scores[7];
            label9.Text = high.players[8] + "   " + high.scores[8];
            label10.Text = high.players[9] + "   " + high.scores[9];

            HighTime time = new HighTime();
            time.hightime();
            label22.Text = time.players[0] + "   " + time.second[0];
            label21.Text = time.players[1] + "   " + time.second[1];
            label20.Text = time.players[2] + "   " + time.second[2];
            label19.Text = time.players[3] + "   " + time.second[3];
            label18.Text = time.players[4] + "   " + time.second[4];
            label17.Text = time.players[5] + "   " + time.second[5];
            label16.Text = time.players[6] + "   " + time.second[6];
            label15.Text = time.players[7] + "   " + time.second[7];
            label14.Text = time.players[8] + "   " + time.second[8];
            label13.Text = time.players[9] + "   " + time.second[9];



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            Image myimage = new Bitmap(@"C:\\Users\\Tassos\\Pictures\\WindowsFormsApp12\\WindowsFormsApp12\\bin\\Debug\\GastlyForm3.jpg");
            this.BackgroundImage = myimage;
        }
    }
    public class HighScore//ftiaxnoune thn klasi h opoia tha exei tis syanrthseis p xrhsimopoioiume
    {
        int a = 0;
    
        int b = 0;
        public System.IO.StreamReader file = new System.IO.StreamReader(@"myfile.txt");
        public string[] ef = System.IO.File.ReadAllLines(@"myfile.txt");
        public string[] players;
        public int[] scores;
        public int tmp;
        public string tmp1;
        public void highscore()
        {
            players= new string[ef.Count()];
            scores= new int[ef.Count()];
            foreach (string s in ef)
            {
                string[] k = s.Split(' ');
                players[a] = k[0];


                b = int.Parse(k[k.Count() - 1]);

                scores[a] = b;
                a++;
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a - 1; j++)
                {
                    if (scores[j] > scores[j + 1])
                    {
                        tmp = scores[j + 1];
                        scores[j + 1] = scores[j];
                        scores[j] = tmp;

                        tmp1 = players[j + 1];
                        players[j + 1] = players[j];
                        players[j] = tmp1;
                    }
                }
            }
        }
    }

    public class HighTime//ftiaxnoune thn klasi h opoia tha exei tis syanrthseis p xrhsimopoioiume
    {
        int c = 0;

        int d = 0;
        public System.IO.StreamReader file = new System.IO.StreamReader(@"myfileB.txt");
        public string[] ef = System.IO.File.ReadAllLines(@"myfileB.txt");
        public string[] players;
        public int[] second;
        public int tmp;
        public string tmp1;
        public void hightime()
        {
            players = new string[ef.Count()];
            second = new int[ef.Count()];
            foreach (string s in ef)
            {
                string[] k = s.Split(' ');
                players[c] = k[0];


                d = int.Parse(k[k.Count() - 1]);

                second[c] = d;
                c++;
            }
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c - 1; j++)
                {
                    if (second[j] > second[j + 1])
                    {
                        tmp = second[j + 1];
                        second[j + 1] = second[j];
                        second[j] = tmp;

                        tmp1 = players[j + 1];
                        players[j + 1] = players[j];
                        players[j] = tmp1;
                    }
                }
            }
        }
    }

}
