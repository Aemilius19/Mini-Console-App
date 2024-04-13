using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Console_App.Extensions
{
    internal class InvalidNameException: Exception
    {
        public InvalidNameException()
        {
            
        }
        public InvalidNameException(string message):base(message) 
        {
            
        }
        public InvalidNameException(string message, Exception inner)
        : base(message, inner)
        {

        }
    }
}
