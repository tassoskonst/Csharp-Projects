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
    public partial class Form1 : Form
    {
        Class1 c1 = new Class1();
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1.txtbx = textBox1.Text;
            c1.SetUser();

            if (c1.flag == "succes")
            {
                this.Hide();
                f2.Show();
            }
            /* else if(c1.flag== "no username")
              {
                  MessageBox.Show(c1.flag);
              }
             else if (c1.flag=="")
          }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   /* public class Class1
    {
        public List<string> user = new List<string>();
        public List<int> scorelist = new List<int>();
        bool paliospaiktis;
        public int index = 0;
        Form1 f1 = new Form1();
        Form2 f2 = new Form2();
        public Class1()
    {
        Stream st = new FileStream("katastasixristwn.txt", FileMode.OpenOrCreate);
        st.Close();

        string d;
        using (StreamReader file = File.OpenText("katastasixristwn.txt"))
        { //diavazei to arxeio
            while ((d = file.ReadLine()) != null)
            {
                string[] tmp = d.Split(' ');
                user.Add(tmp[0]);
                scorelist.Add(int.Parse(tmp[1]));
            }
        }
    }
        public void SetUser(string txtbx)
        {

            foreach (string c in user)
            {
                index++; //anevenei kathe fora p diavazete ena stoixeio tis listas
                if (c == txtbx)

                {

                    paliospaiktis = true;
                    MessageBox.Show("You logged in succesfully!");
                    ////  richTextBox1.Text = index.ToString();
                    /// richTextBox1.Visible = true;
                    // richTextBox1.SaveFile("myfile.txt", RichTextBoxStreamType.PlainText);

                    f1.Hide();
                    f2.ShowDialog();
                    break;
                }
            }

            if (paliospaiktis == false)
            {
                if (txtbx == "")
                    MessageBox.Show("Please write a username.");
                else if (txtbx.Contains(' '))
                    MessageBox.Show("Don't use space letters.");

                else
                {
                    user.Add(txtbx);
                    index = user.Count();
                    //// f1.richTextBox1.Text = index.ToString();
                    // f1.richTextBox1.Visible = true;
                    // f1.richTextBox1.SaveFile("myfile.txt", RichTextBoxStreamType.PlainText);
                    scorelist.Add(0);

                    File.AppendAllText("katastasixristwn.txt", txtbx + " " + 0 + Environment.NewLine);

                    MessageBox.Show("Your account has been created!");


                    f1.Hide();
                    f2.ShowDialog();


                }
            }
        }

    } */
}
