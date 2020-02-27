﻿using System;
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
        private Bullet bullet;
        EnemyManager enemyManager;
        

        public GameManager(int panelWidth, int panelHeight)
        {
            mainShip = new MainShip(350, 750, new Bitmap(Resources.player), panelWidth, panelHeight);
            bullet = new Bullet(-100, -100, new Bitmap(Resources.PlayerShot), panelWidth, panelHeight);
            enemyManager = new EnemyManager(panelWidth, panelHeight);
            enemyManager.GenerateEnemies();
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
            CheckCollision(enemyManager.GetAliens());
        }
        
        public void CheckCollision(List<Alien> aliens)
        {
            foreach (Alien alien in aliens)
            {
                if (Collision(bullet, alien))
                { 
                    enemyManager.GetAliens().Remove(alien);
                    bullet.reset();
                    return;
                }
            }
        }

        public Boolean Collision(MovableObject a, MovableObject b)
        {
            if (a.X < b.X + b.Image.Width && a.X > b.X)
                if (a.Y < b.Y + b.Image.Height && a.Y > b.Y)
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
