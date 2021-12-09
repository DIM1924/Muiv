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
        private Pole pole;
        public Form1()
        {
            InitializeComponent();
            PictureBox[] walls = new PictureBox[] 
            {
                pictureBox10,pictureBox26,pictureBox14,
                pictureBox15,pictureBox44,pictureBox37,pictureBox25,pictureBox20,pictureBox39,pictureBox19,
                pictureBox31,pictureBox32,pictureBox42,pictureBox11,pictureBox29,pictureBox24,pictureBox34,
                pictureBox47,pictureBox48,pictureBox45,pictureBox49,pictureBox46,pictureBox23,pictureBox35,
                pictureBox22,pictureBox36,pictureBox21,pictureBox40,pictureBox18,pictureBox30,pictureBox33,
                pictureBox41,pictureBox12,pictureBox13,pictureBox27,pictureBox16,pictureBox17,pictureBox43,
                pictureBox38,pictureBox28
                
            };
            pole = new Pole(walls);
            pacman = new PacManPlayer();
            pacman.pacmanPicture = pacmanPicture;
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            pacman.Update();
            pole.Update(pacman);
             pacman.CheckCollision( );
                     foreach ( 1 in 10 walls )
                        {
                             pacman.CheckCollision(wall.pictureBox);
                         }
            */

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Up)
            {
                pacman.Move(0, -1);
            }
            if (e.KeyCode == Keys.Down)
            {
                pacman.Move(0, 1);
            }
            if (e.KeyCode == Keys.Right)
            {
                pacman.Move(1, 0);
            }
            if (e.KeyCode == Keys.Left)
            {
                pacman.Move(-1, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }
    }
}
