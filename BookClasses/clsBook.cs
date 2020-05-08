﻿using System;

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


        public bool Find(int BookID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookID", BookID);
            DB.Execute("sproc_tblBooks_FilterByBookID");    

            if (DB.Count == 1)
            {
                mBookID = Convert.ToInt32(DB.DataTable.Rows[0]["BookID"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mDatePublished = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePublished"]);
                mStock = Convert.ToInt32(DB.DataTable.Rows[0]["Stock"]);
                mPrice = (float) Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailableOnline = Convert.ToBoolean(DB.DataTable.Rows[0]["AvailableOnline"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string Valid(int bookID,
                            string title,
                            DateTime datePublished,
                            int stock,
                            float price,
                            bool availableOnline)
        {
            string Error = "";

            if (bookID < 1)
            {
                Error += "The BookID may not be lower than 1.\n";
            }

            if (title.Length < 1)
            {
                Error += "The Title may not be shorter than 1 character.\n";
            }
            
            if(title.Length > 50)
            {
                Error += "The Title may not be longer than 50 characters.\n";
            }
            return Error;
        }
    }
}