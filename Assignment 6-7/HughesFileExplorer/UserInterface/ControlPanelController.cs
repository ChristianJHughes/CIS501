using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystem;
using FileSystemController;
using System.Windows.Forms;

namespace UserInterface
{
    //The controller for the ControlPanelForm. Ultimately handles all click events. 
    public class ControlPanelController
    {
        //A handle to the File Controller of the entire system.
        private FileSystemContoller fileController;

        //A list of all of the DirectoryForms that are currently in use.
        private List<DirectoryForm> directoryFormOpen;
        
        //A registry containging Observers - used for updating the visuals of all the forms currently in use.
        private List<Observer> registry;

        //A list of all of the edit forms that are currently in use.
        private List<EditForm> editFormsOpen;

        //Gets the handle to the systems file controller, as well as all of the other objects used by this class. 
        public ControlPanelController(FileSystemContoller fileController)
        {
            this.fileController = fileController;
            directoryFormOpen = new List<DirectoryForm>();
        }

        /// <summary>
        /// Creates/shows a new directory form, and then adds it to the list of open directory forms. 
        /// </summary>
        public void handleNewDirectoryForm()
        {
            DirectoryFormController dController = new DirectoryFormController(fileController);
            DirectoryForm dForm = new DirectoryForm(dController);
            directoryFormOpen.Add(dForm);
            dForm.Show();
        }

        public void closeDirectoryForm(DirectoryForm dForm)
        {
             throw new NotImplementedException();
        }

        public void CloseEditForm(EditForm eForm)
        {
            throw new NotImplementedException();
        }

        public void acknowledgeNewEditForm(EditForm eForm)
        {
            throw new NotImplementedException();
        }

        public void handleCloseAllForms()
        {
            MessageBox.Show("Not yet implemented.", "Sorry");
        }

        public void register(Observer f)
        {
            throw new NotImplementedException();
        }

        public void handleUpdatingAllDirectoryForms()
        {
            throw new NotImplementedException();
        }
    }
}
