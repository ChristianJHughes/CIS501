using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingDatabase;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// The controller for the ATM assembly.
    /// </summary>
    public class AtmPresenter
    {
        //Keeps track of the ATM's current state.
        private AtmStatus state = AtmStatus.Start;

        //A handle to the customer database.
        private CustomerDatabase cDatabase;

        //A handle to the account database.
        private AccountDatabase aDatabase;

        /// <summary>
        /// The constructor takes handles from the databases, and adds them to the private fields.
        /// </summary>
        /// <param name="c">A handle to the customer database.</param>
        /// <param name="a">A handle to the account database.</param>
        public AtmPresenter(CustomerDatabase c, AccountDatabase a)
        {
            aDatabase = a;
            cDatabase = c;
        }

        //Variables used in the below method, handle(). They keep track of the users balance and account number, and are reset
        //when the system enters the Start state. 
        private double balance = 0;
        private int accountNumber = 0;

        /// <summary>
        /// The handler method for all of the ATM's states.
        /// </summary>
        /// <param name="s">The string taken from the input text box on the ATM from.</param>
        /// <returns>A tuple containing the next state, as well as the balance of the account when applicable.</returns>
        public Tuple<AtmStatus, double> handle(string s) 
        {
            //int acctNum = 0;
            switch (state)
            {
                case AtmStatus.Start:
                {
                    int acctNum = 0; 
                    bool intOK = int.TryParse(s, out acctNum);
                    if (intOK)
                    {
                        if (aDatabase.doesAccountExist(acctNum) == true)
                        {
                            if (aDatabase.logInAccount(acctNum) == true)
                            {
                                balance = 0;
                                state = AtmStatus.LoggedIn;
                                accountNumber = acctNum;
                            }
                            else
                            {
                                state = AtmStatus.AccountAlreadyInUse;
                            }
                        }
                        else
                        {
                            state = AtmStatus.AccountNotFound;
                        }
                    }
                    else
                    {
                        state = AtmStatus.AccountNotFound;
                    }
                    break;
                }
                case AtmStatus.AccountNotFound:
                {
                    state = AtmStatus.Start;
                    break;
                }
                case AtmStatus.LoggedIn:
                {
                    int input = 0;
                    bool intOK = int.TryParse(s, out input);
                    if (intOK)
                    {
                        if (input == 1)
                        {
                            state = AtmStatus.ChooseBalanceInquiry;
                            balance = checkBalance(accountNumber);
                        }
                        else if (input == 2)
                        {
                            state = AtmStatus.ChoseWithdrawalNeedAmount;
                            balance = checkBalance(accountNumber);
                        }
                        else
                        {
                            //Add an invalid input state here.
                            state = AtmStatus.InvalidInput;
                        }
                    }
                    else
                    {
                        state = AtmStatus.InvalidInput;
                    }
                    break;
                }
                case AtmStatus.ChooseBalanceInquiry:
                {
                    state = AtmStatus.Start;
                    aDatabase.logOutAccount(accountNumber);
                    break;
                }
                case AtmStatus.ChoseWithdrawalNeedAmount:
                {
                    double withAmmt = 0;
                    bool doubleOk = Double.TryParse(s, out withAmmt);
                    if (doubleOk == true)
                    {
                        if ((balance - withAmmt) >= 0)
                        {
                            completeWithdrawal(accountNumber, withAmmt);
                            balance = checkBalance(accountNumber);
                            state = AtmStatus.CompletedWithdrawal;
                            MessageBox.Show("Here's $" + withAmmt.ToString("00.00") + ", just for you.", "Dolla Dolla Bills Ya'll");
                        }
                        else
                        {
                            state = AtmStatus.InvalidInput;
                        }
                    }
                    else
                    {
                        //Add the invalid input state here.
                        state = AtmStatus.InvalidInput;
                    }
                    break;
                }
                case AtmStatus.CompletedWithdrawal:
                {
                    state = AtmStatus.Start;
                    aDatabase.logOutAccount(accountNumber);
                    break;
                }
                case AtmStatus.InvalidInput:
                {
                    state = AtmStatus.Start;
                    aDatabase.logOutAccount(accountNumber);
                    break;
                }
                case AtmStatus.AccountAlreadyInUse:
                {
                    state = AtmStatus.Start;
                    break;
                }
                default: { break; }

            }
            return new Tuple<AtmStatus, double>(state, balance);
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