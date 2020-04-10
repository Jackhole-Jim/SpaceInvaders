using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SpaceInvaders.Player
{
    public class Bullet: MovableObject
    {
        public int timer = 0;
        MediaPlayer sound = new MediaPlayer();
        public Bullet(int x, int y, List<Bitmap> image, List<Bitmap> deathanimation, int panelWidth, int panelHeight) : base(x, y, image, deathanimation, panelWidth, panelHeight)
        {            
            sound.Open(new Uri(Util.bingPathToAppDir("Resources\\shoot.wav")));
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
                sound.Stop();
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
