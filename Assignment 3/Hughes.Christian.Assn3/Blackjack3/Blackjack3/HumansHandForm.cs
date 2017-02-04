using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardConcepts;

namespace Blackjack3
{
    /// <summary>
    /// Constructs a Form with the Human's Hand, along with the necessary buttons to interact with the system.
    /// </summary>
    public partial class HumansHandForm : Form
    {
        //Delegate declarations of methods to be passed in by the controller (The dealer, in this case).
        InputHandler newRoundMethod;
        InputHandler anotherCardMethod;
        InputHandler holdCardsMethod;

        //Creates a handle to the human's hand.
        Hand human;

        //Creates a handle to the House's Hand (So the form can be updated should the house player be dealt blackjack).
        Hand house;

        /// <summary>
        /// Constructor initalizes the hand text to an empty string, along with assigning the fields below. 
        /// </summary>
        /// <param name="newRoundMethod">Method for starting a new round.</param>
        /// <param name="anotherCardMethod">Method for receiving another card from the dealer.</param>
        /// <param name="holdCardsMethod">Method for keeping the cards already in the hand, and passing the round on to the next player.</param>
        /// <param name="human">The Human player's hand.</param>
        public HumansHandForm(InputHandler newRoundMethod, InputHandler anotherCardMethod, InputHandler holdCardsMethod, Hand human, Hand house)
        {
            InitializeComponent();
            this.newRoundMethod = newRoundMethod;
            this.anotherCardMethod = anotherCardMethod;
            this.holdCardsMethod = holdCardsMethod;
            this.human = human;
            this.house = house;
            uxHandLabel.Text = "(No cards in hand)";
            uxAddAnotherCardButton.Enabled = false;
            uxHoldCardsButton.Enabled = false;
            uxStaticTopCardLabel.Visible = false;
        }

        /// <summary>
        /// The click event for starting a new round.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewRoundButton_Click(object sender, EventArgs e)
        {
            newRoundMethod(sender, e);
            uxNewRoundButton.Enabled = false;
            uxAddAnotherCardButton.Enabled = true;
            uxHoldCardsButton.Enabled = true;
            uxStaticTopCardLabel.Visible = true;

            if (human.BJscore() == 0 || house.BJscore() == 0)
            {
                uxNewRoundButton.Enabled = true;
                uxAddAnotherCardButton.Enabled = false;
                uxHoldCardsButton.Enabled = false;
            }
        }

        /// <summary>
        /// The click event for recieving another card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddAnotherCardButton_Click(object sender, EventArgs e)
        {
            uxStaticTopCardLabel.Visible = true;
            anotherCardMethod(sender, e);

            if (human.BJscore() >= 21)
            {
                uxAddAnotherCardButton.Enabled = false;
                uxHoldCardsButton.Enabled = false;
                uxNewRoundButton.Enabled = true;
                holdCardsMethod(sender, e);
            }
        }

        /// <summary>
        /// The click event for holding the cards in the current hand. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxHoldCardsButton_Click(object sender, EventArgs e)
        {
            holdCardsMethod(sender, e);

            uxAddAnotherCardButton.Enabled = false;
            uxHoldCardsButton.Enabled = false;
            uxNewRoundButton.Enabled = true;
        }

        /// <summary>
        /// Prints the Human's hand to the form.
        /// </summary>
        public void showhand()
        {
            uxHandLabel.Text = human.ToString();
            Refresh();
        }

        /// <summary>
        /// Handles the loading of the form. Places the instance of this form in the upper left corner of the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HumansHandForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
