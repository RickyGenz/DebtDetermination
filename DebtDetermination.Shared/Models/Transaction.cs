namespace DebtDetermination.Shared.Models
{
    public class Transaction
    {
        public string Name { get; }
        public decimal Amount { get; }

        public Transaction(string name, decimal amount)
        {
            this.Name = name;
            this.Amount = amount;
        }
    }
}
