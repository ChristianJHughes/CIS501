namespace UserInterface
{
    partial class DirectoryForm
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
            this.uxFolderStatusLabel = new System.Windows.Forms.Label();
            this.uxDirectoryBox = new System.Windows.Forms.ListBox();
            this.uxOpenButton = new System.Windows.Forms.Button();
            this.uxNewFileButton = new System.Windows.Forms.Button();
            this.uxNewFolderButton = new System.Windows.Forms.Button();
            this.uxDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxStaticTitleLabel
            // 
            this.uxStaticTitleLabel.AutoSize = true;
            this.uxStaticTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStaticTitleLabel.Location = new System.Drawing.Point(-3, 9);
            this.uxStaticTitleLabel.Name = "uxStaticTitleLabel";
            this.uxStaticTitleLabel.Size = new System.Drawing.Size(231, 35);
            this.uxStaticTitleLabel.TabIndex = 0;
            this.uxStaticTitleLabel.Text = "Directory Form";
            // 
            // uxFolderStatusLabel
            // 
            this.uxFolderStatusLabel.AutoSize = true;
            this.uxFolderStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFolderStatusLabel.Location = new System.Drawing.Point(0, 64);
            this.uxFolderStatusLabel.Name = "uxFolderStatusLabel";
            this.uxFolderStatusLabel.Size = new System.Drawing.Size(126, 24);
            this.uxFolderStatusLabel.TabIndex = 1;
            this.uxFolderStatusLabel.Text = "Folder: Root";
            // 
            // uxDirectoryBox
            // 
            this.uxDirectoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectoryBox.FormattingEnabled = true;
            this.uxDirectoryBox.ItemHeight = 18;
            this.uxDirectoryBox.Items.AddRange(new object[] {
            "Folder Contents..."});
            this.uxDirectoryBox.Location = new System.Drawing.Point(4, 91);
            this.uxDirectoryBox.Name = "uxDirectoryBox";
            this.uxDirectoryBox.Size = new System.Drawing.Size(222, 130);
            this.uxDirectoryBox.TabIndex = 2;
            // 
            // uxOpenButton
            // 
            this.uxOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenButton.Location = new System.Drawing.Point(4, 227);
            this.uxOpenButton.Name = "uxOpenButton";
            this.uxOpenButton.Size = new System.Drawing.Size(106, 41);
            this.uxOpenButton.TabIndex = 3;
            this.uxOpenButton.Text = "Open";
            this.uxOpenButton.UseVisualStyleBackColor = true;
            this.uxOpenButton.Click += new System.EventHandler(this.uxOpenButton_Click);
            // 
            // uxNewFileButton
            // 
            this.uxNewFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewFileButton.Location = new System.Drawing.Point(120, 227);
            this.uxNewFileButton.Name = "uxNewFileButton";
            this.uxNewFileButton.Size = new System.Drawing.Size(106, 41);
            this.uxNewFileButton.TabIndex = 4;
            this.uxNewFileButton.Text = "New File";
            this.uxNewFileButton.UseVisualStyleBackColor = true;
            this.uxNewFileButton.Click += new System.EventHandler(this.uxNewFileButton_Click);
            // 
            // uxNewFolderButton
            // 
            this.uxNewFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewFolderButton.Location = new System.Drawing.Point(119, 274);
            this.uxNewFolderButton.Name = "uxNewFolderButton";
            this.uxNewFolderButton.Size = new System.Drawing.Size(106, 41);
            this.uxNewFolderButton.TabIndex = 5;
            this.uxNewFolderButton.Text = "New Folder";
            this.uxNewFolderButton.UseVisualStyleBackColor = true;
            this.uxNewFolderButton.Click += new System.EventHandler(this.uxNewFolderButton_Click);
            // 
            // uxDeleteButton
            // 
            this.uxDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDeleteButton.Location = new System.Drawing.Point(4, 274);
            this.uxDeleteButton.Name = "uxDeleteButton";
            this.uxDeleteButton.Size = new System.Drawing.Size(106, 41);
            this.uxDeleteButton.TabIndex = 6;
            this.uxDeleteButton.Text = "Delete";
            this.uxDeleteButton.UseVisualStyleBackColor = true;
            this.uxDeleteButton.Click += new System.EventHandler(this.uxDeleteButton_Click);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 316);
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.uxNewFolderButton);
            this.Controls.Add(this.uxNewFileButton);
            this.Controls.Add(this.uxOpenButton);
            this.Controls.Add(this.uxDirectoryBox);
            this.Controls.Add(this.uxFolderStatusLabel);
            this.Controls.Add(this.uxStaticTitleLabel);
            this.Name = "DirectoryForm";
            this.Text = "Directory Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxStaticTitleLabel;
        private System.Windows.Forms.Label uxFolderStatusLabel;
        private System.Windows.Forms.ListBox uxDirectoryBox;
        private System.Windows.Forms.Button uxOpenButton;
        private System.Windows.Forms.Button uxNewFileButton;
        private System.Windows.Forms.Button uxNewFolderButton;
        private System.Windows.Forms.Button uxDeleteButton;
    }
}