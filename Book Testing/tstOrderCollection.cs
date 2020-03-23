using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Book_Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Completed = true;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.StaffID = 1;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }

        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Completed = true;
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.DatePlaced = DateTime.Now.Date;
            TestOrder.OrderStatus = "Pending";
            TestOrder.StaffID = 1;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Completed = true;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.StaffID = 1;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
       
    }
}
