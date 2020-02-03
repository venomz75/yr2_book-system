using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff AnStaff = new clsStaff();
            assert.IsNotNull(AnStaff);
            

        }
    }
}
