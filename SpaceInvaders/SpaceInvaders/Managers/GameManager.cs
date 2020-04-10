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
        private MovableObject mainShip;
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
            mainShip = new MainShip(350, 750, playerSprites, playerDSprites, panelWidth, panelHeight);
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
            RemoveDead(enemyManager.GetAliens());
        }

        private void RemoveDead(List<Alien> aliens)
        {
            foreach (Alien alien in aliens)
            {
                if (alien.dead && alien.deadTimer > 5)
                {
                    enemyManager.Reduce(alien);
                    aliens.Remove(alien);
                    return;
                }
            }
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

        public Boolean Collision(MovableObject a, MovableObject b)
        {
            if ((a.X < b.X + b.Width() && a.X > b.X) || (a.X + a.Width() < b.X + b.Width() && a.X + a.Width() > b.X))
                if ((a.Y < b.Y + b.Height() && a.Y > b.Y) || (a.Y + a.Height() < b.Y + b.Height() && a.Y + a.Height() > b.Y))
                    return true;
                else
                    return false;
            else
                return false;
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
            }
        }
    }
}
