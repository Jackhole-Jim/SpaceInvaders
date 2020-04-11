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
using System.Media;
using System.Windows.Media;

namespace SpaceInvaders
{
    public class GameManager
    {
        private const int MAINSHIP_MOVE_DIST = 5;
        private MainShip mainShip;
        private Bullet bullet;
        public int score = 0;
        MediaPlayer player = new MediaPlayer();
        EnemyManager enemyManager;
        List<Bitmap> playerSprites = new List<Bitmap>();
        List<Bitmap> playerDSprites = new List<Bitmap>();
        List<Bitmap> bulletSprites = new List<Bitmap>();
        List<Bitmap> bulletDSprites = new List<Bitmap>();

        public GameManager(int panelWidth, int panelHeight)
        {
            playerSprites.Add(new Bitmap(Resources.player));
            playerDSprites.Add(new Bitmap(Resources.PlayerExplosion1));
            playerDSprites.Add(new Bitmap(Resources.PlayerExplosion2));
            bulletSprites.Add(new Bitmap(Resources.PlayerShot));
            bulletDSprites.Add(new Bitmap(Resources.PlayerShotExplosion));
            mainShip = new MainShip(300, 716, playerSprites, playerDSprites, panelWidth, panelHeight);
            bullet = new Bullet(-100, -100, bulletSprites, bulletDSprites, panelWidth, panelHeight);
            enemyManager = new EnemyManager(panelWidth, panelHeight);
            enemyManager.GenerateEnemies();
            player.Open(new Uri(Util.bingPathToAppDir("Resources\\invaderkilled.wav")));
        }
        
        public void ShowAll(PaintEventArgs e)
        {
            mainShip.Show(e);
            bullet.Show(e);
            enemyManager.ShowEnemies(e);
        }
        
        public void Move(PaintEventArgs e)
        {
            bullet.Move(0, 0);
            enemyManager.MoveNextAlien();
            ShowAll(e);
            CheckCollision(enemyManager.GetAliens(), enemyManager.getUFO());
            if (bullet.timer == 5)
            {
                bullet.reset();
                bullet.timer = 0;
                bullet.dead = false;
            }
            enemyManager.RemoveDead();
        }

        public Boolean Count()
        {
            return enemyManager.EnemyCount();
        }

        public void CheckCollision(List<Alien> aliens, UFO ufo)
        {
            if (!bullet.dead)
            {
                foreach (Alien alien in aliens)
                {
                    if (Collision(bullet, alien))
                    {
                        player.Stop();
                        player.Play();
                        bullet.dead = true;
                        bullet.X -= 10;
                        score += 600;
                        alien.dead = true;
                  return;
                    }
                }

                if (Collision(bullet, ufo))
                {
                    player.Stop();
                    player.Play();
                    ufo.die();
                    bullet.dead = true;
                    bullet.X -= 10;
                    score += 3000;
                }
            }
        }

      private void PlayerHit()
      {
         mainShip.Hit();
      }

      public int GetPlayerLives()
      {
         return mainShip.Lives;
      }

      public bool PlayerDead()
        {
            return mainShip.dead;
        }
            }

            enemyManager.getBullets().ForEach(bullet =>
            {
                if (Collision(mainShip, bullet))
                {
                    //TODO: impliment the start of the life counter here
                }
            });
        }

        public bool AlienHitBottom()
        {
            return enemyManager.AlienHitBottom();
        }

        public Boolean Collision(MovableObject a, MovableObject b)
        {
            if (IsWithin(a.X, b.X, a.X + a.Width()) || IsWithin(b.X, a.X, b.X + b.Width()))
                if (IsWithin(a.Y, b.Y, a.Y + a.Height()) || IsWithin(b.Y, a.Y, b.Y + b.Height()))
                    return true;
                else
                    return false;
            else
                return false;
        }

        public static bool IsWithin(int minimum, int value, int maximum)
        {
            return value >= minimum && value <= maximum;
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
                case Keys.Space:
                    bullet.Fire(mainShip.X, mainShip.Y);
                    break;
                default:
                    break;
            }
        }
    }
}
