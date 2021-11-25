using System.Diagnostics;
using System.Windows.Forms;

namespace PacMan
{
    public class PacManPlayer
    {
        public int moveDirectionX = 1;
        public int moveDirectionY = 0;
        public PictureBox picture;
        public void Move()
        {
            var location = picture.Location;
            location.Offset(moveDirectionX, moveDirectionY);
            picture.Location = location;
                


        }
    }
}
