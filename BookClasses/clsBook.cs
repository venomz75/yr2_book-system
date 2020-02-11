using System;

namespace BookClasses
{
    public class clsBook
    {
        private int mBookID;
        public int BookID
        {
            get
            {
                return mBookID;
            }
            set
            {
                mBookID = value;
            }
        }


        private string mTitle;
        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;
            }
        }


        private DateTime mDatePublished;
        public DateTime DatePublished
        {
            get
            {
                return mDatePublished;
            }
            set
            {
                mDatePublished = value;
            }
        }


        private int mStock;
        public int Stock
        {
            get
            {
                return mStock;
            }
            set
            {
                mStock = value;
            }
        }


        private float mPrice;
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }


        private bool mAvailableOnline;
        public bool AvailableOnline
        {
            get
            {
                return mAvailableOnline;
            }
            set
            {
                mAvailableOnline = value;
            }
        }


        public bool Find(int bookid)
        {
            mBookID = 3;
            mTitle = "Test";
            mDatePublished = Convert.ToDateTime("12/12/2012");
            mStock = 6;
            mPrice = 9.99F;
            mAvailableOnline = true;
            return true;
        }
    }
}