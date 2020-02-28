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