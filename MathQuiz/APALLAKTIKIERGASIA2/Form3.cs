using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APALLAKTIKIERGASIA2
{
    public partial class Calculator : Form
    {
        double result;
        String operation = "";
        bool operationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        //CE
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
           // reslabel.Text = "0";
          //  label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        { }

        //CLOSE
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        { }

        private void button4_Click(object sender, EventArgs e)
        { }

        private void button3_Click(object sender, EventArgs e)
        { }

        //C
        private void button5_Click(object sender, EventArgs e)
        {

            /*
             //  textBox1.Text = "0";
             if (textBox1.SelectionStart > 0) //an iparxei kati grammeno, to index dld na nai >0
             {
                 char[] array = textBox1.Text.ToCharArray();
                  int index = array.Count();

                 textBox1.Text = textBox1.Text.Remove(index - 1, 1); // remove(startindex, count (poses theseis na deletarei))
                 textBox1.Select(index - 1, 1); //move ton kersora

             }*/
            if (operationPerformed == true)
            {
                // do nothing
            }
            else if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        { }

        private void button10_Click(object sender, EventArgs e)
        { }

        private void button15_Click(object sender, EventArgs e)

        { }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0"  || operationPerformed)
                textBox1.Clear();
           
            operationPerformed = false; //ksepatiete o telestis


            Button b = (Button)sender; //pernoume to object to kanume cast se button

        
            if (b.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {

                    textBox1.Text += b.Text;
                }

                
            }
            else
                textBox1.Text += b.Text;

        }

       

        private void operations_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                button20.PerformClick(); //kane oti kanei to button20 dld to enter

                operation = b.Text;

                reslabel.Text = result + " " + operation;
                operationPerformed = true; //exei patithei telestis

            }
            else
            {


                operation = b.Text;
                result = Double.Parse(textBox1.Text);
                reslabel.Text = result + " " + operation;
                operationPerformed = true; //exei patithei telestis


            }
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
           // if (textBox1.Text == null)
           ///     reslabel.Text = "0";
            

            switch (operation)
            {
                case "+":
                    textBox1.Text=(result + Double.Parse(textBox1.Text)).ToString();
                    break;


                case "-":
                    textBox1.Text=( result - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text= ( result / Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox1.Text);
            reslabel.Text = "";
        }
            private void reslabel_Click(object sender, EventArgs e)
            {

            }
        }

    }

