using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardConcepts;
using System.Windows.Forms;

namespace Blackjack3
{
    /// <summary>
    /// The "Controller" for this program (implemnting MVC architecture). The dealer handles dealing cards, and telling the players wheter they won or lost. 
    /// </summary>
    public class Dealer
    {
        /// <summary>
        /// The deck that the dealer is dealing from.
        /// </summary>
        private Deck d;

        /// <summary>
        /// A list of all of the guest players playing in the Blackjack game.
        /// </summary>
        private List<Player> guestPlayers;

        /// <summary>
        /// The house player in the Blackjack game.
        /// </summary>
        private Player housePlayer;

        /// <summary>
        /// Keeps track of the number of guest players that are out of the round.
        /// </summary>
        private int guestPlayersOut;

        /// <summary>
        /// Keeps track of how many rounds have been played.
        /// </summary>
        private int rounds;

        /// <summary>
        /// Keeps track of the human wins.
        /// </summary>
        private int humanWins;

        /// <summary>
        /// The status of the game;
        /// </summary>
        private string status;

        /// <summary>
        /// A registry of observer delegates, to be used for the purpose of updating the views (except for the HouseHandForm) as the models change. 
        /// </summary>
        private List<Observer> observers = new List<Observer>();

        /// <summary>
        /// A registry of observer delegates, to be used for the purpose of updating the HouseHandForm
        /// </summary>
        private List<Observer> observersHouseHandOnly = new List<Observer>();

        /// <summary>
        /// Constructs a dealer object, and a new deck.
        /// </summary>
        /// <param name="guestPlayers">A list of the guest players.</param>
        /// <param name="housePlayer">The house player.</param>
        /// <param name="d">The deck that the dealer will be dealing from.</param>
        public Dealer(List<Player> guestPlayers, Player housePlayer, Deck d)
        {
            this.guestPlayers = guestPlayers;
            this.housePlayer = housePlayer;
            this.d = d;
            rounds = 0;
            humanWins = 0;
            status = ("Welcome to Blackjack! Press 'New Round' to begin the game.");
        }

        /// <summary>
        /// Adds method f to the observers registry. This registry contains methods for updating the Human From/Scoreboard views.
        /// </summary>
        /// <param name="f">The method to be added to the registry.</param>
        public void registerOb(Observer f)
        { 
            observers.Add(f);
        }

        /// <summary>
        /// Adds method f to the observersHouseHandOnly registry. This registry contains methods for updating the HouseHandForm exclusively.
        /// </summary>
        /// <param name="f">The method to be added to the registry.</param>
        public void registerObHouseHandOnly(Observer f)
        {
            observersHouseHandOnly.Add(f);
        }

        /// <summary>
        /// Starts a new round of blackjack! Both players are dealt two cards, and the views are updated appropriately.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void newRound(object sender, EventArgs e)
        {
            guestPlayersOut = 0;
            //Gives each non house player two cards.
            foreach (Player p in guestPlayers)
            {
                p.getsCard(d.deal());
                p.getsCard(d.deal());
            }

            //Gives the house player two cards.
            housePlayer.getsCard(d.deal());
            updateHouseViewOnly();
            housePlayer.getsCard(d.deal());

            rounds++;

            status = "Round " + rounds + " begins!";

            //Update all of the forms with all the methods that are stored in the registry.
            updateViews();
            

            //Check to see if the house player was dealt a Blackjack.
            if (housePlayer.showHand().BJscore() == 21)
            {
                status = ("The house player holds a Blackjack! You do not win. Round " + rounds + " is now over. Statistics may now be viewed.");
                updateViews();
                updateHouseViewOnly();
                housePlayer.outcomeOfRound(Outcome.Win);
                d.acceptDiscards(housePlayer.showHand().surrenderCards());
                foreach (Player p in guestPlayers)
                {
                    p.outcomeOfRound(Outcome.NotWin);
                    d.acceptDiscards(p.showHand().surrenderCards());
                }
                return;
            }

            //Check to see if any of the guest players were dealt Blackjack. If so they win the round.
            foreach (Player h in guestPlayers)
            {
                if (h.showHand().BJscore() == 21)
                {
                    status = ("Wowzers! You were dealt a Blackjack! You win! Round " + rounds + " is now over. Statistics may now be viewed.");
                    h.outcomeOfRound(Outcome.Win);
                    humanWins++;
                    updateViews();
                    updateHouseViewOnly();
                    d.acceptDiscards(h.showHand().surrenderCards());
                    guestPlayersOut++;
                    //And the house player LOSES the round. 
                    housePlayer.outcomeOfRound(Outcome.NotWin);
                    d.acceptDiscards(housePlayer.showHand().surrenderCards());
                    return;
                }
            }
        }

        /// <summary>
        /// Handles dealing card to the human player. In this game, there is only one human player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dealACardToHuman(object sender, EventArgs e)
        {
            //Deal the human player one card. The human is the only player in the list, so this is not an issue.
            foreach (Player p in guestPlayers)
            {
                p.getsCard(d.deal());
                //Update all of the forms with all the methods that are stored in the registry.
                updateViews();
            }
        }

