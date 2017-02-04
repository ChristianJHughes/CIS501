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
    /// Creates a scoreboard form that diplays the Human Player's score, wins, and the current round/game status.
    /// </summary>
    public partial class Scoreboard : Form
    {
        //A handle to the Human player's hand.
        Hand h;

        //Delegate declarations of methods to be passed in by the controller (The dealer, in this case).
        ObserverInt wins;
        ObserverInt rounds;
        ObserverString status;

        /// <summary>
        /// Constructs the inital view for the Scoreboard form.
        /// </summary>
        /// <param name="h">The Human Player's hand.</param>
        /// <param name="wins">The Human Player's wins.</param>
        /// <param name="rounds">A method that returns the number of rounds played.</param>
        /// <param name="status">A method that returns the game status in string format.</param>
        public Scoreboard(Hand h, ObserverInt wins, ObserverInt rounds, ObserverString status)
        {
            this.h = h;
            this.wins = wins;
            this.rounds = rounds;
            this.status = status;
            InitializeComponent();
        }

        /// <summary>
        /// Updates the score on the scoreboard to the score of the human players hand.
        /// </summary>
        public void updateScore()
        {
            uxScoreLabel.Text = "" + h.BJscore();
            Refresh();
        }

        /// <summary>
        /// Updates the Human Player's wins on the form.
        /// </summary>
        public void updateWins()
        {
            uxWinsLabel.Text = "" + wins();
            Refresh();
        }

        /// <summary>
        /// Updates the number of rounds played on the form.
        /// </summary>
        public void updateRounds()
        {
            uxRoundsPlayedLabel.Text = "" + rounds();
            Refresh();
        }

        /// <summary>
        /// Updates the game status on the form.
        /// </summary>
        public void updateStatus()
        {
            uxStatusLabel.Text = status();
            Refresh();
        }

        /// <summary>
        /// Loads the Scoreboard form, and places it in between the HumanHandForm and the HouseHandForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scoreboard_Load(object sender, EventArgs e)
        {
            this.Location = new Point(340, 50);
        }
    }
}
