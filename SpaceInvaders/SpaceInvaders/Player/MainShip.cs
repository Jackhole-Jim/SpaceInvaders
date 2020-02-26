using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Player
{
    public class MainShip : MovableObject
    {

      public MainShip(int x, int y, Bitmap image, int panelWidth, int panelHeight) : base(x, y, image, panelWidth, panelHeight)
      {
            Image = image;
      }
      public override void Move(int deltaX, int deltaY)
      {
            X += deltaX;         
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
