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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            Room1 n = new Room1(5,3,5,5,5,3,"xd","ninja");
            n.Show();
            Hide();
        }

        private void lblstart_MouseHover(object sender, EventArgs e)
        {
            lblstart.ForeColor = System.Drawing.Color.DarkRed;
            label1.ForeColor = System.Drawing.Color.DarkRed;
            label2.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void lblstart_MouseLeave(object sender, EventArgs e)
        {
            lblstart.ForeColor = System.Drawing.Color.White;
            label1.ForeColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
        }
    }
}
