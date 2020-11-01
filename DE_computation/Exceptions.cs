using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_computation
{
    public class WrongDataException : Exception
    {
        public WrongDataException() { }

        public WrongDataException(string message) : base(message) { }
    }

    public class DiscontinuityException : Exception
    {
        public DiscontinuityException(string message) : base(message) { }
    }


}
