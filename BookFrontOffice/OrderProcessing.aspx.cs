using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class OrderProcessing : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        OrderID = Convert.ToInt32(Session["StaffID"]);
        if(IsPostBack == false)
        {
            if(OrderID != -1)
            {
                DisplayOrders();

            }


        }
       // Response.Write(AnOrder.OrderID);
    }

     void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrderBook.ThisOrder.CustomerID.ToString();
        txtDatePlaced.Text = OrderBook.ThisOrder.DatePlaced.ToString();
       txtCompleted.Text = OrderBook.ThisOrder.Completed.ToString();
        //txtOrderStatus.Text = OrderBook.ThisOrder.OrderStatus.ToString();
        txtStaffID.Text = OrderBook.ThisOrder.StaffID.ToString();

       
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        

        string CustomerID = txtCustomerID.Text;
        string DatePlaced = txtDatePlaced.Text;
        string Completed = txtCompleted.Text;
        string StaffID = txtStaffID.Text;
        string OrderStatus = txtOrderStatus.Text;
        string Error = "";
        Error = AnOrder.Valid(CustomerID, DatePlaced, Completed, StaffID, OrderStatus);
        if (Error =="")
        {
            AnOrder.OrderID = Convert.ToInt32(OrderID);

            AnOrder.CustomerID = Convert.ToInt32(CustomerID);

            AnOrder.DatePlaced = Convert.ToDateTime(DatePlaced);

            AnOrder.Completed = Convert.ToBoolean(Completed);

            AnOrder.StaffID = Convert.ToInt32(StaffID);

            AnOrder.OrderStatus = OrderStatus;

            clsOrderCollection OrderList = new clsOrderCollection();
            if(OrderID == 000)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            txtOrderID.Text = Convert.ToString(AnOrder.OrderID);
            txtCustomerID.Text = Convert.ToString(AnOrder.CustomerID);
            txtDatePlaced.Text = Convert.ToString(AnOrder.DatePlaced);
            txtCompleted.Text = Convert.ToString(AnOrder.Completed);
            txtStaffID.Text = Convert.ToString(AnOrder.StaffID);
            txtOrderStatus.Text = Convert.ToString(AnOrder.OrderStatus);

        }

    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}