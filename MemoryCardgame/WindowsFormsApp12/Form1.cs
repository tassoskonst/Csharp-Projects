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
    
    public partial class Form1 : Form
    {

        //Image File;


        bool check = false; 
        PictureBox firstGuess;   
        Random rnd = new Random();
        Timer clkTimer = new Timer();
        int time = 0;
        Timer timer = new Timer { Interval=1000};
        PictureBox[] picArray;

        public Form1()
        {
            InitializeComponent();
            richTextBox2.LoadFile("myfile.txt", RichTextBoxStreamType.PlainText);
            richTextBox3.LoadFile("myfileB.txt", RichTextBoxStreamType.PlainText);
        }

        int Ts = 0;

        private PictureBox[] pictureBoxes//this is the PictureBox function, we are going to add all the pictureboxes to an Array
        {
            get { return Controls.OfType<PictureBox>().ToArray(); } //pernaei ola ta arxeia typou picture se pinaka 
            
        }


        /* This functions purpose is to link the images which we imported to the resources
        earlier using a static IEnumerable<image> in the title of this function.What this means is we are
        going to create an array of Image class and we need to have access to those files. */
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.img1,
                    Properties.Resources.img2,
                    Properties.Resources.img3,
                    Properties.Resources.img4,
                    Properties.Resources.img5,
                    Properties.Resources.img6,
                    Properties.Resources.img7,
                    Properties.Resources.img8,
                };
            }
        }

        private void timerbeggin()
        {
            timer.Start();
            timer.Tick += delegate //gia to event .tick 
            {
                time++;
                
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text = "00: " + time.ToString();
            };
        }


        private void PictureboxesHidde()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
            }
        }
        /* This function will run a foreach loop through the form looking for picture box components and it will mask them with
        the question mark image we imported  */


        private void PictureBoxesRandom()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        /*In this function above we are running  loop, this loop will look for images and try to find a pair of slots where both can be tagged
        with the same name,
        this giving us a change to match the images with each other. */



        private void ImagesResetAfterRound()
        {
            foreach (var pic in  pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;

            }

            PictureboxesHidde();
            PictureBoxesRandom();
            time = 00;
            timer.Start();
        }
        /* This function will be resetting the picture boxes. This function will be used when we are allowing the user to play the
        game again after their first round */





        private PictureBox getFreeSlot()
        {
            int num ;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];

        }
        /* This function  when this runs it will return a value back to the 
        program. In this
        function we are first declaring an integer num, then we are going to run a do LOOP which will loop 
        through all of the
        picture boxes randomly. While loop will check which picture boxes tags are = null or EMPTY and 
        then we will return
        those back to the program. By doing this process we can randomly select a pair of picture boxes.
         */

        
       

        private void CLICKTIMER_TICK(object sender,EventArgs e)
        {
            PictureboxesHidde();
            check = true;
            clkTimer.Stop();

        }
        /* this function will first hide all of the images by using the HideImages() function
[discussed a little later], will change the allow click Boolean to true and then stop the timer itself. 
This timer only has these instructions to run so it can stop when its successful*/
        



        private void Form1_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap("C:\\Users\\Tassos\\Pictures\\WindowsFormsApp12\\WindowsFormsApp12\\bin\\Debug\\WhoseForm1.jpg");
            this.BackgroundImage = myimage;
            
        }
        
        private void clickImage(object sender, EventArgs e)
        {

            Ts = Ts + 1;
            if (!check) return;// is isClicked is false then return back to the program without 
           //doing anything else.
            var pic = (PictureBox)sender;// in this line we creating a local variable, which will only 
            // be used inside this function called pic. This variable will identify which picture box was clicked or where this event came from.


            /* If the first guess is bull or empty, then we are going to allow the pic variable to become our first guess, since the pic
variable is a type of picture box it has the same properties as one, therefore we can use the pic.Image property to set
any images to it. In the later line we are setting an image to the pic variable using (Image)pic.Tag value.*/
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;//to image pairnei tin fotografia gia etiketa
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)//tairiazei tis etiketes
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                PictureboxesHidde();

            }
            else
            {
                check = false;
                clkTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible))
            {
                
                return;
                

                

            } //This line is checking if there any visible picture boxes left on the screen
            MessageBox.Show("You win with time  " + time.ToString()  + "sec, now try again," + " your tries were " + Ts );
            richTextBox2.Text = (richTextBox2.Text) + "\n" + (richTextBox1.Text + " " + Ts) ;
            richTextBox2.SaveFile("myfile.txt", RichTextBoxStreamType.PlainText);

            richTextBox3.Text = (richTextBox3.Text) + "\n" + (richTextBox1.Text + " " + time.ToString() );
            richTextBox3.SaveFile("myfileB.txt", RichTextBoxStreamType.PlainText);

            Ts = 0;
            //button1.Enabled = true;
            ImagesResetAfterRound();//If all of the picture boxes are matched and done then we run this message box to show the player has won and run
                         //the Set Images below. This will restart the game for the player.

            clkTimer.Stop();//1
        }

        private void startGame(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                check = true;
                PictureBoxesRandom();
                PictureboxesHidde();
                timerbeggin();
                clkTimer.Interval = 1000;
                clkTimer.Tick += CLICKTIMER_TICK;
                //2 button1.Enabled = false;
                timer.Enabled = true;//3
            }
            else
            {
                timer.Enabled = false;//4
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            check = true;
            PictureBoxesRandom();
            PictureboxesHidde();
            timerbeggin();
            clkTimer.Interval = 1000;
            clkTimer.Tick += CLICKTIMER_TICK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox17.Image = File;


                Bitmap p1 = new Bitmap("C://Users//Tassos//Documents//Visual Studio 2017//Projects//WindowsFormsApp12//WindowsFormsApp12//WindowsFormsApp12//bin//Debug//img10.jpg");
                //p1 = pictureBox1.Image ;
               
            }

            
            SaveFileDialog ff = new SaveFileDialog();
            ff.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File.Save(ff.FileName);
            }
            */
        }
    }
}
