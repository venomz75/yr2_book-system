using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstOrder
    {
        string CustomerID = "4";
        string DatePlaced = DateTime.Now.Date.ToString();
        string Completed = "True";
        string StaffID = "3";
        string OrderStatus = "Pending";





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
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Int32 OrderID = 1;

            Found = AnOrder.Find(OrderID);

            Assert.IsTrue(Found);



        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderID = 5;

            Found = AnOrder.Find(OrderID);

            if (AnOrder.CustomerID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderID = 5;

            Found = AnOrder.Find(OrderID);

            if (AnOrder.OrderID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDatePlacedFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderID = 5;

            Found = AnOrder.Find(OrderID);

            if (AnOrder.DatePlaced != Convert.ToDateTime("07/11/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCompletedFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderID = 5;

            Found = AnOrder.Find(OrderID);

            if (AnOrder.Completed != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderStatusFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderID = 5;

            Found = AnOrder.Find(OrderID);

            if (AnOrder.OrderStatus != "Delivered")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderID = 5;

            Found = AnOrder.Find(OrderID);

            if (AnOrder.StaffID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "5";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "55";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "55555";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "555555";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "555";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "5555555";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, '5');
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePlacedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DatePlaced = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePlacedMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DatePlaced = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePlacedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePlaced = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DatePlacedMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePlaced = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePlacedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DatePlaced = TestDate.ToString();
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePlacedInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DatePlaced = "this is not a date";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "p";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "pp";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "ppppp";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "pppppp";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(50, 'p');
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(51, 'p');
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(500, 'p');
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "3";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "33";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "33333";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "333333";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "333";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "3333333";
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string StaffID = "";
            StaffID = StaffID.PadRight(500, '3');
            Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

    }
}
