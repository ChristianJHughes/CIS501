*****CIS 501 Assignment #7: HughesFileSystem*****
	Author: Christian J. Hughes
	Professor: David Schmidt
	Due Date: May 12th, 3:50 PM

RELEASE NOTES:
	The majority of the system is complete, though there are features that are not implemented. Please note the following:
		-The "back-end" is completely finished, and is comprised of two VS projects ("FileSystem" and "FileSystemController"). Everything in regards to reading the XML file and building the file tree is in working order. The function of the Virtual Proxy system can be verrified using the "UnitTests" VS project. The "UnitTests" project is a simple console application that tests functionality. It is NOT set as the default start up project, and must be should you desire to test it. 
		
		-In acordance with the "What you must do" section on the assignment page, I have completed all of part 1, as well as part 2(a-d). All the basic fucntionality is present, however -- The CloseAll button does not work, the system does not write output to a textfile, and the NewFile/NewFolder/DeleteFile buttons are not yet opperational. 

		-The "UserInterface" project is set to the start up project by default, and contains all of the forms (as well as thier controllers). You can create multiple windows, utilize the full functationality of the Edit Form (saving and exiting), and view all folders and diles without a hitch. Buttons that don't work will say so with a Message Box. 

		-There are delegates and methods that have not yet been utlized, but are still defined (as they would be used to implement the remaining features). 