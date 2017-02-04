namespace Blackjack3
{
    partial class Scoreboard
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
            this.uxScoreboardLabel = new System.Windows.Forms.Label();
            this.uxStaticHumanWinsLabel = new System.Windows.Forms.Label();
            this.uxStaticHumanScoreLabel = new System.Windows.Forms.Label();
            this.uxStaticTotalRoundsLabel = new System.Windows.Forms.Label();
            this.uxScoreLabel = new System.Windows.Forms.Label();
            this.uxRoundsPlayedLabel = new System.Windows.Forms.Label();
            this.uxWinsLabel = new System.Windows.Forms.Label();
            this.uxStaticStatusLabel = new System.Windows.Forms.Label();
            this.uxStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxScoreboardLabel
            // 
            this.uxScoreboardLabel.AutoSize = true;
            this.uxScoreboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxScoreboardLabel.Location = new System.Drawing.Point(61, 9);
            this.uxScoreboardLabel.Name = "uxScoreboardLabel";
            this.uxScoreboardLabel.Size = new System.Drawing.Size(168, 29);
            this.uxScoreboardLabel.TabIndex = 0;
            this.uxScoreboardLabel.Text = "-Scoreboard-";
            // 
            // uxStaticHumanWinsLabel
            // 
            this.uxStaticHumanWinsLabel.AutoSize = true;
            this.uxStaticHumanWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticHumanWinsLabel.Location = new System.Drawing.Point(12, 107);
            this.uxStaticHumanWinsLabel.Name = "uxStaticHumanWinsLabel";
            this.uxStaticHumanWinsLabel.Size = new System.Drawing.Size(141, 20);
            this.uxStaticHumanWinsLabel.TabIndex = 1;
            this.uxStaticHumanWinsLabel.Text = "Your Total Wins:";
            // 
            // uxStaticHumanScoreLabel
            // 
            this.uxStaticHumanScoreLabel.AutoSize = true;
            this.uxStaticHumanScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticHumanScoreLabel.Location = new System.Drawing.Point(12, 60);
            this.uxStaticHumanScoreLabel.Name = "uxStaticHumanScoreLabel";
            this.uxStaticHumanScoreLabel.Size = new System.Drawing.Size(173, 20);
            this.uxStaticHumanScoreLabel.TabIndex = 2;
            this.uxStaticHumanScoreLabel.Text = "Score of Your Hand:";
            // 
            // uxStaticTotalRoundsLabel
            // 
            this.uxStaticTotalRoundsLabel.AutoSize = true;
            this.uxStaticTotalRoundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticTotalRoundsLabel.Location = new System.Drawing.Point(12, 154);
            this.uxStaticTotalRoundsLabel.Name = "uxStaticTotalRoundsLabel";
            this.uxStaticTotalRoundsLabel.Size = new System.Drawing.Size(132, 20);
            this.uxStaticTotalRoundsLabel.TabIndex = 3;
            this.uxStaticTotalRoundsLabel.Text = "Current Round:";
            // 
            // uxScoreLabel
            // 
            this.uxScoreLabel.AutoSize = true;
            this.uxScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxScoreLabel.Location = new System.Drawing.Point(222, 60);
            this.uxScoreLabel.Name = "uxScoreLabel";
            this.uxScoreLabel.Size = new System.Drawing.Size(35, 20);
            this.uxScoreLabel.TabIndex = 4;
            this.uxScoreLabel.Text = "N/A";
            // 
            // uxRoundsPlayedLabel
            // 
            this.uxRoundsPlayedLabel.AutoSize = true;
            this.uxRoundsPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRoundsPlayedLabel.Location = new System.Drawing.Point(222, 154);
            this.uxRoundsPlayedLabel.Name = "uxRoundsPlayedLabel";
            this.uxRoundsPlayedLabel.Size = new System.Drawing.Size(18, 20);
            this.uxRoundsPlayedLabel.TabIndex = 5;
            this.uxRoundsPlayedLabel.Text = "0";
            // 
            // uxWinsLabel
            // 
            this.uxWinsLabel.AutoSize = true;
            this.uxWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWinsLabel.Location = new System.Drawing.Point(222, 107);
            this.uxWinsLabel.Name = "uxWinsLabel";
            this.uxWinsLabel.Size = new System.Drawing.Size(35, 20);
            this.uxWinsLabel.TabIndex = 6;
            this.uxWinsLabel.Text = "N/A";
            // 
            // uxStaticStatusLabel
            // 
            this.uxStaticStatusLabel.AutoSize = true;
            this.uxStaticStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticStatusLabel.Location = new System.Drawing.Point(12, 196);
            this.uxStaticStatusLabel.Name = "uxStaticStatusLabel";
            this.uxStaticStatusLabel.Size = new System.Drawing.Size(120, 20);
            this.uxStaticStatusLabel.TabIndex = 7;
            this.uxStaticStatusLabel.Text = "Game Status:";
            // 
            // uxStatusLabel
            // 
            this.uxStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStatusLabel.Location = new System.Drawing.Point(12, 231);
            this.uxStatusLabel.Name = "uxStatusLabel";
            this.uxStatusLabel.Size = new System.Drawing.Size(257, 138);
            this.uxStatusLabel.TabIndex = 8;
            this.uxStatusLabel.Text = "Welcome to Blackjack! Press \"New Round\" to begin the game.";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 378);
            this.Controls.Add(this.uxStatusLabel);
            this.Controls.Add(this.uxStaticStatusLabel);
            this.Controls.Add(this.uxWinsLabel);
            this.Controls.Add(this.uxRoundsPlayedLabel);
            this.Controls.Add(this.uxScoreLabel);
            this.Controls.Add(this.uxStaticTotalRoundsLabel);
            this.Controls.Add(this.uxStaticHumanScoreLabel);
            this.Controls.Add(this.uxStaticHumanWinsLabel);
            this.Controls.Add(this.uxScoreboardLabel);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxScoreboardLabel;
        private System.Windows.Forms.Label uxStaticHumanWinsLabel;
        private System.Windows.Forms.Label uxStaticHumanScoreLabel;
        private System.Windows.Forms.Label uxStaticTotalRoundsLabel;
        private System.Windows.Forms.Label uxScoreLabel;
        private System.Windows.Forms.Label uxRoundsPlayedLabel;
        private System.Windows.Forms.Label uxWinsLabel;
        private System.Windows.Forms.Label uxStaticStatusLabel;
        private System.Windows.Forms.Label uxStatusLabel;
    }
}