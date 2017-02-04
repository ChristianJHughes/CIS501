//Author: Christian Hughes

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

namespace BlackJack2
{
    //Class constructs an instance of a Passive form for displaying Blackjack information.
    public partial class OutputForm : Form
    {
        // coordinates for upper left corner of the visible passive form:
        static int xPosition = 0;
        static int yPosition = 0;

        //Constructor that initailizes the form.
        public OutputForm()
        {
            InitializeComponent();
        }

        //Ensures that new instances of the output form are not overlaping each other. 
        private void OutputForm_Load(object sender, EventArgs e)
        {
            //Set location of where to display the new passive form:
            this.Location = new Point(xPosition, yPosition);
            //Update position coordinates for the next time a passive form is created:
            xPosition = xPosition + this.Width;
            yPosition = yPosition + 50;
            topCardLabel.Text = "(Top Card)";
            resultsLabel.Text = "N/A";
        }

        /// <summary>
        /// Updates the list of cards on the from.
        /// </summary>
        /// <param name="s">A string of the cards to be accepted.</param>
        public void UpdateCards(Hand h)
        {
            currentHandLabel.Text = "" + h.ToString();
            Refresh();
        }

        /// <summary>
        /// Updates the Blackjack score on the form.
        /// </summary>
        /// <param name="h">The hand to be scored.</param>
        public void UpdateScore(Hand h)
        {
            scoreLabel.Text = "" + h.BJscore();
            Refresh();
        }

        
        /// <summary>
        /// Updates the Blackjack statistics on the form.
        /// </summary>
        /// <param name="wins">Number of wins.</param>
        /// <param name="rounds">Number of rounds.</param>
        public void UpdateStats(int wins, int rounds)
        {
            statsLabel.Text = wins + " win(s) after " + rounds + " round(s).";
            Refresh();
        }

        /// <summary>
        /// Changes the score to a question mark. To be used when an Android Player is only revealing the top card.
        /// </summary>
        public void ChangeScoreToQuestionMark()
        {
            scoreLabel.Text = "?";
            Refresh();
        }

        /// <summary>
        /// Updates the result of the round (Win or Not Win).
        /// </summary>
        /// <param name="o"></param>
        public void UpdateResult(Outcome o)
        {
            if (o == Outcome.Win)
            {
                resultsLabel.Text = "Win";
            }
            else
            {
                resultsLabel.Text = "Not Win";
            }
        }

        /// <summary>
        /// Resets the result label back to "N/A".
        /// </summary>
        public void resetResult()
        {
            resultsLabel.Text = "N/A";
        }
    }
}
