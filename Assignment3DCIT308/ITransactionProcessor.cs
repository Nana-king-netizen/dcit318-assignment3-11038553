using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3DCIT308
{
    internal interface ITransactionProcessor
    {
        void Process(Transaction transaction);
    }
}
