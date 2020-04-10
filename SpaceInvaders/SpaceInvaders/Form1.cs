using SpaceInvaders.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private GameManager manager;
        private bool gameStarted = false;

        public Form1()
        {
            InitializeComponent();

            manager = new GameManager(drawingPanel.Width, drawingPanel.Height);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, drawingPanel, new object[] { true });
            Invalidate();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                if (!String.Equals(lblScore2.Text, "You Win!"))
                {
                    drawingPanel.Invalidate();
                    lblScore1.Text = manager.score.ToString();
                }
                if (manager.Count())
                {
                    SoundPlayer sounds = new SoundPlayer(Resources.spaceinvaders1);
                    lblScore1.Text = "You Win!";
                    sounds.Play();
                }
            }
        }
        
        private void onPaint(object sender, PaintEventArgs e)
        {
            if(gameStarted)
            {
                manager.Move(e);
            }
        }

        private void buttonPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.P)
            {
                HideGameStartScreen();
                gameStarted = true;
            }
            else
            {
                manager.handlebuttonPressed(e.KeyCode);
            }
        }

        private void HideGameStartScreen()
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameStartAnimation();
        }



        private void GameStartAnimation()
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
        }

        private void lblHighScoreResult_Click(object sender, EventArgs e)
        {

        }

        private void drawingPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
