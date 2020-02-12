using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }
    }
}
