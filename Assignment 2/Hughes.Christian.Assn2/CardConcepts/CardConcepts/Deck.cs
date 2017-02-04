using System;
using System.Collections.Generic;
using System.Text;

namespace CardConcepts
{
    //A class for constructing a deck of cards.
	public class Deck
	{
        /// <summary>
        /// The list of cards that are still in the deck.
        /// </summary>
		private List<Card> d;

        /// <summary>
        /// The list of cards that have been discarded durring play.
        /// </summary>
		private List<Card> discards;

        /// <summary>
        /// Random number generator used to select a card from the deck. NOT INITALLY IN CLASS DIAGRAM.
        /// </summary>
        private Random R = new Random();

        /// <summary>
        /// A constructor that adds 52 cards (of all required suits and values) to the deck.
        /// </summary>
		public Deck()
		{
            d = new List<Card>();
            discards = new List<Card>();
            // generate all combinations of Suits and Counts:
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Count c in Enum.GetValues(typeof(Count)))
                {
                    d.Add(new Card(c, s));
                }
            }
		}

        /// <summary>
        /// Adds old cards to the discard pile.
        /// </summary>
        /// <param name="dis">The hands to be added to collected.</param>
		public void acceptDiscards(List<Card> dis)
		{
            foreach (Card c in dis)
            {
                discards.Add(c);
            }
		}

        /// <summary>
        /// Deals a card from the deck, and reshuffles the discard pile to form a new deck should the inital deck be empty. 
        /// </summary>
        /// <returns>A random card from the deck (simulates the top card, essentially).</returns>
		public Card deal()
		{
            if (d.Count > 0)
            {
                int index = R.Next(0, d.Count);
                Card ans = d[index];
                d.RemoveAt(index);
                return ans;
            }
            else
            {
                //Move cards from the discard pile back into the deck.
                while (discards.Count > 0)
                {
                    int index = discards.Count - 1;
                    Card current = discards[index];
                    d.Add(current);
                    discards.RemoveAt(index);
                }
                //In the console version of the program, the below line would alert the user that the cards had been reshufled.
                //Console.WriteLine("(The original deck ran out! The discarded cards have been shuffled, and will become the new deck.)");
                return deal();
            }
		}
	}
}
