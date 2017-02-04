using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teller
{
    //An enumeration to keep track of the state for the Teller.
    public enum TellerStatus
    {
        Start,
        ClosingAnAccount,
        AttemptClosingCustomerAccount,
        ClosedCustomerAccount,
        AttemptClosingBankAccount,
        ClosedBankAccount,
        CreatingNewAccount,
        AttemptCreatingNewCustomerAccount,
        NeedValidAddress,
        CreatedNewCustomerAccount,
        AttemptCreatingNewBankAccount,
        CreatedNewBankAccount,
        WorkingWithAnExistingAccount,
        Depositing,
        NeedValidDepositAmount,
        DepositSuccess,
        Withdrawing,
        NeedValidWithdrawalAmount,
        WithdrawalSuccess,
        BalanceInquiry,
        DisplayingBalanceInquiry,
        InvalidInput,
        AccountAlreadyInUse,
        AccountNotFound
    }
}
