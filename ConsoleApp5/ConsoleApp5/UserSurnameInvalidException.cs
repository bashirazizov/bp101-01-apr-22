using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class UserSurnameInvalidException : Exception
    {
        public UserSurnameInvalidException() : base("User name is invalid")
        { }
        public UserSurnameInvalidException(string message) : base(message)
        { }
    }
}
