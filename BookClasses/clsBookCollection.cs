using System;
using System.Collections.Generic;

namespace BookClasses
{
    public class clsBookCollection
    {
        List<clsBook> mBookList = new List<clsBook>();
        clsBook mThisBook = new clsBook();
        public clsBookCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblBooks_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount;
            RecordCount = DB.Count;
            mBookList = new List<clsBook>();
            while (Index < RecordCount)
            {
                clsBook ABook = new clsBook();
                ABook.BookID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookID"]);
                ABook.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                ABook.DatePublished = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePublished"]);
                ABook.Stock = Convert.ToInt32(DB.DataTable.Rows[Index]["Stock"]);
                ABook.Price = (float)Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                ABook.AvailableOnline = Convert.ToBoolean(DB.DataTable.Rows[Index]["AvailableOnline"]);
                mBookList.Add(ABook);
                Index++;
            }
        }

        public List<clsBook> BookList
        {
            get
            {
                return mBookList;
            }
            set
            {
                mBookList = value;
            }
        }

        public clsBook ThisBook
        {
            get
            {
                return mThisBook;
            }
            set
            {
                mThisBook = value;
            }
        }

        public int Count
        {
            get
            {
                return mBookList.Count;
            }
            set
            {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Title", mThisBook.Title);
            DB.AddParameter("@DatePublished", mThisBook.DatePublished);
            DB.AddParameter("@Stock", mThisBook.Stock);
            DB.AddParameter("@Price", mThisBook.Price);
            DB.AddParameter("@AvailableOnline", mThisBook.AvailableOnline);
            return DB.Execute("sproc_tblBooks_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookID", mThisBook.BookID);
            DB.Execute("sproc_tblBooks_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookID", mThisBook.BookID);
            DB.AddParameter("@Title", mThisBook.Title);
            DB.AddParameter("@DatePublished", mThisBook.DatePublished);
            DB.AddParameter("@Stock", mThisBook.Stock);
            DB.AddParameter("@Price", mThisBook.Price);
            DB.AddParameter("@AvailableOnline", mThisBook.AvailableOnline);
            DB.Execute("sproc_tblBooks_Update");
        }

        public void FilterByTitle(string Title)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Title", Title);
            DB.Execute("sproc_tblBooks_FilterByTitle");
            PopulateArray(DB);
        }
    }
}