using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardConcepts;
using System.Windows.Forms;
using System.Threading;

namespace Blackjack3
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
        /// A string representing the player's name.
        /// </summary>
        private string playersName;

        /// <summary>
        /// A constructor that creates the form, as well as a new hand for the Android Player.
        /// </summary>
        /// <param name="name">The name of the Android Player.</param>
        public Android(string name, Hand h)
        {
            this.h = h;
            rounds = 0;
            wins = 0;
            playersName = name;
        }

        /// <summary>
        /// Returns true if the android Player would like another card.
        /// </summary>
        /// <returns>Whether the Android Player wants another card.</returns>
        public bool wantsCard()
        {
            Thread.Sleep(500);
            if (h.BJscore() < 17)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds a card to the players hand.
        /// </summary>
        /// <param name="c">The card to be added to the player's hand.</param>
        public void getsCard(Card c)
        {
            h.add(c);
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
            rounds++;
            if (result == Outcome.Win)
            {
                wins++;
            }
        }

    }
}