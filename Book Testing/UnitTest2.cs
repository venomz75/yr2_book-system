using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class clsReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview AnReview = new clsReview();

            Assert.IsNotNull(AnReview);
        }
    }
}
