using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDatabase
{
    /// <summary>
    /// The database containg all of the accounts at the bank.
    /// </summary>
    public class AccountDB : AccountDatabase
    {
        /// <summary>
        /// The hash table containing all of the accounts. This is the "data" part of the database.
        /// Indexed via accountNumbers.
        /// </summary>
        private Dictionary<int, Account> accounts = new Dictionary<int,Account>();

        /// <summary>
        /// Keeps track of the latest account number in order to create unique account numbers as accounts are generated.
        /// </summary>
        private int latestAccountNumber = 99;

        /// <summary>
        /// Returns the customer number on a given account.
        /// </summary>
        /// <param name="accountNumber">The account number to look up.</param>
        /// <returns>The customer number of the account.</returns>
        public int lookUpAccountReturnCustomerNumber(int accountNumber)
        {
            return accounts[accountNumber].returnCustomerNumber(); 
        }

        /// <summary>
        /// Makes a deposit into the associated
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="depositAmmount"></param>
        /// <returns></returns>
        public void depositIntoAccount(int accountNumber, double depositAmmount)
        {
            accounts[accountNumber].deposit(depositAmmount);
        }

        /// <summary>
        /// Updates the account balance given with withdrawal ammount, and returns whether it was done sucssesfully.
        /// </summary>
        /// <param name="accountNumber">The account number to be withdrawn from</param>
        /// <param name="withdrawAmmount">The amount to withdraw.</param>
        /// <returns>True if withdrawn sucsesfully, false otherwise.</returns>
        public bool withdrawFromAccount(int accountNumber, double withdrawAmmount)
        {
            return accounts[accountNumber].amountToWithdraw(withdrawAmmount);
        }

        /// <summary>
        /// Returns the balance of the given account.
        /// </summary>
        /// <param name="accountNumber">The account number to get the balance of.</param>
        /// <returns>The balance of the account.</returns>
        public double returnAccountBalance(int accountNumber)
        {
            return accounts[accountNumber].returnBalance();
        }

        /// <summary>
        /// Adds a new account to the database with a unique account number. Starts with 100.
        /// </summary>
        /// <param name="customerNumber">The customer number to be associated with the account.</param>
        /// <param name="accountBalance">The starting balance of the account.</param>
        public int addNewAccount(int customerNumber, double accountBalance)
        {
            int acctNum = returnNewAccountNumber();
            accounts.Add(acctNum, new Account(acctNum, customerNumber, accountBalance));
            return acctNum;
        }

        //public void removeAccount(int accountNumber)

        /// <summary>
        /// Simply returns a new, unique account number.
        /// </summary>
        /// <returns>A new, unique account number.</returns>
        public int returnNewAccountNumber()
        {
            latestAccountNumber++;
            return latestAccountNumber;
        }

        /// <summary>
        /// Determines whether the given account exists or not.
        /// </summary>
        /// <param name="accountNumber">Tha ccount number to look up.</param>
        /// <returns>True if the account exists, false otherise.</returns>
        public bool doesAccountExist(int accountNumber)
        {
            lock (this)
            {
                if (accounts.ContainsKey(accountNumber))
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Checks to see if the account is open, and logs in if so.
        /// </summary>
        /// <param name="accountNumber">The number of the account we wish to log into.</param>
        /// <returns></returns>
        public bool logInAccount(int accountNumber)
        {
            lock (this)
            {
                if (accounts[accountNumber].logIn() == true)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Logs out the user, and makes the account available.
        /// </summary>
        /// <param name="accountNumber">The number of the account that we wish to log out of.</param>
        public void logOutAccount(int accountNumber)
        {
            lock (this)
            {
                accounts[accountNumber].logOut();
            }
        }

        /// <summary>
        /// Removes the customer account from the face of the earth.
        /// </summary>
        /// <param name="accountNumber">The account number of the account to be removed.</param>
        public void removeAccount(int accountNumber)
        {
            accounts.Remove(accountNumber);
        }
    }
}
