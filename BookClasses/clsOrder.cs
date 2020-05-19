using System;

namespace BookClasses
{
    public class clsOrder
    {
        private Int32 mOrderID;
        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        private Int32 mCustomerID;
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private DateTime mDatePlaced;
        public DateTime DatePlaced
        {
            get
            {
                return mDatePlaced;
            }
            set
            {
                mDatePlaced = value;
            }
        }
        private Boolean mCompleted;
        public bool Completed
        {
            get
            {
                return mCompleted;
            }
            set
            {
                mCompleted = value;
            }
        }
        private string mOrderStatus;
        public string OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }
        private Int32 mStaffID;
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
             //   mDatePlaced = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePlaced"]);
                mCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["Completed"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                return true;

            }
            else
            {
                return false;

            }
        }

        public string Valid(string customerID, string datePlaced, string completed, string staffID, string orderStatus)
        {
            String Error = "";
            DateTime DateTemp;
            if (customerID.Length == 0)
            {
                Error = Error + "The customer ID may not be blank :";

            }
            if(customerID.Length > 6)
            {
                Error = Error + "The customer ID must be less than 6 characters :";
            }
            try
            {
                Convert.ToInt32(customerID);
            }
            catch
            {
                Error = Error + "The customer ID must be integers: ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(datePlaced);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past:";

                }
                DateTemp = Convert.ToDateTime(datePlaced);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future:";

                }
            }

            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            if (orderStatus.Length == 0)
            {
                Error = Error + "The order Status may not be blank : ";
            }
            if (orderStatus.Length > 50)
            {
                Error = Error + "The order Status must be less than 50 characters :";

            }
            if (staffID.Length == 0)
            {
                Error = Error + "The staff ID may not be blank :";

            }
            if (staffID.Length > 6)
            {
                Error = Error + "The staff ID must be less than 50 characters :";
            }
                try
                {
                    Convert.ToInt32(staffID);
                }
                catch
                {
                    Error = Error + "The staff ID must be integers: ";
                }



            
            return Error;
        }


    }
}