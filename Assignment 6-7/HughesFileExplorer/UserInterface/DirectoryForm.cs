using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    /// <summary>
    /// The DirectoryForm class is in charge of displaying new Directory Forms. These display folder contents at the request of the user. 
    /// </summary>
    public partial class DirectoryForm : Form
    {
        //Retains a handle to its contorller.
        private DirectoryFormController dController;

        /// <summary>
        /// The constructor gets the controller for the form, and loads in the contents of the root folder. 
        /// </summary>
        /// <param name="dController">The controller for the form.</param>
        public DirectoryForm(DirectoryFormController dController)
        {
            this.dController = dController;
            InitializeComponent();

            //Update the contents of the List Box with the Root Folder Contents.
            uxDirectoryBox.Items.Clear();
            List<string> namesInFolder = this.dController.returnFolderContents("Root");
            foreach (String s in namesInFolder)
            {
                uxDirectoryBox.Items.Add(s);
            }
        }

        /// <summary>
        /// The click event for the open button on the form. Either opens a textfile with an edit window...
        /// or opens the next folder layer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenButton_Click(object sender, EventArgs e)
        {
            //If it is a textfile (has a .txt extension)...
            if (uxDirectoryBox.SelectedItem.ToString().Contains("."))
            {
                dController.handleOpenTextFile(uxDirectoryBox.SelectedItem.ToString());
            }
            //else it is a folder...
            else
            {
                updateEntryList();
            }
        }

        /// <summary>
        /// Asks the controller for the contents of the folder selected, and updates the form accordingly. 
        /// </summary>
        private void updateEntryList()
        {
            List<string> namesInFolder = new List<string>();
            namesInFolder = this.dController.returnFolderContents(uxDirectoryBox.SelectedItem.ToString());
            uxFolderStatusLabel.Text = "Folder: " + uxDirectoryBox.SelectedItem.ToString();
            uxDirectoryBox.Items.Clear();
            foreach (String s in namesInFolder)
            {
                uxDirectoryBox.Items.Add(s);
            }
        }

        /// <summary>
        /// The click event for the new file button, which allows the user to add new files to the directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewFileButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Sorry");
        }

        /// <summary>
        /// The click event for the delete button, which allows the user to delete files from the directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Sorry");
        }

        /// <summary>
        /// The click event for the New Folder Button. Adds a new folder to the directory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewFolderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.", "Sorry");
        }

    }
}
