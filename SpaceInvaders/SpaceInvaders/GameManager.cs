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

namespace SpaceInvaders
{
    public class GameManager
    {
        private const int moveDist = 5;
        private const int ALIEN_MOVE_DIST = 5;
        private const int ENEMIES_PER_ROW = 11;
        private const int NUM_OF_ROWS = 5;
        private const int ENEMIES_ROW_SPACING= 50;
        private const int ENEMIES_COL_SPACING= 50;
        private const int INITIAL_ALIEN_X = 20;
        private const int INITIAL_ALIEN_Y = 50;

        private MovableObject mainShip;
        private int alienToMove = 0;
        private List<TopEnemy> aliens = new List<TopEnemy>();
        private List<Bitmap> alienBmps = new List<Bitmap>();
        Panel panel;

        public GameManager(Panel drawingPanel)
        {
            int x = INITIAL_ALIEN_X;
            int y = INITIAL_ALIEN_Y;
            this.panel = drawingPanel;
            mainShip = new MainShip(350, 750, new Bitmap(Resources.player), drawingPanel);
            alienBmps.Add(new Bitmap(Resources.AlienA1));
            alienBmps.Add(new Bitmap(Resources.AlienB1));
            alienBmps.Add(new Bitmap(Resources.AlienB1));
            alienBmps.Add(new Bitmap(Resources.AlienC1));
            alienBmps.Add(new Bitmap(Resources.AlienC1));
            Bitmap alienImg = alienBmps[0];
            for (int i = 0; i < NUM_OF_ROWS; i++)
            {
                for(int j = 0; j < ENEMIES_PER_ROW; j++)
                {
                    aliens.Add(new TopEnemy(x, y, false, alienImg, drawingPanel));
                    x += ENEMIES_COL_SPACING;
                }
                y += ENEMIES_ROW_SPACING;
                x = INITIAL_ALIEN_X;
                alienImg = alienBmps[i++];

                //aliens.Add(new TopEnemy(initialX, initialY, false, new Bitmap(Resources.AlienA1), drawingPanel));
                //aliens.Add(new TopEnemy(initialX, initialY = initialY + ENEMIES_ROW_SPACING, false, new Bitmap(Resources.AlienB1), drawingPanel));
                //aliens.Add(new TopEnemy(initialX, initialY = initialY + ENEMIES_ROW_SPACING, false, new Bitmap(Resources.AlienB1), drawingPanel));
                //aliens.Add(new TopEnemy(initialX, initialY = initialY + ENEMIES_ROW_SPACING, false, new Bitmap(Resources.AlienC1), drawingPanel));
                //aliens.Add(new TopEnemy(initialX, initialY = initialY + ENEMIES_ROW_SPACING, false, new Bitmap(Resources.AlienC1), drawingPanel));
                //initialX = initialX + ENEMIES_COL_SPACING;
                //initialY = INITIAL_ALIEN_Y;
            }
            aliens.Reverse();
        }

        public void ShowAll()
        {
            mainShip.Show();
            foreach(TopEnemy alien in aliens)
            {
                alien.Show();
            }
        }

        public void Move()
        {
            mainShip.Show();
            MoveAliens();
        }

        public void MoveAliens()
        {
            int x = INITIAL_ALIEN_X;
            int y = INITIAL_ALIEN_Y;

            if (alienToMove >= aliens.Count)
            {
                alienToMove = 0;
            }
            TopEnemy aleinToMove = aliens[alienToMove];
            aleinToMove.Move(ALIEN_MOVE_DIST, 0);

            if (aleinToMove.X >= panel.Size.Width - 100)
            {
                //Move all aliens down one at a time just by y
                //movingRight = false;
            }
            else if (aleinToMove.X <= 20)
            {
                //Move all aliens down one at a time just by y
                //movingRight = true;
            }

            aleinToMove.Show();
            alienToMove++;

            foreach (TopEnemy alien in aliens)
            {
                //alien.Move(ALIEN_MOVE_DIST, 0);
                alien.Show();
            }
        }

        public void handlebuttonPressed(Keys key)
        {
            switch(key)
            {
                case Keys.Right:
                    mainShip.Move(moveDist, 0);
                    break;

                case Keys.Left:
                    mainShip.Move(-moveDist, 0);
                    break;
            }
        }
    }
}
