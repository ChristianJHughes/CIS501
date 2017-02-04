using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDatabase
{
    /// <summary>
    /// A class that contains a database of customers. There are various methods to interact with these customers.
    /// </summary>
    public class CustomerDB : CustomerDatabase
    {
        /// <summary>
        /// A hash table containing all of the customers, searchable by the associated customer number.
        /// </summary>
        private Dictionary<int, Customer> customers = new Dictionary<int,Customer>();

        /// <summary>
        /// The latest customer number created by the database. Ensures that we are able to consistantly create new customer numbers.
        /// </summary>
        private int latestCustomerNumber = 0;

        /// <summary>
        /// Returns the customer with the given customer number.
        /// </summary>
        /// <param name="customerNumber">The number of the customer we wish to look up.</param>
        /// <returns>The customer with the associated customer number.</returns>
        public Customer lookUpCustomer(int customerNumber)
        {
            if (customers.ContainsKey(customerNumber))
            {
                return customers[customerNumber];
            }
            return null;
        }

        /// <summary>
        /// Adds a new customer to the Database.
        /// </summary>
        /// <param name="customerName">The name of the customer we wish to add.</param>
        /// <param name="customerAddress">The address of the customer that we wish to add.</param>
        public int addNewCustomer(string customerName, string customerAddress)
        {
            int custNum = returnNewCustomerNumber();
            Customer newOne = new Customer(customerName, customerAddress, custNum);
            customers.Add(custNum, newOne);
            return custNum;
        }

        /// <summary>
        /// Removes the customer from the database of customers. 
        /// </summary>
        /// <param name="customerNumber"></param>
        public void removeCustomer(int customerNumber)
        {
            customers.Remove(customerNumber);
        }


        /// <summary>
        /// Returns a unique/new customer number.
        /// </summary>
        /// <returns>A unique customer number.</returns>
        public int returnNewCustomerNumber()
        {
            latestCustomerNumber++;
            return latestCustomerNumber;
        }

        /// <summary>
        /// Adds a given account to a customers portfolio.
        /// </summary>
        /// <param name="customerNumberParam">The customer number of the customer that we wish to give the account to.</param>
        /// <param name="accountNumber">The account number of the account that we wish to give to the customer.</param>
        public void addAccountToCustomer(int customerNumberParam, int accountNumber)
        {
            customers[customerNumberParam].addBankAccount(accountNumber);
        }


    }
}
