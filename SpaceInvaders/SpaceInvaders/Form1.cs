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
        private GameManager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new GameManager(this.drawingPanel);
        }

        private void tick_Tick(object sender, EventArgs e)
        {

        }
        
        private void onPaint(object sender, PaintEventArgs e)
        {
            manager.ShowAll();
        }

        private void buttonPressed(object sender, KeyEventArgs e)
        {
            manager.handlebuttonPressed(e.KeyCode);
        }
    }
}
