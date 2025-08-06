
namespace Assignment3DCIT308
{
    internal class Account
    {
        string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = initialBalance;
        }

        public virtual void ApplyTransaction(Transaction transaction)
        {
            Balance -= transaction.Amount;
        }
    }
}
