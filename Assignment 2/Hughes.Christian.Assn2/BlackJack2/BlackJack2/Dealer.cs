//Author: Christian Hughes

using System;
using System.Collections.Generic;
using System.Text;
using CardConcepts;
using System.Windows.Forms;

namespace BlackJack2
{
    //A class for constructing the dealer in the Blackjack game. There is only one dealer in the game.
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
        /// Determines whether the house Player won at all on the current round.
        /// </summary>
        private bool housePlayerWin;

        /// <summary>
        /// Keeps track of the number of guest players that are out of the round.
        /// </summary>
        private int guestPlayersOut;

        /// <summary>
        /// Keeps track of how many rounds have been played.
        /// </summary>
        private int rounds;

        /// <summary>
        /// Constructs a dealer object, and a new deck.
        /// </summary>
        /// <param name="guestPlayers">A list of the guest players.</param>
        /// <param name="housePlayer">The house player.</param>
        public Dealer(List<Player> guestPlayers, Player housePlayer)
        {
            this.guestPlayers = guestPlayers;
            this.housePlayer = housePlayer;
            d = new Deck();
            rounds = 0;
        }

        /// <summary>
        /// Goes through the algorithm of a single round of Blackjack.
        /// </summary>
		public void playRound()
		{
            
            housePlayerWin = false;
            guestPlayersOut = 0;
            //Gives each non house player two cards.
			foreach (Player p in guestPlayers)
            {
                p.getsCard(d.deal());
                p.getsCard(d.deal());
            }

            //Gives the house player two cards.
            housePlayer.getsCard(d.deal());
            housePlayer.getsCard(d.deal());

            //If it's the begining of the game, we want to alert the player about some of the rules.
            if (rounds == 0)
            {
                MessageBox.Show("Welcome to Blackjack by Christian Hughes! In this game, Android Players and Human Players compete against a House Player. \n\nThe Android Player(s) will take thier turns first, followed by the Human Player(s), followed by the House Player.\n\nThe House Player will consider a win against ANY INDIVIDUAL PLAYER a win for the round. \n\nHave fun!", "Welcome");
            }
            rounds++;

            //Check to see if the house player was dealt a Blackjack.
            if (housePlayer.showHand().BJscore() == 21)
            {
                MessageBox.Show("A new round begins! The house player holds a Blackjack! The round is over.", "Game Status");
                housePlayer.outcomeOfRound(Outcome.Win);
                d.acceptDiscards(housePlayer.showHand().surrenderCards());
                foreach (Player p in guestPlayers)
                {
                    p.outcomeOfRound(Outcome.NotWin);
                    d.acceptDiscards(p.showHand().surrenderCards());
                }
                MessageBox.Show("The round is now over. Statistics may now be viewed.", "Round " + rounds + " Completed");
                playRound();
                return;
            }
            else
            {
                MessageBox.Show("A new round begins! The house player does NOT hold a Blackjack, so play continues!", "Game Status");
            }

            //Check to see if any of the guest players were dealt Blackjack. If so they win the round.
            foreach (Player h in guestPlayers)
            {
                if (h.showHand().BJscore() == 21)
                {
                    MessageBox.Show("Wowzers! A player was dealt Blackjack!", "Game Status");
                    h.outcomeOfRound(Outcome.Win);
                    d.acceptDiscards(h.showHand().surrenderCards());
                    guestPlayersOut++;
                }
            }

            //For every guest player that was not dealt a Blackjack initally, play a round.
            foreach (Player h in guestPlayers)
            {
                if (h.showHand().BJscore() != 0)
                {
                    while (h.wantsCard() == true)
                    {
                        h.getsCard(d.deal());
                        
                        if (h.showHand().BJscore() > 21)
                        {
                            h.outcomeOfRound(Outcome.NotWin);
                            d.acceptDiscards(h.showHand().surrenderCards());
                            guestPlayersOut++;
                            break;
                        }
                        else if (h.showHand().BJscore() == 21)
                        {
                            break;
                        }
                    }
                }
            }

            //If there are still players in the game...
            if (guestPlayersOut < guestPlayers.Count)
            {
                //Allow the house player to play a round
                while (housePlayer.wantsCard() == true)
                {
                    housePlayer.getsCard(d.deal());
                    //If the house player busts, they return the cards, the other players that are still in win, and a new round is started.
                    if (housePlayer.showHand().BJscore() > 21)
                    {
                        housePlayer.outcomeOfRound(Outcome.NotWin);
                        d.acceptDiscards(housePlayer.showHand().surrenderCards());

                        foreach (Player h in guestPlayers)
                        {
                            if (h.showHand().BJscore() != 0)
                            {
                                h.outcomeOfRound(Outcome.Win);
                                d.acceptDiscards(h.showHand().surrenderCards());
                            }
                        }
                        MessageBox.Show("The round is now over. Statistics may now be viewed.", "Round " + rounds + " Completed");
                        playRound();
                        return;
                    }
                }
            }
            //Otherwise both players are already finished with the round, and a new one must be started.
            else
            {
                housePlayer.outcomeOfRound(Outcome.Win);
                d.acceptDiscards(housePlayer.showHand().surrenderCards());
                MessageBox.Show("The round is now over. Statistics may now be viewed.", "Round " + rounds + " Completed");
                playRound();
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
                        d.acceptDiscards(h.showHand().surrenderCards());
                    }
                    //If the two players tie.
                    else if (housePlayer.showHand().BJscore() == h.showHand().BJscore())
                    {
                        h.outcomeOfRound(Outcome.NotWin);
                        d.acceptDiscards(h.showHand().surrenderCards());
                    }
                    //If the house player wins.
                    else
                    {
                        housePlayerWin = true;
                        h.outcomeOfRound(Outcome.NotWin);
                        d.acceptDiscards(h.showHand().surrenderCards());
                    }
                }
            }

            //If we've gotten this far then we need to make sure that the dealer surrenders thier cards.
            if (housePlayerWin == true)
            {
                housePlayer.outcomeOfRound(Outcome.Win);
                d.acceptDiscards(housePlayer.showHand().surrenderCards());
            }
            else
            {
                housePlayer.outcomeOfRound(Outcome.NotWin);
                d.acceptDiscards(housePlayer.showHand().surrenderCards());
            }

            //Play another round, the game goes on forever.
            MessageBox.Show("The round is now over. Statistics may now be viewed.", "Round " + rounds + " Completed");
            playRound();
            return;
            
		}
	}
}
