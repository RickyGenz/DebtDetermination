namespace DebtDetermination.Shared.Models
{
    public class Transaction
    {
        public string Name { get; }
        public decimal Amount { get; }
        public TransactionType Type { get; }

        public Transaction(string name, decimal amount, TransactionType type)
        {
            this.Name = name;
            this.Amount = amount;
            this.Type = type;
        }
        public Transaction() { }
    }
}
