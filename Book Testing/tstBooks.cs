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
            //create book object
            clsBook ABook = new clsBook();
            //assert class exists
            Assert.IsNotNull(ABook);
        }

        [TestMethod]
        public void TitleOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            string TestData = "Example Book Title";

            //assign test data to property
            book1.Title = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.Title, TestData);
        }

        [TestMethod]
        public void DatePublishedOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            DateTime TestData = DateTime.Now.Date;

            //assign test data to property
            book1.DatePublished = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.DatePublished, TestData);
        }

        [TestMethod]
        public void StockOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            int TestData = 5;

            //assign test data to property
            book1.Stock = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.Stock, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            float TestData = 9.99F;

            //assign test data to property
            book1.Price = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.Price, TestData);
        }

        [TestMethod]
        public void AvailableOnlineOK()
        {   
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            Boolean TestData = true;

            //assign test data to property
            book1.AvailableOnline = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.AvailableOnline, TestData);
        }
    }
}
