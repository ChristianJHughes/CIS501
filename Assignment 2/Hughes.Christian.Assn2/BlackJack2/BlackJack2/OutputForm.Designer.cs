namespace BlackJack2
{
    partial class OutputForm
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
            this.currentHandLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreLabelStatic = new System.Windows.Forms.Label();
            this.statsLabelStatic = new System.Windows.Forms.Label();
            this.currentHandLabelStatic = new System.Windows.Forms.Label();
            this.topCardLabel = new System.Windows.Forms.Label();
            this.staticResultsLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentHandLabel
            // 
            this.currentHandLabel.AutoSize = true;
            this.currentHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHandLabel.Location = new System.Drawing.Point(11, 39);
            this.currentHandLabel.Name = "currentHandLabel";
            this.currentHandLabel.Size = new System.Drawing.Size(109, 20);
            this.currentHandLabel.TabIndex = 0;
            this.currentHandLabel.Text = "Cards go here";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLabel.Location = new System.Drawing.Point(76, 347);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(180, 20);
            this.statsLabel.TabIndex = 1;
            this.statsLabel.Text = "0 win(s) after 0 round(s).";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(76, 316);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(18, 20);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "?";
            // 
            // scoreLabelStatic
            // 
            this.scoreLabelStatic.AutoSize = true;
            this.scoreLabelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabelStatic.Location = new System.Drawing.Point(11, 316);
            this.scoreLabelStatic.Name = "scoreLabelStatic";
            this.scoreLabelStatic.Size = new System.Drawing.Size(66, 20);
            this.scoreLabelStatic.TabIndex = 3;
            this.scoreLabelStatic.Text = "Score: ";
            // 
            // statsLabelStatic
            // 
            this.statsLabelStatic.AutoSize = true;
            this.statsLabelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLabelStatic.Location = new System.Drawing.Point(11, 347);
            this.statsLabelStatic.Name = "statsLabelStatic";
            this.statsLabelStatic.Size = new System.Drawing.Size(57, 20);
            this.statsLabelStatic.TabIndex = 4;
            this.statsLabelStatic.Text = "Stats:";
            // 
            // currentHandLabelStatic
            // 
            this.currentHandLabelStatic.AutoSize = true;
            this.currentHandLabelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHandLabelStatic.Location = new System.Drawing.Point(11, 9);
            this.currentHandLabelStatic.Name = "currentHandLabelStatic";
            this.currentHandLabelStatic.Size = new System.Drawing.Size(122, 20);
            this.currentHandLabelStatic.TabIndex = 5;
            this.currentHandLabelStatic.Text = "Current Hand:";
            // 
            // topCardLabel
            // 
            this.topCardLabel.AutoSize = true;
            this.topCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topCardLabel.Location = new System.Drawing.Point(161, 39);
            this.topCardLabel.Name = "topCardLabel";
            this.topCardLabel.Size = new System.Drawing.Size(38, 20);
            this.topCardLabel.TabIndex = 6;
            this.topCardLabel.Text = "TCL";
            // 
            // staticResultsLabel
            // 
            this.staticResultsLabel.AutoSize = true;
            this.staticResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticResultsLabel.Location = new System.Drawing.Point(11, 287);
            this.staticResultsLabel.Name = "staticResultsLabel";
            this.staticResultsLabel.Size = new System.Drawing.Size(151, 20);
            this.staticResultsLabel.TabIndex = 7;
            this.staticResultsLabel.Text = "Result for Round:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(168, 287);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(48, 20);
            this.resultsLabel.TabIndex = 8;
            this.resultsLabel.Text = "result";
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 376);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.staticResultsLabel);
            this.Controls.Add(this.topCardLabel);
            this.Controls.Add(this.currentHandLabelStatic);
            this.Controls.Add(this.statsLabelStatic);
            this.Controls.Add(this.scoreLabelStatic);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.currentHandLabel);
            this.Name = "OutputForm";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentHandLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreLabelStatic;
        private System.Windows.Forms.Label statsLabelStatic;
        private System.Windows.Forms.Label currentHandLabelStatic;
        private System.Windows.Forms.Label topCardLabel;
        private System.Windows.Forms.Label staticResultsLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}

