using SpaceInvaders.Properties;

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
         this.tick = new System.Windows.Forms.Timer(this.components);
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.drawingPanel = new System.Windows.Forms.Panel();
         this.playerLivesLbl = new System.Windows.Forms.Label();
         this.linebreakLbl = new System.Windows.Forms.Label();
         this.playerLifepb2 = new System.Windows.Forms.PictureBox();
         this.playerLifepb1 = new System.Windows.Forms.PictureBox();
         this.gameOverLbl = new System.Windows.Forms.Label();
         this.startLbl9 = new System.Windows.Forms.Label();
         this.startpb4 = new System.Windows.Forms.PictureBox();
         this.startpb3 = new System.Windows.Forms.PictureBox();
         this.startpb2 = new System.Windows.Forms.PictureBox();
         this.startpb1 = new System.Windows.Forms.PictureBox();
         this.startLbl8 = new System.Windows.Forms.Label();
         this.startLbl7 = new System.Windows.Forms.Label();
         this.startLbl6 = new System.Windows.Forms.Label();
         this.startLbl5 = new System.Windows.Forms.Label();
         this.startLbl4 = new System.Windows.Forms.Label();
         this.startLbl3 = new System.Windows.Forms.Label();
         this.startLbl2 = new System.Windows.Forms.Label();
         this.startLbl1 = new System.Windows.Forms.Label();
         this.lblScore2 = new System.Windows.Forms.Label();
         this.lblHighScoreResult = new System.Windows.Forms.Label();
         this.lblPlayerTwoScore = new System.Windows.Forms.Label();
         this.lblHighScore = new System.Windows.Forms.Label();
         this.lblPlayerOnesScore = new System.Windows.Forms.Label();
         this.lblScore1 = new System.Windows.Forms.Label();
         this.mainShipBindingSource = new System.Windows.Forms.BindingSource(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.drawingPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.playerLifepb2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.playerLifepb1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mainShipBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // tick
         // 
         this.tick.Enabled = true;
         this.tick.Interval = 25;
         this.tick.Tick += new System.EventHandler(this.tick_Tick);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(140, 533);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(100, 50);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // drawingPanel
         // 
         this.drawingPanel.Controls.Add(this.playerLivesLbl);
         this.drawingPanel.Controls.Add(this.linebreakLbl);
         this.drawingPanel.Controls.Add(this.playerLifepb2);
         this.drawingPanel.Controls.Add(this.playerLifepb1);
         this.drawingPanel.Controls.Add(this.gameOverLbl);
         this.drawingPanel.Controls.Add(this.startLbl9);
         this.drawingPanel.Controls.Add(this.startpb4);
         this.drawingPanel.Controls.Add(this.startpb3);
         this.drawingPanel.Controls.Add(this.startpb2);
         this.drawingPanel.Controls.Add(this.startpb1);
         this.drawingPanel.Controls.Add(this.startLbl8);
         this.drawingPanel.Controls.Add(this.startLbl7);
         this.drawingPanel.Controls.Add(this.startLbl6);
         this.drawingPanel.Controls.Add(this.startLbl5);
         this.drawingPanel.Controls.Add(this.startLbl4);
         this.drawingPanel.Controls.Add(this.startLbl3);
         this.drawingPanel.Controls.Add(this.startLbl2);
         this.drawingPanel.Controls.Add(this.startLbl1);
         this.drawingPanel.Controls.Add(this.lblScore2);
         this.drawingPanel.Controls.Add(this.lblHighScoreResult);
         this.drawingPanel.Controls.Add(this.lblPlayerTwoScore);
         this.drawingPanel.Controls.Add(this.lblHighScore);
         this.drawingPanel.Controls.Add(this.lblPlayerOnesScore);
         this.drawingPanel.Controls.Add(this.lblScore1);
         this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.drawingPanel.Location = new System.Drawing.Point(0, 0);
         this.drawingPanel.Name = "drawingPanel";
         this.drawingPanel.Size = new System.Drawing.Size(700, 800);
         this.drawingPanel.TabIndex = 1;
         this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
         this.drawingPanel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.drawingPanel_PreviewKeyDown);
         // 
         // playerLivesLbl
         // 
         this.playerLivesLbl.AutoSize = true;
         this.playerLivesLbl.Font = new System.Drawing.Font("Agency FB", 24F);
         this.playerLivesLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.playerLivesLbl.Location = new System.Drawing.Point(3, 760);
         this.playerLivesLbl.Name = "playerLivesLbl";
         this.playerLivesLbl.Size = new System.Drawing.Size(30, 40);
         this.playerLivesLbl.TabIndex = 26;
         this.playerLivesLbl.Text = "3";
         this.playerLivesLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // linebreakLbl
         // 
         this.linebreakLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(25)))));
         this.linebreakLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.linebreakLbl.Location = new System.Drawing.Point(-4, 747);
         this.linebreakLbl.Name = "linebreakLbl";
         this.linebreakLbl.Size = new System.Drawing.Size(701, 10);
         this.linebreakLbl.TabIndex = 25;
         // 
         // playerLifepb2
         // 
         this.playerLifepb2.Image = global::SpaceInvaders.Properties.Resources.player;
         this.playerLifepb2.Location = new System.Drawing.Point(84, 769);
         this.playerLifepb2.Name = "playerLifepb2";
         this.playerLifepb2.Size = new System.Drawing.Size(49, 28);
         this.playerLifepb2.TabIndex = 23;
         this.playerLifepb2.TabStop = false;
         this.playerLifepb2.Visible = false;
         // 
         // playerLifepb1
         // 
         this.playerLifepb1.Image = global::SpaceInvaders.Properties.Resources.player;
         this.playerLifepb1.Location = new System.Drawing.Point(29, 769);
         this.playerLifepb1.Name = "playerLifepb1";
         this.playerLifepb1.Size = new System.Drawing.Size(49, 28);
         this.playerLifepb1.TabIndex = 22;
         this.playerLifepb1.TabStop = false;
         this.playerLifepb1.Visible = false;
         // 
         // gameOverLbl
         // 
         this.gameOverLbl.AutoSize = true;
         this.gameOverLbl.Font = new System.Drawing.Font("Agency FB", 32F, System.Drawing.FontStyle.Bold);
         this.gameOverLbl.ForeColor = System.Drawing.Color.Red;
         this.gameOverLbl.Location = new System.Drawing.Point(231, 128);
         this.gameOverLbl.Name = "gameOverLbl";
         this.gameOverLbl.Size = new System.Drawing.Size(256, 52);
         this.gameOverLbl.TabIndex = 21;
         this.gameOverLbl.Text = "G A M E   O V E R";
         this.gameOverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.gameOverLbl.Visible = false;
         // 
         // startLbl9
         // 
         this.startLbl9.AutoSize = true;
         this.startLbl9.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl9.Location = new System.Drawing.Point(208, 613);
         this.startLbl9.Name = "startLbl9";
         this.startLbl9.Size = new System.Drawing.Size(264, 40);
         this.startLbl9.TabIndex = 20;
         this.startLbl9.Text = "P R E S S   P   T O   P L A Y";
         this.startLbl9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startpb4
         // 
         this.startpb4.BackColor = System.Drawing.Color.Transparent;
         this.startpb4.Image = global::SpaceInvaders.Properties.Resources.AlienC1Green;
         this.startpb4.InitialImage = global::SpaceInvaders.Properties.Resources.AlienC1;
         this.startpb4.Location = new System.Drawing.Point(232, 545);
         this.startpb4.Name = "startpb4";
         this.startpb4.Size = new System.Drawing.Size(45, 35);
         this.startpb4.TabIndex = 19;
         this.startpb4.TabStop = false;
         // 
         // startpb3
         // 
         this.startpb3.BackColor = System.Drawing.Color.Transparent;
         this.startpb3.Image = global::SpaceInvaders.Properties.Resources.AlienB2;
         this.startpb3.InitialImage = global::SpaceInvaders.Properties.Resources.AlienB2;
         this.startpb3.Location = new System.Drawing.Point(231, 493);
         this.startpb3.Name = "startpb3";
         this.startpb3.Size = new System.Drawing.Size(51, 34);
         this.startpb3.TabIndex = 18;
         this.startpb3.TabStop = false;
         // 
         // startpb2
         // 
         this.startpb2.BackColor = System.Drawing.Color.Transparent;
         this.startpb2.Image = global::SpaceInvaders.Properties.Resources.AlienA1;
         this.startpb2.InitialImage = global::SpaceInvaders.Properties.Resources.AlienA1;
         this.startpb2.Location = new System.Drawing.Point(235, 438);
         this.startpb2.Name = "startpb2";
         this.startpb2.Size = new System.Drawing.Size(45, 28);
         this.startpb2.TabIndex = 17;
         this.startpb2.TabStop = false;
         // 
         // startpb1
         // 
         this.startpb1.BackColor = System.Drawing.Color.Transparent;
         this.startpb1.Image = global::SpaceInvaders.Properties.Resources.AlienUFOWhite;
         this.startpb1.InitialImage = global::SpaceInvaders.Properties.Resources.AlienUFO;
         this.startpb1.Location = new System.Drawing.Point(229, 387);
         this.startpb1.Name = "startpb1";
         this.startpb1.Size = new System.Drawing.Size(51, 30);
         this.startpb1.TabIndex = 16;
         this.startpb1.TabStop = false;
         // 
         // startLbl8
         // 
         this.startLbl8.AutoSize = true;
         this.startLbl8.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl8.Location = new System.Drawing.Point(538, 757);
         this.startLbl8.Name = "startLbl8";
         this.startLbl8.Size = new System.Drawing.Size(159, 40);
         this.startLbl8.TabIndex = 14;
         this.startLbl8.Text = "C R E D I T   00";
         this.startLbl8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startLbl7
         // 
         this.startLbl7.AutoSize = true;
         this.startLbl7.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(25)))));
         this.startLbl7.Location = new System.Drawing.Point(274, 534);
         this.startLbl7.Name = "startLbl7";
         this.startLbl7.Size = new System.Drawing.Size(179, 40);
         this.startLbl7.TabIndex = 13;
         this.startLbl7.Text = "= 1 0   P O I N T S";
         this.startLbl7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startLbl6
         // 
         this.startLbl6.AutoSize = true;
         this.startLbl6.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl6.Location = new System.Drawing.Point(271, 484);
         this.startLbl6.Name = "startLbl6";
         this.startLbl6.Size = new System.Drawing.Size(186, 40);
         this.startLbl6.TabIndex = 12;
         this.startLbl6.Text = "= 2 0   P O I N T S";
         this.startLbl6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startLbl5
         // 
         this.startLbl5.AutoSize = true;
         this.startLbl5.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl5.Location = new System.Drawing.Point(271, 429);
         this.startLbl5.Name = "startLbl5";
         this.startLbl5.Size = new System.Drawing.Size(186, 40);
         this.startLbl5.TabIndex = 11;
         this.startLbl5.Text = "= 3 0   P O I N T S";
         this.startLbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startLbl4
         // 
         this.startLbl4.AutoSize = true;
         this.startLbl4.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl4.Location = new System.Drawing.Point(274, 377);
         this.startLbl4.Name = "startLbl4";
         this.startLbl4.Size = new System.Drawing.Size(180, 40);
         this.startLbl4.TabIndex = 10;
         this.startLbl4.Text = "=?  M Y S T E R Y";
         this.startLbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startLbl3
         // 
         this.startLbl3.AutoSize = true;
         this.startLbl3.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl3.Location = new System.Drawing.Point(156, 322);
         this.startLbl3.Name = "startLbl3";
         this.startLbl3.Size = new System.Drawing.Size(377, 40);
         this.startLbl3.TabIndex = 9;
         this.startLbl3.Text = "* S C O R E   A D V A N C E   T A B L E *";
         this.startLbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startLbl2
         // 
         this.startLbl2.AutoSize = true;
         this.startLbl2.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl2.Location = new System.Drawing.Point(215, 254);
         this.startLbl2.Name = "startLbl2";
         this.startLbl2.Size = new System.Drawing.Size(272, 40);
         this.startLbl2.TabIndex = 8;
         this.startLbl2.Text = "S P A C E      I N V A D E R S";
         this.startLbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // startLbl1
         // 
         this.startLbl1.AutoSize = true;
         this.startLbl1.Font = new System.Drawing.Font("Agency FB", 24F);
         this.startLbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.startLbl1.Location = new System.Drawing.Point(297, 198);
         this.startLbl1.Name = "startLbl1";
         this.startLbl1.Size = new System.Drawing.Size(81, 40);
         this.startLbl1.TabIndex = 7;
         this.startLbl1.Text = "P L A Y";
         this.startLbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // lblScore2
         // 
         this.lblScore2.AutoSize = true;
         this.lblScore2.Font = new System.Drawing.Font("Agency FB", 24F);
         this.lblScore2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.lblScore2.Location = new System.Drawing.Point(549, 67);
         this.lblScore2.Name = "lblScore2";
         this.lblScore2.Size = new System.Drawing.Size(79, 40);
         this.lblScore2.TabIndex = 6;
         this.lblScore2.Text = " 0000";
         this.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblHighScoreResult
         // 
         this.lblHighScoreResult.AutoSize = true;
         this.lblHighScoreResult.Font = new System.Drawing.Font("Agency FB", 24F);
         this.lblHighScoreResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.lblHighScoreResult.Location = new System.Drawing.Point(274, 67);
         this.lblHighScoreResult.Name = "lblHighScoreResult";
         this.lblHighScoreResult.Size = new System.Drawing.Size(79, 40);
         this.lblHighScoreResult.TabIndex = 5;
         this.lblHighScoreResult.Text = " 0000";
         this.lblHighScoreResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.lblHighScoreResult.Click += new System.EventHandler(this.lblHighScoreResult_Click);
         // 
         // lblPlayerTwoScore
         // 
         this.lblPlayerTwoScore.AutoSize = true;
         this.lblPlayerTwoScore.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPlayerTwoScore.ForeColor = System.Drawing.Color.White;
         this.lblPlayerTwoScore.Location = new System.Drawing.Point(514, 9);
         this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
         this.lblPlayerTwoScore.Size = new System.Drawing.Size(174, 58);
         this.lblPlayerTwoScore.TabIndex = 4;
         this.lblPlayerTwoScore.Text = "SCORE<2>";
         // 
         // lblHighScore
         // 
         this.lblHighScore.AutoSize = true;
         this.lblHighScore.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblHighScore.ForeColor = System.Drawing.Color.White;
         this.lblHighScore.Location = new System.Drawing.Point(263, 9);
         this.lblHighScore.Name = "lblHighScore";
         this.lblHighScore.Size = new System.Drawing.Size(165, 58);
         this.lblHighScore.TabIndex = 3;
         this.lblHighScore.Text = "HI-SCORE";
         // 
         // lblPlayerOnesScore
         // 
         this.lblPlayerOnesScore.AutoSize = true;
         this.lblPlayerOnesScore.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPlayerOnesScore.ForeColor = System.Drawing.Color.White;
         this.lblPlayerOnesScore.Location = new System.Drawing.Point(12, 9);
         this.lblPlayerOnesScore.Name = "lblPlayerOnesScore";
         this.lblPlayerOnesScore.Size = new System.Drawing.Size(163, 58);
         this.lblPlayerOnesScore.TabIndex = 2;
         this.lblPlayerOnesScore.Text = "SCORE<1>";
         // 
         // lblScore1
         // 
         this.lblScore1.AutoSize = true;
         this.lblScore1.Font = new System.Drawing.Font("Agency FB", 24F);
         this.lblScore1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.lblScore1.Location = new System.Drawing.Point(47, 67);
         this.lblScore1.Name = "lblScore1";
         this.lblScore1.Size = new System.Drawing.Size(79, 40);
         this.lblScore1.TabIndex = 1;
         this.lblScore1.Text = " 0000";
         this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // mainShipBindingSource
         // 
         this.mainShipBindingSource.DataSource = typeof(SpaceInvaders.Player.MainShip);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Black;
         this.ClientSize = new System.Drawing.Size(700, 800);
         this.Controls.Add(this.drawingPanel);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Space Invaders";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPressed);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.drawingPanel.ResumeLayout(false);
         this.drawingPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.playerLifepb2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.playerLifepb1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.startpb1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mainShipBindingSource)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblHighScoreResult;
        private System.Windows.Forms.Label lblPlayerTwoScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblPlayerOnesScore;
        private System.Windows.Forms.Label startLbl1;
        private System.Windows.Forms.Label startLbl8;
        private System.Windows.Forms.Label startLbl7;
        private System.Windows.Forms.Label startLbl6;
        private System.Windows.Forms.Label startLbl5;
        private System.Windows.Forms.Label startLbl4;
        private System.Windows.Forms.Label startLbl3;
        private System.Windows.Forms.Label startLbl2;
        private System.Windows.Forms.PictureBox startpb4;
        private System.Windows.Forms.PictureBox startpb3;
        private System.Windows.Forms.PictureBox startpb2;
        private System.Windows.Forms.PictureBox startpb1;
        private System.Windows.Forms.Label startLbl9;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.PictureBox playerLifepb2;
        private System.Windows.Forms.PictureBox playerLifepb1;
        private System.Windows.Forms.Label linebreakLbl;
        private System.Windows.Forms.Label playerLivesLbl;
        private System.Windows.Forms.BindingSource mainShipBindingSource;
    }
}

