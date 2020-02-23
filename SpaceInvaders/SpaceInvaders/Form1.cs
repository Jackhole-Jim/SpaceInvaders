using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpaceInvaders
{
    public partial class Form1 : Form
    {

        int anim = 0;
        List<Bitmap> animation = new List<Bitmap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienA1.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienA2.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienAShot1.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienAShot2.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienAShot3.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienAShot4.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienB1.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienB2.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienBShot1.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienBShot2.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienBShot3.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienBShot4.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienC1.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienC2.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienCShot1.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienCShot2.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienCShot3.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienCShot4.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienPop.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienShotExplosion.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienUFO.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\AlienUFOExplosion.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\BigRock.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\player.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\PlayerExplosion1.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\PlayerExplosion2.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\PlayerShot.bmp"));
            animation.Add(new Bitmap("J:\\Yes\\team_11\\SpaceInvaders\\SpaceInvaders\\Sprites\\PlayerShotExplosion.bmp"));
        }

        private void animate()
        {
            if (anim == animation.Count - 1)
                anim = 0;
            else
                anim++;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            animate();
            e.Graphics.DrawImage(animation[anim], 500, 400);
        }
    }
}
