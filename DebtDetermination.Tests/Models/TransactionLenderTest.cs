using DebtDetermination.Shared.Models;
using DebtDetermination.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebtDetermination.Tests.Models
{
    [TestClass]
    public class TransactionLenderTest
    {
        MockTransaction Transaction;
        MockPerson Lender;
        TransactionLender TransactionLender;

        [TestInitialize]
        public void InitializeTransactionLender()
        {
            Transaction = new MockTransaction();
            Lender = new MockPerson();
            TransactionLender = new TransactionLender(Transaction, Lender);
        }

        [TestMethod]
        public void TransactionLenderHasTransaction()
        {
            Assert.AreEqual(Transaction, TransactionLender.Transaction);
            Assert.IsInstanceOfType(TransactionLender.Transaction, typeof(Transaction));
        }

        [TestMethod]
        public void TransactionLenderHasLender()
        {
            Assert.AreEqual(Lender, TransactionLender.Lender);
            Assert.IsInstanceOfType(TransactionLender.Lender, typeof(Person));
        }
    }
}
