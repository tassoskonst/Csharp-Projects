using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp12.Properties;

namespace WindowsFormsApp12
{
    public partial class Form4 : Form
    {

        Image File;

        public Form4()
        {
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.img1;
            pictureBox2.Image = Properties.Resources.img2;
            pictureBox3.Image = Properties.Resources.img3;
            pictureBox4.Image = Properties.Resources.img4;
            pictureBox5.Image = Properties.Resources.img5;
            pictureBox6.Image = Properties.Resources.img6;
            pictureBox7.Image = Properties.Resources.img7;
            pictureBox8.Image = Properties.Resources.img8;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if(f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox1.Image = File;
                

                //Bitmap p1 = new Bitmap("C://Users//Tassos//Documents//Visual Studio 2017//Projects//WindowsFormsApp12//WindowsFormsApp12//WindowsFormsApp12//bin//Debug//img1.jpg");
                //p1 = pictureBox1.Image ;
            }

            /*
            SaveFileDialog ff = new SaveFileDialog();
            ff.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(ff.FileName);
            }
            */

            }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            Image myimage = new Bitmap(@"C:\\Users\\Tassos\\Pictures\\WindowsFormsApp12\\WindowsFormsApp12\\bin\\Debug\\LavaForm4.jpg");
            this.BackgroundImage = myimage;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox2.Image = File;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox3.Image = File;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox4.Image = File;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox8.Image = File;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox7.Image = File;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox6.Image = File;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox5.Image = File;
            }
        }
    }
}
