namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PracticalLinq;
    using System.Linq;

    [TestClass]
    public class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomerRepository repo = new CustomerRepository();
            var customerList = repo.Retrieve();

            //Act
            var result = repo.Find(customerList, 2);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirstName);
        }

        [TestMethod]
        public void SortByNameTest()
        {
            //Arrange
            CustomerRepository repo = new CustomerRepository();
            var customerList = repo.Retrieve();

            //Act
            var result = repo.SortByName(customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
        }

        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            //Arrange
            Builder listBuilder = new Builder();

            //Act
            var result = listBuilder.BuildIntegerSequence();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
