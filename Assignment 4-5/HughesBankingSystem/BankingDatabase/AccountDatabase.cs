using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDatabase
{
    /// <summary>
    /// An interface for the Database containg all of the accounts. This way, the bank
    /// can replace the Database without have to recode the entire system.
    /// </summary>
    public interface AccountDatabase
    {
       /// <summary>
        /// Returns the customer number on a given account.
        /// </summary>
        /// <param name="accountNumber">The account number to look up.</param>
        /// <returns>The customer number of the account.</returns>
        int lookUpAccountReturnCustomerNumber(int accountNumber);

        /// <summary>
        /// Makes a deposit into the associated
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="depositAmmount"></param>
        /// <returns></returns>
        void depositIntoAccount(int accountNumber, double depositAmmount);

        /// <summary>
        /// Updates the account balance given with withdrawal ammount, and returns whether it was done sucssesfully.
        /// </summary>
        /// <param name="accountNumber">The account number to be withdrawn from</param>
        /// <param name="withdrawAmmount">The amount to withdraw.</param>
        /// <returns>True if withdrawn sucsesfully, false otherwise.</returns>
        bool withdrawFromAccount(int accountNumber, double withdrawAmmount);

        /// <summary>
        /// Returns the balance of the given account.
        /// </summary>
        /// <param name="accountNumber">The account number to get the balance of.</param>
        /// <returns>The balance of the account.</returns>
        double returnAccountBalance(int accountNumber);

        /// <summary>
        /// Adds a new account to the database with a unique account number. Starts with 100.
        /// </summary>
        /// <param name="customerNumber">The customer number to be associated with the account.</param>
        /// <param name="accountBalance">The starting balance of the account.</param>
        int addNewAccount(int customerNumber, double accountBalance);

        //public void removeAccount(int accountNumber)

        /// <summary>
        /// Simply returns a new, unique account number.
        /// </summary>
        /// <returns>A new, unique account number.</returns>
        int returnNewAccountNumber();

        /// <summary>
        /// Determines whether the given account exists or not.
        /// </summary>
        /// <param name="accountNumber">Tha ccount number to look up.</param>
        /// <returns>True if the account exists, false otherise.</returns>
        bool doesAccountExist(int accountNumber);

        /// <summary>
        /// Checks to see if the account is open, and logs in if so.
        /// </summary>
        /// <param name="accountNumber">The number of the account we wish to log into.</param>
        /// <returns></returns>
        bool logInAccount(int accountNumber);

        /// <summary>
        /// Logs out the user, and makes the account available.
        /// </summary>
        /// <param name="accountNumber">The number of the account that we wish to log out of.</param>
        void logOutAccount(int accountNumber);

        /// <summary>
        /// Removes the customer account from the face of the earth.
        /// </summary>
        /// <param name="accountNumber">The account number of the account to be removed.</param>
        void removeAccount(int accountNumber);
    }
}
