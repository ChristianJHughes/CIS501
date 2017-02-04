//Author: Christian Hughes

using System;
using System.Collections.Generic;
using System.Text;
using CardConcepts;

namespace BlackJack2
{
	public interface Player
	{
		bool wantsCard();

		void getsCard(Card c);

		Hand showHand();

		void outcomeOfRound(Outcome result);
	}
}
