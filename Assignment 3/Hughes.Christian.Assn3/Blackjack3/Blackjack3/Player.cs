using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardConcepts;

namespace Blackjack3
{
    /// <summary>
    /// An Interface defining the necessary methods for an instantiation of Player.
    /// </summary>
    public interface Player
    {
         bool wantsCard();

         void getsCard(Card c);

         Hand showHand();

         void outcomeOfRound(Outcome result);
        
    }
}
