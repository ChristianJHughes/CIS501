using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardConcepts;
using Blackjack3;

namespace UnitTests
{
    /// <summary>
    /// The point of entry for the UnitTests.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method for Unit Tests. Runs all of the individual unit tests. 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit Tests:\n");
            try
            {
                TestHuman();
                TestAndroid();
                TestDealer();
                Console.WriteLine("All unit testing completed sucsessfully. Press enter to exit.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test cases were aborted due to error.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Runs unit tests for the Human class.
        /// </summary>
        static void TestHuman()
        {
            Hand h = new Hand();
            Console.WriteLine("Tests for the Human class:\n");
            Human Christian = new Human("Christian", h);
            //Console.WriteLine("Output Window with 'Christian' as banner should have popped up."); //Not Applicable in Blackjack3
            Deck d = new Deck();

            //Test getCard() and showHand().
            Christian.getsCard(d.deal());
            Christian.getsCard(d.deal());
            Console.WriteLine("Current Hand after having been dealt two cards: \n");
            h = Christian.showHand();
            Console.WriteLine(h.ToString());

            //Tests outcomeOfRound()
            Console.WriteLine("Test a win by pressing enter.");
            Console.ReadLine();
            Christian.outcomeOfRound(Outcome.Win);
            Console.WriteLine("Sucsess.");

            //Tests wantsCard() NOT USED IN Blackjack3
            Console.WriteLine("Test wantsCard() by pressing enter.");
            Console.ReadLine();
            Christian.wantsCard();
            Console.WriteLine("Success.\n");
        }

        /// <summary>
        /// Runs unit tests for the Android class.
        /// </summary>
        static void TestAndroid()
        {
            Hand h = new Hand();
            Console.WriteLine("Tests for the Android class:\n");
            Android c3po = new Android("c3po", h);
            //Console.WriteLine("Output Window with 'c3po' as banner should have popped up."); //Not applicable in Blackjack3
            Deck d = new Deck();

            //Test getCard() and showHand().
            c3po.getsCard(d.deal());
            c3po.getsCard(d.deal());
            Console.WriteLine("Current Hand after having been dealt two cards: \n");
            h = c3po.showHand();
            Console.WriteLine(h.ToString());

            //Tests outcomeOfRound()
            Console.WriteLine("Test a win by pressing enter.");
            Console.ReadLine();
            c3po.outcomeOfRound(Outcome.Win);
            Console.WriteLine("Sucsess.");

            //Tests wantsCard()
            Console.WriteLine("Test wantsCard() by pressing enter.");
            Console.ReadLine();
            c3po.wantsCard();
            Console.WriteLine("Success.\n");
        }

        /// <summary>
        /// Runs unit tests for the Dealer class.
        /// </summary>
        static void TestDealer()
        {
            Hand h1 = new Hand();
            Hand h2 = new Hand();
            Deck d = new Deck();

            Console.WriteLine("Tests for the Dealer Class");
            List<Player> guests = new List<Player>();
            Human George = new Human("George", h1);
            Android r2d2 = new Android("r2d2", h2);
            guests.Add(George);

            Dealer dealer = new Dealer(guests, r2d2, d);

            Console.WriteLine("Test number of Rounds: " + dealer.numberOfRounds() + "\n(Should display 0)");
            Console.WriteLine("Test number of wins: " + dealer.numberOfWins() + "\n(Should display 0)");
            Console.WriteLine("Test game status: " + dealer.gameStatus() + "\n(Should display status)");

            Console.WriteLine("This concludes all of the unit test that don't require use of the forms.");
            Console.WriteLine("If this point has been reached, then all tests have been completed sucsessfully.");
            Console.WriteLine("Please press enter when you are ready to quit.");
        }
    }
}
