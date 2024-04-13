using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Console_App.Helper
{
    internal class StudentNotFoundException: Exception
    {
        public StudentNotFoundException()
        {
            

        }
        public StudentNotFoundException(string message):base (message)
        {
            
        }

    }
}
