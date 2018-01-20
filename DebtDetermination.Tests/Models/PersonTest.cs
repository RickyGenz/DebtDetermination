using DebtDetermination.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebtDetermination.Tests.Models
{
    [TestClass]
    public class PersonTest
    {
        string Name;
        Person Person;

        [TestInitialize]
        public void InstantiatePerson()
        {
            Name = "Ricky";
            Person = new Person(Name);
        }

        [TestMethod]
        public void PersonHasName()
        {
            Assert.AreEqual(Name, Person.Name);
        }
    }
}
