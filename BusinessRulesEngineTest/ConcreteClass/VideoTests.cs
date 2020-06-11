using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass.Tests
{
    [TestClass()]
    public class VideoTests
    {
      

        [TestMethod()]
        public void AddPromoItemToPackageTest()
        {

            Video video = new Video();
            var result = video.AddPromoItemToPackage();

            Assert.AreEqual("Added promo Item", result);

        }
    }
}