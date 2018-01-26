namespace DebtDetermination.Shared.Models
{
    public class TransactionType
    {
        public string Name { get; }

        public TransactionType(string name)
        {
            this.Name = name;
        }
    }
}
