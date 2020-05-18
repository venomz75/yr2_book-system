using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Book_Testing
{
    [TestClass]
    public class tstBookCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            Assert.IsNotNull(AllBooks);
        }

        [TestMethod]
        public void BookListOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            List<clsBook> TestList = new List<clsBook>();
            clsBook TestItem = new clsBook();
            TestItem.BookID = 1;
            TestItem.Title = "Oxford English Dictionary";
            TestItem.DatePublished = Convert.ToDateTime("1/2/1884");
            TestItem.Stock = 50;
            TestItem.Price = 4.99F;
            TestItem.AvailableOnline = false;
            TestList.Add(TestItem);
            AllBooks.BookList = TestList;
            Assert.AreEqual(AllBooks.Count, TestList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            int someCount = 2;
            AllBooks.Count = someCount;
            Assert.AreEqual(AllBooks.Count, someCount);
        }

        [TestMethod]
        public void ThisBookPropertyOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            clsBook TestItem = new clsBook();
            TestItem.BookID = 1;
            TestItem.Title = "Oxford English Dictionary";
            TestItem.DatePublished = Convert.ToDateTime("1/2/1884");
            TestItem.Stock = 50;
            TestItem.Price = 4.99F;
            TestItem.AvailableOnline = false;
            AllBooks.ThisBook = TestItem;
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            List<clsBook> TestList = new List<clsBook>();
            clsBook TestItem = new clsBook();
            TestItem.BookID = 1;
            TestItem.Title = "Oxford English Dictionary";
            TestItem.DatePublished = Convert.ToDateTime("1/2/1884");
            TestItem.Stock = 50;
            TestItem.Price = 4.99F;
            TestItem.AvailableOnline = false;
            TestList.Add(TestItem);
            AllBooks.BookList = TestList;
            Assert.AreEqual(AllBooks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            clsBook TestItem = new clsBook();
            int primaryKey = 0;
            //TestItem.BookID = 1;
            TestItem.Title = "Oxford English Dictionary";
            TestItem.DatePublished = Convert.ToDateTime("1/2/1884");
            TestItem.Stock = 50;
            TestItem.Price = 4.99F;
            TestItem.AvailableOnline = false;
            AllBooks.ThisBook = TestItem;
            primaryKey = AllBooks.Add();
            TestItem.BookID = primaryKey;
            AllBooks.ThisBook.Find(primaryKey);
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            clsBook TestItem = new clsBook();
            int PrimaryKey = 0;
            //TestItem.BookID = 1;
            TestItem.Title = "Oxford English Dictionary";
            TestItem.DatePublished = Convert.ToDateTime("1/2/1884");
            TestItem.Stock = 50;
            TestItem.Price = 4.99F;
            TestItem.AvailableOnline = false;
            AllBooks.ThisBook = TestItem;
            PrimaryKey = AllBooks.Add();
            TestItem.BookID = PrimaryKey;
            AllBooks.Delete();
            bool Found = AllBooks.ThisBook.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            clsBook TestItem = new clsBook();
            int PrimaryKey = 0;
            //TestItem.BookID = 1;
            TestItem.Title = "Oxford English Dictionary";
            TestItem.DatePublished = Convert.ToDateTime("1/2/1884");
            TestItem.Stock = 50;
            TestItem.Price = 4.99F;
            TestItem.AvailableOnline = false;
            AllBooks.ThisBook = TestItem;
            PrimaryKey = AllBooks.Add();
            TestItem.BookID = PrimaryKey;
            //TestItem.BookID = 1;
            TestItem.Title = "Oxford English Dictionary";
            TestItem.DatePublished = Convert.ToDateTime("1/2/1884");
            TestItem.Stock = 100;
            TestItem.Price = 4.99F;
            TestItem.AvailableOnline = false;
            AllBooks.ThisBook = TestItem;
            AllBooks.Update();
            AllBooks.ThisBook.Find(PrimaryKey);
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }

        [TestMethod]
        public void FilterByTitleMethodOK()
        {
            clsBookCollection AllBooks = new clsBookCollection();
            clsBookCollection FilteredBooks = new clsBookCollection();
            FilteredBooks.FilterByTitle("");
            Assert.AreEqual(AllBooks.Count, FilteredBooks.Count);
        }

        [TestMethod]
        public void FilterByTitleNoneFound()
        {
            clsBookCollection FilteredBooks = new clsBookCollection();
            FilteredBooks.FilterByTitle("nonexistent book title here");
            Assert.AreEqual(0, FilteredBooks.Count);
        }

        [TestMethod]
        public void FilterByTitleTestDataFound()
        {
            clsBookCollection FilteredBooks = new clsBookCollection();
            bool OK = true;
            FilteredBooks.FilterByTitle("nonexistent book title here");
            if (FilteredBooks.Count == 1)
            {
                if (FilteredBooks.BookList[0].BookID != 1)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
