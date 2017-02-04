using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingDatabase;
using System.Windows.Forms;

namespace Teller
{
    //The class with the necessary constructs for the Teller form.
    public class TellerController
    {
        //A handle to the account database.
        private AccountDatabase aDatabase;

        //A handle to the customer database.
        private CustomerDatabase cDatabase;

        //Keeps track of the current state of the Teller assembly.
        private TellerStatus state = TellerStatus.Start;

        public TellerController(AccountDatabase a, CustomerDatabase c)
        {
            aDatabase = a;
            cDatabase = c;
        }

        //The number to be returned to the Teller form in the below method.
        private double output;

        //The account number that we are curretly working with.
        private int currentAccountNum;

        //Keeps track of the name of the current customer trying to make a new customer account.
        private string currentName;

        //Keeps track of the address of the current customer trying to make a new customer account.
        private string currentAddress;

        /// <summary>
        /// Handles all of states that are passed to the controller.
        /// </summary>
        /// <param name="s">The string passed from the input text box on the form.</param>
        /// <param name="stat">The status passed in by the form.</param>
        /// <returns>A tuple containing the new status, as well as a double value that will be used for a variety of purposes.</returns>
        public Tuple<TellerStatus, double> handle(string s, TellerStatus stat)
        {
            state = stat;
            switch (state)
            {
                case TellerStatus.AttemptClosingCustomerAccount:
                {
                    int acctNum = 0;
                    bool intOK = int.TryParse(s, out acctNum);
                    if (intOK)
                    {
                        if (aDatabase.doesAccountExist(acctNum))
                        {
                            if (aDatabase.logInAccount(acctNum) == true)
                            {
                                currentAccountNum = acctNum;
                                output = aDatabase.returnAccountBalance(currentAccountNum);
                                completeWithdrawal(currentAccountNum, output);
                                MessageBox.Show("The account provided was emptied. Here's $" + output.ToString("00.00") + ", just for you.", "Dolla Dolla Bills Ya'll");
                                aDatabase.logOutAccount(currentAccountNum);
                                cDatabase.removeCustomer(aDatabase.lookUpAccountReturnCustomerNumber(currentAccountNum));
                                aDatabase.removeAccount(currentAccountNum);
                                state = TellerStatus.ClosedCustomerAccount;
                            }
                            else
                            {
                                state = TellerStatus.AccountAlreadyInUse;
                            }
                        }
                        else
                        {
                            state = TellerStatus.AccountNotFound;
                        }
                    }
                    else
                    {
                        //figure out what to do if invalid input.
                        state = TellerStatus.AccountNotFound;
                    }
                    break;
                }
                case TellerStatus.ClosedCustomerAccount:
                {
                    state = TellerStatus.Start;
                    break;
                }
                case TellerStatus.AttemptClosingBankAccount:
                {
                    int acctNum = 0;
                    bool intOK = int.TryParse(s, out acctNum);
                    if (intOK)
                    {
                        if (aDatabase.doesAccountExist(acctNum))
                        {
                            if (aDatabase.logInAccount(acctNum) == true)
                            {
                                currentAccountNum = acctNum;
                                output = aDatabase.returnAccountBalance(currentAccountNum);
                                completeWithdrawal(currentAccountNum, output);
                                MessageBox.Show("Account emptied. Here's $" + output.ToString("00.00") + ", just for you.", "Dolla Dolla Bills Ya'll");
                                aDatabase.logOutAccount(currentAccountNum);
                                aDatabase.removeAccount(currentAccountNum);
                                state = TellerStatus.ClosedBankAccount;
                            }
                            else
                            {
                                state = TellerStatus.AccountAlreadyInUse;
                            }
                        }
                        else
                        {
                            state = TellerStatus.AccountNotFound;
                        }
                    }
                    else
                    {
                        //figure out what to do if invalid input.
                        state = TellerStatus.AccountNotFound;
                    }
                    break;
                }
                case TellerStatus.ClosedBankAccount:
                {
                    state = TellerStatus.Start;
                    break;
                }
                case TellerStatus.AttemptCreatingNewCustomerAccount:
                {
                    currentName = s;
                    state = TellerStatus.NeedValidAddress;
                    break;
                }
                case TellerStatus.NeedValidAddress:
                {
                    currentAddress = s;
                    state = TellerStatus.CreatedNewCustomerAccount;
                    output = (double)(cDatabase.addNewCustomer(currentName, currentAddress));
                    break;
                }
                case TellerStatus.CreatedNewCustomerAccount:
                {
                    state = TellerStatus.Start;
                    break;
                }
                case TellerStatus.AttemptCreatingNewBankAccount:
                {
                    int custNum = 0;
                    bool intOK = int.TryParse(s, out custNum);
                    if (intOK)
                    {
                        if (cDatabase.lookUpCustomer(custNum) != null)
                        {
                            //Customer newCust = cDatabase.lookUpCustomer(custNum);
                            int newNum = aDatabase.addNewAccount(custNum, 0.0);
                            cDatabase.addAccountToCustomer(custNum, newNum);
                            output = newNum;
                            state = TellerStatus.CreatedNewBankAccount;
                        }
                        else
                        {
                            state = TellerStatus.AccountNotFound;
                        }
                    }
                    else
                    {
                        state = TellerStatus.AccountNotFound;
                    }
                    break;
                }
                case TellerStatus.CreatedNewBankAccount:
                {
                    state = TellerStatus.Start;
                    break;
                }
                case TellerStatus.Depositing:
                {
                    int acctNum = 0;
                    bool intOK = int.TryParse(s, out acctNum);
                    if (intOK)
                    {
                        if (aDatabase.doesAccountExist(acctNum))
                        {
                            if (aDatabase.logInAccount(acctNum) == true)
                            {
                                currentAccountNum = acctNum;
                                output = aDatabase.returnAccountBalance(currentAccountNum);
                                state = TellerStatus.NeedValidDepositAmount;
                                currentAccountNum = acctNum;
                            }
                            else
                            {
                                state = TellerStatus.AccountAlreadyInUse;
                            }
                        }
                        else
                        {
                            state = TellerStatus.AccountNotFound;
                        }
                    }
                    else
                    {
                        //figure out what to do if invalid input.
                        state = TellerStatus.AccountNotFound;
                    }
                    break;
                }
                case TellerStatus.NeedValidDepositAmount:
                {
                    double withAmmt = 0;
                    bool doubleOk = Double.TryParse(s, out withAmmt);
                    if (doubleOk == true)
                    {
                         aDatabase.depositIntoAccount(currentAccountNum, withAmmt);
                         output = aDatabase.returnAccountBalance(currentAccountNum);
                         MessageBox.Show("Here's your new balance: $" + output.ToString("00.00") + ".", "Dolla Dolla Bills Ya'll");
                         state = TellerStatus.DepositSuccess;
                    }
                    else
                    {
                        //Add the invalid input state here.
                        state = TellerStatus.InvalidInput;
                    }
                    break;
                }
                case TellerStatus.DepositSuccess:
                {
                    aDatabase.logOutAccount(currentAccountNum);
                    state = TellerStatus.Start;
                    break;
                }
                case TellerStatus.Withdrawing:
                {
                    int acctNum = 0;
                    bool intOK = int.TryParse(s, out acctNum);
                    if (intOK)
                    {
                        if (aDatabase.doesAccountExist(acctNum))
                        {
                            if (aDatabase.logInAccount(acctNum) == true)
                            {
                                currentAccountNum = acctNum;
                                output = aDatabase.returnAccountBalance(currentAccountNum);
                                state = TellerStatus.NeedValidWithdrawalAmount;
                            }
                            else
                            {
                                state = TellerStatus.AccountAlreadyInUse;
                            }
                        }
                        else
                        {
                            state = TellerStatus.AccountNotFound;
                        }
                    }
                    else
                    {
                        //figure out what to do if invalid input.
                        state = TellerStatus.AccountNotFound;
                    }
                    break;
                }
                case TellerStatus.NeedValidWithdrawalAmount:
                {
                    double withAmmt = 0;
                    bool doubleOk = Double.TryParse(s, out withAmmt);
                    if (doubleOk == true)
                    {
                        if ((output - withAmmt) >= 0)
                        {
                            completeWithdrawal(currentAccountNum, withAmmt);
                            output = checkBalance(currentAccountNum);
                            state = TellerStatus.WithdrawalSuccess;
                            MessageBox.Show("Here's $" + withAmmt.ToString("00.00") + ", just for you.", "Dolla Dolla Bills Ya'll");
                        }
                        else
                        {
                            state = TellerStatus.InvalidInput;
                        }
                    }
                    else
                    {
                        //If invalid input.
                        state = TellerStatus.InvalidInput;
                    }
                    break;
                }
                case TellerStatus.WithdrawalSuccess:
                {
                    aDatabase.logOutAccount(currentAccountNum);
                    state = TellerStatus.Start;
                    break;
                }
                case TellerStatus.BalanceInquiry:
                {
                    int acctNum = 0;
                    bool intOK = int.TryParse(s, out acctNum);
                    if (intOK)
                    {
                        if (aDatabase.doesAccountExist(acctNum))
                        {
                            if (aDatabase.logInAccount(acctNum) == true)
                            {
                                currentAccountNum = acctNum;
                                output = aDatabase.returnAccountBalance(currentAccountNum);
                                state = TellerStatus.DisplayingBalanceInquiry;
                            }
                            else
                            {
                                state = TellerStatus.AccountAlreadyInUse;
                            }
                        }
                        else
                        {
                            state = TellerStatus.AccountNotFound;
                        }
                    }
                    else
                    {
                        //figure out what to do if invalid input.
                        state = TellerStatus.AccountNotFound;
                    }
                    break;
                }
                case TellerStatus.DisplayingBalanceInquiry:
                {
                    state = TellerStatus.Start;
                    aDatabase.logOutAccount(currentAccountNum);
                    break;
                }
                case TellerStatus.InvalidInput:
                {
                    state = TellerStatus.Start;
                    aDatabase.logOutAccount(currentAccountNum);
                    break;
                }
                case TellerStatus.AccountAlreadyInUse:
                {
                    state = TellerStatus.Start;
                    break;
                }
                case TellerStatus.AccountNotFound:
                {
                    state = TellerStatus.Start;
                    break;
                }
                default: {break;}
            }
            return new Tuple<TellerStatus, double>(state, output);
        }

        /// <summary>
        /// A method for getting the balance of the account from the database.
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns>The balance of the account.</returns>
        private double checkBalance(int accountNumber)
        {
            return aDatabase.returnAccountBalance(accountNumber);
        }

        /// <summary>
        /// A method for completing an account withdrawal through the database.
        /// </summary>
        /// <param name="accountNumber">The number of the account that the user wishes to withdraw from.</param>
        /// <param name="withdrawAmount">The amount that the user wishes to withdraw.</param>
        private void completeWithdrawal(int accountNumber, double withdrawAmount)
        {
            aDatabase.withdrawFromAccount(accountNumber, withdrawAmount);
        }

    }
}
