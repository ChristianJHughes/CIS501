using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    //A delegate for signifying the creation of a new editForm. This allows for the Control Panel controller to shut everything down cleanly at the users request. 
    public delegate void NewEditMethod(EditForm eForm);
}
