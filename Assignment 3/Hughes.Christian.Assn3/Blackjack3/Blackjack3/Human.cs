using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardConcepts;
using System.Windows.Forms;

namespace Blackjack3
{
    //A class with the necessary constructs for a Human Player. Much of this class is copied from Blackjack2, and is no longer applicable in the same fashion.
    public class Human : Player
    {
        /// <summary>
        /// The hand of the Human Player.
        /// </summary>
        private Hand h;

        /// <summary>
        /// The name of the human Player.
        /// </summary>
        private string playerName;

        /// <summary>
        /// The number of rounds that have been played so far.
        /// </summary>
        private int rounds;

        /// <summary>
        /// The number of wins the current Player has gotten.
        /// </summary>
        private int wins;

        /// <summary>
        /// How many cards the current player has.
        /// </summary>
        private int cardCounter;

        /// <summary>
        /// The constructor creates a new hand, constructs a new form for the player, and assigns the name of the player to the text of that form.
        /// </summary>
        /// <param name="name">The name of the player.</param>
        public Human(string name, Hand h)
        {
            this.h = h;
            rounds = 0;
            wins = 0;
            playerName = name;
            cardCounter = 0;
        }

        /// <summary>
        /// Asks the Human Player via a MessageBox whether or not they would like another card.
        /// THIS METHOD IS NOT USED IN Blackjack3, AS BUTTONS HAVE REPLACED THE MESSAGEBOX SYSTEM.
        /// IT REMAINS IMPLEMENTED TO FUFILL THE INTERFACE Player.
        /// </summary>
        /// <returns>Whether or not the human Player would like another card.</returns>
        public bool wantsCard()
        {

            if (cardCounter == 2)
            {
                DialogResult result = MessageBox.Show("It's your turn now! Would you like another card?", "Human Player's Turn (" + playerName + ")", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    return true;
                }
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Would you like another card?", "Human Player's Turn (" + playerName + ")", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Adds a card to the players hand.
        /// </summary>
        /// <param name="c">The card to be added to the player's hand.</param>
        public void getsCard(Card c)
        {
            h.add(c);
            cardCounter++;
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
        /// Tells the Player whether they won or lost. 
        /// </summary>
        /// <param name="result">The result of the round.</param>
        public void outcomeOfRound(Outcome result)
        {
            rounds++;
            if (result == Outcome.Win)
            {
                wins++;
            }

            cardCounter = 0;
        }
    }
}
