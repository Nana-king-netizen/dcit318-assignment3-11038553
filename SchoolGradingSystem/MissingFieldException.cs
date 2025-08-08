using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGradingSystem
{
    internal class MissingFieldException: Exception
    {
        public MissingFieldException(string message) : base(message) { }
    }
}
