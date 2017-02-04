namespace Teller
{
    partial class TellerForm
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
            this.uxCreateNewAccountButton = new System.Windows.Forms.Button();
            this.uxNewCustomerAccountButton = new System.Windows.Forms.Button();
            this.uxNewBankAccountButton = new System.Windows.Forms.Button();
            this.uxDepositButton = new System.Windows.Forms.Button();
            this.uxWithdrawButton = new System.Windows.Forms.Button();
            this.uxModifyAccountButton = new System.Windows.Forms.Button();
            this.uxCloseBankAccount = new System.Windows.Forms.Button();
            this.uxCloseCustomerAccountButton = new System.Windows.Forms.Button();
            this.uxCloseAccountButton = new System.Windows.Forms.Button();
            this.uxBalanceInquiryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxNewSessionButton = new System.Windows.Forms.Button();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.uxStatusLabel = new System.Windows.Forms.Label();
            this.uxInputTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxCreateNewAccountButton
            // 
            this.uxCreateNewAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateNewAccountButton.Location = new System.Drawing.Point(33, 165);
            this.uxCreateNewAccountButton.Name = "uxCreateNewAccountButton";
            this.uxCreateNewAccountButton.Size = new System.Drawing.Size(137, 50);
            this.uxCreateNewAccountButton.TabIndex = 0;
            this.uxCreateNewAccountButton.Text = "Create New Account";
            this.uxCreateNewAccountButton.UseVisualStyleBackColor = true;
            this.uxCreateNewAccountButton.Click += new System.EventHandler(this.uxCreateNewAccountButton_Click);
            // 
            // uxNewCustomerAccountButton
            // 
            this.uxNewCustomerAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewCustomerAccountButton.Location = new System.Drawing.Point(33, 279);
            this.uxNewCustomerAccountButton.Name = "uxNewCustomerAccountButton";
            this.uxNewCustomerAccountButton.Size = new System.Drawing.Size(137, 50);
            this.uxNewCustomerAccountButton.TabIndex = 1;
            this.uxNewCustomerAccountButton.Text = "New Customer Account";
            this.uxNewCustomerAccountButton.UseVisualStyleBackColor = true;
            this.uxNewCustomerAccountButton.Click += new System.EventHandler(this.uxNewCustomerAccountButton_Click);
            // 
            // uxNewBankAccountButton
            // 
            this.uxNewBankAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewBankAccountButton.Location = new System.Drawing.Point(33, 221);
            this.uxNewBankAccountButton.Name = "uxNewBankAccountButton";
            this.uxNewBankAccountButton.Size = new System.Drawing.Size(137, 50);
            this.uxNewBankAccountButton.TabIndex = 2;
            this.uxNewBankAccountButton.Text = "New Bank Account";
            this.uxNewBankAccountButton.UseVisualStyleBackColor = true;
            this.uxNewBankAccountButton.Click += new System.EventHandler(this.uxNewBankAccountButton_Click);
            // 
            // uxDepositButton
            // 
            this.uxDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDepositButton.Location = new System.Drawing.Point(176, 221);
            this.uxDepositButton.Name = "uxDepositButton";
            this.uxDepositButton.Size = new System.Drawing.Size(137, 50);
            this.uxDepositButton.TabIndex = 5;
            this.uxDepositButton.Text = "Deposit";
            this.uxDepositButton.UseVisualStyleBackColor = true;
            this.uxDepositButton.Click += new System.EventHandler(this.uxDepositButton_Click);
            // 
            // uxWithdrawButton
            // 
            this.uxWithdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWithdrawButton.Location = new System.Drawing.Point(176, 279);
            this.uxWithdrawButton.Name = "uxWithdrawButton";
            this.uxWithdrawButton.Size = new System.Drawing.Size(137, 50);
            this.uxWithdrawButton.TabIndex = 4;
            this.uxWithdrawButton.Text = "Withdraw";
            this.uxWithdrawButton.UseVisualStyleBackColor = true;
            this.uxWithdrawButton.Click += new System.EventHandler(this.uxWithdrawButton_Click);
            // 
            // uxModifyAccountButton
            // 
            this.uxModifyAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxModifyAccountButton.Location = new System.Drawing.Point(176, 165);
            this.uxModifyAccountButton.Name = "uxModifyAccountButton";
            this.uxModifyAccountButton.Size = new System.Drawing.Size(137, 50);
            this.uxModifyAccountButton.TabIndex = 3;
            this.uxModifyAccountButton.Text = "Modify Existing Account";
            this.uxModifyAccountButton.UseVisualStyleBackColor = true;
            this.uxModifyAccountButton.Click += new System.EventHandler(this.uxModifyAccountButton_Click);
            // 
            // uxCloseBankAccount
            // 
            this.uxCloseBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCloseBankAccount.Location = new System.Drawing.Point(319, 221);
            this.uxCloseBankAccount.Name = "uxCloseBankAccount";
            this.uxCloseBankAccount.Size = new System.Drawing.Size(137, 50);
            this.uxCloseBankAccount.TabIndex = 8;
            this.uxCloseBankAccount.Text = "Close Bank Account";
            this.uxCloseBankAccount.UseVisualStyleBackColor = true;
            this.uxCloseBankAccount.Click += new System.EventHandler(this.uxCloseBankAccount_Click);
            // 
            // uxCloseCustomerAccountButton
            // 
            this.uxCloseCustomerAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCloseCustomerAccountButton.Location = new System.Drawing.Point(319, 279);
            this.uxCloseCustomerAccountButton.Name = "uxCloseCustomerAccountButton";
            this.uxCloseCustomerAccountButton.Size = new System.Drawing.Size(137, 50);
            this.uxCloseCustomerAccountButton.TabIndex = 7;
            this.uxCloseCustomerAccountButton.Text = "Close Customer Account";
            this.uxCloseCustomerAccountButton.UseVisualStyleBackColor = true;
            this.uxCloseCustomerAccountButton.Click += new System.EventHandler(this.uxCloseCustomerAccountButton_Click);
            // 
            // uxCloseAccountButton
            // 
            this.uxCloseAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCloseAccountButton.Location = new System.Drawing.Point(319, 165);
            this.uxCloseAccountButton.Name = "uxCloseAccountButton";
            this.uxCloseAccountButton.Size = new System.Drawing.Size(137, 50);
            this.uxCloseAccountButton.TabIndex = 6;
            this.uxCloseAccountButton.Text = "Close An Account";
            this.uxCloseAccountButton.UseVisualStyleBackColor = true;
            this.uxCloseAccountButton.Click += new System.EventHandler(this.uxCloseAccountButton_Click);
            // 
            // uxBalanceInquiryButton
            // 
            this.uxBalanceInquiryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBalanceInquiryButton.Location = new System.Drawing.Point(176, 335);
            this.uxBalanceInquiryButton.Name = "uxBalanceInquiryButton";
            this.uxBalanceInquiryButton.Size = new System.Drawing.Size(137, 50);
            this.uxBalanceInquiryButton.TabIndex = 9;
            this.uxBalanceInquiryButton.Text = "Balance Inquiry";
            this.uxBalanceInquiryButton.UseVisualStyleBackColor = true;
            this.uxBalanceInquiryButton.Click += new System.EventHandler(this.uxBalanceInquiryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hughes Bank Teller Application";
            // 
            // uxNewSessionButton
            // 
            this.uxNewSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewSessionButton.Location = new System.Drawing.Point(33, 335);
            this.uxNewSessionButton.Name = "uxNewSessionButton";
            this.uxNewSessionButton.Size = new System.Drawing.Size(96, 50);
            this.uxNewSessionButton.TabIndex = 11;
            this.uxNewSessionButton.Text = "New Sesison";
            this.uxNewSessionButton.UseVisualStyleBackColor = true;
            this.uxNewSessionButton.Click += new System.EventHandler(this.uxNewSessionButton_Click);
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmitButton.Location = new System.Drawing.Point(363, 335);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(93, 50);
            this.uxSubmitButton.TabIndex = 12;
            this.uxSubmitButton.Text = "Submit";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            this.uxSubmitButton.Click += new System.EventHandler(this.uxSubmitButton_Click);
            // 
            // uxStatusLabel
            // 
            this.uxStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStatusLabel.Location = new System.Drawing.Point(33, 45);
            this.uxStatusLabel.Name = "uxStatusLabel";
            this.uxStatusLabel.Size = new System.Drawing.Size(423, 91);
            this.uxStatusLabel.TabIndex = 13;
            this.uxStatusLabel.Text = "The current status will go here.";
            // 
            // uxInputTextbox
            // 
            this.uxInputTextbox.Location = new System.Drawing.Point(33, 139);
            this.uxInputTextbox.Name = "uxInputTextbox";
            this.uxInputTextbox.Size = new System.Drawing.Size(423, 20);
            this.uxInputTextbox.TabIndex = 14;
            // 
            // TellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 389);
            this.Controls.Add(this.uxInputTextbox);
            this.Controls.Add(this.uxStatusLabel);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.uxNewSessionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxBalanceInquiryButton);
            this.Controls.Add(this.uxCloseBankAccount);
            this.Controls.Add(this.uxCloseCustomerAccountButton);
            this.Controls.Add(this.uxCloseAccountButton);
            this.Controls.Add(this.uxDepositButton);
            this.Controls.Add(this.uxWithdrawButton);
            this.Controls.Add(this.uxModifyAccountButton);
            this.Controls.Add(this.uxNewBankAccountButton);
            this.Controls.Add(this.uxNewCustomerAccountButton);
            this.Controls.Add(this.uxCreateNewAccountButton);
            this.Name = "TellerForm";
            this.Text = "Teller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCreateNewAccountButton;
        private System.Windows.Forms.Button uxNewCustomerAccountButton;
        private System.Windows.Forms.Button uxNewBankAccountButton;
        private System.Windows.Forms.Button uxDepositButton;
        private System.Windows.Forms.Button uxWithdrawButton;
        private System.Windows.Forms.Button uxModifyAccountButton;
        private System.Windows.Forms.Button uxCloseBankAccount;
        private System.Windows.Forms.Button uxCloseCustomerAccountButton;
        private System.Windows.Forms.Button uxCloseAccountButton;
        private System.Windows.Forms.Button uxBalanceInquiryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxNewSessionButton;
        private System.Windows.Forms.Button uxSubmitButton;
        private System.Windows.Forms.Label uxStatusLabel;
        private System.Windows.Forms.TextBox uxInputTextbox;
    }
}

