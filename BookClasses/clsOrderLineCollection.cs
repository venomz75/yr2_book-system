using System;
using System.Collections.Generic;

namespace BookClasses
{
    public class clsOrderLineCollection
    {



        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderLineList.Count;
            }
            set
            {

            }
        }
        public clsOrderLine ThisOrderLine
        {
            get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.AddParameter("@TotalPrice", mThisOrderLine.TotalPrice);

            return DB.Execute("sproc_tblOrderLine_Insert");
        }
        public clsOrderLineCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            PopulateArray(DB);
        }
        


        
    
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);

            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.AddParameter("@TotalPrice", mThisOrderLine.TotalPrice);


            DB.Execute("sproc_tblOrderLine_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderLineID", mThisOrderLine.OrderLineID);
            DB.Execute("sproc_tblOrderLine_delete");
        }
        public void ReportByQuantity(string Quantity)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Quantity", Quantity);
            DB.Execute("sproc_tblOrderLine_FilterByQuantity");
            PopulateArray(DB);


        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderLineList = new List<clsOrderLine>();
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrderLine.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrderLine.TotalPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalPrice"]);

                mOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }
    }
}