using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystem;
using FileSystemController;

namespace UserInterface
{
    public class DirectoryFormController
    {
        //Retains a handle to the single FileSystemController that is running in the application.
        private FileSystemContoller fileController;

        //Keeps track of the folder that the DirectoryForm is currently dealing with.
        private Folder folderWeAreIn;
        
        /// <summary>
        /// Constructor for the Controller. It gets a file to the FileSystemController, and assigns the folder we are in to Root initally.
        /// </summary>
        /// <param name="fileController">A handle to the fileController for the application.</param>
        public DirectoryFormController(FileSystemContoller fileController)
        {
            this.fileController = fileController;

            //The FolderWeAreIn field will be set to the root by default.
            folderWeAreIn = fileController.returnCurrentFileSystem();
        }

        /// <summary>
        /// Handles opening a textfile by opening a new edit window with its contents. 
        /// </summary>
        /// <param name="textFileName">The name of the textfile to be opened in an edit window.</param>
        public void handleOpenTextFile(string textFileName)
        {
            EditForm eForm = new EditForm((TextFile)folderWeAreIn.find(textFileName));
            eForm.Show();
        }

        /// <summary>
        /// Handles deleting an entry from the file system.
        /// </summary>
        public void handleDeleteEntry()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Handles adding a new folder to the file system.
        /// </summary>
        public void handleNewFolder()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Handle adding a new file to the file system. 
        /// </summary>
        public void handleNewFile()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the contents of the requested folder as a List<string> and updates the folderWeAreIn to reflect the change.
        /// </summary>
        /// <param name="nameOfFolderToGetContentsOf">The name of the folder we wish to get the contents of.</param>
        /// <returns>See summary. </returns>
        public List<string> returnFolderContents(string nameOfFolderToGetContentsOf)
        {
            List<string> toBeReturned = fileController.returnDesiredFolder(folderWeAreIn, nameOfFolderToGetContentsOf).returnListOfFolderContentsAsString();
            folderWeAreIn = fileController.returnDesiredFolder(folderWeAreIn, nameOfFolderToGetContentsOf);
            return toBeReturned;
        }
    }
}
