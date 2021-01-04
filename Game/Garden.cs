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
    public partial class Garden : Form
    {
        public int intel;
        public int hel;
        public int per;
        public int strength;
        public int agil;
        public int stel;
        public Garden(int h, int a, int st, int str, int p, int i, string n, string c)
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
            des.Text = "After your bath you continue up another flight of stairs and come to what\n seems to be garden. There are trees with what seem to have fruit on them.";
            Roompic.Image = Properties.Resources.garden;
            Roompic.SizeMode = PictureBoxSizeMode.StretchImage;
            button1.Text = "Eat fruit";
            button2.Text = "Continue to next room";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="Eat fruit")
            {
                Random rnd = new Random();
                int x = rnd.Next(1, 4);
                if (x == 1)
                {
                    des.Text = "The fruit appears to do nothing";
                }
                if (x == 2)
                {
                    des.Text = "The fruit makes you feel much better. You heal 2 damage.";
                    hel = hel + 2;
                    Health.Text = "" + hel;
                }
                if (x == 3)
                {
                    des.Text = "The fruit makes you feel horrible. You take 2 damage";
                    hel = hel - 2;
                    Health.Text = "" + hel;
                    if (hel <= 0)
                    {
                        Lose xd = new Lose();
                        xd.Show();
                        Hide();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="Continue to next room")
            {
                Finalroom xd = new Finalroom(hel, agil, stel, strength, per, intel, CName.Text, Class.Text);
                xd.Show();
                Hide();
            }
        }
    }
}
