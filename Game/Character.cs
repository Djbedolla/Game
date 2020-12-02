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
            this.Str.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Per.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Int.DropDownStyle = ComboBoxStyle.DropDownList;
            this.St.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Class.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Ag.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Character_Load(object sender, EventArgs e)
        {

        }
        int th, s, a, p, i;
        int str, st, intel, ag, per;

        private void Create_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0&&Class.Text.Length>0&&Str.Text.Length>0&&St.Text.Length>0&&Int.Text.Length>0&&Ag.Text.Length>0&&Per.Text.Length>0)
            {
                Room1 n = new Room1();
                n.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please finish selecting a Name, Class, and Stats to continue.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Char.name = textBox1.Text;
        }

        

        

        CharStat Char = new CharStat();
        private void Per_SelectedIndexChanged(object sender, EventArgs e)
        {
            p = Convert.ToInt32(Per.Text);
            Char.Perception = p + per;
            characterperception.Text = Convert.ToString(Char.Perception);

            Ag.Items.AddRange(new string[] { "5", "4", "3", "2", "1" });
            Int.Items.AddRange(new string[] { "5", "4", "3", "2", "1" });
            St.Items.AddRange(new string[] { "5", "4", "3", "2", "1" });
            Str.Items.AddRange(new string[] { "5", "4", "3", "2", "1" });


            if (p == 5)
            {
                Ag.Items.Remove("5");
                Int.Items.Remove("5");
                St.Items.Remove("5");
                Str.Items.Remove("5");
            }
            if (p == 4)
            {
                Ag.Items.Remove("4");
                Int.Items.Remove("4");
                St.Items.Remove("4");
                Str.Items.Remove("4");
            }
            if (p == 3)
            {
                Ag.Items.Remove("3");
                Int.Items.Remove("3");
                St.Items.Remove("3");
                Str.Items.Remove("3");
            }
            if (p == 2)
            {
                Ag.Items.Remove("2");
                Int.Items.Remove("2");
                St.Items.Remove("2");
                Str.Items.Remove("2");
            }
            if (p == 1)
            {
                Ag.Items.Remove("1");
                Int.Items.Remove("1");
                St.Items.Remove("1");
                Str.Items.Remove("1");
            }

        }
        private void Int_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = Convert.ToInt32(Int.Text);
            Char.Intelligence = i + intel;
            characterintelligence.Text = Convert.ToString(Char.Intelligence);
        }
        private void Ag_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(Ag.Text);
            Char.Agility = a+ag;
            characteragility.Text = Convert.ToString(Char.Agility);

        }
        private void St_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = Convert.ToInt32(St.Text);
            Char.Stealth = s + st;
            characterstealth.Text = Convert.ToString(Char.Stealth);
        }
        private void Str_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            th = Convert.ToInt32(Str.Text);            
            Char.Strength = th + str ;
            characterstrength.Text = Convert.ToString(Char.Strength);
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
                characterstrength.Text = Convert.ToString(Char.Strength);
                
                st = Convert.ToInt32(StBn.Text);
                Char.Stealth = s + st;
                characterstealth.Text = Convert.ToString(Char.Stealth);

                ag = Convert.ToInt32(AgBn.Text);
                Char.Agility = a + ag;
                characteragility.Text = Convert.ToString(Char.Agility);

                intel = Convert.ToInt32(IntBn.Text);
                Char.Intelligence = i + intel;
                characterintelligence.Text = Convert.ToString(Char.Intelligence);
                
                per = Convert.ToInt32(PerBn.Text);
                Char.Perception = p + per;
                characterperception.Text = Convert.ToString(Char.Perception);

                Char.Health = 10 + Convert.ToInt32(HpBn.Text);
                characterhealth.Text = Convert.ToString(Char.Health);



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
                characterstrength.Text = Convert.ToString(Char.Strength);
                
                st = Convert.ToInt32(StBn.Text);
                Char.Stealth = s + st;
                characterstealth.Text = Convert.ToString(Char.Stealth);

                ag = Convert.ToInt32(AgBn.Text);
                Char.Agility = a + ag;
                characteragility.Text = Convert.ToString(Char.Agility);
                
                intel = Convert.ToInt32(IntBn.Text);
                Char.Intelligence = i + intel;
                characterintelligence.Text = Convert.ToString(Char.Intelligence);

                per = Convert.ToInt32(PerBn.Text);
                Char.Perception = p + per;
                characterperception.Text = Convert.ToString(Char.Perception);

                Char.Health = 10 + Convert.ToInt32(HpBn.Text);
                characterhealth.Text = Convert.ToString(Char.Health);






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
                characterstrength.Text = Convert.ToString(Char.Strength);
                
                st = Convert.ToInt32(StBn.Text);
                Char.Stealth = s + st;
                characterstealth.Text = Convert.ToString(Char.Stealth);

                ag = Convert.ToInt32(AgBn.Text);
                Char.Agility = a + ag;
                characteragility.Text = Convert.ToString(Char.Agility);

                intel = Convert.ToInt32(IntBn.Text);
                Char.Intelligence = i + intel;
                characterintelligence.Text = Convert.ToString(Char.Intelligence);

                per = Convert.ToInt32(PerBn.Text);
                Char.Perception = p + per;
                characterperception.Text = Convert.ToString(Char.Perception);
                
                Char.Health = 10 + Convert.ToInt32(HpBn.Text);
                characterhealth.Text = Convert.ToString(Char.Health);


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
                characterstrength.Text = Convert.ToString(Char.Strength);

                st = Convert.ToInt32(StBn.Text);
                Char.Stealth = s + st;
                characterstealth.Text = Convert.ToString(Char.Stealth);

                ag = Convert.ToInt32(AgBn.Text);
                Char.Agility = a + ag;
                characteragility.Text = Convert.ToString(Char.Agility);

                intel = Convert.ToInt32(IntBn.Text);
                Char.Intelligence = i + intel;
                characterintelligence.Text = Convert.ToString(Char.Intelligence);

                per = Convert.ToInt32(PerBn.Text);
                Char.Perception = p + per;
                characterperception.Text = Convert.ToString(Char.Perception);

                Char.Health = 10 + Convert.ToInt32(HpBn.Text);
                characterhealth.Text = Convert.ToString(Char.Health);

            }
            
            

        }
        



    }
    
}
