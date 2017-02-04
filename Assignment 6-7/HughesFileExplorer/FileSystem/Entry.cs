using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    //An abstract class that models the various entries of a file system. Can represent either a TextFile or a Folder.
    public abstract class Entry
    {
        //The name of the entry, to be assigned by the subclasses.
        protected string name;

        //Allow the 'name' field to be assigned to by the various subclasses of entry.
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; 
            }
        }

        /// <summary>
        /// A method that is created in each of the subclasses of entry. This includes both folders and text files. 
        /// Originally from FileSystem lecture, by David Schmidt.
        /// </summary>
        /// <param name="indentation">The number of leading spaces before the string.</param>
        /// <returns>The entry it is actiing upon as a string.</returns>
        public abstract string makeString(string indentation);
    }
}
