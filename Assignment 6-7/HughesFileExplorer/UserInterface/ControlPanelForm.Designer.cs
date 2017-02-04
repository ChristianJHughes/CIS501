namespace UserInterface
{
    partial class ControlPanelForm
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
            this.uxStaticTitleLabel = new System.Windows.Forms.Label();
            this.uxOpenButton = new System.Windows.Forms.Button();
            this.uxCloseAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxStaticTitleLabel
            // 
            this.uxStaticTitleLabel.AutoSize = true;
            this.uxStaticTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticTitleLabel.Location = new System.Drawing.Point(67, 0);
            this.uxStaticTitleLabel.Name = "uxStaticTitleLabel";
            this.uxStaticTitleLabel.Size = new System.Drawing.Size(191, 31);
            this.uxStaticTitleLabel.TabIndex = 0;
            this.uxStaticTitleLabel.Text = "Control Panel";
            // 
            // uxOpenButton
            // 
            this.uxOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenButton.Location = new System.Drawing.Point(12, 43);
            this.uxOpenButton.Name = "uxOpenButton";
            this.uxOpenButton.Size = new System.Drawing.Size(142, 59);
            this.uxOpenButton.TabIndex = 1;
            this.uxOpenButton.Text = "Open";
            this.uxOpenButton.UseVisualStyleBackColor = true;
            this.uxOpenButton.Click += new System.EventHandler(this.uxOpenButton_Click);
            // 
            // uxCloseAllButton
            // 
            this.uxCloseAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCloseAllButton.Location = new System.Drawing.Point(171, 43);
            this.uxCloseAllButton.Name = "uxCloseAllButton";
            this.uxCloseAllButton.Size = new System.Drawing.Size(142, 59);
            this.uxCloseAllButton.TabIndex = 2;
            this.uxCloseAllButton.Text = "Close All";
            this.uxCloseAllButton.UseVisualStyleBackColor = true;
            this.uxCloseAllButton.Click += new System.EventHandler(this.uxCloseAllButton_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 114);
            this.Controls.Add(this.uxCloseAllButton);
            this.Controls.Add(this.uxOpenButton);
            this.Controls.Add(this.uxStaticTitleLabel);
            this.Name = "ControlPanelForm";
            this.Text = "Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxStaticTitleLabel;
        private System.Windows.Forms.Button uxOpenButton;
        private System.Windows.Forms.Button uxCloseAllButton;
    }
}

