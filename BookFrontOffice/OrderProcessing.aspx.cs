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
        //capture order id
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);

        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);

        AnOrder.DatePlaced = Convert.ToDateTime(txtDatePlaced.Text);

        AnOrder.Completed = Convert.ToBoolean(txtCompleted.Text);

        AnOrder.OrderStatus = txtOrderStatus.Text;


        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

    }
}