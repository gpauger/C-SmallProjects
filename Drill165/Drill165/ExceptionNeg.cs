using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill165
{
    public class ExceptionNeg : Exception
    {
        public ExceptionNeg()
            : base() { }
        public ExceptionNeg(string message)
            : base(message) { }
    }
}
