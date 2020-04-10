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
        private int xMoveDistance = 10;
        private int yMoveDistance = 10;
        public int deadTimer = 0;
        public bool MovingRight { get; set; }

        public Alien(int x, int y, List<Bitmap> image, List<Bitmap> deathanimation, int panelWidth, int panelHeight) : base(x, y, image, deathanimation, panelWidth, panelHeight)
        { MovingRight = true; }

        public override void Move(int deltaX = 10, int deltaY = 5)
        {
            if (!dead)
            {
                xMoveDistance = deltaX;
                yMoveDistance = deltaY;
                X = MovingRight ? X + deltaX : X - deltaX;
            }
            else
                deadTimer++;
            Animate();
        }

        public void MoveDown()
        {
            Y += yMoveDistance;
        }

        public bool CheckWallHit()
        {
            X = MovingRight ? X + xMoveDistance : X - xMoveDistance;
            bool inPanel = IsInPanel();
            X = MovingRight ? X - xMoveDistance : X + xMoveDistance;
            return !inPanel;
        }
    }
}

namespace SpaceInvaders.Enemies
{
    public class UFO : MovableObject
    {
        private const int MOVE_NUM = 3;
        private int movingD = -1;
        private bool moving = false;
        private int deadTime = 0;
        

        public UFO(int x, int y, List<Bitmap> image, List<Bitmap> deathanimation, int panelWidth, int panelHeight) : base(x, y, image, deathanimation, panelWidth, panelHeight) { }
        
        public override void Move(int deltaX = 1, int deltaY = 5)
        {
         Animate();
         if (!dead && moving)
         {
            X += MOVE_NUM * movingD;
            if (X <= -150 || X >= panelWidth + 150)
               moving = false;
         }
         else if (dead && moving)
            moving = false;
         else if (dead && !moving && deadTime < 30)
            deadTime++;
         else if (dead && !moving && deadTime >= 30)
            X = -300;
         
      }

        public void Smove()
        {
            movingD *= -1;
            moving = true;
        }

        public void die()
        {
            dead = true;
        }
    }
}