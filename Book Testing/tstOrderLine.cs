using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstOrderLine
    {
        string OrderID = "3";
        string Quantity = "5";
        string TotalPrice = "9";








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

            Int32 TestData = 5;
            AnOrder.TotalPrice = TestData;

            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Int32 OrderLineID = 2;

            Found = AnOrderLine.Find(OrderLineID);

            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderLineID = 1;

            Found = AnOrderLine.Find(OrderLineID);

            if (AnOrderLine.OrderLineID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderLineID = 1;

            Found = AnOrderLine.Find(OrderLineID);

            if (AnOrderLine.OrderID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderLineID = 1;

            Found = AnOrderLine.Find(OrderLineID);

            if (AnOrderLine.Quantity != 35)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderLineID = 1;

            Found = AnOrderLine.Find(OrderLineID);

            if (AnOrderLine.TotalPrice != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "5";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "55";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "55555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "555555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "5555555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(500, '5');
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "5";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "55";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "55555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "555555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "5555555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string Quantity = "";
            OrderID = OrderID.PadRight(500, '5');
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "5";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "55";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "55555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "555555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "5555555";
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            string TotalPrice = "";
            OrderID = OrderID.PadRight(500, '5');
            Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

    }
}