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
      protected int x, y;
      protected bool dead;
      protected Panel drawingPanel;
      public Bitmap Image { get; set; }

      protected MovableObject(int x, int y, bool dead, Panel drawingPanel)
      {
         this.x = x;
         this.y = y;
         this.dead = dead;
         this.drawingPanel = drawingPanel;
      }

      public abstract void Move();
      public void Show()
      {
         Graphics graphics = drawingPanel.CreateGraphics();
         graphics.DrawImageUnscaled(Image, x, y);
      }

      public bool IsInPanel()
      {
         return ((x > 0) && ((x + Image.Width) < drawingPanel.Width))
         && ((y > 0) && ((y + Image.Height) < drawingPanel.Height));
      }
   }
}
