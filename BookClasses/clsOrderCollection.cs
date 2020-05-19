using System.Collections.Generic;
using System;

namespace BookClasses
{
    public class clsOrderCollection


    {


        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
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
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public clsOrder TestItem { get; private set; }
        public clsOrder clsOrder { get; private set; }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@DatePlaced", mThisOrder.DatePlaced);
            DB.AddParameter("@Completed", mThisOrder.Completed);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            return DB.Execute("sproc_tblOrder_Insert");
        }


        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);



        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            //  DB.AddParameter("@DataPlaced", mThisOrder.DatePlaced);
            DB.AddParameter("@Completed", mThisOrder.Completed);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);

            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByOrderStatus(string OrderStatus)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderStatus", OrderStatus);
           DB.Execute("sproc_tblOrder_FilterByOrderStatus");
           PopulateArray(DB);


        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
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
