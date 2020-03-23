using System.Collections.Generic;
using System;
using BookClasses;

using System.Collections.Generic;

namespace BookClasses
{
    public class clsOrderCollection


    {

        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder { get; set; }
        public clsOrder TestItem { get; private set; }
        public clsOrder clsOrder { get; private set; }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Completed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Completed"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.DatePlaced = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePlaced"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                mOrderList.Add(AnOrder);
                Index++;
                
            }

        }






    }
}
