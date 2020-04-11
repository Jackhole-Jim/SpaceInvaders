using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private GameManager manager;
        private bool gameRunning = false;
        private MediaPlayer sounds = new MediaPlayer();
        private MediaPlayer startSound = new MediaPlayer();
        private int playersLivesLeft = 3;

        public Form1()
        {
            InitializeComponent();

            manager = new GameManager(drawingPanel.Width, drawingPanel.Height);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, drawingPanel, new object[] { true });
            Invalidate();
            sounds.Open(new Uri(Util.bingPathToAppDir("Resources\\spaceinvaders1.wav")));
            startSound.Open(new Uri(Util.bingPathToAppDir("Resources\\spaceinvaders2.wav")));
            startSound.Play();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (gameRunning)
            {
                if (!String.Equals(gameOverLbl.Text, "Y O U   W I N !"))
                {
                    drawingPanel.Invalidate();
                    lblScore1.Text = manager.score.ToString();
                }
                
                if (manager.Count())
                {
                    GameWon();
                }
               else if (manager.GetPlayerLives() < playersLivesLeft)
               {
                  DeductPlayerLife();
               }
               else if (manager.AlienHitBottom() || manager.PlayerDead())
                   {
                      GameLost();
                   }
               }
        }

      private void DeductPlayerLife()
      {
         playersLivesLeft--;
         playerLivesLbl.Text = playersLivesLeft.ToString();
         if (playersLivesLeft == 2)
         {
            playerLifepb2.Visible = false;
         }
         else if (playersLivesLeft == 1)
         {
            playerLifepb1.Visible = false;
         }
         else if (playersLivesLeft == 0)
         {
            GameLost();
         }
      }

      private void GameWon()
        {
            gameRunning = false;
            gameOverLbl.Text = "Y O U   W I N !";
            gameOverLbl.ForeColor = System.Drawing.Color.Green;
            gameOverLbl.Visible = true;
            sounds.Play();
        }

        public void GameLost()
        {
            gameRunning = false;
            gameOverLbl.Text = "G A M E   O V E R";
            gameOverLbl.ForeColor = System.Drawing.Color.Red;
            gameOverLbl.Visible = true;
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            if(gameRunning)
            {
                manager.Move(e);
            }
        }


        private void buttonPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.P)
            {
                startSound.Stop();
                DisplayGameStartScreen();
                gameRunning = true;
            }
            else
            {
                manager.handlebuttonPressed(e.KeyCode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayGameIntroScreen();
        }

        private void DisplayGameStartScreen()
        {
            startLbl1.Visible = false;
            startLbl2.Visible = false;
            startLbl3.Visible = false;
            startLbl4.Visible = false;
            startLbl5.Visible = false;
            startLbl6.Visible = false;
            startLbl7.Visible = false;
            startLbl8.Visible = false;
            startLbl9.Visible = false;
            startpb1.Visible = false;
            startpb2.Visible = false;
            startpb3.Visible = false;
            startpb4.Visible = false;
            playerLifepb1.Visible = true;
            playerLifepb2.Visible = true;
            linebreakLbl.Visible = true;
            playerLivesLbl.Visible = true;
        }


        private void DisplayGameIntroScreen()
        {
            startLbl1.Visible = true;
            startLbl2.Visible = true;
            startLbl3.Visible = true;
            startLbl4.Visible = true;
            startLbl5.Visible = true;
            startLbl6.Visible = true;
            startLbl7.Visible = true;
            startLbl8.Visible = true;
            startLbl9.Visible = true;
            startpb1.Visible = true;
            startpb2.Visible = true;
            startpb3.Visible = true;
            startpb4.Visible = true;
            playerLifepb1.Visible = false;
            playerLifepb2.Visible = false;
            linebreakLbl.Visible = false;
            playerLivesLbl.Visible = false;
        }

      private void lblHighScoreResult_Click(object sender, EventArgs e)
        {

        }

        private void drawingPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
