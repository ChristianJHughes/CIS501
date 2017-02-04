using System;
using System.Collections.Generic;
using System.Text;

namespace CardConcepts
{
    //Class for constructing a player's hand of cards.
	public class Hand
	{
        //A list of the cards in the hand.
        private List<Card> h;

        public Hand()
        {
            h = new List<Card>();
        }

        /// <summary>
        /// Returns a list of all the cards in private field h, and resets h to an empty list.
        /// </summary>
        /// <returns>A list of all the cards in private field h.</returns>
		public List<Card> surrenderCards()
		{
            List<Card> discardHand = new List<Card>();

            foreach (Card c in h)
            {
                discardHand.Add(c);
            }
            h.Clear(); 
            return discardHand;
		}

        /// <summary>
        /// Adds a card to the hand/
        /// </summary>
        /// <param name="c">The card to be added to the hand.</param>
		public void add(Card c)
		{
            h.Add(c);
		}

        /// <summary>
        /// Returns the Blackjack score of the current hand.
        /// </summary>
        /// <returns>The Blackjack score of the current hand.</returns>
		public int BJscore()
		{
            int preAceScore = 0;
            int numberOfAces = 0;
            int withAceScore = 0;
            foreach (Card c in h)
            {
                if (c.BJvalue() != 1)
                {
                    preAceScore += c.BJvalue();
                }
                else
                {
                    numberOfAces++;
                }
            }

            for (int j = 0; j <= numberOfAces; j++)
            {
                withAceScore = (preAceScore + ((numberOfAces - j) * 11) + j);
                if (withAceScore <= 21)
                {
                    return withAceScore;
                }
            }
            return withAceScore;
		}

        /// <summary>
        /// Returns a string that lists the cards in the hand.
        /// </summary>
        /// <returns>A string that lists the cards in the hand.</returns>
		public override string ToString()
		{
            string ans = "";
            foreach (Card c in h)
            {
                ans = ans + c.ToString() + "\n";
            }
            return ans;
		}
	}
}
