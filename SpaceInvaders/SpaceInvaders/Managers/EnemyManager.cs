using SpaceInvaders.Enemies;
using SpaceInvaders.Player;
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
        private const double SHOOT_PROBABILITY = 0.1;
        private const int MAX_BULLETS = 2;
        private const int BULLET_MOVE = 5;

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

        private List<EnemyBullet> bullets = new List<EnemyBullet>();
        private List<Bitmap> bulletSprites = new List<Bitmap>
        {
            Resources.PlayerShot
        };
        private List<Bitmap> bulletDeathSprites = new List<Bitmap>
        {
            Resources.PlayerShotExplosion
        };

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
                    Alien newAlien = new Alien(x, y, alienSpriteList[alienImg], alienDeadSprite, panelWidth, panelHeight, i, j);
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
        public void RemoveDead()
        {
            foreach (Alien alien in aliens)
            {
                if (alien.dead && alien.deadTimer > 5)
                {
                    Reduce(alien);
                    aliens.Remove(alien);
                    return;
                }
            }

            bullets.RemoveAll(bullet => !bullet.IsInPanel());
        }

        internal void Reduce(Alien a)
        {
            int place = aliens.IndexOf(a);
            if (alienToMove > place)
                alienToMove--;
        }

        public List<EnemyBullet> getBullets()
        {
            return bullets;
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

            bullets.ForEach(bullet => bullet.Show(e));
        }

        public void DoUfo()
        {
            ufo.Smove();
        }

        public void MoveNextAlien()
        {
            ufoTime++;
            if (ufoTime == UFO_TIMER)
            {
                DoUfo();
                ufoTime = 0;
            }
            ufo.Move();
            if (alienToMove == 0)
            {
                if (++counter > 4)
                    counter = 1;
                switch (counter)
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
            foreach (Alien a in aliens)
            {
                if (a.dead)
                    a.Move();
            }

            CalculateShootProbability(aliens[alienToMove]);
            bullets.ForEach(bullet => bullet.Move(0, BULLET_MOVE));
        }

        private void CalculateShootProbability(Alien alien)
        {
            double rand = new Random().NextDouble();

            if(rand <= SHOOT_PROBABILITY && bullets.Count < MAX_BULLETS)
            {
                Alien bottomAlien = aliens.Where(whereAlien => whereAlien.getColumn() == alien.getColumn()).OrderByDescending(orderAlien => orderAlien.getRow()).LastOrDefault();

                bullets.Add(new EnemyBullet(bottomAlien.X + (bottomAlien.Width() / 2), bottomAlien.Y + bottomAlien.Height(), bulletSprites, bulletDeathSprites, panelWidth, panelHeight));
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
