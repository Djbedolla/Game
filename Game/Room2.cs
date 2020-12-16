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
    public partial class Room2 : Form
    {
        public int intel;
        public int hel;
        public int per;
        public int strength;
        public int agil;
        public int stel;
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
            button1.Text = "Sneak Past guards";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stel >= 4)
            {
                des.Text = "You manage to sneak past the guards without waking them up.";
                button2.Text = "Continue To Next Room";
            }
            else
            {
                des.Text = "As you walk down the hall ou start hearing a sound and then you hear the guards shout to each other. Get Him!";
                button1.Text = "";
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="Continue To Next Room.")
            {
                bathhouse xd = new bathhouse(hel, agil, stel, strength, per, intel, CName.Text, Class.Text);
            }
        }
    }
}
