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
      public Bitmap Image { get; set; }
      private int panelWidth, panelHeight;

      protected MovableObject(int x, int y, Bitmap image, int panelX, int panelY)
      {
         this.X = x;
         this.Y = y;
         this.Image = image;
         this.panelWidth = panelX;
         this.panelHeight = panelY;
      }

      public abstract void Move(int deltaX, int deltaY);
      public void Show(PaintEventArgs e)
      {
         e.Graphics.DrawImage(Image, X, Y);
      }

      public bool IsInPanel()
      {
         return ((X > 0) && ((X + Image.Width) < panelWidth))
         && ((Y > 0) && ((Y + Image.Height) < panelHeight));
      }
   }
}
