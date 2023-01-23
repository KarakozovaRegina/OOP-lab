using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_4
{
    class Exceptions
    {
        public class StringException : Exception
        {
            public StringException(string message) : base(message) { }
            
        }

        public class NumberException : Exception
        {
            public NumberException(string message) : base(message) { }
        }

        public class NotFound : Exception
        {
            public NotFound(string message) : base(message) { }
        }

    }

}
