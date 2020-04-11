using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Enemies
{
    public class EnemyBullet : MovableObject
    {
        public EnemyBullet(int x, int y, List<Bitmap> image, List<Bitmap> deathanimation, int panelWidth, int panelHeight) : base(x, y, image, deathanimation, panelWidth, panelHeight)
        {}

        public override void Move(int deltaX, int deltaY)
        {
            Y += deltaY;
        }
    }
}
