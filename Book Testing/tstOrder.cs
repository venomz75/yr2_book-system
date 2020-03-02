using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstOrder
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            //testing Order ID
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 5;
            AnOrder.OrderID = TestData;

            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //testing Customer ID
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 5;
            AnOrder.CustomerID = TestData;

            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        [TestMethod]
        public void DatePlacedOK()
        {
            //testing DatePlaced
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;
            AnOrder.DatePlaced = TestData;

            Assert.AreEqual(AnOrder.DatePlaced, TestData);
        }
        [TestMethod]
        public void CompletedOK()
        {
            //testing Completed
            clsOrder AnOrder = new clsOrder();

            Boolean TestData = true;
            AnOrder.Completed = TestData;

            Assert.AreEqual(AnOrder.Completed, TestData);
        }
        [TestMethod]
        public void OrderStatusOK()
        {
            //testing Completed
            clsOrder AnOrder = new clsOrder();

            String TestData = "Example Status";
            AnOrder.OrderStatus = TestData;

            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }
        [TestMethod]
        public void StaffIDOK()
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 5;
            AnOrder.StaffID = TestData;

            Assert.AreEqual(AnOrder.StaffID, TestData);


        }



    }
}
