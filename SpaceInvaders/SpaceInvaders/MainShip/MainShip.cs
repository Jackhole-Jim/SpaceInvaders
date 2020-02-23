using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.MainShip
{
    public class MainShip : MovableObject
    {
      protected MainShip(int x, int y, bool dead, Bitmap image, Panel drawingPanel) : base(x, y, dead, image, drawingPanel)
      {
      }
      public override void Move()
      {
         throw new NotImplementedException();
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
   }
}
