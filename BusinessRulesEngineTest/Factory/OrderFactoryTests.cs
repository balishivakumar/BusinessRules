using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine.Factory;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.ConcreteClass;

namespace BusinessRulesEngine.Factory.Tests
{
    [TestClass()]
    public class OrderFactoryTests
    {
        [TestMethod()]
        public void OrderCreationTest()
        {
            var orederFactory = new OrderFactory();

            var result = orederFactory.OrderCreation("Book");

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(Book));
        }
    }
}