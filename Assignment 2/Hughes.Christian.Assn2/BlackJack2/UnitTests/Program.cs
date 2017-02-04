//Author: Christian Hughes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack2;
using CardConcepts;

namespace UnitTests
{
    //The main class for performing unit tests.
    class Program
    {
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

        static void TestHuman()
        {
            Console.WriteLine("Tests for the Human class:\n");
            Human Christian = new Human("Christian");
            Console.WriteLine("Output Window with 'Christian' as banner should have popped up.");
            Deck d = new Deck();

            //Test getCard() and showHand().
            Christian.getsCard(d.deal());
            Christian.getsCard(d.deal());
            Console.WriteLine("Current Hand after having been dealt two cards: \n");
            Hand h = Christian.showHand();
            Console.WriteLine(h.ToString());

            //Tests outcomeOfRound()
            Console.WriteLine("Test a win by pressing enter.");
            Console.ReadLine();
            Christian.outcomeOfRound(Outcome.Win);
            Console.WriteLine("Sucsess.");

            //Tests wantsCard()
            Console.WriteLine("Test wantsCard() by pressing enter.");
            Console.ReadLine();
            Christian.wantsCard();
            Console.WriteLine("Success.\n");
        }

        static void TestAndroid()
        {
            Console.WriteLine("Tests for the Android class:\n");
            Android c3po = new Android("c3po");
            Console.WriteLine("Output Window with 'c3po' as banner should have popped up.");
            Deck d = new Deck();

            //Test getCard() and showHand().
            c3po.getsCard(d.deal());
            c3po.getsCard(d.deal());
            Console.WriteLine("Current Hand after having been dealt two cards: \n");
            Hand h = c3po.showHand();
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

        static void TestDealer()
        {
            Console.WriteLine("Tests for the Dealer Class");
            List<Player> guests = new List<Player>();
            Human George = new Human("George");
            Android r2d2 = new Android("r2d2");
            guests.Add(George);

            Dealer d = new Dealer(guests, r2d2);

            Console.WriteLine("Press enter to play through a game with one android house player, and one human guest player.");
            Console.WriteLine("This is the last test. It will never end, as the game goes on forever (in true casino style).");
            Console.WriteLine("Please exit out of the console when you are ready to quit.");
        }
    }
}
