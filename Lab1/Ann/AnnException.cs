using System;
using System.Collections.Generic;
using System.Text;

namespace core
{
    class AnnException : Exception
    {
        public AnnException(string message) : base(message) { }
    }
}
