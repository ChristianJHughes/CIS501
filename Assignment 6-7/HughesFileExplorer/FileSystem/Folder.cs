

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    //Class defining a Folder, which can contain text files, or other folders.
    public class Folder : Entry
    {
        //The contents of a folder, which can be any of the entry subclasses (text files, or more folders).
        private Dictionary<string, Entry> contents;

        //The constructor for the folder class that assigns the name to the entry part of the object, and creates an empty dictionary.
        public Folder(string name)
        {
            //Assign the name passed in the to the entry part of the object.
            base.name = name;

            //Initally there are no contents in the folder.
            contents = new Dictionary<string, Entry>();
        }

        /// <summary>
        /// Returns the entry object with the name provided. Returns null if not found.
        /// </summary>
        /// <param name="name">The name of the entry to be found.</param>
        /// <returns>The entry with the associated name.</returns>
        public Entry find(string name)
        {
            Entry toBeFound = null;

            if (contents.ContainsKey(name))
            {
                toBeFound = contents[name];
            }
            return toBeFound;
        }

        /// <summary>
        /// Adds a new entry to the current folder!
        /// </summary>
        /// <param name="toBeAdded">The entry to be added to the folder.</param>
        public void add(Entry toBeAdded, string name)
        {
            if (!contents.ContainsKey(name))
            {
                if (toBeAdded != null)
                {
                    contents[toBeAdded.Name] = toBeAdded;
                }
                else
                {
                    contents[name] = toBeAdded;
                }
            }
            else if (contents.ContainsKey(toBeAdded.Name) && contents[toBeAdded.Name] == null)
            {
                contents[toBeAdded.Name] = toBeAdded;
            }
        }

        /// <summary>
        /// Returns a list of all of the entry objects contained within the folder. Some may be null, if they have not been loaded.
        /// </summary>
        /// <returns>See summary.</returns>
        public List<Entry> getListing()
        {
            //The list to be returned.
            List<Entry> toBeReturned = new List<Entry>();

            //Adds all of the folders contents into the list that is to be returned. 
            foreach (var pair in contents)
            {
                toBeReturned.Add(pair.Value);
            }
            return toBeReturned;
        }

        //Prints a string representation of the folder and its contents. 
        //CODE SNIPPETS AUTHORED BY: David Schmidt
        public override string makeString(string indent)
        {
            string ans = indent + "Folder:  " + this.name + " containing:\r\n";
            List<Entry> contents = ((Folder)this).getListing();

            foreach (Entry entry in contents)
            {
                if (entry != null)
                {
                    ans = ans + entry.makeString(indent + "   ");
                }
                else
                {
                    ans = ans + (indent + "   " + "FOLDER PROXY. FOLDER NOT LOADED.\r\n");
                }
            }
            ans = ans + indent + "End Folder " + this.name + "\r\n";
            return ans;
        }

        /// <summary>
        /// Simply returns the names of all of the entries in the folder, as a list of strings.
        /// </summary>
        /// <returns>See summary.</returns>
        public List<string> returnListOfFolderContentsAsString()
        {
            List<string> toBeReturned = new List<string>();

            foreach (var pair in contents)
            {
                toBeReturned.Add(pair.Key);
            }
            return toBeReturned;
        }
    }
}
