using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace simon_says
{
    public partial class Form1 : Form
    {
        int[] pattern = { 1, 2, 4, 3, 3, 2, 1, 1, 2, 4 };
        int [] userpattern = new int[10];
        int spot = 0;
        public Form1()
        {
           
            InitializeComponent();
        }

        int score = 0;
        int rounds = 0;
        private void PlaySound(System.IO.Stream sound)
        {
            SoundPlayer cool = new SoundPlayer(sound);
                cool.Play();
            }
        
        private void flash()
        {
            Random box = new Random();
            int patternlength = pattern.Length + 1;

            for (int i = 0; i < pattern.Length; i++)
            {
                int nextnum = box.Next(1, 5);
                pattern[i]= nextnum;

                switch (nextnum)
                {
                    case 1:
                        PlaySound(Properties.Resources.red);
                        pb1.BackColor = Color.Red;
                        this.Update();
                        Thread.Sleep(1000);
                        pb1.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        PlaySound(Properties.Resources.blue);
                        pb2.BackColor = Color.Blue;
                        this.Update();
                        Thread.Sleep(1000);
                        pb2.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(1000);
                        break;
                    case 3:
                        PlaySound(Properties.Resources.orange);
                        pb3.BackColor = Color.Orange;
                        this.Update();
                        Thread.Sleep(1000);
                        pb3.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(1000);
                        break;
                    case 4:
                        PlaySound(Properties.Resources.green);
                        pb4.BackColor = Color.LimeGreen;
                        this.Update();
                        Thread.Sleep(1000);
                        pb4.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(1000);
                        break;
                }

            }
            Thread.Sleep(500);
            MessageBox.Show("enter colours in correct order ");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            flash();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void all(object sender, EventArgs e)
        {
            PictureBox picked = (PictureBox)sender;
            char[] broken = picked.Name.ToCharArray();
            int num_in_name = int.Parse(broken[2].ToString());
            // spot
            userpattern[spot] = num_in_name;

            //if not game over
            if (userpattern[spot] != pattern[spot])
            {
                MessageBox.Show("Wrong color!, Unfornatley, u lost");
                this.Close();
            }
            spot++;
            // wim
            if (spot == pattern.Length)
            {
                score += 10;
                rounds++;
                MessageBox.Show("You win! time for more rounds!");
                spot = 0;
                Array.Clear(userpattern, 0, userpattern.Length);

            }
            if ( score >= 100)
            {
                MessageBox.Show("You win everythin!");
                this.Close();

            }
            else if (rounds == 10)
            {
                MessageBox.Show("You have completed 10 rounds! Game over!");
                this.Close();
            }
        }



    }
    }
   

