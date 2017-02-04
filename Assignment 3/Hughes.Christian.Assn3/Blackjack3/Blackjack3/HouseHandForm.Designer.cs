namespace Blackjack3
{
    partial class HouseHandForm
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
            this.uxStaticHousePlayersHand = new System.Windows.Forms.Label();
            this.uxHousePlayersHandLabel = new System.Windows.Forms.Label();
            this.uxStaticTopCardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxStaticHousePlayersHand
            // 
            this.uxStaticHousePlayersHand.AutoSize = true;
            this.uxStaticHousePlayersHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticHousePlayersHand.Location = new System.Drawing.Point(12, 9);
            this.uxStaticHousePlayersHand.Name = "uxStaticHousePlayersHand";
            this.uxStaticHousePlayersHand.Size = new System.Drawing.Size(181, 20);
            this.uxStaticHousePlayersHand.TabIndex = 4;
            this.uxStaticHousePlayersHand.Text = "House Player\'s Hand:";
            // 
            // uxHousePlayersHandLabel
            // 
            this.uxHousePlayersHandLabel.AutoSize = true;
            this.uxHousePlayersHandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHousePlayersHandLabel.Location = new System.Drawing.Point(12, 41);
            this.uxHousePlayersHandLabel.Name = "uxHousePlayersHandLabel";
            this.uxHousePlayersHandLabel.Size = new System.Drawing.Size(119, 20);
            this.uxHousePlayersHandLabel.TabIndex = 6;
            this.uxHousePlayersHandLabel.Text = "(Cards go here)";
            // 
            // uxStaticTopCardLabel
            // 
            this.uxStaticTopCardLabel.AutoSize = true;
            this.uxStaticTopCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticTopCardLabel.Location = new System.Drawing.Point(216, 41);
            this.uxStaticTopCardLabel.Name = "uxStaticTopCardLabel";
            this.uxStaticTopCardLabel.Size = new System.Drawing.Size(84, 20);
            this.uxStaticTopCardLabel.TabIndex = 7;
            this.uxStaticTopCardLabel.Text = "(Top Card)";
            // 
            // HouseHandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 264);
            this.Controls.Add(this.uxStaticTopCardLabel);
            this.Controls.Add(this.uxHousePlayersHandLabel);
            this.Controls.Add(this.uxStaticHousePlayersHand);
            this.Name = "HouseHandForm";
            this.Text = "House\'s Hand";
            this.Load += new System.EventHandler(this.HouseHandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxStaticHousePlayersHand;
        private System.Windows.Forms.Label uxHousePlayersHandLabel;
        private System.Windows.Forms.Label uxStaticTopCardLabel;
    }
}