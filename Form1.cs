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
        int[] userpattern = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int spot = 0;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void flash()
        {
            Color[] userPattern = new Color[pattern.Length];
            for (int i = 0; i < pattern.Length; i++)
            {
                switch (pattern[i])
                {
                    case 1:
                        pb1.BackColor = Color.Red;
                        this.Update();
                        Thread.Sleep(500);
                        pb1.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(500);
                        break;
                    case 2:
                        pb2.BackColor = Color.Blue;
                        this.Update();
                        Thread.Sleep(500);
                        pb2.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(500);
                        break;
                    case 3:
                        pb3.BackColor = Color.Orange;
                        this.Update();
                        Thread.Sleep(500);
                        pb3.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(500);
                        break;
                    case 4:
                        pb4.BackColor = Color.LimeGreen;
                        this.Update();
                        Thread.Sleep(500);
                        pb4.BackColor = Color.LightGray;
                        this.Update();
                        Thread.Sleep(500);
                        break;
                }
                MessageBox.Show("enter colour: ");
                string input = Console.ReadLine();


            }
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
            int num_in_name = int.Parse(broken[2].ToString() + broken[2]);


        }
    }
   
}

