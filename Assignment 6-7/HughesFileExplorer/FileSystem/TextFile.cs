using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    //A class that mimics the behavior of a text file. It contains a List of strings to represent the textual data.
    public class TextFile : Entry
    {
        //The content of the textfile, represented as a list of strings.
        private List<string> textLines;
 
        //The constructor for the TextFile, that will get the name of the file, and create a new List of strings.
        public TextFile(string name)
        {
            base.name = name;
            
            //Create empty text file.
            textLines = new List<string>();
        }
        
        /// <summary>
        /// Simply adds the given string (as a new line) to the textfile.
        /// </summary>
        /// <param name="lineToAdd">The string to be added to the textfile.</param>
        public void addLine(string lineToAdd)
        {
            textLines.Add(lineToAdd);
        }

        //The property for returning all of the lines in the file.
        public List<string> Lines
        {
            get
            {
                return textLines;
            }
            set
            {
                textLines = value;
            }
        }

        /// <summary>
        /// Esentially a ToString() copy method for the textfile. An abstract definition for this method exists in class 'Entry'.
        /// </summary>
        /// <param name="indent">The number of spaces the resulting string will be indented.</param>
        /// <returns>A representation of this textfile object in string form.</returns>
        public override string makeString(string indent)
        {
            return indent + "Text file: " + this.name + "\r\n";
        }
    }
}
