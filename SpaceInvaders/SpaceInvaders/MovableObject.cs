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
      protected Panel drawingPanel;
      public int X { get; set; }
      public int Y { get; set; }
      public Bitmap Image { get; set; }

      protected MovableObject(int x, int y, Bitmap image, Panel drawingPanel)
      {
         this.X = x;
         this.Y = y;
         this.Image = image;
         this.drawingPanel = drawingPanel;
        }

      public abstract void Move(int deltaX, int deltaY);
      public void Show()
      {
         Graphics graphics = drawingPanel.CreateGraphics();
         graphics.DrawImageUnscaled(Image, X, Y);
      }

      public bool IsInPanel()
      {
         return ((X > 0) && ((X + Image.Width) < drawingPanel.Width))
         && ((Y > 0) && ((Y + Image.Height) < drawingPanel.Height));
      }
   }
}
