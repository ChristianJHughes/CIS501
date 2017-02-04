//Author: Christian Hughes

using System;
using System.Collections.Generic;
using System.Text;
using CardConcepts;
using System.Windows.Forms;

namespace BlackJack2
{
    //A class with the necessary constructs for an Android Player. 
	public class Android : Player
	{
        /// <summary>
        /// The hand of the Player.
        /// </summary>
		private Hand h;

        /// <summary>
        /// Number of rounds that the Player has played.
        /// </summary>
        private int rounds;

        /// <summary>
        /// Number of times that they Player has won.
        /// </summary>
        private int wins;

        /// <summary>
        /// The passive form representing the Player's stats.
        /// </summary>
        private OutputForm f;

        /// <summary>
        /// Keeps track of how many cards the android player has been dealt.
        /// </summary>
        private int cardCounter = 0;

        private string playersName;

        /// <summary>
        /// A constructor that creates the form, as well as a new hand for the Android Player.
        /// </summary>
        /// <param name="name">The name of the Android Player.</param>
		public Android(string name)
		{
            h = new Hand();
            rounds = 0;
            wins = 0;
            f = new OutputForm();
            playersName = name;
            f.Text = playersName;
            f.Show();   
		}

        /// <summary>
        /// Returns true if the android Player would like another card.
        /// </summary>
        /// <returns>Whether the Android Player wants another card.</returns>
		public bool wantsCard()
		{
            f.UpdateScore(h);
            f.UpdateCards(h);
			if (h.BJscore() < 17)
            {
                return true;
            }
            MessageBox.Show(playersName + " has completed its turn. " + playersName + " did not bust.", playersName + "'s Turn");
            return false;
		}

        /// <summary>
        /// Adds a card to the players hand.
        /// </summary>
        /// <param name="c">The card to be added to the player's hand.</param>
		public void getsCard(Card c)
		{
            f.resetResult();
            if (cardCounter == 0)
            {
                f.ChangeScoreToQuestionMark();
            }
            h.add(c);
            cardCounter++;
            if (cardCounter != 2) //KNOWN BUG FIX THIS
            {
                f.UpdateCards(h);
                if (cardCounter > 1)
                {
                    f.UpdateScore(h);
                }
            }

            if (h.BJscore() > 21)
            {
                MessageBox.Show(playersName + " has completed its turn. " + playersName + " busted.", playersName + "'s Turn");
            }
		}

        /// <summary>
        /// Returns a handle to the Player's Hand of Cards.
        /// </summary>
        /// <returns>A handle to the Player's Hand of Cards.</returns>
		public Hand showHand()
		{
            return h;
		}

        /// <summary>
        /// Determines whether or not the given player one the round.
        /// </summary>
        /// <param name="result">The result of the round, passed in by the dealer.</param>
		public void outcomeOfRound(Outcome result)
		{
            cardCounter = 0;
            rounds++;
			if (result == Outcome.Win)
            {
                wins++;
            }
            f.UpdateStats(wins, rounds);
            f.UpdateScore(h);
            f.UpdateCards(h);
            f.UpdateResult(result);
		}
        
	}
}
