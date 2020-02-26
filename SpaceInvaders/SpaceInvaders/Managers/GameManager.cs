using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceInvaders.Player;
using SpaceInvaders.Enemies;
using SpaceInvaders.Properties;
using System.Drawing;
using System.Collections;
using SpaceInvaders.Managers;

namespace SpaceInvaders
{
    public class GameManager
    {
        private const int MAINSHIP_MOVE_DIST = 5;
        private MovableObject mainShip;
        Panel panel;
        EnemyManager enemyManager;

        public GameManager(Panel drawingPanel)
        {
            this.panel = drawingPanel;
            mainShip = new MainShip(350, 750, new Bitmap(Resources.player), drawingPanel);
            enemyManager = new EnemyManager(drawingPanel);
            enemyManager.GenerateEnemies();
        }

        public void ShowAll()
        {
            mainShip.Show();
            enemyManager.ShowEnemies();
        }

        public void Move()
        {
            enemyManager.MoveNextAlien();
        }

        public void handlebuttonPressed(Keys key)
        {
            switch(key)
            {
                case Keys.Right:
                    mainShip.Move(MAINSHIP_MOVE_DIST, 0);
                    break;

                case Keys.Left:
                    mainShip.Move(-MAINSHIP_MOVE_DIST, 0);
                    break;
            }
        }
    }
}
