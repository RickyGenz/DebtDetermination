namespace DebtDetermination.Shared.Models
{
    public class TransactionBorrower
    {
        public Transaction Transaction { get; }
        public Person Borrower { get; }

        public TransactionBorrower(Transaction transaction, Person borrower)
        {
            this.Transaction = transaction;
            this.Borrower = borrower;
        }
        public TransactionBorrower() { }
    }
}
