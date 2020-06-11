using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass.Tests
{
    [TestClass()]
    public class NewMembershipTests
    {
       

        [TestMethod()]
        public void SendTest()
        {
            var newMembership = new NewMembership();

            var result = newMembership.Send();

            Assert.AreEqual("Mail Sent", result);

        }
    }
}