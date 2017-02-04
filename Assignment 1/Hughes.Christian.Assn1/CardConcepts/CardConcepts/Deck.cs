using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardConcepts {

  // class for constructing a deck of cards
  public class Deck {

    private List<Card> d;  // the list of cards still in the deck
    public List<Card> discardPile = new List<Card>(); //The list of cards discarded durring play.

    // random number generator used to select a random card from the deck:
    private Random R = new Random();

    public Deck() {
      d = new List<Card>();
      // generate all combinations of Suits and Counts:
      foreach (Suit s in Enum.GetValues(typeof(Suit))) {
        foreach (Count c in Enum.GetValues(typeof(Count))) {
          d.Add(new Card(c, s));
        }
      }
    }

    // returns a card randomly selected and removed from the deck
    public Card deal() {
      if (d.Count > 0) {
        int index = R.Next(0, d.Count);
        Card ans = d[index];
        d.RemoveAt(index);
        return ans;
      }
      else 
      {
          //Move cards from the discard pile back into the deck.
          while (discardPile.Count > 0)
          {
              int index = discardPile.Count - 1;
              Card current = discardPile[index];
              d.Add(current);
              discardPile.RemoveAt(index);
          }
          Console.WriteLine("(The original deck ran out! The discarded cards have been shuffled, and will become the new deck.)");
          return deal();
      }
    }

      public void collectCardsFromPlayers(List<Card> oldHands)
      {
          foreach (Card c in oldHands)
          {
              discardPile.Add(c);
          }

      }
  }
}
