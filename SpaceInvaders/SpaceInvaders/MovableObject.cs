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
      private int x, y;
      private bool dead;
      private Bitmap image;
      private Panel drawingPanel;
      public Bitmap Image { get => image; set => image = value; }

      protected MovableObject(int x, int y, bool dead, Bitmap image, Panel drawingPanel)
      {
         this.x = x;
         this.y = y;
         this.dead = dead;
         this.image = image;
         this.drawingPanel = drawingPanel;
      }

      public abstract void Move();
      public void Show()
      {
         Graphics graphics = drawingPanel.CreateGraphics();
         graphics.DrawImageUnscaled(image, x, y);
      }

      public bool IsInPanel()
      {
         return ((x > 0) && ((x + image.Width) < drawingPanel.Width))
         && ((y > 0) && ((y + image.Height) < drawingPanel.Height));
      }
   }
}
