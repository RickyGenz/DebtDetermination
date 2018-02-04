namespace DebtDetermination.Shared.Models
{
    public class TransactionLender
    {
        public Transaction Transaction { get; }
        public Person Lender { get; }

        public TransactionLender(Transaction transaction, Person lender)
        {
            this.Transaction = transaction;
            this.Lender = lender;
        }
        public TransactionLender() { }
    }
}
