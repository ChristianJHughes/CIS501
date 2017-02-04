using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystem;

namespace FileSystemController
{
    public class FileSystemContoller
    {
        //The folder iterator for the file system. It keeps track of the position in the XML file that has been read.
        private FolderIterator iterator;

        //The file system (Which is a dictionaries of dictionaries) begins with the root folder.
        private Folder root;

        /// <summary>
        /// The constructor loads the root folder, and consturcs a new folder iterator. 
        /// </summary>
        public FileSystemContoller()
        {
            //Constructs iterator, and loads the root folder as soon as it is built.
            iterator = new FolderIterator();
            root = iterator.nextFolder();
        }

        /// <summary>
        /// Returns whatever has been built thus far of the file system.
        /// </summary>
        /// <returns>See summary.</returns>
        public Folder returnCurrentFileSystem()
        {
            return root;
        }

        /// <summary>
        /// Returns the folder that the user requests. If the folder is not already in the file system, then it is loaded into the file system as requested. 
        /// </summary>
        /// <param name="folderWeAreIn">The current folder that the user is opperating in.</param>
        /// <param name="folderNameToLoad">The name of the folder that the user wishes to accsess or load.</param>
        /// <returns>The folder requested by the folderNameToLoad parameter.</returns>
        public Folder returnDesiredFolder(Folder folderWeAreIn, string folderNameToLoad)
        {            
            //If it is already loaded into the system at the current folder, just return it.
            if (folderWeAreIn.find(folderNameToLoad) != null)
            {
                return (Folder)folderWeAreIn.find(folderNameToLoad);
            }
            else if (folderWeAreIn.Name == folderNameToLoad)
            {
                return folderWeAreIn;
            }

            //Else it is not in the system, so we load up all of the folders up to/including that folder.
            bool folderFound = false;
            Folder next = null;
            
            //We make sure that we get to the right folder based on the path of the folder provided in the XML file. 
            while (folderFound == false)
            {
                next = iterator.nextFolder();
                folderWeAreIn = root;
                if (next.Name.Contains("/"))
                {
                    string[] yum = next.Name.Split('/');

                    for (int i = 0; i < yum.Length-1; i++)
                    {
                        folderWeAreIn = (Folder)folderWeAreIn.find(yum[i]);
                    }
                    next.Name = yum[yum.Length - 1];
                }

                if (next.Name == folderNameToLoad)
                {
                    folderFound = true;
                }
                folderWeAreIn.add(next, next.Name); 
            }
            return next;
        }

    }
}
