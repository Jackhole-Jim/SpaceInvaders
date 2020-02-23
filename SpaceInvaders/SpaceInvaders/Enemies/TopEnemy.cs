using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.Enemies
{
    public class TopEnemy : Movable
    {
        private Position position = new Position()
        {
            X = 0,
            Y = 0
        };

        public Position getPosition()
        {
            return position;
        }

        public void moveX(int amount)
        {
            position.X += amount;
        }

        public void moveY(int amount)
        {
            position.Y += amount;
        }
    }
}
