using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// The various possible states of the ATM Assembly.
    /// </summary>
    public enum AtmStatus
    {
        Start,
        LoggedIn,
        AccountNotFound,
        ChooseBalanceInquiry,
        ChoseWithdrawalNeedAmount,
        CompletedWithdrawal,
        InvalidInput,
        AccountAlreadyInUse
    }
}
