using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Player
{
    public class Bullet: MovableObject
    {
        public int timer = 0;
        SoundPlayer sound = new SoundPlayer(Resources.shoot);
        public Bullet(int x, int y, List<Bitmap> image, List<Bitmap> deathanimation, int panelWidth, int panelHeight) : base(x, y, image, deathanimation, panelWidth, panelHeight)
        {
            Image = image;
        }

        public override void Move(int deltaX, int deltaY)
        {
            if (!dead)
            {
                if (Y == -100)
                    return;
                else if (Y <= 0)
                    Y = -100;
                else
                    Y += -10;
            }
            else
                timer++;
        }

        internal void Fire(int x, int y)
        {
            if (Y == -100)
            {
                sound.Play();
                X = x + 24;
                Y = y - 10;
                
            }
        }

        public void reset()
        {
            X = -100;
            Y = -100;
        }
    }
}
