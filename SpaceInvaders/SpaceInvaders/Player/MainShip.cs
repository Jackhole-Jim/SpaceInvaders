using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SpaceInvaders.Player
{
    public class MainShip : MovableObject
    {
        private MediaPlayer sounds = new MediaPlayer();
      public int Lives { get; private set; }

      public MainShip(int x, int y, List<Bitmap> image, List<Bitmap> deathanimation,int panelWidth, int panelHeight) : base(x, y, image, deathanimation, panelWidth, panelHeight)
      {
            Image = image;
            Lives = 3;
            sounds.Open(new Uri(Util.bingPathToAppDir("Resources\\explosion.wav")));
        }
      public override void Move(int deltaX, int deltaY)
      {
            X += deltaX;
            Animate();
      }

      public override bool Equals(object obj)
      {
         return base.Equals(obj);
      }

      public override int GetHashCode()
      {
         return base.GetHashCode();
      }

      public override string ToString()
      {
         return base.ToString();
      }

      public void Hit()
      {
         sounds.Stop();
         sounds.Play();
         Lives--;
         if (Lives <= 0)
         {
            dead = true;
         }
      }
   }
}
