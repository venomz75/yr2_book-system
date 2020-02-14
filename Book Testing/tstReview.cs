using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void ReviewNoExists()
        {
            clsReview anReview = new clsReview();
            Assert.IsNotNull(anReview);
        }
    }
}
