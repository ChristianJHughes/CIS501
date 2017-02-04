using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingDatabase;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Defines the ATM form, which will provide user input and output for the ATM.
    /// </summary>
    public partial class ATMForm : Form
    {
        //Keeps track of the state that the ATM is in.
        AtmStatus state = AtmStatus.Start;

        //A handle to the controller, which will do all of the calculations and state switching.
        AtmPresenter controller;

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public ATMForm(AtmPresenter controller)
        {
            InitializeComponent();
            uxDisplayMenuLabel.Text = message[state];
            this.controller = controller;
        }

        /// <summary>
        /// The click event for the 1 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux1button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "1";
            Refresh();
        }

        /// <summary>
        /// The click event for the 2 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux2button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "2";
            Refresh();
        }

        /// <summary>
        /// The click event for the 3 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux3button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "3";
            Refresh();
        }

        /// <summary>
        /// The click event for the 4 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux4button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "4";
            Refresh();
        }

        /// <summary>
        /// The click event for the 5 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux5button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "5";
            Refresh();
        }

        /// <summary>
        /// The click event for the 6 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux6button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "6";
            Refresh();
        }

        /// <summary>
        /// The click event for the 7 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux7button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "7";
            Refresh();
        }

        /// <summary>
        /// The click event for the 8 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux8button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "8";
            Refresh();
        }

        /// <summary>
        /// The click event for the 9 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux9button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "9";
            Refresh();
        }

        /// <summary>
        /// The click event for the 0 button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ux0button_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += "0";
            Refresh();
        }

        /// <summary>
        /// Click event for a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDecimalButton_Click(object sender, EventArgs e)
        {
            uxCustomerInputTextbox.Text += ".";
            Refresh();
        }

        /// <summary>
        /// The click event for the OK Button. Does most of the work interfacing with the controller.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOKButton_Click(object sender, EventArgs e)
        {
            Tuple<AtmStatus, double> s = controller.handle(uxCustomerInputTextbox.Text);
            uxCustomerInputTextbox.Text = "";
            state = s.Item1;
            double balance = s.Item2;
            uxDisplayMenuLabel.Text = message[state];

            if (state == AtmStatus.ChooseBalanceInquiry)
            {
                uxDisplayMenuLabel.Text += balance.ToString("00.00") + ". Please press 'OK' to log out.";
            }

            if (state == AtmStatus.CompletedWithdrawal)
            {
                uxDisplayMenuLabel.Text += balance.ToString("00.00") + ". Please press 'OK' to log out.";
            }
        }

      //A dictionary of messages to display on the output form.
      private Dictionary<AtmStatus, string> message = new Dictionary<AtmStatus, string>()
	  {  
	      {AtmStatus.Start, "Hello and welcome to the Hughes Banking ATM! Please enter your bank account number."},
          {AtmStatus.AccountNotFound, "Account Not Found. Please press the 'OK' button to restart the system."},
	      {AtmStatus.LoggedIn, "Log in complete. Press (1) for a balance inquiry. Press (2) to make a withdrawal."},
          {AtmStatus.ChooseBalanceInquiry, "Your balance is: $"},
	      {AtmStatus.ChoseWithdrawalNeedAmount, "Please enter the amount that you would like to withdraw:"},
          {AtmStatus.CompletedWithdrawal, "Withdrawal Complete. The updated balance is: $"},
          {AtmStatus.InvalidInput, "Invalid Input. Either you have entered an invalid command, or you have attempted to withdraw more money than possible. Press 'ok' to log out."},
          {AtmStatus.AccountAlreadyInUse, "The account is logged into on another machine, as is currently unavailable. Please try again later. Press 'ok' to log out."}
	  };
    }
}
