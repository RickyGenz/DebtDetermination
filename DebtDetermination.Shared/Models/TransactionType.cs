using System.Collections.Generic;

namespace DebtDetermination.Shared.Models
{
    public class TransactionType
    {
        public string Name { get; }
        public List<Transaction> Transactions { get; set; }

        public TransactionType(string name)
        {
            this.Name = name;
            this.Transactions = new List<Transaction>();
        }
    }
}
