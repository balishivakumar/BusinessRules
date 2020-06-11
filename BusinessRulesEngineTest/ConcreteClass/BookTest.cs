using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass.Tests
{
    [TestClass()]
    public class BookTest
    {
        //[TestMethod()]
        //public void BookTest()
        //{
        //    Assert.Inconclusive();
        //}

        [TestMethod()]
        public void CalculateCommisionTest()
        {
            Book book = new Book();

            var result = book.CalculateCommision();

            Assert.AreEqual("Commision calculated", result);
        }

        [TestMethod()]
        public void PrintSlipTest()
        {

            Book book = new Book();

            var result = book.PrintSlip();
            Assert.AreEqual("printed 2 slips", result);
        }
    }
}