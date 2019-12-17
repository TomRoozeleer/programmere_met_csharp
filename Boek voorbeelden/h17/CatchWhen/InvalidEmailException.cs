using System;

namespace CatchWhen
{
    public class InvalidEmailException
        : ApplicationException
    {
        public InvalidEmailException(string message)
            : base(message)
        {}

        public int Severity { get; set; }
    }
}
