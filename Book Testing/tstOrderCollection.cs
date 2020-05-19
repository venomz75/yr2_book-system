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
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Completed = true;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.StaffID = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Completed = true;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.StaffID = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);



        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Completed = true;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.StaffID = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            TestItem.Completed = false;
            TestItem.OrderID = 3;
            TestItem.CustomerID = 2;
            TestItem.DatePlaced = DateTime.Now.Date;
            TestItem.OrderStatus = "Arrived";
            TestItem.StaffID = 4;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void ReportByOrderStatusMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderStatus("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);


        }
        [TestMethod]
        public void ReportByOrderStatusNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderStatus("xxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderStatusTestDataFound()
       // {
         //   clsOrderCollection FilteredOrder = new clsOrderCollection();
          //  Boolean OK = true;
          //  FilteredOrder.ReportByOrderStatus("ccccccccc");
          //  if(FilteredOrder.Count == 71)
          //  {
            //    if(FilteredOrder.OrderList[0].OrderID != 2)
            //    {
             //       OK = false;


              //  }
              //  if(FilteredOrder.OrderList[1].OrderID != 4)
              //  {
               //     OK = false;
              //  }
          //  }
          //  else
            {
           //     OK = false;

          //  }
           // Assert.IsTrue(OK);
        }
    }
}
