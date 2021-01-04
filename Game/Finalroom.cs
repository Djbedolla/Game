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
    public partial class Finalroom : Form
    {
        public int intel;
        public int hel;
        public int per;
        public int strength;
        public int agil;
        public int stel;
        public int guard = 15;
        public Finalroom(int h, int a, int st, int str, int p, int i, string n, string c)
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
            des.Text = "You Continue up yet another flight of stairs and you see it. The gem stone from\n the legend. Finally it is yours. You step forward to grab but you hear\n a door slam shut and demonic voice yell, STOP RIGHT THERE! You turn\n around and you see a giant oni carrying a club. He says if you want the gem\n you will have to solve his riddle or defeat him in combat.";
                
            Roompic.Image = Properties.Resources.oni;
            Roompic.SizeMode = PictureBoxSizeMode.StretchImage;
            button4.Text = "Riddle";
            button1.Text = "Combat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Combat")
            {
                des.Text = "The oni yells prepare to DIE! He swings at you with his giant club!";
                button1.Text = "";
                button2.Text = "Block";
                button3.Text = "Dodge";
                button4.Text = "";
            }
            if (button1.Text == "Attack")
            {
                Random rnd = new Random();
                int attack = rnd.Next(1, 10);
                int x = attack + strength;
                if (x > 7)
                {
                    des.Text = "You hit the oni but he is Attacking you!";
                    button1.Text = "";
                    button2.Text = "Block";
                    button3.Text = "Dodge";
                    guard = guard - 3;
                    if (guard <= 0)
                    {
                        bool r = false;
                        win xd = new win(r);
                        xd.Show();
                        Hide();
                        
                    }


                    
                    

                }
                else
                {
                    des.Text = "You missed and he is attacking you!";
                    button1.Text = "";
                    button2.Text = "Block";
                    button3.Text = "Dodge";
                }
                
            }
            if (button1.Text == "Wolves")
            {
                des.Text = "The oni says wrong answer and prepare to DIE! He swings his giant club\n at you!";
                button1.Text = "";
                button2.Text = "Block";
                button3.Text = "Dodge";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            if (button2.Text == "Block")
            {
                Random rnd = new Random();
                int Block = rnd.Next(1, 10);
                int x = Block + strength;
                if (x < 12)
                {
                    des.Text = "You weren't able to block his attack and take one damage.";
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
                    des.Text = "You blocked his attack.";
                    button1.Text = "Attack";
                    button2.Text = "";
                    button3.Text = "";
                }
            }
            if (button2.Text == "Dreams")
            {
                des.Text = "The oni says wrong answer and prepare to DIE! He swings his giant club\n at you!";
                button1.Text = "";
                button2.Text = "Block";
                button3.Text = "Dodge";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Dodge")
            {

                Random rnd = new Random();
                int Dodge = rnd.Next(1, 10);
                int x = Dodge + agil;
                if (x < 6)
                {
                    des.Text = "You weren't able to Dodge his attack and take three damage.";
                    hel = hel - 3;
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
                    des.Text = "You dodged his attack.";
                    button1.Text = "Attack";
                    button2.Text = "";
                    button3.Text = "";
                }
            }
            if (button3.Text == "Stars")
            {
                bool r = true;
                win xd = new win(r);
                xd.Show();
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Riddle")
            {
                des.Text = "You say want the riddle and the oni responds by saying, At night they come\n without being fetched and by day they are lost without being stolen.\n What are they?";

                button3.Text = "Stars";
                button1.Text = "Wolves";
                button2.Text = "Dreams";
                button4.Text = "";
            }
        }
    }
}
