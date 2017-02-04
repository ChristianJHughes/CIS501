//Author: Christian Hughes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardConcepts;

namespace Blackjack3
{
    //The main entry point for the program. The MVC architecture is assembled here.
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

            // WRITE ME: CONSTRUCT MODEL OBJECTS
            //           CONSTRUCT CONTROLLER
            //           CONSTRUCT VIEWS
            //           REGISTER VIEWS WITH CONTROLLER
            //           START THE SYSTEM
            
            //Models are created, and later passed on to the entities that own them (dealer/players).
            Deck d = new Deck();
            Hand humanHand = new Hand();
            Hand houseHand = new Hand();

            //Players!
            Player housePlayer = new Android("House", houseHand);
            List<Player> guestPlayers = new List<Player>();
            guestPlayers.Add(new Human("You", humanHand));

            //Controller (The Dealer)!
            Dealer dealer = new Dealer(guestPlayers, housePlayer, d);

            //Construct views!
            HumansHandForm humanForm = new HumansHandForm(dealer.newRound, dealer.dealACardToHuman, dealer.playerDecidedToHold, humanHand, houseHand);
            Scoreboard scoreboard = new Scoreboard(humanHand, dealer.numberOfWins, dealer.numberOfRounds, dealer.gameStatus);
            HouseHandForm houseForm = new HouseHandForm(houseHand);

            //Display views!
            humanForm.Show();
            scoreboard.Show();
            houseForm.Show();
            
            //Register the methods that update the forms.
            dealer.registerOb(humanForm.showhand);
            dealer.registerObHouseHandOnly(houseForm.updateHand);
            dealer.registerOb(scoreboard.updateScore);
            dealer.registerOb(scoreboard.updateWins);
            dealer.registerOb(scoreboard.updateRounds);
            dealer.registerOb(scoreboard.updateStatus);

            //The HumansHandForm will serve as our main view.
            Application.Run(humanForm);

            //We will conculde our program with a cute little message box before exiting.
            MessageBox.Show("Thanks for playing! Click to exit.", "Exit");
        }
    }
}
