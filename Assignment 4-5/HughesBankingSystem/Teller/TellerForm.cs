using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teller
{
    /// <summary>
    /// The class for the Teller form, which contains all of the UI elements and interactions with the user.
    /// </summary>
    public partial class TellerForm : Form
    {
        //A handle to the Teller Controller.
        TellerController controller;

        //Keeps track of the current state of the system.
        TellerStatus state = TellerStatus.Start;


        //Constructor that properly loads the Teller Form, and takes a handle to its controller.
        public TellerForm(TellerController controller)
        {
            InitializeComponent();
            this.controller = controller;
            updateForm();
        }
      
      /// <summary>
      /// This dictionary holds all of the status messages for all of the different states.
      /// </summary>
      private Dictionary<TellerStatus, string> message = new Dictionary<TellerStatus, string>()
	  {  
	      {TellerStatus.Start, "Hello and welcome to the Hughes Banking Teller System! Please make a selection."},
          {TellerStatus.ClosingAnAccount, "Please select the type of account that you would like to close."},
          {TellerStatus.AttemptClosingCustomerAccount, "Please enter a bank account number to close all current accounts, and withdraw all funds. The customer account will be closed."},
          {TellerStatus.ClosedCustomerAccount, "Customer account (as well as all associated bank accounts) closed sucsessfully. Please press the 'new session' button to restart the system."},
          {TellerStatus.AttemptClosingBankAccount, "Please enter a bank account number to close the account, and withdraw all funds."},
          {TellerStatus.ClosedBankAccount, "The bank account was sucsessfully closed. Please press the 'New Session' button to restart the system."},
          {TellerStatus.CreatingNewAccount, "Please select the type of account that you would like to create."},
          {TellerStatus.AttemptCreatingNewCustomerAccount, "Please enter the customer's name."},
          {TellerStatus.NeedValidAddress, "Please enter the customer's address."},
          {TellerStatus.CreatedNewCustomerAccount, "A new customer account has been created! The customer's Customer Number is: "},
          {TellerStatus.AttemptCreatingNewBankAccount, "Please supply a valid customer number to open a new bank account."},
          {TellerStatus.CreatedNewBankAccount, "A new bank account has been created. The customer's Bank Account Number is: "},
          {TellerStatus.WorkingWithAnExistingAccount, "Please select what action the customer would like to perform on their account."},
          {TellerStatus.Depositing, "Please enter the Bank Account Number of the account on which the customer would like to make a deposit."},
          {TellerStatus.NeedValidDepositAmount, "Please enter a deposit amount."},
          {TellerStatus.DepositSuccess, "Money successfully deposited! Please press the 'New Session' button to restart the system."},
          {TellerStatus.Withdrawing, "Please enter the bank account number of the account on which the customer would like to perform a withdrawal."},
          {TellerStatus.NeedValidWithdrawalAmount, "Please enter a valid withdrawal amount."},
          {TellerStatus.WithdrawalSuccess, "Money sucsessfully withdrawn! Press the 'New Session' button to restart the system."},
          {TellerStatus.BalanceInquiry, "Please enter the Bank Account Number of the account on which the customer would like to know their balance."},
          {TellerStatus.DisplayingBalanceInquiry, "The current balance in that account is: $"},
          {TellerStatus.InvalidInput, "Invalid Input. Either you have entered an invalid ammount, the account does not exist, or you have attempted to withdraw more money than possible. Press 'new session' to restart the system."},
          {TellerStatus.AccountAlreadyInUse, "This account is already in use on another machine. Please try again later. Press 'New Session' to restart the system."},
          {TellerStatus.AccountNotFound, "Account Not Found. Please press the 'New Session' button to restart the system."}
	  };
      
      /// <summary>
      /// Just makes certain buttons visible or invisible based on the current state of the machine.
      /// </summary>
      private void updateForm()
      {
          switch (state)
          {
              case TellerStatus.Start:
              {
                  uxCloseAccountButton.Enabled = true;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = true;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = true;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.ClosingAnAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = true;
                  uxCloseCustomerAccountButton.Enabled = true;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.AttemptClosingCustomerAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.ClosedCustomerAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.AttemptClosingBankAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.ClosedBankAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.CreatingNewAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = true;
                  uxNewCustomerAccountButton.Enabled = true;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.AttemptCreatingNewCustomerAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.NeedValidAddress:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.CreatedNewCustomerAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.AttemptCreatingNewBankAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.CreatedNewBankAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.WorkingWithAnExistingAccount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = true;
                  uxWithdrawButton.Enabled = true;
                  uxBalanceInquiryButton.Enabled = true;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.Depositing:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.NeedValidDepositAmount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.DepositSuccess:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.Withdrawing:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.NeedValidWithdrawalAmount:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.WithdrawalSuccess:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.BalanceInquiry:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = true;
                  uxNewSessionButton.Enabled = false;
                  uxInputTextbox.Enabled = true;
                  break;
              }
              case TellerStatus.DisplayingBalanceInquiry:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.InvalidInput:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.AccountAlreadyInUse:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              case TellerStatus.AccountNotFound:
              {
                  uxCloseAccountButton.Enabled = false;
                  uxCloseBankAccount.Enabled = false;
                  uxCloseCustomerAccountButton.Enabled = false;
                  uxModifyAccountButton.Enabled = false;
                  uxDepositButton.Enabled = false;
                  uxWithdrawButton.Enabled = false;
                  uxBalanceInquiryButton.Enabled = false;
                  uxCreateNewAccountButton.Enabled = false;
                  uxNewBankAccountButton.Enabled = false;
                  uxNewCustomerAccountButton.Enabled = false;
                  uxSubmitButton.Enabled = false;
                  uxNewSessionButton.Enabled = true;
                  uxInputTextbox.Enabled = false;
                  break;
              }
              default: { break; }
          }
          uxStatusLabel.Text = message[state];
          uxInputTextbox.Text = "";
      }

      /// <summary>
      /// Click event for the create new account button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxCreateNewAccountButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.CreatingNewAccount;
          updateForm();
          //vvv Probably not necessary vvv
          //controller.handle(uxInputTextbox.Text, state);
      }
      
      /// <summary>
      /// Click event for the new bank account button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxNewBankAccountButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.AttemptCreatingNewBankAccount;
          updateForm();
      }

      /// <summary>
      /// Click event for the new customer account button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxNewCustomerAccountButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.AttemptCreatingNewCustomerAccount;
          updateForm();
      }
      
      /// <summary>
      /// Click event for the modify account button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxModifyAccountButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.WorkingWithAnExistingAccount;
          updateForm();
      }

      /// <summary>
      /// Click event for the close account button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxCloseAccountButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.ClosingAnAccount;
          updateForm();
      }

      /// <summary>
      /// Click event for the deposit button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxDepositButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.Depositing;
          updateForm();
      }
      
       /// <summary>
       /// Click event for the withdraw button.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
      private void uxWithdrawButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.Withdrawing;
          updateForm();
      }

      /// <summary>
      /// Click event for the balance inquiry button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxBalanceInquiryButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.BalanceInquiry;
          updateForm();
      }

      /// <summary>
      /// Click event for the close bank account button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxCloseBankAccount_Click(object sender, EventArgs e)
      {
          state = TellerStatus.AttemptClosingBankAccount;
          updateForm();
      }

      /// <summary>
      /// Click event for the close customer button.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void uxCloseCustomerAccountButton_Click(object sender, EventArgs e)
      {
          state = TellerStatus.AttemptClosingCustomerAccount;
          updateForm();
      }

      private void uxNewSessionButton_Click(object sender, EventArgs e)
      {
          Tuple<TellerStatus, double> newTup = controller.handle(uxInputTextbox.Text, state);
          state = newTup.Item1;
          updateForm();
      }

      private void uxSubmitButton_Click(object sender, EventArgs e)
      {
          Tuple<TellerStatus, double> newTup = controller.handle(uxInputTextbox.Text, state);
          state = newTup.Item1;
          double returnNum = newTup.Item2;
          updateForm();

          if (state == TellerStatus.DisplayingBalanceInquiry)
          {
              uxStatusLabel.Text += returnNum.ToString("00.00") + ". Press the 'New Session' button to restart the system.";
              Refresh();
          }

          if (state == TellerStatus.WithdrawalSuccess)
          {
              uxStatusLabel.Text += "The updates balance is $" + returnNum.ToString("00.00") + ".";
              Refresh();
          }

          if (state == TellerStatus.CreatedNewBankAccount)
          {
              uxStatusLabel.Text += returnNum.ToString("000");
              Refresh();
          }

          if (state == TellerStatus.CreatedNewCustomerAccount)
          {
              uxStatusLabel.Text += returnNum.ToString("000");
              Refresh();
          }

      }

      

    }
}
