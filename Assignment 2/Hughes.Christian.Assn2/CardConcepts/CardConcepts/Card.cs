using System;
using System.Collections.Generic;
using System.Text;

namespace CardConcepts
{
    //Class for constructing a playing card.
	public class Card
	{
        //The count of the playing card.
		public Count count;
        //The suit of the playing card.
		public Suit suit;

        //Constructs a new card based on given parameters.
        public Card(Count a, Suit b)
        {
            count = a; suit = b;
        }

        //Returns the int value of a card in Blackjack.
		public int BJvalue()
		{
            int i = (int)count + 1;
            if (i > 10) { i = 10; }
            return i;
		}

        //Returns the string value of a card.
		public string ToString()
		{
            return count + " of " + suit;
		}
	}
}
