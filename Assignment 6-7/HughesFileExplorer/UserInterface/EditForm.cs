using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystemController;
using FileSystem;

namespace UserInterface
{
    public partial class EditForm : Form
    {
        //A handle to the current text file in use.
        TextFile workingTextFile;

        //Constructor initialized relevant objects. 
        public EditForm(TextFile textContents)
        {
            //Assign the text file that is passed in. 
            workingTextFile = textContents;

            //Initialize component, as is required with every form. 
            InitializeComponent();

            //Update the label to display the correct name.
            uxFileNameLabel.Text = workingTextFile.Name;

            //Adjusts the view so that the lines in the textbox represent those in the text file.
            string[] lines = new string[workingTextFile.Lines.Count];
            int count = 0;
            foreach (string s in workingTextFile.Lines)
            {
                lines[count] = s;
                count++;
            }
            uxFileContentsTextBox.Lines = lines; 
        }

        /// <summary>
        /// The click event for the save button. Saves the edited textfile to the entry in question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveButton_Click(object sender, EventArgs e)
        {
            //WE need to take the Lines property of the text box (which hosts string[])...
            //, and convert it into a List<string> to be saved back to the text file.
            string[] lines = new string[uxFileContentsTextBox.Lines.Length];
            List<string> newTextFile = new List<string>();
            int count = 0;
            lines = uxFileContentsTextBox.Lines;

            while (count < lines.Length)
            {
                newTextFile.Add(lines[count]);
                count++;
            }
            workingTextFile.Lines = newTextFile;

        }

        /// <summary>
        /// The click event for the exit button. Literally just closes the form. Not very much fun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
