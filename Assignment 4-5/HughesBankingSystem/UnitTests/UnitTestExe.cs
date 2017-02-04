using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingDatabase;

namespace UnitTests
{
    //Excecutes Unit tests for the bankingDatabase VS Project.
    class UnitTestExe
    {
        //The main/only method used for doing unit tests.
        //ONLY UNIT TESTS THE DATABASE.
        static void Main(string[] args)
        {
            //Build the databases. 
            CustomerDB custDatabase = new CustomerDB();
            AccountDB acctDatabase = new AccountDB();

            //Add two customers to the database. Give Bill gates an account. He should be customer number 2, and have account number 100 (the first account).
            //The databases do all of the work creating the customers and accounts!
            custDatabase.addNewCustomer("Donald Trump", "New York City");
            custDatabase.addNewCustomer("Bill Gates", "Microsoft Lane, Seatle");
            int accountNum = acctDatabase.addNewAccount(2, 500.50);
            custDatabase.addAccountToCustomer(2, accountNum);
            
            //Customer numbers begin at 001 and increase from there. This should disply both customers with the correct information.
            Console.WriteLine(custDatabase.lookUpCustomer(1).toString());
            Console.WriteLine();
            Console.WriteLine(custDatabase.lookUpCustomer(2).toString());

            
            Console.WriteLine();
            //an actual customer will never be able to do this for obvious reasons. The system can, however. 
            Console.Write("Bill Gates provides his account number (100), and should have his customer number returned (2): ");
            Console.WriteLine(acctDatabase.lookUpAccountReturnCustomerNumber(100));
            Console.Write("Bill Gates makes a reqest for his balance (500.50): $");
            Console.WriteLine(acctDatabase.returnAccountBalance(100));
            Console.Write("Bill Gates withdraws $200. New Balance: $");
            acctDatabase.withdrawFromAccount(100, 200.00);
            Console.WriteLine(acctDatabase.returnAccountBalance(100));
            Console.Write("Bill Gates deposits $50. New Balance: $");
            acctDatabase.depositIntoAccount(100, 50.00);
            Console.WriteLine("" + acctDatabase.returnAccountBalance(100));

            Console.WriteLine("Unit tests complete. Press enter to quit.");
            Console.ReadLine();
        }
    }
}
