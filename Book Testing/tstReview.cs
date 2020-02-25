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
        public void ActiveReviewOK()
        {
            clsReview AnReview = new clsReview();

            Boolean TestData = true;

            AnReview.Active = TestData;

            Assert.AreEqual(AnReview.Active, TestData);
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
        public void ReviewNoReviewOK()
        {
            clsReview AnReview = new clsReview();

            Int32 TestData = 1;

            AnReview.ReviewNo = TestData;

            Assert.AreEqual(AnReview.ReviewNo, TestData);
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

            Assert.AreEqual(AnReview.Active, TestData);
        }
    }

}
