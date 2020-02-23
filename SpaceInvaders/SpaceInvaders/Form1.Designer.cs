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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.hiScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 500;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCORE<1>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "HI-SCORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(510, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "SCORE<2>";
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p1Score.Location = new System.Drawing.Point(59, 52);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(50, 24);
            this.p1Score.TabIndex = 3;
            this.p1Score.Text = "6969";
            // 
            // p2Score
            // 
            this.p2Score.AutoSize = true;
            this.p2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p2Score.Location = new System.Drawing.Point(531, 52);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(40, 24);
            this.p2Score.TabIndex = 4;
            this.p2Score.Text = "420";
            // 
            // hiScore
            // 
            this.hiScore.AutoSize = true;
            this.hiScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hiScore.Location = new System.Drawing.Point(304, 52);
            this.hiScore.Name = "hiScore";
            this.hiScore.Size = new System.Drawing.Size(20, 24);
            this.hiScore.TabIndex = 5;
            this.hiScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.hiScore);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label hiScore;
    }
}

