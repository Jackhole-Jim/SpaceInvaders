using SpaceInvaders.Enemies;
using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders.Managers
{
    class EnemyManager
    {
        private const int ALIEN_MOVE_DIST_X = 5;
        private const int ALIEN_MOVE_DIST_Y = 5;
        private const int ENEMIES_PER_ROW = 11;
        private const int NUM_OF_ROWS = 5;
        private const int ENEMIES_ROW_SPACING = 50;
        private const int ENEMIES_COL_SPACING = 50;
        private const int INITIAL_ALIEN_X = 20;
        private const int INITIAL_ALIEN_Y = 300;
        
        private int alienToMove = 0;
        private List<Alien> aliens = new List<Alien>();
        private List<Bitmap> alienBmps = new List<Bitmap>();
        Panel panel;

        public EnemyManager( ) { }

        public EnemyManager(Panel panel)
        {
            this.panel = panel;
        }


        public void GenerateEnemies()
        {
            int x = INITIAL_ALIEN_X;
            int y = INITIAL_ALIEN_Y;

            alienBmps.Add(new Bitmap(Resources.AlienC1));
            alienBmps.Add(new Bitmap(Resources.AlienC1));
            alienBmps.Add(new Bitmap(Resources.AlienB1));
            alienBmps.Add(new Bitmap(Resources.AlienB1));
            alienBmps.Add(new Bitmap(Resources.AlienA1));

            Bitmap alienImg = alienBmps[0];
            for (int i = 0; i < NUM_OF_ROWS; i++)
            {
                for (int j = 0; j < ENEMIES_PER_ROW; j++)
                {
                    aliens.Add(new Alien(x, y, alienImg));
                    x += ENEMIES_COL_SPACING;
                }
                y -= ENEMIES_ROW_SPACING;
                x = INITIAL_ALIEN_X;
                if((i + 1) < NUM_OF_ROWS)
                {
                    alienImg = alienBmps[i + 1];
                }
            }
        }

        public void ShowEnemies(PaintEventArgs e)
        {
            foreach (Alien alien in aliens)
            {
                alien.Show(e);
            }
        }

        public void MoveNextAlien()
        {
            if (alienToMove < aliens.Count)
            {
                aliens[alienToMove++].Move();
            }
            else
            {
                alienToMove = 0;
                aliens[alienToMove++].Move();
            }
        }
    }
}
