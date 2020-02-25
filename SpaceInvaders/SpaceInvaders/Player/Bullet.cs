using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Player
{
    public class Bullet: MovableObject
    {
        public Bullet(int x, int y, Bitmap image) : base(x, y, false, image)
        {
            Image = image;
        }

        public override void Move(int deltaX, int deltaY)
        {
            if (Y == -100)
                return;
            else if (Y <= 0)
                Y = -100;
            else
                Y += -20;
        }

        internal void Fire(int x, int y)
        {
            if (Y == -100)
            {
                X = x + 24;
                Y = y - 10;
            }
        }
    }
}
