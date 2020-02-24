using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Enemies
{
    public class TopEnemy : MovableObject
    {
        private const int ALIEN_Y_DROP = 50;
        private bool movingRight = true;

        public TopEnemy(int x, int y, bool dead, Bitmap image, Panel drawingPanel) : base(x, y, false, image, drawingPanel) { }
        
        public override void Move(int deltaX = 5, int deltaY = 5)
        {
            if (X >= drawingPanel.Size.Width - 100)
            {
                Y += ALIEN_Y_DROP;
                movingRight = false;
            }
            else if (X <= 20)
            {
                Y += ALIEN_Y_DROP;
                movingRight = true;
            }
            if (movingRight)
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
