using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Room1 : Form
    {


        public int intel;
        public int hel;
        public int per;        
        public int strength;
        public int agil;
        public int stel;

        public Room1(int h, int a, int str, int st, int p, int i, string n, string c)
        {
            InitializeComponent();
            intel = i;
            agil = a;
            strength = str;
            hel = h;
            per = p;
            stel = st;
            Health.Text = Convert.ToString(hel);
            Agility.Text = Convert.ToString(agil);
            Strength.Text = Convert.ToString(strength);
            Stealth.Text = Convert.ToString(stel);
            Perception.Text = Convert.ToString(per);
            Int.Text = Convert.ToString(intel);
            Convert.ToInt32(hel);
            Convert.ToInt32(agil);
            Convert.ToInt32(strength);
            Convert.ToInt32(per);
            Convert.ToInt32(intel);




            CName.Text = n;
            Class.Text = c;
            if (c == "Ninja")
            {
                Cel.Image = Properties.Resources.ninja;
                Cel.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (c == "Samurai")
            {
                Cel.Image = Properties.Resources.samurai;
                Cel.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (c == "Ronin")
            {
                Cel.Image = Properties.Resources.ronin;
                Cel.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                Cel.Image = Properties.Resources.monk;
                Cel.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            des.Text = "You Enter a Dark Room That appears to be empty. The wooden floor and\n walls are old and rough. ";
            Roompic.Image = Properties.Resources.room1;
            Roompic.SizeMode = PictureBoxSizeMode.StretchImage;
            
            




        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           if(button1.Text=="Search Room")
            {
              des.Text = "You look around the room And you find a small crack in the wall.\n Through the crack you can see a dim candle light. You keep shearching and\n find a small metal hole in the wall";
              button2.Text = "Investigate hole";
              
            }
            if (button1.Text == "Dodge")
            {
                if (agil >= 4)
                {
                    des.Text="You manage to dodge the arrow just in time! You Look back at the hole\n is now closed.";
                }
                else
                {
                    des.Text = "You aren't quick enough and the arrow strick you in th arm. You take two\n damage and the hole in now closed.";
                    hel = hel - 2;
                    Health.Text = Convert.ToString(hel);
                    Convert.ToInt32(hel);
                    button1.Text = "Break Down Door";
                   
                }
            }
            if(button1.Text=="Break Down Door")
            {
                if (strength >= 5)
                {
                    des.Text = "You manage to break down the door with ease.";
                }
                else
                {
                    des.Text = "You barely manage to break down the door and you take one damage.";
                    hel = hel - 1;
                    Health.Text = Convert.ToString(hel);
                    Convert.ToInt32(hel);

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (button2.Text == "Investigate hole")
            {
                if (intel >= 4 && per >= 2)
                {
                    des.Text = "The hole seems to be some type of lock";
                    button2.Text=("Pick Lock");
                }
                else
                {
                    des.Text = "It appears to be a small metal hole in the wall";
                    button1.Text = "Break Down Door";
                }
                
            }
            else if(button2.Text=="Pick Lock")
            {
                if (intel >= 5)
                {
                    des.Text = "You have succesfully picke the lock and the door gently creeks open";
                }
                else
                {
                    des.Text = "While you are picking the lock you \nstart hearing a clicking sound. You countinue picking the lock and out of\nthe corner of your eye you see a trap door open and out comes a flying arrow";
                    button1.Text = "Dodge";
                    button2.Text = "";
                }

            }
        }

        
    }
}
