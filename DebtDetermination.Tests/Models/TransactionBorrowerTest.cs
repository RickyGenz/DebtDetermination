using DebtDetermination.Shared.Models;
using DebtDetermination.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebtDetermination.Tests.Models
{
    [TestClass]
    public class TransactionBorrowerTest
    {
        MockTransaction Transaction;
        MockPerson Borrower;
        TransactionBorrower TransactionBorrower;

        [TestInitialize]
        public void InitializeTransactionBorrower()
        {
            Transaction = new MockTransaction();
            Borrower = new MockPerson();
            TransactionBorrower = new TransactionBorrower(Transaction, Borrower);
        }

        [TestMethod]
        public void TransactionBorrowerHasTransaction()
        {
            Assert.AreEqual(Transaction, TransactionBorrower.Transaction);
            Assert.IsInstanceOfType(TransactionBorrower.Transaction, typeof(Transaction));
        }

        [TestMethod]
        public void TransactionBorrowerHasBorrower()
        {
            Assert.AreEqual(Borrower, TransactionBorrower.Borrower);
            Assert.IsInstanceOfType(TransactionBorrower.Borrower, typeof(Person));
        }
    }
}
