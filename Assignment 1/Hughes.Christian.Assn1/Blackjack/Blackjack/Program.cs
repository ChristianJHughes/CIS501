/* Blackjack: Program.cs
 * 
 * Author: Christian J. Hughes
 * Section: CIS 501 Tu/Th 1 PM
 * Professor: David Schmidt
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardConcepts;

namespace Blackjack
{
    class Program
    {
        //Begins with the assuption that the player would like to play.
        public static string wantsToPlay = "y";

        //Initially no rounds are played.
        public static int round = 0;

        //Intially the player has no wins.
        public static int wins = 0;

        //Iniitally neither player has busted.
        public static bool guestBusted = false;
        public static bool houseBusted = false;

        //The pile of cards that have already been used. 
        public static List<Card> discardPile = new List<Card>();

        /// <summary>
        /// Main method creates deck, welcomes the player, and continually starts rounds of Blackjack until the 
        /// player decides that they'd like to quit.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //A new deck is created when the application is launched.
            Deck deck = new Deck();

            Console.WriteLine("Welcome to Blackjack!");
            
            //While the player still wants to play Blackjack, new rounds will begin.
            while (wantsToPlay.CompareTo("y") == 0)
            {
                    RoundOfBlackjack(deck);    
            }

            //Should the player decide say 'n' (no) to more rounds of blackjack, the application...
            //will prepare for an exit state.
            Console.WriteLine("\nThank you for playing Blackjack by Christian Hughes!\nJust hit enter to exit.");
            Console.ReadLine();

        }

        /// <summary>
        /// A method containing commands necessary to complete one round of blackjack.
        /// This method, along with the methods that it calls, determine the win/loss/tie
        /// state of the player.
        /// </summary>
        /// <param name="d">The deck being used for the current game.</param>
        public static void RoundOfBlackjack(Deck d)
        {
            //A new round begins. Neither player has busted, as no cards have been dealt.
            Console.WriteLine("\nNew Round:");
            round++;
            guestBusted = false;
            houseBusted = false;
            
            //Creates Hands for the guest and the member of the house.
            Hand guestHand = new Hand();
            Hand houseHand = new Hand();

            //Each Player is dealt two cards from the deck into their hands.
            guestHand.add(d.deal());
            guestHand.add(d.deal());
            houseHand.add(d.deal());
            houseHand.add(d.deal());


            //Reveal the top cards of each player.
            Console.WriteLine("Your top card is: " + guestHand.firstCardDealt().ToString());
            Console.WriteLine("The house player's top card is: " + houseHand.firstCardDealt().ToString());

            //Check to see if the house player was dealt a blackjack.
            if (houseHand.BJscore() == 21)
            {
                Console.WriteLine("The house player holds a blackjack! The round is over.\n");
                Console.WriteLine("You lose!");
                Console.WriteLine("After " + round + " rounds, you have " + wins + " wins.");
                playersGiveTheirCardsBack(guestHand, houseHand, d);
                anotherRound();
                return;
            }
            else
            {
                Console.WriteLine("The house player does NOT hold a blackjack, so play continues:\n");
            }
            
            //Look at the player's hand.
            Console.WriteLine("Your hand is:");
            Console.Write(guestHand.ToString());
            Console.WriteLine("The score is: " + guestHand.BJscore());

            //Check to see if the player was dealt blackjack...
            if (guestHand.BJscore() == 21)
            {
                Console.WriteLine("Wowzers! You were dealt blackjack, lucky you!\nYou win!\n");
                playersGiveTheirCardsBack(guestHand, houseHand, d);
                wins++;
                printStats();
                anotherRound();
                return;
            }

            //At this point, neither player has gotten blackjack. Thus cards are now dealt out 
            //to the guest player at theier discretion. The round ends if the human player busts.
            guestTurn(guestHand, houseHand, d);
            if (guestBusted == true)
            {
                return;
            }
            

            //Once the human player is done, the computerized "house" hand will aquire cards. Will end the round if the computer busts.
            housesTurn(houseHand, guestHand, d);
            if (houseBusted == true)
            {
                return;
            }

            //Check for a tie.
            if (guestHand.BJscore() == houseHand.BJscore())
            {
                Console.WriteLine("\nThe round ends in a tie!");
                playersGiveTheirCardsBack(guestHand, houseHand, d);
                printStats();
                anotherRound();
            }
            //Otherwise, check for a win.
            else if (guestHand.BJscore() > houseHand.BJscore())
            {
                Console.WriteLine("\nYou Win!");
                playersGiveTheirCardsBack(guestHand ,houseHand, d);
                wins++;
                printStats();
                anotherRound();
            }
            //Otherwise check for a loss.
            else
            {
                Console.WriteLine("\nYou Lose!");
                printStats();
                playersGiveTheirCardsBack(guestHand, houseHand, d);
                anotherRound();
            }

        }

        /// <summary>
        /// This method asks the player if they would like to begin another round.
        /// Basic error checking has been implemented should the player enter invalid input.
        /// </summary>
        public static void anotherRound()
        {
            Console.Write("Do you want to play another round (y or n)? ");
            string answer = Console.ReadLine();

            if (answer.CompareTo("y") != 0 && answer.CompareTo("n") != 0)
            {
                Console.WriteLine("Invalid Input, please type 'y' or 'n'.");
                anotherRound();
            }
            else
            {
                wantsToPlay = answer;
            }
        }

        /// <summary>
        /// This method handles the guest players turn, prompting them for more cards, and doing 
        /// basic error handling should there be invalid input. It will return immediatly should the 
        /// guest player reach 21. It determines whether or not the player busted.
        /// </summary>
        /// <param name="guestHand">The guest's hand.</param>
        /// <param name="houseHand">The house players hand.</param>
        /// <param name="d">The deck in play for the current game session.</param>
        public static void guestTurn(Hand guestHand, Hand houseHand, Deck d)
        {
            Console.Write("Do you want another card (y or n)? ");
            string answer = Console.ReadLine();
            if (answer.CompareTo("y") != 0 && answer.CompareTo("n") != 0)
            {
                Console.WriteLine("Invalid Input, please type 'y' or 'n'.");
                guestTurn(guestHand, houseHand, d);
            }
            else
            {
                if (answer.CompareTo("y") == 0)
                {
                    guestHand.add(d.deal());
                    Console.WriteLine("Your hand is: ");
                    Console.Write(guestHand.ToString());
                    Console.WriteLine("The score is: " + guestHand.BJscore());

                    if (guestHand.BJscore() == 21)
                    {
                        Console.WriteLine();
                        return;
                    }
                    else if (guestHand.BJscore() > 21)
                    {
                        Console.WriteLine("A bust!\n\nYou lose!");
                        playersGiveTheirCardsBack(guestHand, houseHand, d);
                        printStats();
                        anotherRound();
                        guestBusted = true;
                    }
                    else
                    {
                        guestTurn(guestHand, houseHand, d);
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// This method handles the house player's turn (which occurs after the guest player's turn).
        /// The house player will continue to accept cards if the current value of the hand is less
        /// than 17. It will keep track of whether or not the house player busts.
        /// </summary>
        /// <param name="houseHand">The house player's hand.</param>
        /// <param name="guestHand">The guest player's hand.</param>
        /// <param name="d">The deck in play for the current play session.</param>
        public static void housesTurn(Hand houseHand, Hand guestHand, Deck d)
        {
            while (houseHand.BJscore() <= 21)
            {
                Console.WriteLine("The house player's hand is: ");
                Console.WriteLine(houseHand.ToString() + "The score is " + houseHand.BJscore());

                if (houseHand.BJscore() < 17)
                {
                    houseHand.add(d.deal());
                }
                else
                {
                    return;
                }
            }
            Console.WriteLine("The house player's hand is: ");
            Console.WriteLine(houseHand.ToString() + "The score is " + houseHand.BJscore());
            Console.WriteLine("A bust!\n\nYou win!");
            playersGiveTheirCardsBack(guestHand, houseHand, d);
            wins++;
            printStats();
            anotherRound();
            houseBusted = true;
        }

        /// <summary>
        /// Prints the win and round statistics for the current game session.
        /// </summary>
        public static void printStats()
        {
            Console.WriteLine("After " + round + " rounds, you have " + wins + " win(s).");
        }

        /// <summary>
        /// This method returns the hands of the guest player/house player to the Dealer's 
        /// discard pile. It is done at the end of every sucsessful round or bust. 
        /// </summary>
        /// <param name="guestHand">The guest's current hand.</param>
        /// <param name="houseHand">That house's current hand.</param>
        /// <param name="d">The deck being used.</param>
        public static void playersGiveTheirCardsBack(Hand guestHand, Hand houseHand, Deck d)
        {
            d.collectCardsFromPlayers(guestHand.giveCardsBackToDealer());
            d.collectCardsFromPlayers(houseHand.giveCardsBackToDealer());
        }
    }
}
