

namespace Assignment3DCIT308
{
    internal class CryptoWalletProcessor:ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"[Crypto Wallet]: An amount of {transaction.Amount} has been processed for the {transaction.Category} category");
        }
    }
}
