using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APALLAKTIKIERGASIA2
{
    public partial class Form2 : Form
    {
        Class1 c1 = new Class1();
        Random r = new Random();
        Form1 form1 = new Form1();
        StartTheQuiz s = new StartTheQuiz();
        int time = 120;
        // double res1, res2, res3, res4;
        List<int> numbers = new List<int>();
        public int count = 0;

        public Form2()
        {
            InitializeComponent();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count++;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            addOutput.Value = 0;
            minOutput.Value = 0;
            mulOutput.Value = 0;
            divOutput.Value = 0;
            s.fillArray();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                timelabel.Text = time.ToString();
                if (time > 60)
                    timelabel.ForeColor = Color.Green;
                else if (time < 60 && time > 30)
                    timelabel.ForeColor = Color.Orange;
                else if (time < 30)
                    timelabel.ForeColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                label6.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.numbers[0] + "+" + s.numbers[1] + "=" + s.Add());
            c1.per1 -= 25;

            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            timer1.Start();
            timer2.Start();
            label1.Text = s.str1;
            label2.Text = s.str2;
            label3.Text = s.str3;
            label4.Text = s.str4;

        }



        private void button4_Click(object sender, EventArgs e)
        {

            timer2.Stop();


            ///o logos p den vazw tis sinartiseis Add Min, ktl einai oti ta exw double enw ta numeric einai decimal k de ginete sigkrisi
             if (addOutput.Value == s.numbers[0] + s.numbers[1])
                  c1.per1 += 25;
              else
                  button5.PerformClick();


              if (minOutput.Value == s.numbers[2] - s.numbers[3])
                  c1.per1 += 25;
              else
                  button6.PerformClick();

              if (mulOutput.Value == s.numbers[4] * s.numbers[5])
                  c1.per1 += 25;
              else
                  button7.PerformClick();

              if (divOutput.Value == s.numbers[6] / s.numbers[7])
                  c1.per1 += 25;
              else
                  button8.PerformClick();

            

            c1.GetUser();
            MessageBox.Show("Congatulations! \n Your score is:" + c1.score + "\n Your time is:" + count + "seconds \n Correct Answers:" + c1.per1 + "% \n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.ShowDialog();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numbers[2] + "+" + numbers[3] + "=" + s.Min());
            c1.per1 -= 25;

            button5.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.numbers[4] + "+" + s.numbers[5] + "=" + s.Mul());
            c1.per1 -= 25;

            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.numbers[6] + "+" + s.numbers[7] + "=" + s.Div());
            c1.per1 -= 25;

            button6.Enabled = false;
            button7.Enabled = false;
            button5.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string tmp1 = (s.Min() - 15).ToString();
            string tmp2 = (s.Min() + 15).ToString();
            MessageBox.Show("The answer is between " + tmp1 + " and " + tmp2 + ".");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string tmp1 = (s.Add() - 15).ToString();
            string tmp2 = (s.Add() + 15).ToString();
           
            MessageBox.Show("The answer is between " + tmp1 + " and " + tmp2 + ".");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string tmp1 = (s.Mul() - 15).ToString();
            string tmp2 = (s.Mul() + 15).ToString();
            MessageBox.Show("The answer is between " + tmp1 + " and " + tmp2 + ".");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string tmp1 = (s.Div() - 15).ToString();
            string tmp2 = (s.Div() + 15).ToString();
            MessageBox.Show("The answer is between " + tmp1 + " and " + tmp2 + ".");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
