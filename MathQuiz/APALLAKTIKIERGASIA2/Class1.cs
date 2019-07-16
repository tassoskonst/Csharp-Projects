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
    public class Class1
    {
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
        public List<string> user = new List<string>();
        public List<int> scorelist = new List<int>();
        bool paliospaiktis;
        public int index;
        public int per1;
        public int score;
        public string txtbx;
        public string flag;
        public string st;
        public string rtB;

        public void SetUser()
        {

            foreach (string c in user)
            {
                index++; //anevenei kathe fora p diavazete ena stoixeio tis listas
                File.WriteAllText("myfile.txt", index.ToString());
                if (c == txtbx)

                {
                    paliospaiktis = true;
                    MessageBox.Show("You logged in succesfully!");
                    //rtB = index.ToString();

                    flag = "succes";


                    break;

                }

            }

            if (paliospaiktis == false)
            {
                if (txtbx == "")
                {
                    flag = "no username";
                    MessageBox.Show("Please write a username.");

                }
                else if (txtbx.Contains(' '))
                {
                    flag = "dont use space";
                    MessageBox.Show("Don't use space letters.");
                }
                else
                {
                    user.Add(txtbx);
                    index = user.Count();
                    File.WriteAllText("myfile.txt", index.ToString());
                    scorelist.Add(0);
                    File.AppendAllText("katastasixristwn.txt", txtbx + " " + 0 + Environment.NewLine);
                    MessageBox.Show("Your account has been created!");
                    flag = "succes";

                }
            }

        }

        public void GetUser()
        {

            string dd;
            using (StreamReader file2 = File.OpenText("myfile.txt"))
            { //diavazei to arxeio
                while ((dd = file2.ReadLine()) != null)
                {
                   index = int.Parse(dd);
                }
               
                   scorelist[index - 1] += per1;
                    score = scorelist[index - 1];
                    File.WriteAllText("katastasixristwn.txt", "");
                    for (int i = 0; i < user.Count() - 1; i++)
                    {
                        File.AppendAllText("katastasixristwn.txt", user[i] + " " + scorelist[i] + Environment.NewLine);
                    }
                    

            }
        }
    }
}

        
    

