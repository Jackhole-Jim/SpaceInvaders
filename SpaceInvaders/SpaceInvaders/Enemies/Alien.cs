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

        public bool MovingRight { get; set; }

        public Alien(int x, int y, List<Bitmap> image, int panelWidth, int panelHeight) : base(x, y, image, panelWidth, panelHeight)
        { MovingRight = true; }

        public override void Move(int deltaX = 10, int deltaY = 5)
        {
            xMoveDistance = deltaX;
            yMoveDistance = deltaY;
            X = MovingRight ? X + deltaX : X - deltaX;
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