using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystemController;
using FileSystem;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create the File System Controller for the entire system...
            //This will read in the root folder intitally, and other folders as the user requests them (using virtual proxies).
            FileSystemContoller fileSystem = new FileSystemContoller();

            //Next we create the controller for the Control Panel. There is only one of this form, and through it...
            //all other forms are constructed.
            ControlPanelController cController = new ControlPanelController(fileSystem);

            //Next we run the ControlPanelForm, and pass it the controller constructed above. 
            //There is no need to construct more forms here, as the Control Panel will do that henceforth.
            Application.Run(new ControlPanelForm(cController));
        }
    }
}
