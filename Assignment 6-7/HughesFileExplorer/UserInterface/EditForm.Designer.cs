namespace UserInterface
{
    partial class EditForm
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
            this.uxFileNameLabel = new System.Windows.Forms.Label();
            this.uxFileContentsTextBox = new System.Windows.Forms.TextBox();
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxStaticTitleLabel
            // 
            this.uxStaticTitleLabel.AutoSize = true;
            this.uxStaticTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticTitleLabel.Location = new System.Drawing.Point(35, 9);
            this.uxStaticTitleLabel.Name = "uxStaticTitleLabel";
            this.uxStaticTitleLabel.Size = new System.Drawing.Size(157, 35);
            this.uxStaticTitleLabel.TabIndex = 1;
            this.uxStaticTitleLabel.Text = "Edit Form";
            // 
            // uxFileNameLabel
            // 
            this.uxFileNameLabel.AutoSize = true;
            this.uxFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFileNameLabel.Location = new System.Drawing.Point(3, 58);
            this.uxFileNameLabel.Name = "uxFileNameLabel";
            this.uxFileNameLabel.Size = new System.Drawing.Size(134, 29);
            this.uxFileNameLabel.TabIndex = 2;
            this.uxFileNameLabel.Text = "random.txt";
            // 
            // uxFileContentsTextBox
            // 
            this.uxFileContentsTextBox.Location = new System.Drawing.Point(8, 90);
            this.uxFileContentsTextBox.Multiline = true;
            this.uxFileContentsTextBox.Name = "uxFileContentsTextBox";
            this.uxFileContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxFileContentsTextBox.Size = new System.Drawing.Size(215, 133);
            this.uxFileContentsTextBox.TabIndex = 3;
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(8, 229);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(106, 41);
            this.uxSaveButton.TabIndex = 4;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // uxExitButton
            // 
            this.uxExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExitButton.Location = new System.Drawing.Point(117, 229);
            this.uxExitButton.Name = "uxExitButton";
            this.uxExitButton.Size = new System.Drawing.Size(106, 41);
            this.uxExitButton.TabIndex = 5;
            this.uxExitButton.Text = "Exit";
            this.uxExitButton.UseVisualStyleBackColor = true;
            this.uxExitButton.Click += new System.EventHandler(this.uxExitButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 275);
            this.Controls.Add(this.uxExitButton);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxFileContentsTextBox);
            this.Controls.Add(this.uxFileNameLabel);
            this.Controls.Add(this.uxStaticTitleLabel);
            this.Name = "EditForm";
            this.Text = "Edit Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxStaticTitleLabel;
        private System.Windows.Forms.Label uxFileNameLabel;
        private System.Windows.Forms.TextBox uxFileContentsTextBox;
        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Button uxExitButton;

    }
}