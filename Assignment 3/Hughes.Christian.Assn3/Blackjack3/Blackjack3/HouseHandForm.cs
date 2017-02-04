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
    /// Creates a form where the House Player's hand is displayed. ONLY the cards in the hand are displayed, not its associated score.
    /// </summary>
    public partial class HouseHandForm : Form
    {
        //A handle to the House Player's Hand.
        Hand h;

        /// <summary>
        /// A constructor for the form that sets up its inital state. 
        /// </summary>
        /// <param name="h">The house player's hand.</param>
        public HouseHandForm(Hand h)
        {
            InitializeComponent();
            uxHousePlayersHandLabel.Text = "(No cards in hand)";
            uxStaticTopCardLabel.Visible = false;
            this.h = h;
        }

        /// <summary>
        /// Prints the contents of the House Player's hand to the form.
        /// </summary>
        public void updateHand()
        {
            uxStaticTopCardLabel.Visible = true;
            uxHousePlayersHandLabel.Text = h.ToString();
            Refresh();
        }

        /// <summary>
        /// Loads the form, and puts it in place on the screen to the right of the Scoreboard form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HouseHandForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(629, 100);
        }
    }
}