        /// <summary>
        /// This constitutes the logic for the rest of the game (after players have been dealt cards/Human done asking for cards or has busted).
        /// This method is called if the human presses the Hold button, or the Human has busted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void playerDecidedToHold(object sender, EventArgs e)
        {
            //First check to see if the human player busted.
            foreach (Player p in guestPlayers)
            {
                //Check to see if the player busted.
                if (p.showHand().BJscore() > 21)
                {
                    status = ("You busted! Round " + rounds + " is now over. Statistics may now be viewed.");
                    updateViews();
                    updateHouseViewOnly();
                    p.outcomeOfRound(Outcome.NotWin);
                    d.acceptDiscards(p.showHand().surrenderCards());
                    guestPlayersOut++;
                    housePlayer.outcomeOfRound(Outcome.Win);
                    d.acceptDiscards(housePlayer.showHand().surrenderCards());
                    return;
                }
            }

            //If there are still players in the game...
            if (guestPlayersOut < guestPlayers.Count)
            {
                updateHouseViewOnly();
                //Allow the house player to play a round
                while (housePlayer.wantsCard() == true)
                {
                    housePlayer.getsCard(d.deal());
                    updateHouseViewOnly();
                    //If the house player busts, they return the cards, the other players that are still in win, and a new round is started.
                    if (housePlayer.showHand().BJscore() > 21)
                    {
                        foreach (Player h in guestPlayers)
                        {
                            if (h.showHand().BJscore() != 0)
                            {
                                h.outcomeOfRound(Outcome.Win);
                                humanWins++;
                                status = ("The House Player busted! You win! Round " + rounds + " is now over. Statistics may now be viewed.");
                                updateViews();
                                updateHouseViewOnly();
                                d.acceptDiscards(h.showHand().surrenderCards());
                            }
                        }
                        housePlayer.outcomeOfRound(Outcome.NotWin);
                        d.acceptDiscards(housePlayer.showHand().surrenderCards());
                        return;
                    }
                }
            }
            //Otherwise both players are already finished with the round, and a new one must be started.
            else
            {
                housePlayer.outcomeOfRound(Outcome.Win);
                status = ("You didn't win! Round " + rounds + " is now over. Statistics may now be viewed.");
                updateViews();
                updateHouseViewOnly();
                d.acceptDiscards(housePlayer.showHand().surrenderCards());
                return;
            }

            //At this point, the house player is still in, and at least ONE of the guest players is still in.
            foreach (Player h in guestPlayers)
            {
                if (h.showHand().BJscore() != 0)
                {
                    //if the house player busted, or if there score is less than the guest player, then the guest player wins that round.
                    if (housePlayer.showHand().BJscore() < h.showHand().BJscore())
                    {
                        h.outcomeOfRound(Outcome.Win);
                        humanWins++;
                        status = ("You win! Round " + rounds + " is now over. Statistics may now be viewed.");
                        updateViews();
                        updateHouseViewOnly();
                        d.acceptDiscards(h.showHand().surrenderCards());
                        housePlayer.outcomeOfRound(Outcome.NotWin);
                        d.acceptDiscards(housePlayer.showHand().surrenderCards());
                    }
                    //If the two players tie.
                    else if (housePlayer.showHand().BJscore() == h.showHand().BJscore())
                    {
                        h.outcomeOfRound(Outcome.NotWin);
                        status = ("A Tie with the House Player! You didn't win! Round " + rounds + " is now over. Statistics may now be viewed.");
                        updateViews();
                        updateHouseViewOnly();
                        d.acceptDiscards(h.showHand().surrenderCards());
                        housePlayer.outcomeOfRound(Outcome.Win);
                        d.acceptDiscards(housePlayer.showHand().surrenderCards());
                    }
                    //If the house player wins.
                    else
                    {
                        status = ("You didn't win! Round " + rounds + " is now over. Statistics may now be viewed.");
                        updateViews();
                        updateHouseViewOnly();
                        d.acceptDiscards(h.showHand().surrenderCards());
                        housePlayer.outcomeOfRound(Outcome.Win);
                        d.acceptDiscards(housePlayer.showHand().surrenderCards());
                    }
                }
            }
            return;

        }

        /// <summary>
        /// Simply returns the number of rounds played in the current game.
        /// </summary>
        /// <returns>The number of rounds played in the current game.</returns>
        public int numberOfRounds()
        {
            return rounds;
        }

        /// <summary>
        /// Simply returns the number of times that the Human has one in the current game.
        /// </summary>
        /// <returns>The number of times that the Human has won in the current game.</returns>
        public int numberOfWins()
        {
            return humanWins;
        }

        /// <summary>
        /// Excecutes all of the methods in the "observers" registry. That is,
        /// IT ONLY UPDATES THE VIEWS FOR THE HumanHandForm AND THE Scoreboard.
        /// </summary>
        public void updateViews()
        {
            foreach (Observer m in observers)
            {
                m();
            }
        }

        /// <summary>
        /// Excecutes all of the methods in the "observersHouseHandOnly" registry. That is,
        /// IT ONLY UPDATES THE VIEW FOR THE HouseHandForm.
        /// </summary>
        public void updateHouseViewOnly()
        {
            foreach (Observer m in observersHouseHandOnly)
            {
                m();
            }
        }

        /// <summary>
        /// Simply returns a string containing the status for the game.
        /// </summary>
        /// <returns></returns>
        public string gameStatus()
        {
            return status;
        }
    }
}