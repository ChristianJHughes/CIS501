using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDatabase
{
    /// <summary>
    /// A class with all of the necessary constructs for creating an account, as well as that accounts associated values.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The number of the account being worked with.
        /// </summary>
        private int accountNumber;

        /// <summary>
        /// The number of the customer that owns this specific account.
        /// </summary>
        private int customerNumber;

        /// <summary>
        /// The current balance of the account.
        /// </summary>
        private double accountBalance;

        //An enumeration to determine the use status of the account.
        private enum status
        {
            Available,
            InUse
        }

        //The account begins in an available state.
        private status currentState = status.Available;

        /// <summary>
        /// Constructor for creating new accounts. Generally called by the AccountDB.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <param name="customerNumber">The customer number.</param>
        /// <param name="accountBalance">The account balance.</param>
        public Account(int accountNumber, int customerNumber, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.customerNumber = customerNumber;
            this.accountBalance = accountBalance;
        }

        /// <summary>
        /// Simply returns the account balance.
        /// </summary>
        /// <returns>The account balance.</returns>
        public double returnBalance()
        {
            return accountBalance;
        }

        /// <summary>
        /// Updates the account balance given a deposit.
        /// </summary>
        /// <param name="ammountToDeposit">The amount to be deposited.</param>
        public double deposit(double ammountToDeposit)
        {
            return accountBalance += ammountToDeposit;
        }

        /// <summary>
        /// Updates the balance of the account should the user make a withdrawal.
        /// </summary>
        /// <param name="withdrawalAmmount">The ammount that the user wishes to withdraw.</param>
        /// <returns>True if the ammount can be withdrawn, false otherwise.</returns>
        public bool amountToWithdraw(double withdrawalAmmount)
        {
            if (withdrawalAmmount <= accountBalance)
            {
                accountBalance -= withdrawalAmmount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Simply returns the customer number of the current account.
        /// </summary>
        /// <returns>The customer number associated with the current account.</returns>
        public int returnCustomerNumber()
        {
            return customerNumber;
        }

        /// <summary>
        /// Returns true if the user was able to sucsesfully log in.
        /// </summary>
        /// <returns></returns>
        public bool logIn()
        {
            if (currentState == status.Available)
            {
                currentState = status.InUse;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Changes the status to available when the user logs out.
        /// </summary>
        public void logOut()
        {
            currentState = status.Available;
        }


    }
}
