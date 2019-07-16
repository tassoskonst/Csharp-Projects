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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\\Users\\Tassos\\Pictures\\WindowsFormsApp12\\WindowsFormsApp12\\bin\\Debug\\ASHform2.jpg");
            this.BackgroundImage = myimage;
            //panel1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal )+ @"\ASHform2.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
