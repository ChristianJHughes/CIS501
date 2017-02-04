/* UnitTests: Program.cs
 * Original Author: David Schmidt
 * Modified By: Christian J. Hughes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardConcepts;  // ADD ME and remember to "Add Reference" CardConcepts

namespace UnitTests {
  class Program {

      // executes unit tests of the classes in CardConcepts
      public static void Main()
      {
          try
          {
              testCard();
              // insert more test cases here...
              testHand();
              testDeck();
          }
          catch (Exception ex)
          {
              Console.WriteLine("Test cases aborted due to error");
              Console.WriteLine(ex.Message);
          }
          Console.ReadLine();
      }


      //Executes a unit test of class Card.
      static void testCard()
      {
          Console.WriteLine("Test Card:");
          Card c1 = new Card(Count.Ace, Suit.Hearts);
          Console.WriteLine("Card {0} has value {1}",
                            c1.ToString(), c1.BJvalue());
      }

      //Excecutes a unit test of class Deck.
      static void testDeck()
      {
          //Creates a deck and prints out the first 20 cards dealt.
          Console.WriteLine("\nTest Deck:");
          Deck deck = new Deck();
          for (int i = 0; i < 20; i++)
          {
              Card newcard = deck.deal();
              Console.WriteLine(newcard.ToString());
          }
          Console.WriteLine();

          //Test the collectCardsFromPlayers method, and print out the discard pile.
          Hand newHand = new Hand();
          for (int i = 0; i < 3; i++)
          {
              newHand.add(deck.deal());
          }
          deck.collectCardsFromPlayers(newHand.giveCardsBackToDealer());
          Console.WriteLine("Test collecting cards from players/adding cards to discard pile: ");
          foreach (Card c in deck.discardPile)
          {
              Console.WriteLine(c.ToString());
          }
          Console.WriteLine("(The above cards were sucsessfully dealt, and recieved by the dealer, and added to the discard pile.)");
      }

      //Excecutes a unit test of class Hand.
      static void testHand()
      {
          Console.WriteLine("\nTest Hand:");
          Deck deck = new Deck();
          Hand currentHand = new Hand();


          for (int i = 0; i < 2; i++)
          {
              currentHand.add(deck.deal());
          }
          Console.WriteLine(currentHand.ToString());

          //Test the hand score.
          
          Console.WriteLine("\nTest Hand Score:");
          Console.WriteLine(currentHand.BJscore());

          //Test for the first card Dealt.
          Console.WriteLine("\nTest first card dealt:");
          Console.WriteLine(currentHand.firstCardDealt().ToString());

          //Test for giving cards back to dealer.
          Console.WriteLine("\nTest Giving cards to dealer (end of round action): ");
          foreach (Card c in currentHand.giveCardsBackToDealer())
          {
              Console.WriteLine(c.ToString());
          }
          Console.WriteLine("(The above cards have been sucsessfully returned to the dealer.)");

          //NO TEST FOR THE REMOVE METHOD, AS IT IS NOT USED IN MY PROGRAM
      }


  }
}
