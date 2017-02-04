namespace Blackjack3
{
    partial class HumansHandForm
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
            this.uxNewRoundButton = new System.Windows.Forms.Button();
            this.uxAddAnotherCardButton = new System.Windows.Forms.Button();
            this.uxHoldCardsButton = new System.Windows.Forms.Button();
            this.uxStaticHandLabel = new System.Windows.Forms.Label();
            this.uxHandLabel = new System.Windows.Forms.Label();
            this.uxStaticTopCardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxNewRoundButton
            // 
            this.uxNewRoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewRoundButton.Location = new System.Drawing.Point(13, 319);
            this.uxNewRoundButton.Name = "uxNewRoundButton";
            this.uxNewRoundButton.Size = new System.Drawing.Size(308, 36);
            this.uxNewRoundButton.TabIndex = 0;
            this.uxNewRoundButton.Text = "New Round";
            this.uxNewRoundButton.UseVisualStyleBackColor = true;
            this.uxNewRoundButton.Click += new System.EventHandler(this.uxNewRoundButton_Click);
            // 
            // uxAddAnotherCardButton
            // 
            this.uxAddAnotherCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddAnotherCardButton.Location = new System.Drawing.Point(12, 361);
            this.uxAddAnotherCardButton.Name = "uxAddAnotherCardButton";
            this.uxAddAnotherCardButton.Size = new System.Drawing.Size(149, 36);
            this.uxAddAnotherCardButton.TabIndex = 1;
            this.uxAddAnotherCardButton.Text = "Hit";
            this.uxAddAnotherCardButton.UseVisualStyleBackColor = true;
            this.uxAddAnotherCardButton.Click += new System.EventHandler(this.uxAddAnotherCardButton_Click);
            // 
            // uxHoldCardsButton
            // 
            this.uxHoldCardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHoldCardsButton.Location = new System.Drawing.Point(167, 361);
            this.uxHoldCardsButton.Name = "uxHoldCardsButton";
            this.uxHoldCardsButton.Size = new System.Drawing.Size(153, 36);
            this.uxHoldCardsButton.TabIndex = 2;
            this.uxHoldCardsButton.Text = "Hold";
            this.uxHoldCardsButton.UseVisualStyleBackColor = true;
            this.uxHoldCardsButton.Click += new System.EventHandler(this.uxHoldCardsButton_Click);
            // 
            // uxStaticHandLabel
            // 
            this.uxStaticHandLabel.AutoSize = true;
            this.uxStaticHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticHandLabel.Location = new System.Drawing.Point(9, 9);
            this.uxStaticHandLabel.Name = "uxStaticHandLabel";
            this.uxStaticHandLabel.Size = new System.Drawing.Size(165, 20);
            this.uxStaticHandLabel.TabIndex = 3;
            this.uxStaticHandLabel.Text = "Your Current Hand:";
            // 
            // uxHandLabel
            // 
            this.uxHandLabel.AutoSize = true;
            this.uxHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHandLabel.Location = new System.Drawing.Point(9, 40);
            this.uxHandLabel.Name = "uxHandLabel";
            this.uxHandLabel.Size = new System.Drawing.Size(100, 20);
            this.uxHandLabel.TabIndex = 4;
            this.uxHandLabel.Text = "(Cards Here)";
            // 
            // uxStaticTopCardLabel
            // 
            this.uxStaticTopCardLabel.AutoSize = true;
            this.uxStaticTopCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticTopCardLabel.Location = new System.Drawing.Point(220, 40);
            this.uxStaticTopCardLabel.Name = "uxStaticTopCardLabel";
            this.uxStaticTopCardLabel.Size = new System.Drawing.Size(84, 20);
            this.uxStaticTopCardLabel.TabIndex = 5;
            this.uxStaticTopCardLabel.Text = "(Top Card)";
            // 
            // HumansHandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 409);
            this.Controls.Add(this.uxStaticTopCardLabel);
            this.Controls.Add(this.uxHandLabel);
            this.Controls.Add(this.uxStaticHandLabel);
            this.Controls.Add(this.uxHoldCardsButton);
            this.Controls.Add(this.uxAddAnotherCardButton);
            this.Controls.Add(this.uxNewRoundButton);
            this.Name = "HumansHandForm";
            this.Text = "Human\'s Hand";
            this.Load += new System.EventHandler(this.HumansHandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxNewRoundButton;
        private System.Windows.Forms.Button uxAddAnotherCardButton;
        private System.Windows.Forms.Button uxHoldCardsButton;
        private System.Windows.Forms.Label uxStaticHandLabel;
        private System.Windows.Forms.Label uxHandLabel;
        private System.Windows.Forms.Label uxStaticTopCardLabel;
    }
}

