using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystem;
using FileSystemController;

namespace UserInterface
{
    public partial class ControlPanelForm : Form
    {
        //Retains a handle to the controller for this form (of which there is only one).
        private ControlPanelController cController;

        //Constructs a Control Panel, and passes to it its controller.
        public ControlPanelForm(ControlPanelController cController)
        {
            this.cController = cController;
            InitializeComponent();
        }

        /// <summary>
        /// The click event for the open button that is on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenButton_Click(object sender, EventArgs e)
        {
            cController.handleNewDirectoryForm();
        }

        /// <summary>
        /// Handles the click event for the Close all button on the form. This button closes all of the forms currently in use CLEANLY.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCloseAllButton_Click(object sender, EventArgs e)
        {
            cController.handleCloseAllForms();
        }
    }
}
