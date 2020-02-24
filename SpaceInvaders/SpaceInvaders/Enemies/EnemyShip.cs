using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Enemies
{
   public class EnemyShip : MovableObject
   {
      private static bool movingRight = true;
      private int XMoveAmount = 5;
      private int YMoveAmount = 5;
      public event EventHandler WallHit;
      protected EnemyShip(int x, int y, bool dead, Panel drawingPanel, Bitmap image) : base(x, y, dead, drawingPanel)
      {
         this.Image = image;
      }

      public override void Move()
      {
         x = movingRight ? x + XMoveAmount : x - XMoveAmount;
         if(!IsInPanel())
         {
            x = movingRight ? x - XMoveAmount : x + XMoveAmount;
            WallHit.Invoke("Wall hit", new EventArgs());
         }

      }

      public bool IsInPlayingField()
      {
         return y > 5000; //TODO: Change to match lower threshhold 
      }
      public void MoveDown()
      {
         y += YMoveAmount;
         if(!IsInPlayingField())
         {
            //Kill();
         }
      }
   }
}




// TopEnemy File Merge becasue it got deleted
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace SpaceInvaders.Enemies
//{
//    public class TopEnemy : MovableObject
//    {
//        private const int ALIEN_Y_DROP = 50;
//        private bool movingRight = true;

//        public TopEnemy(int x, int y, bool dead, Bitmap image, Panel drawingPanel) : base(x, y, false, image, drawingPanel) { }

//        public override void Move(int deltaX = 5, int deltaY = 5)
//        {
//            if (X >= drawingPanel.Size.Width - 100)
//            {
//                Y += ALIEN_Y_DROP;
//                movingRight = false;
//            }
//            else if (X <= 20)
//            {
//                Y += ALIEN_Y_DROP;
//                movingRight = true;
//            }
//            if (movingRight)
//            {
//                X += deltaX;
//            }
//            else
//            {
//                X -= deltaX;
//            }
//        }
//    }
//}

