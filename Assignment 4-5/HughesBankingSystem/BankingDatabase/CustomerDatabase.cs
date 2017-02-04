using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDatabase
{
    /// <summary>
    /// An interface for the Database containg all of the customers. This way, the bank
    /// can replace the Database without have to recode the entire system.
    /// </summary>
    public interface CustomerDatabase
    {
        /// <summary>
        /// Returns the customer with the given customer number.
        /// </summary>
        /// <param name="customerNumber">The number of the customer we wish to look up.</param>
        /// <returns>The customer with the associated customer number.</returns>
        Customer lookUpCustomer(int customerNumber);

        /// <summary>
        /// Adds a new customer to the Database.
        /// </summary>
        /// <param name="customerName">The name of the customer we wish to add.</param>
        /// <param name="customerAddress">The address of the customer that we wish to add.</param>
        int addNewCustomer(string customerName, string customerAddress);

        /// <summary>
        /// Returns a unique/new customer number.
        /// </summary>
        /// <returns>A unique customer number.</returns>
        int returnNewCustomerNumber();

        /// <summary>
        /// Adds a given account to a customers portfolio.
        /// </summary>
        /// <param name="customerNumberParam">The customer number of the customer that we wish to give the account to.</param>
        /// <param name="accountNumber">The account number of the account that we wish to give to the customer.</param>
        void addAccountToCustomer(int customerNumberParam, int accountNumber);

        /// <summary>
        /// Removes the customer from the database of customers. 
        /// </summary>
        /// <param name="customerNumber"></param>
        void removeCustomer(int customerNumber);
    }
}
