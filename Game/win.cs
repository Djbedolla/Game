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
    public partial class win : Form
    {
        public win(bool r)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.gem;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (r == true)
            {
                label3.Text = "You successfully sloved the riddle and the oni hands you the gem stone.";
            }
            else
            {
                label3.Text = "You successfully defeated the oni. You can now claim the gem stone for your self";
            }
        }
    }
}
