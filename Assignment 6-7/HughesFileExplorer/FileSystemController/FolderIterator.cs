using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileSystem;

namespace FileSystemController
{
    //Iterates through the XML with the encoded file system. It returns one file at a time, as requested. It does not load the entire thing at once! The power of proxies! 
    public class FolderIterator
    {
        //This StreamReader will read in the XML file containing the file system.
        private StreamReader inputFileReader = new StreamReader("..\\..\\..\\filesIn.txt");

        /// <summary>
        /// Uses a StreamReader to read through an XML file defining a file system. It returns one complete folder as a time,
        /// and will represent folders that have not been loaded as NULL. 
        /// </summary>
        /// <returns>The next folder in the XML file.</returns>
        public Folder nextFolder()
        {
            string line = inputFileReader.ReadLine();

            Folder toBeReturned;

            //Check to see if it is the beginning of a folder.
            if (line.Contains("<folder"))
            {
                //Snag the index of the first set of quotes.
                int start = line.IndexOf('\"');
                //Snag the index of the second set of quotes.
                int end = line.IndexOf('\"', start + 1);

                //Get the path name as a string from this folder.
                string pathName = line.Substring(start + 1, (end - start) - 1);

                //Create a new folder with the path name.
                if (pathName == "")
                {
                    toBeReturned = new Folder("Root");
                }
                else
                {
                        toBeReturned = new Folder(pathName);
                }

                line = inputFileReader.ReadLine();

                //Add all of the contents to the folder as virtual proxies.
                while (!line.Contains("</folder>"))
                {
                    //First deal with a potential file.
                    if (line.Contains("<file"))
                    {
                        //Snag the index of the first set of quotes.
                        start = line.IndexOf('\"');
                        //Snag the index of the second set of quotes.
                        end = line.IndexOf('\"', start + 1);

                        //Get the path name as a string from this file.
                        pathName = line.Substring(start + 1, (end - start) - 1);
                        //Create a new Textfile with that name.
                        TextFile newText = new TextFile(pathName);
                        line = inputFileReader.ReadLine();
                        while (!line.Contains("</file>"))
                        {
                            newText.addLine(line);
                            line = inputFileReader.ReadLine();
                        }
                        toBeReturned.add(newText, newText.Name);
                    }
                    //Next, deal with a potential subfolder.
                    else if (line.Contains("<flink"))
                    {
                        //Snag the index of the first set of quotes.
                        start = line.IndexOf('\"');
                        //Snag the index of the second set of quotes.
                        end = line.IndexOf('\"', start + 1);

                        //Get the path name as a string from this file.
                        pathName = line.Substring(start + 1, (end - start) - 1);
                        //Folder proxyFolder = new Folder(pathName);
                        Folder proxyFolder = null;
                        toBeReturned.add(proxyFolder, pathName);
                    }
                    line = inputFileReader.ReadLine();
                }
                return toBeReturned;
            }
            else if (line == null)
            {
                inputFileReader.Close();
                inputFileReader.Dispose();
                return null;
            }
            return null;
        }

    }
}
