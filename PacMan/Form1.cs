using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Form1 : Form
    {
        private PacManPlayer pacman;
        public Form1()
        {
            InitializeComponent();
            pacman = new PacManPlayer();
            pacman.picture = pacmanPicture;

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            pacman.Move();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
