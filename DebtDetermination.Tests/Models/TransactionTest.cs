﻿using DebtDetermination.Shared.Models;
using DebtDetermination.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebtDetermination.Tests.Models
{
    [TestClass]
    public class TransactionTest
    {
        string Name;
        decimal Amount;
        MockTransactionType Type;
        Transaction Transaction;

        [TestInitialize]
        public void InstantiateTransaction()
        {
            Name = "Pi";
            Amount = 3.14m;
            Type = new MockTransactionType();
            Transaction = new Transaction(Name, Amount, Type);
        }

        [TestMethod]
        public void TransactionHasName()
        {
            Assert.AreEqual(Name, Transaction.Name);
            Assert.IsInstanceOfType(Transaction.Name, typeof(string));
        }

        [TestMethod]
        public void TransactionHasAmount()
        {
            Assert.AreEqual(Amount, Transaction.Amount);
            Assert.IsInstanceOfType(Transaction.Amount, typeof(decimal));
        }

        [TestMethod]
        public void TransactionHasType()
        {
            Assert.AreEqual(Type, Transaction.Type);
            Assert.IsInstanceOfType(Transaction.Type, typeof(TransactionType));
        }
    }
}
