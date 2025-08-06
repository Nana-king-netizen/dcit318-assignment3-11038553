

namespace Assignment3DCIT308
{
    internal class FinanceApp
    {
       private List<Transaction> _transactions = new();

        public void Run()
        {
            var account = new SavingsAccount("11038553", 1000.00m);

            var transaction1 = new Transaction { Id = 001, Amount = 200.00m, Date = DateTime.Now, Category = "Groceries" };
            var transaction2 = new Transaction { Id = 002, Amount = 150.00m, Date = DateTime.Now, Category = "Utilities" };
            var transaction3 = new Transaction { Id = 003, Amount = 50.00m, Date = DateTime.Now, Category = "Entertainment" };

            MobileMoneyProcessor mobileMoneyProcessor = new MobileMoneyProcessor();
            BankTransferProcessor bankTransferProcessor = new BankTransferProcessor();
            CryptoWalletProcessor cryptoWalletProcessor = new CryptoWalletProcessor();


            mobileMoneyProcessor.Process(transaction1);
            bankTransferProcessor.Process(transaction2);
            cryptoWalletProcessor.Process(transaction3);

            account.ApplyTransaction(transaction1);
            account.ApplyTransaction(transaction2);
            account.ApplyTransaction(transaction3);

            _transactions.Add(transaction1);
            _transactions.Add(transaction2);
            _transactions.Add(transaction3);

        }
    }
}
