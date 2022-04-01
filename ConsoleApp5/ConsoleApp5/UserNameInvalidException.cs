using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class UserNameInvalidException : Exception
    {
        public UserNameInvalidException():base("User name is invalid")
        {}
        public UserNameInvalidException(string message):base(message)
        {}
    }
}
