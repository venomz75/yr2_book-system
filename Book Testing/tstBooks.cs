using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstBooks
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBook book1 = new clsBook();
            Assert.IsNotNull(book1);
        }
    }
}
