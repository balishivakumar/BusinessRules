using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass.Tests
{
    [TestClass()]
    public class UpgradeMembershipTests
    {
      
        [TestMethod()]
        public void SendTest()
        {
            var upgradeMembership = new UpgradeMembership();
            var result = upgradeMembership.Send();

            Assert.AreEqual("Mail Sent", result);
        }
    }
}