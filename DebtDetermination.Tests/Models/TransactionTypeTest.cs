using DebtDetermination.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
