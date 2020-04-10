using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
   public abstract class MovableObject
   {
      public int X { get; set; }
      public int Y { get; set; }
      public List<Bitmap> Image { get; set; }
      public List<Bitmap> DeathAnimation { get; set; }
      public Boolean dead = false;
      protected int panelWidth, panelHeight;
      private int frame = 0;

      protected MovableObject(int x, int y, List<Bitmap> image, List<Bitmap> deathanimation,  int panelX, int panelY)
      {
            this.X = x;
            this.Y = y;
            this.Image = image;
            this.DeathAnimation = deathanimation;
            this.panelWidth = panelX;
            this.panelHeight = panelY;
      }

      public abstract void Move(int deltaX, int deltaY);
      public void Show(PaintEventArgs e)
      {
            if(!dead)
                e.Graphics.DrawImage(Image[frame], X, Y);
            else
                e.Graphics.DrawImage(DeathAnimation[frame], X, Y);
        }

        public void Animate()
        {
            if (dead)
            {
                if (frame < DeathAnimation.Count() - 1)
                    frame++;
                else
                    frame = 0;
            }
            else
            {
                if (frame < Image.Count() - 1)
                    frame++;
                else
                    frame = 0;
            }
        
        }

        public bool IsInPanel()
      {
         return ((X > 0) && ((X + Image[frame].Width) < panelWidth))
         && ((Y > 0) && ((Y + Image[frame].Height) < panelHeight));
      }

        internal int Width()
        {
            return Image[frame].Width;
        }

        internal int Height()
        {
            return Image[frame].Height;
        }
    }
}
