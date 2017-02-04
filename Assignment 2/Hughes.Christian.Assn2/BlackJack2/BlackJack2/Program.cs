//Author: Christian Hughes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack2
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
            //Application.Run(new OutputForm()); //Instead, we're suing OutputForm as a passive output form...
            //that each player constructs on thier own.

            //Assemble all system componenets, and call the Dealer, who "controls" the game:
            Player housePlayer = new Android("House");
            List<Player> guestPlayers = new List<Player>();
            guestPlayers.Add(new Android("Robo"));
            guestPlayers.Add(new Human("You"));
            Dealer d = new Dealer(guestPlayers, housePlayer);
            while (true) { d.playRound(); }
        }
    }
}
