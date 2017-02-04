using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDatabase
{
    //Class for creating the necessary constructs of a customer. Each customer has a number of attributes, such as a customer number, listed in this class. 
    public class Customer
    {
        /// <summary>
        /// The customers name
        /// </summary>
        private string customerName;

        /// <summary>
        /// The customers address.
        /// </summary>
        private string customerAddress;
        
        /// <summary>
        /// The customers assigned Customer number.
        /// </summary>
        private int customerNumber;

        /// <summary>
        /// A list keeping track of all of the accounts owned by the customer.
        /// </summary>
        private List<int> customerAccounts = new List<int>();

        /// <summary>
        /// Constructor, to be called by the CustomerDB for creating new customers.
        /// </summary>
        /// <param name="customerName">Customer name.</param>
        /// <param name="customerAddress">Customer Address.</param>
        /// <param name="customerNumber">Customer Address.</param>
        public Customer(string customerName, string customerAddress, int customerNumber)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerNumber = customerNumber;
        }

        /// <summary>
        /// Adds a bank account to the accounts owned by the customer.
        /// </summary>
        /// <param name="accountNumber">The account number to be assocated with the Customer.</param>
        public void addBankAccount(int accountNumber)
        {
            customerAccounts.Add(accountNumber);
        }

        /// <summary>
        /// Prints out the customers information.
        /// </summary>
        /// <returns>A string with the customers information.</returns>
        public string toString()
        {
            string accountsOwned = "";
            if (customerAccounts.Count != 0)
            {
                foreach (int i in customerAccounts)
                {
                    accountsOwned += i + " ";
                }
            }
            else
            {
                accountsOwned = "N/A";
            }
            return "Name: " + customerName + "\nCustomer Address: " + customerAddress + "\nCustomer Number: " + customerNumber + "\nAccount Numbers Owned: " + accountsOwned;
        }

        public List<int> returnAccountsOwned()
        {
            return customerAccounts;
        }
    }
}
