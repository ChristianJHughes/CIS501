using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingDatabase;
using System.Threading;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the ATM Assemby. IT TESTS THIS ASSMBLY ALONE. THE MAIN METHOD IN THE TELLER ASSEMBLY CONSTRUCTS THE ENTIRE SYSTEM.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Construct the models.
            CustomerDB cDatabase = new CustomerDB();
            AccountDB aDatabase = new AccountDB();

            //Create virtual Donald Trump.
            cDatabase.addNewCustomer("D. Trump", "Atlantic City, NJ");
            aDatabase.addNewAccount(1, 80);
            MessageBox.Show("Account number 100 constructed for D.Trump.", "New Customer Created");

            //Construct the controller.
            AtmPresenter controller = new AtmPresenter(cDatabase, aDatabase);
            AtmPresenter controller2 = new AtmPresenter(cDatabase, aDatabase);
            //Construct the view.
            new Thread(ATMThread1).Start(controller);
            new Thread(ATMThread2).Start(controller2);
        }

        /// <summary>
        /// The Thread for the first ATM.
        /// </summary>
        /// <param name="ob"></param>
        static void ATMThread1(Object ob)
        {
            Application.Run(new ATMForm((AtmPresenter)ob));
        }

        /// <summary>
        /// The thread for the second ATM.
        /// </summary>
        /// <param name="ob"></param>
        static void ATMThread2(Object ob)
        {
            Application.Run(new ATMForm((AtmPresenter)ob));
        }
    }
}
