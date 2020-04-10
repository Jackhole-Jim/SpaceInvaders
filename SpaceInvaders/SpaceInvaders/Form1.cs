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
        private MediaPlayer sounds = new MediaPlayer();
       

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
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            //Invalidate();
            if (!String.Equals(label1.Text, "You Win!"))
            {
                drawingPanel.Invalidate();
                lblScore1.Text = manager.score.ToString();
            }
            if (manager.Count())
            {
                label1.Text = "You Win!";
                sounds.Play();
            }
               
        }
        
        private void onPaint(object sender, PaintEventArgs e)
        {
            manager.Move(e);
        }

        private void buttonPressed(object sender, KeyEventArgs e)
        {
            manager.handlebuttonPressed(e.KeyCode);
        }
    }
}
