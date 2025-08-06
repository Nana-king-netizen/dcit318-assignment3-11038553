using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3DCIT308
{
    internal class BankTransferProcessor : ITransactionProcessor
    {
       public void Process(Transaction transaction)
        {
            Console.WriteLine($"[Bank Transfer]: An amount of {transaction.Amount} has been processed for the {transaction.Category} category");
        }


    }
}

