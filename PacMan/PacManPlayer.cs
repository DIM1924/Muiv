using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PacMan
{
    public class PacManPlayer
    {
        public int moveDirectionX = 0;
        public int moveDirectionY = 0;
        public PictureBox pacmanPicture;
        

        public void Move(int x, int y)
        {
            

            moveDirectionY = y;
            moveDirectionX = x;
        }

        public void Update()
        {
            var location = pacmanPicture.Location;
            location.Offset(moveDirectionX, moveDirectionY);
            pacmanPicture.Location = location;
        }

        public void CheckCollision(PictureBox bounds)
        { 

            if (pacmanPicture.Bounds.(bounds))
            {
                Move(0, 0);
            } 
        }
    }
    public class Pole
    {
        public PictureBox[] ghost;
        public PictureBox[] Coin;
        private PictureBox[] wall;


        public Pole(PictureBox[] walls)
        {
            wall = walls;
        }
        
        
     
        public void walls()
        {

           



        }
        public void Ghosts()
        {

        }
        public void Coins()
        {

        }

        internal void Update(PacManPlayer player)
        {
            for (int i = 0; i < wall.Length; i++)
            {
                player.CheckCollision(wall[i].Bounds);
            }
        }
    }
    
}
