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
        [TestMethod]
        public void OrderLineIDOK()
        {
            //testing OrderLine ID
            clsOrderLine AnOrder = new clsOrderLine();

            Int32 TestData = 5;
            AnOrder.OrderLineID = TestData;

            Assert.AreEqual(AnOrder.OrderLineID, TestData);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            //testing OrderLine ID
            clsOrderLine AnOrder = new clsOrderLine();

            Int32 TestData = 5;
            AnOrder.OrderID = TestData;

            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void QuantityOK()
        {
            //testing OrderLine ID
            clsOrderLine AnOrder = new clsOrderLine();

            Int32 TestData = 5;
            AnOrder.Quantity = TestData;

            Assert.AreEqual(AnOrder.Quantity, TestData);
        }
        [TestMethod]
        public void TotalPriceOK()
        {
            //testing OrderLine ID
            clsOrderLine AnOrder = new clsOrderLine();

            float TestData = 5;
            AnOrder.TotalPrice = TestData;

            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }
    }
}
