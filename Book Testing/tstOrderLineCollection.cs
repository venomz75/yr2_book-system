using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Book_Testing
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();

            Assert.IsNotNull(AllOrderLines);

        }
        [TestMethod]
        public void OrderLineListOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.TotalPrice = 1;
            TestItem.OrderLineID = 1;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);

        }
        [TestMethod]
        public void ThisOrderLineOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            clsOrderLine TestOrder = new clsOrderLine();
            TestOrder.Quantity = 1;
            TestOrder.OrderID = 1;
            TestOrder.TotalPrice = 1;
            TestOrder.OrderLineID = 1;
            
            AllOrderLine.ThisOrderLine = TestOrder;
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.TotalPrice = 1;
            TestItem.OrderLineID = 1;
            TestList.Add(TestItem);
            AllOrderLine.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLine.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.TotalPrice = 1;
            TestItem.OrderLineID = 1;
            AllOrderLine.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLine.Add();
            TestItem.OrderLineID = PrimaryKey;
            AllOrderLine.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.TotalPrice = 1;
            TestItem.OrderLineID = 1;
            AllOrderLines.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLines.Add();
            TestItem.OrderLineID = PrimaryKey;
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            AllOrderLines.Delete();
            Boolean Found = AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            Assert.IsFalse(Found);



        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.TotalPrice = 1;
            TestItem.OrderLineID = 1;
            AllOrderLines.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLines.Add();
            TestItem.OrderLineID = PrimaryKey;
            TestItem.Quantity = 4;
            TestItem.OrderID = 3;
            TestItem.TotalPrice = 2;
            TestItem.OrderLineID = 2;
           
            AllOrderLines.ThisOrderLine = TestItem;
            AllOrderLines.Update();
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);

        }
      //  [TestMethod]
      //  public void ReportByQuantityMethodOK()
      //  {
         //   clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
         //   clsOrderLineCollection FilteredOrders = new clsOrderLineCollection();
         //   FilteredOrders.ReportByQuantity("");
         //   Assert.AreEqual(AllOrderLines.Count, FilteredOrders.Count);


       // }
        [TestMethod]
        public void ReportByOrderStatusNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderStatus("xxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

    }
}

