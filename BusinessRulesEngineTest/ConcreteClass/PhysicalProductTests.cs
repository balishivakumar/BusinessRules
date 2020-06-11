using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass.Tests
{
    [TestClass()]
    public class PhysicalProductTests
    {
       
        [TestMethod()]
        public void CalculateCommisionTest()
        {
            var physicalProduct = new PhysicalProduct();
            var result=physicalProduct.CalculateCommision();

            Assert.AreEqual("Commision calculated", result);
        }

        [TestMethod()]
        public void PrintSlipTest()
        {
            var physicalProduct = new PhysicalProduct();
            var result = physicalProduct.PrintSlip();

            Assert.AreEqual("Printed slip", result);
        }
    }
}