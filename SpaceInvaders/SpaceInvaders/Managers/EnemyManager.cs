using SpaceInvaders.Enemies;
using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private const int INITIAL_ALIEN_Y = 450;
        private const int UFO_TIMER = 500;

        private int counter = 0;
        public int alienToMove = 0;
        private List<Alien> aliens = new List<Alien>();
        private TopEnemy ufo;
        private List<Bitmap> alienBmps = new List<Bitmap>();
        private List<List<Bitmap>> alienSpriteList = new List<List<Bitmap>>();
        private List<Bitmap> alienDeadSprite = new List<Bitmap>();
        private SoundPlayer sounds;
        private int panelWidth;
        private int panelHeight;
        private bool moveDown = false;
        private int ufoTime = 0;
        
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
            alienSpriteList.Add(new List<Bitmap>());
            alienSpriteList[0].Add(new Bitmap(Resources.AlienC1));
            alienSpriteList[0].Add(new Bitmap(Resources.AlienC2));
            alienSpriteList[1].Add(new Bitmap(Resources.AlienB1));
            alienSpriteList[1].Add(new Bitmap(Resources.AlienB2));
            alienSpriteList[2].Add(new Bitmap(Resources.AlienA1));
            alienSpriteList[2].Add(new Bitmap(Resources.AlienA2));
            alienSpriteList[3].Add(new Bitmap(Resources.AlienUFO));
            alienDeadSprite.Add(new Bitmap(Resources.AlienPop));
            ufo = new TopEnemy(-150, 150, alienSpriteList[3], alienDeadSprite, panelWidth, panelHeight);
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

        public TopEnemy getUFO()
        {
            return ufo;
        }

        public void ShowEnemies(PaintEventArgs e)
        {
            foreach (Alien alien in aliens)
            {
                alien.Show(e);
            }
            ufo.Show(e);
        }

        public void DoUfo()
        {
            ufo.Smove();
        }

        public void MoveNextAlien()
        {
            ufoTime++;
            if(ufoTime == UFO_TIMER)
            {
                DoUfo();
                ufoTime = 0;
            }
            ufo.Move();
            if (alienToMove == 0)
            {
                if (++counter > 4)
                    counter = 1;
                switch(counter)
                {
                    case 1:
                        sounds = new SoundPlayer(Resources.fastinvader1);
                        sounds.Play();
                        break;
                    case 2:
                        sounds = new SoundPlayer(Resources.fastinvader2);
                        sounds.Play();
                        break;
                    case 3:
                        sounds = new SoundPlayer(Resources.fastinvader3);
                        sounds.Play();
                        break;
                    case 4:
                        sounds = new SoundPlayer(Resources.fastinvader4);
                        sounds.Play();
                        break;
                }
                

                moveDown = CheckIfWallHit();
            }

            if (alienToMove < aliens.Count)
            {
                if (moveDown)
                    aliens[alienToMove++].MoveDown();
                else
                    aliens[alienToMove++].Move();
                if (alienToMove == aliens.Count)
                    alienToMove = 0;
            }
            if (alienToMove > aliens.Count)
                alienToMove = 0;
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
