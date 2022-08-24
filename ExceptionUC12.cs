using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message)
            : base(message)
        { }
    }
    public class InvalidMobileNumberException : Exception
    {
        public InvalidMobileNumberException(string message)
            : base(message)
        { }
    }

    public class InvalidEMailIDException : Exception
    {
        public InvalidEMailIDException(string message)
            : base(message)
        { }
    }

    public class InvalidFirstName : Exception
    {
        public InvalidFirstName(string message)
            : base(message)
        { }
    }

    public class InvalidLastName : Exception
    {
        public InvalidLastName(string message)
            : base(message)
        { }
    }
}
