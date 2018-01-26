using DebtDetermination.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DebtDetermination.Tests.Models
{
    [TestClass]
    public class TransactionTypeTest
    {
        string Name;
        TransactionType TransactionType;

        [TestInitialize]
        public void InstantiateTransactionType()
        {
            Name = "Dessert";
            TransactionType = new TransactionType(Name);
        }

        [TestMethod]
        public void TransactionTypeHasName()
        {
            Assert.AreEqual(Name, TransactionType.Name);
        }

        [TestMethod]
        public void TransactionTypeHasTransactions()
        {
            Assert.IsInstanceOfType(TransactionType.Transactions, typeof(List<Transaction>));
        }

        [TestMethod]
        public void TransactionTypeTransactionsAreNotNull()
        {
            Assert.IsNotNull(TransactionType.Transactions);
        }
    }
}
