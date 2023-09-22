using System;
using System.Windows.Forms;

namespace As_racing_car_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }

        int collectedcoin = 0;




        Random r = new Random();
        int x,y;
        
       
        void enemy(int speed)
        {

            if (A1.Top >= 500)
            {
                x = r.Next(0, 40);
                A1.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                A1.Top += speed;
            }
            if (A2.Top >= 500)
            {
                x = r.Next(65, 115);
                A2.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                A2.Top += speed;
            }
            if (A3.Top >= 500)
            {
                x = r.Next(126, 220);
                A3.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                A3.Top += speed;
            }
        }
        void coins(int speed)
        {

            if (C1.Top >= 500)
            {
                x = r.Next(50, 100);
                C1.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                C1.Top += speed;
            }
            if (C2.Top >= 500)
            {
                x = r.Next(40, 100);
                C2.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                C2.Top += speed;
            }
            if (C3.Top >= 500)
            {
                x = r.Next(40, 100);
                C3.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                C3.Top += speed;
            }
            if (C4.Top >= 500)
            {
                x = r.Next(40, 150);
                C4.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                C4.Top += speed;
            }
            if (C5.Top >= 500)
            {
                x = r.Next(40, 150);
                C5.Location = new System.Drawing.Point(x, 0);
            }
            else
            {
                C5.Top += speed;
            }
        }




            void gameover()
        {
            if (car.Bounds.IntersectsWith(A1.Bounds))
            {
                RoadMover.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(A2.Bounds))
            {
                RoadMover.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(A2.Bounds))
            {
                RoadMover.Enabled = false;
                over.Visible = true;
            }
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(C1.Bounds))
            {
                collectedcoin++;
                label1.Text ="Coins"+collectedcoin.ToString();
                x = r.Next(50, 100);
                C1.Location = new System.Drawing.Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(C2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(40, 100);
                C2.Location = new System.Drawing.Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(C3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(40, 100);
               C3.Location = new System.Drawing.Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(C4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(40, 150);
                C4.Location = new System.Drawing.Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(C5.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(40, 150);
                C5.Location = new System.Drawing.Point(x, 0);
            }
        }






        int gamespeed = 0;
 private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 225)
                    car.Left += 5;
            }
            if(e.KeyCode==Keys.Up)
            {
                if (gamespeed<21)
                 gamespeed++; }
                    if(e.KeyCode== Keys.Down)
            {
                if (gamespeed>0)
                 gamespeed--; }
        }

        

    }
}

    
    

