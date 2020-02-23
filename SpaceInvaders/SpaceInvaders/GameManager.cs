using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.Player;

namespace SpaceInvaders
{
    public class GameManager
    {
        private const int moveDist = 5;
        private MovableObject mainShip;

        public GameManager(Panel drawingPanel)
        {
            mainShip = new MainShip(0, 0, drawingPanel);
        }

        public void ShowAll()
        {
            mainShip.Show();
        }

        public void handlebuttonPressed(Keys key)
        {

        }
    }
}
