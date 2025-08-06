

namespace Assignment3DCIT308
{
    internal class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"[Mobile Money]: An amount of {transaction.Amount} has been processed for the {transaction.Category} category");
        }
    }
}
