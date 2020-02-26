using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        private GameManager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new GameManager();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, drawingPanel, new object[] { true });
            Invalidate();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            //Invalidate();
            drawingPanel.Invalidate();
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
