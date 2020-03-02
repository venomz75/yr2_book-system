using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing

{
    [TestClass]
    public class tstReview

    {

        [TestMethod]
        public void InstanceOK()

        {
            clsReview anReview = new clsReview();
            Assert.IsNotNull(anReview);
        }

    

        [TestMethod]
        public void DateAddedReviewOK()
        {
            clsReview AnReview = new clsReview();

            DateTime TestData = DateTime.Now.Date;

            AnReview.DateAdded = TestData;

            Assert.AreEqual(AnReview.DateAdded, TestData);
        }

       

        [TestMethod]
        public void ReviewerNameOK()
        {
            clsReview AnReview = new clsReview();

            string TestData = "Fred";

            AnReview.ReviewerName = TestData;

            Assert.AreEqual(AnReview.ReviewerName, TestData);
        }

        [TestMethod]
        public void StarRatingOK()
        {
            clsReview AnReview = new clsReview();

            Int32 TestData = 5;

            AnReview.Star = TestData;

            Assert.AreEqual(AnReview.Star, TestData);
        }

        [TestMethod]
        public void WouldUseAgainOK()
        {
            clsReview AnReview = new clsReview();

            Boolean TestData = false;

            AnReview.WouldUse = TestData;

            Assert.AreEqual(AnReview.WouldUse, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsReview AnReview = new clsReview();

            Boolean Found = false;

            Int32 ReviewNo = 3;

            Found = AnReview.Find(ReviewNo);

            Assert.IsTrue(Found);
        }

       

        [TestMethod]
        public void TestReviewNameFound()
        {
            clsReview AnReview = new clsReview();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ReviewNo = 33;

            Found = AnReview.Find(ReviewNo);

            if (AnReview.ReviewerName != "Paul")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsReview AnReview = new clsReview();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ReviewNo = 33;

            Found = AnReview.Find(ReviewNo);

            if (AnReview.DateAdded != Convert.ToDateTime("06/06/2018"))
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStarFound()
        {
            clsReview AnReview = new clsReview();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ReviewNo = 33;

            Found = AnReview.Find(ReviewNo);

            if (AnReview.Star != 5)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestWouldUseFound()
        {
            clsReview AnReview = new clsReview();

            Boolean Found = false;

            Boolean OK = true;

            Int32 ReviewNo = 33;

            Found = AnReview.Find(ReviewNo);

            if (AnReview.WouldUse != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        
    }

}
