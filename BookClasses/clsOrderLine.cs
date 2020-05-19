using System;

namespace BookClasses
{
    public class clsOrderLine
    {
        private Int32 mOrderLineID;
        public Int32 OrderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }
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
        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        private float mTotalPrice;
        public float TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }





        public bool Find(int OrderLineID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", OrderLineID);
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            if (DB.Count == 1)
            {
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotalPrice = Convert.ToInt32(DB.DataTable.Rows[0]["TotalPrice"]);

                return true;

            }
            else
            {
                return false;

            }
        }

        public string Valid(string orderID, string quantity, string totalPrice)
        {
            String Error = "";

            if (orderID.Length == 0)
            {
                Error = Error + "The order ID may not be blank :";

            }
            if (orderID.Length > 6)
            {
                Error = Error + "The order ID must be less than 6 characters :";
            }
            try
            {
                Convert.ToInt32(orderID);
            }
            catch
            {
                Error = Error + "The order ID must be integers: ";
            }


            if (quantity.Length == 0)
            {
                Error = Error + "The quantity may not be blank :";

            }
            if (quantity.Length > 6)
            {
                Error = Error + "The quantity must be less than 6 characters :";
            }
            try
            {
                Convert.ToInt32(orderID);
            }
            catch
            {
                Error = Error + "The quantity must be integers: ";
            }
            if (totalPrice.Length == 0)
            {
                Error = Error + "The total price may not be blank :";

            }
            if (totalPrice.Length > 6)
            {
                Error = Error + "The total price must be less than 6 characters :";
            }
            try
            {
                Convert.ToInt32(orderID);
            }
            catch
            {
                Error = Error + "The totalprice must be integers: ";
            }
            return Error;
        }
    }
}