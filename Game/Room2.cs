﻿using System;
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
    public partial class Room2 : Form
    {
        public int intel;
        public int hel;
        public int per;
        public int strength;
        public int agil;
        public int stel;
        public int guard =10;
        public int d = 0;
        
        
        public Room2(int h, int a, int st, int str, int p, int i, string n, string c)
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
            Convert.ToInt32(stel);




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
            des.Text = "You walk up a flight of stairs and come to a long hall. There are panels on \nyour right and left and shadows behind the panels. They appear to be \nsleeping guards.";
            Roompic.Image = Properties.Resources.guardroom;
            Roompic.SizeMode = PictureBoxSizeMode.StretchImage;
            button1.Text = "Sneak Past Guards";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (stel >= 4&&button1.Text=="Sneak Past Guards")
            {
                des.Text = "You manage to sneak past the guards without waking them up.";
                button2.Text = "Continue To Next Room";
            }
            else if(button1.Text == "Sneak Past Guards")
            {
                des.Text = "As you walk down the hall you start hearing a sound and then you hear the\n guards shout to each other. Get Him!\n Three guards appear. They have swords and are getting ready to attack you!\n The first guards swing his sword!";
                button1.Text = "";
                button2.Text = "Block";
                button3.Text = "Dodge";
               
            }
            if (button1.Text == "Attack")
            {
                Random rnd = new Random();
                int attack = rnd.Next(1, 10);
                int x = attack + strength;
                if (x > 8)
                {
                    des.Text = "You hit one of the guards but another one is Attacking you!";
                    guard = guard- 5;
                    if (guard <= 0)
                    {
                        
                        guard = 10;
                        des.Text="You killed one of the guards!";
                        d = d + 1;
                    }


                    if (d < 3)
                    {
                        button1.Text = "";
                        button2.Text = "Block";
                        button3.Text = "Dodge";
                    }
                    else
                    {
                        des.Text = "You managed to kill all the guards!";
                        button1.Text = "";
                        button2.Text = "Continue To Next Room";
                        button3.Text = "";
                    }
                    
                }
                else
                {
                    des.Text = "You missed and another guard is attacking you!";
                    button1.Text = "";
                    button2.Text = "Block";
                    button3.Text = "Dodge";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="Continue To Next Room")
            {
                bathhouse xd = new bathhouse(hel, agil, stel, strength, per, intel, CName.Text, Class.Text);
                xd.Show();
                Hide();
            }
            if (button2.Text == "Block")
            {
                Random rnd = new Random();
                int Block = rnd.Next(1, 10);
                int x = Block + strength;
                if (x < 8)
                {
                    des.Text = "You weren't able to block his attack and take one damage.";
                    hel = hel -1;
                    Health.Text = "" + hel;
                    if (hel <= 0)
                    {
                        Lose xd = new Lose();
                        xd.Show();
                        Hide();
                    }
                    button1.Text = "Attack";
                    button2.Text = "";
                    button3.Text = "";
                }
                else
                {
                    des.Text = "You blocked his attack.";
                    button1.Text = "Attack";
                    button2.Text = "";
                    button3.Text = "";
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Dodge")
            {

                Random rnd = new Random();
                int Dodge = rnd.Next(1, 10);
                int x = Dodge + agil;
                if (x < 8)
                {
                    des.Text = "You weren't able to Dodge his attack and take one damage.";
                    hel = hel - 1;
                    Health.Text = "" + hel;
                    if (hel <= 0)
                    {
                        Lose xd = new Lose();
                        xd.Show();
                        Hide();
                    }
                    button1.Text = "Attack";
                    button2.Text = "";
                    button3.Text = "";
                }
                else
                {
                    des.Text="You dodged his attack.";
                    button1.Text = "Attack";
                    button2.Text = "";
                    button3.Text = "";
                }
            }
        }
    }
}
