using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingDatabase;
using WindowsFormsApplication1;
using System.Threading;

namespace Teller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TellerForm());

            //Construct the models.
            CustomerDB cDatabase = new CustomerDB();
            AccountDB aDatabase = new AccountDB();

            //Create virtual Donald Trump.
            cDatabase.addNewCustomer("D. Trump", "Atlantic City, NJ");
            aDatabase.addNewAccount(1, 80);
            MessageBox.Show("Account number 100 constructed for D.Trump.", "New Customer Created");

            //Create Virtual Bill Gates. He gets $10,000 and a custoemr number of 2.
            cDatabase.addNewCustomer("Bill Gates", "Microsoft Lane, United States");
            aDatabase.addNewAccount(2, 10000);
            MessageBox.Show("Account number 101 constructed for Bill Gates.", "New Customer Created");

            //Construct the controllers for the ATM's.
            AtmPresenter ATMController1 = new AtmPresenter(cDatabase, aDatabase);
            AtmPresenter ATMController2 = new AtmPresenter(cDatabase, aDatabase);

            //Construct the controller for the Teller form.
            TellerController TellerConroller1 = new TellerController(aDatabase, cDatabase);

            //Construct the threads for the ATM's.
            new Thread(ATMThread1).Start(ATMController1);
            new Thread(ATMThread2).Start(ATMController2);

            //Construct the thread for the Teller assmebly.
            new Thread(TellerThread1).Start(TellerConroller1);
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

        /// <summary>
        /// The thread for the teller assembly.
        /// </summary>
        /// <param name="ob"></param>
        static void TellerThread1(Object ob)
        {
            Application.Run(new TellerForm((TellerController)ob));
        }
    }
}
