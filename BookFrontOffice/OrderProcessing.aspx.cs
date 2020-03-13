using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class OrderProcessing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
      //  Response.Write(AnOrder.OrderID);
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
            

            AnOrder.CustomerID = Convert.ToInt32(CustomerID);

            AnOrder.DatePlaced = Convert.ToDateTime(DatePlaced);

            AnOrder.Completed = Convert.ToBoolean(Completed);

            AnOrder.StaffID = Convert.ToInt32(StaffID);

            AnOrder.OrderStatus = txtOrderStatus.Text;
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
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
            txtOrderStatus.Text = AnOrder.OrderStatus;

        }

    }
}