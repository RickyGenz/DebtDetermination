using DebtDetermination.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebtDetermination.Tests.Models
{
    [TestClass]
    public class TransactionTest
    {
        string Name;
        decimal Amount;
        Transaction Transaction;

        [TestInitialize]
        public void InstantiateTransaction()
        {
            Name = "Pi";
            Amount = 3.14m;
            Transaction = new Transaction(Name, Amount);
        }

        [TestMethod]
        public void TransactionHasName()
        {
            Assert.AreEqual(Name, Transaction.Name);
        }

        [TestMethod]
        public void TransactionHasAmount()
        {
            Assert.AreEqual(Amount, Transaction.Amount);
        }
    }
}
