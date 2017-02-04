using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystem;
using FileSystemController;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construct the controller, which owns the folder iterator.
            FileSystemContoller controller = new FileSystemContoller();

            //Simulate the whole file system being created on the fly, simulating requests from the user (using virtual proxies). 
            Console.WriteLine("First we construct the contoller, and load in just the root. OUTPUT:\r\n");
            Folder test = controller.returnCurrentFileSystem();
            Console.WriteLine(test.makeString(""));

            Console.WriteLine("Next, we simulate the user requesting just the Shakespeare folder. OUTPUT:\r\n");
            controller.returnDesiredFolder(test, "Shakespeare");
            test = controller.returnCurrentFileSystem();
            Console.WriteLine(test.makeString(""));

            Console.WriteLine("Lastly, we user the user requesting the Sonnets folder within Shakespeare. This should also load the Dickens folder corectly, based on its place in the XML file. OUTPUT:\r\n");
            controller.returnDesiredFolder(controller.returnDesiredFolder(test, "Shakespeare"), "Sonnets");
            test = controller.returnCurrentFileSystem();
            Console.WriteLine(test.makeString(""));

            Console.WriteLine("This demonstrates the use of virtual proxies, as the system will be built step-by-step, as requested by the user. Tests Completed.");
            Console.ReadLine();
        }
    }
}
