using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    interface Movable
    {
        Position getPosition();

        void moveX(int amount);

        void moveY(int amount);

    }
}
