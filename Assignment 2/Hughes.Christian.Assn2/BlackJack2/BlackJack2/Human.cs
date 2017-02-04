//Author: Christian Hughes

using System;
using System.Collections.Generic;
using System.Text;
using CardConcepts;
using System.Windows.Forms;

namespace BlackJack2
{
    //A class with the necessary constructs for a Human Player.
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
        /// The passive form showing the Player's stats.
        /// </summary>
        private OutputForm f;

        /// <summary>
        /// How many cards the current player has.
        /// </summary>
        private int cardCounter;

        /// <summary>
        /// The constructor creates a new hand, constructs a new form for the player, and assigns the name of the player to the text of that form.
        /// </summary>
        /// <param name="name">The name of the player.</param>
		public Human(string name)
		{
            h = new Hand();
            rounds = 0;
            wins = 0;
            f = new OutputForm();
            playerName = name;
            f.Text = playerName;
            f.Show();
            cardCounter = 0;
		}

        /// <summary>
        /// Asks the Human Player via a MessageBox whether or not they would like another card.
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
            f.resetResult();
            h.add(c);
            cardCounter++;
            f.UpdateCards(h);
            f.UpdateScore(h);

            if (h.BJscore() > 21)
            {
                MessageBox.Show(playerName + " busted!", "Game Status");
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
            f.UpdateStats(wins, rounds);
            f.UpdateCards(h);
            f.UpdateScore(h);
            f.UpdateResult(result);

            string resultText;
            if (result == Outcome.Win)
            {
                resultText = "a win";
            }
            else
            {
                resultText = "not a win";
            }

            //Prints out that the round must continue (other player's must take turns) if the player was immediatly dealt a Blackjack. Otherwise prints out that a new round is about to start.
            if (cardCounter == 2 && h.BJscore() == 21)
            {
                MessageBox.Show("The result is " + resultText + "!\nAfter all other players finish their turns, a new round will begin.", "Result for " + playerName);
            }
            else
            {
                MessageBox.Show("The result is " + resultText + "!", "Result for " + playerName);
            }

            cardCounter = 0;
            
		}
	}
}
