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
        private const int ENEMIES_PER_ROW = 11;
        private const int NUM_OF_ROWS = 5;
        private const int ENEMIES_ROW_SPACING = 50;
        private const int ENEMIES_COL_SPACING = 50;
        private const int INITIAL_ALIEN_X = 20;
        private const int INITIAL_ALIEN_Y = 300;


        public int alienToMove = 0;
        private List<Alien> aliens = new List<Alien>();
        private List<Bitmap> alienBmps = new List<Bitmap>();
        private List<List<Bitmap>> alienSpriteList = new List<List<Bitmap>>();
        private List<Bitmap> alienDeadSprite = new List<Bitmap>();
        private int panelWidth;
        private int panelHeight;
        private bool moveDown = false;
        public EnemyManager(int panelWidth, int panelHeight)
        {
            this.panelWidth = panelWidth;
            this.panelHeight = panelHeight;
        }

        public Boolean EnemyCount()
        {
            return aliens.Count() == 0;
        }

        public void GenerateEnemies()
        {
            int x = INITIAL_ALIEN_X;
            int y = INITIAL_ALIEN_Y;
            int rowCount = 0;

            alienSpriteList.Add(new List<Bitmap>());
            alienSpriteList.Add(new List<Bitmap>());
            alienSpriteList.Add(new List<Bitmap>());
            alienSpriteList[0].Add(new Bitmap(Resources.AlienC1));
            alienSpriteList[0].Add(new Bitmap(Resources.AlienC2));
            alienSpriteList[1].Add(new Bitmap(Resources.AlienB1));
            alienSpriteList[1].Add(new Bitmap(Resources.AlienB2));
            alienSpriteList[2].Add(new Bitmap(Resources.AlienA1));
            alienSpriteList[2].Add(new Bitmap(Resources.AlienA2));
            alienDeadSprite.Add(new Bitmap(Resources.AlienPop));

            int alienImg = 0;
            for (int i = 0; i < NUM_OF_ROWS; i++)
            {

                    for (int j = 0; j < ENEMIES_PER_ROW; j++)
                    {
                        Alien newAlien = new Alien(x, y, alienSpriteList[alienImg], alienDeadSprite, panelWidth, panelHeight);
                        aliens.Add(newAlien);

                        x += ENEMIES_COL_SPACING;
                    }
                    y -= ENEMIES_ROW_SPACING;
                    x = INITIAL_ALIEN_X;
                if (rowCount == 1)
                {
                    rowCount = 0;
                    alienImg++;
                }
                else
                    rowCount++;
            }
        }

        internal void Reduce(Alien a)
        {
            int place = aliens.IndexOf(a);
            if (alienToMove > place)
                alienToMove--;
        }

        public List<Alien> GetAliens()
        {
            return aliens;
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
            if (alienToMove == 0)
            {
                moveDown = CheckIfWallHit();
            }
            if (alienToMove > aliens.Count)
                alienToMove = 0;
            if (alienToMove < aliens.Count)
            {
                if (moveDown)
                    aliens[alienToMove++].MoveDown();
                else
                    aliens[alienToMove++].Move();
                if (alienToMove == aliens.Count)
                    alienToMove = 0;
            }
            
            foreach(Alien a in aliens)
            {
                if (a.dead)
                    a.Move();
            }
        }

        public bool CheckIfWallHit()
        {
            bool wallHit = false;

            foreach (Alien alien in aliens)
            {
                if (alien.CheckWallHit())
                    wallHit = true;
            }

            if (wallHit)
            {
                foreach (Alien alien in aliens)
                {
                    alien.MovingRight = !alien.MovingRight;
                }
            }
            return wallHit;
        }
    }
}
