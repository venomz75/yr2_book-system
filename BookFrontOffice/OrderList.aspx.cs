using BookClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if(IsPostBack == false)
        {
            DisplayOrders();
        }
    }
     void DisplayOrders()
    {
        BookClasses.clsOrderCollection Orders = new BookClasses.clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderStatus";
        lstOrderList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = 000;
        Response.Redirect("OrderProcessing.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("DeleteOrder.aspx");


        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderProcessing.aspx");


        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrderLine = new clsOrderCollection();
        AnOrderLine.ReportByOrderStatus(lstOrder.Text);
        lstOrderList.DataSource = AnOrderLine.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderStatus";
        lstOrderList.DataBind();
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrderLine = new clsOrderCollection();
        AnOrderLine.ReportByOrderStatus("");
        lstOrder.Text = "";
        lstOrderList.DataSource = AnOrderLine.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderStatus";
        lstOrderList.DataBind();
    }
}