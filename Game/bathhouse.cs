﻿ using System;
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
    public partial class bathhouse : Form
    {
        public int intel;
        public int hel;
        public int per;
        public int strength;
        public int agil;
        public int stel;
        public bathhouse(int h, int a, int st, int str, int p, int i, string n, string c)
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
            des.Text = "After you defeat the guards you continue up another flight of stairs.\nAs you make it to the next floor you are greeted by a soaking tub.";
            Roompic.Image = Properties.Resources.bathhouse;
            Roompic.SizeMode = PictureBoxSizeMode.StretchImage;
            button1.Text = "Get In Tub";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Get In Tub")
            {
                des.Text = "As you get in the tub you can feel your strength come back to you.\nYou gain 5 health.";
                hel = hel + 5;
                Health.Text = "" + hel;
                button1.Text = "";
                button2.Text = "Get Out And Continue To Next Room";
            }
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Get Out And Continue To Next Room")
            {
                Garden xd = new Garden(hel, agil, stel, strength, per, intel, CName.Text, Class.Text);
                xd.Show();
                Hide();
            }
        }
    }
}
