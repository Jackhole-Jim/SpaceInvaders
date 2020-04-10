namespace SpaceInvaders
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tick = new System.Windows.Forms.Timer(this.components);
			this.drawingPanel = new System.Windows.Forms.Panel();
			this.lblScore1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.drawingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tick
			// 
			this.tick.Enabled = true;
			this.tick.Interval = 5;
			this.tick.Tick += new System.EventHandler(this.tick_Tick);
			// 
			// drawingPanel
			// 
			this.drawingPanel.Controls.Add(this.lblScore1);
			this.drawingPanel.Controls.Add(this.label1);
			this.drawingPanel.Cursor = System.Windows.Forms.Cursors.Default;
			this.drawingPanel.Location = new System.Drawing.Point(0, 0);
			this.drawingPanel.Name = "drawingPanel";
			this.drawingPanel.Size = new System.Drawing.Size(701, 805);
			this.drawingPanel.TabIndex = 1;
			this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
			// 
			// lblScore1
			// 
			this.lblScore1.AutoSize = true;
			this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblScore1.Location = new System.Drawing.Point(93, 67);
			this.lblScore1.Name = "lblScore1";
			this.lblScore1.Size = new System.Drawing.Size(11, 16);
			this.lblScore1.TabIndex = 1;
			this.lblScore1.Text = " ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(54, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(596, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "SCORE<1>        HI-SCORE        SCORE<2>";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(140, 533);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(700, 800);
			this.Controls.Add(this.drawingPanel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Space Invaders";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPressed);
			this.drawingPanel.ResumeLayout(false);
			this.drawingPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore1;
    }
}

