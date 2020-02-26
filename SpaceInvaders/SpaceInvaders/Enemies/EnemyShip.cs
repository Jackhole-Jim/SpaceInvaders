using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Enemies
{
    public class Alien : MovableObject
    {
        private const int ALIEN_Y_DROP = 50;
        public bool MovingRight { get; set; }

        public Alien(int x, int y, Bitmap image) : base(x, y, image) { MovingRight = true; }

        public override void Move(int deltaX = 5, int deltaY = 5)
        {
            if (MovingRight)
            {
                X += deltaX;
            }
            else
            {
                X -= deltaX;
            }
        }
    }
}