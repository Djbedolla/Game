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
    public partial class Character : Form
    {
       
        public Character()
        {
            InitializeComponent();
            
        }
        
        int th, s, a, p, i;
        int str, st, intel, ag, per;

        private void Character_Load(object sender, EventArgs e)
        {
            
        }

        CharStat Char = new CharStat();
        
        



        private void St_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = Convert.ToInt32(St.Text);
            Char.Stealth = s + st;
        }
        private void Str_SelectedIndexChanged(object sender, EventArgs e)
        {
            th = Convert.ToInt32(Str.Text);            
            Char.Strength = th + str ;
            Fstr.Text = Convert.ToString(Char.Strength);
        }   
        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class.Text == "Ninja")
            {

                pb.Image = Properties.Resources.ninja;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                
                StBn.Text = "+4";
                AgBn.Text = "+2";
                StrBn.Text = "-1";
                HpBn.Text = "+0";
                PerBn.Text = "+1";
                IntBn.Text = "+1";
                str =Convert.ToInt32(StrBn.Text);
                Char.Strength = th + str;
                Fstr.Text = Convert.ToString(Char.Strength);
                


            }
            if (Class.Text == "Samurai")
            {
                pb.Image = Properties.Resources.samurai;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                StrBn.Text = "+3";
                HpBn.Text = "+3";
                StBn.Text = "-3";
                PerBn.Text = "+2";
                IntBn.Text = "+2";
                AgBn.Text = "-2";
                str = Convert.ToInt32(StrBn.Text);
                Char.Strength = th + str;
                Fstr.Text = Convert.ToString(Char.Strength);






            }
            if (Class.Text == "Ronin")
            {
                pb.Image = Properties.Resources.ronin;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                StrBn.Text = "+2";
                AgBn.Text = "+2";
                HpBn.Text = "+1";
                StBn.Text = "+1";
                PerBn.Text = "-2";
                IntBn.Text = "+1";

                str = Convert.ToInt32(StrBn.Text);
                Char.Strength = th + str;
                Fstr.Text = Convert.ToString(Char.Strength);
                Char.Agility = Char.Agility + 2;
                Char.Stealth = Char.Stealth + 1;
                Char.Health = Char.Health + 1;
                Char.Perception = Char.Perception - 1;
                Char.Intelligence = Char.Intelligence + 1;

            }
            if (Class.Text == "Monk")
            {
                pb.Image = Properties.Resources.monk;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                StrBn.Text = "+1";
                AgBn.Text = "+3";
                HpBn.Text = "+0";
                StBn.Text = "+2";
                PerBn.Text = "+1";
                IntBn.Text = "+3";


                str = Convert.ToInt32(StrBn.Text);
                Char.Strength = th + str;
                Fstr.Text = Convert.ToString(Char.Strength);
                Char.Agility = Char.Agility + 3;
                Char.Stealth = Char.Stealth + 2;
                Char.Health = Char.Health + 0;
                Char.Perception = Char.Perception + 1;
                Char.Intelligence = Char.Intelligence + 3;
            }
            
            

        }
        



    }
    
}
