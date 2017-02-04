using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardConcepts {

  // class for constructing a player's hand of cards
  public class Hand {

    private List<Card> h;  // the cards in the hand

    public Hand() { h = new List<Card>(); }

    // adds Card c to the hand
    public void add(Card c) { h.Add(c); }

    // removes the Card with Suit s and Count c from the hand (if it's there).
    // returns whether or not the card was found and successfully removed
    public bool remove(Count c, Suit s) {
      bool ok = false;
      foreach (Card cd in h) {
        if (cd.count == c && cd.suit == s) {
          h.Remove(cd); ok = true;
          break;
        }
      }
      return ok;
    }

    // returns the count of how many cards are in the hand
    public int howManyCards() { return h.Count; }

    // returns the Blackjack score of the hand
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
   

    // returns a string that lists the cards in the hand
    public override string ToString() {
      string ans = "";
      foreach (Card c in h) {
        ans = ans + c.ToString() + "\n";
      }
      return ans;
    }

      /// <summary>
      /// Returns the first card dealt.
      /// </summary>
      /// <returns>A card object of the first card dealt.</returns>
      public Card firstCardDealt()
      {
          return h[0];
      }

      public List<Card> giveCardsBackToDealer()
      {
          List<Card> discardHand = new List<Card>();

          foreach (Card c in h)
          {
              discardHand.Add(c);
          }
          return discardHand;
      }

  }
}
