using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        BookClasses.clsOrderCollection Orders = new BookClasses.clsOrderCollection();
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "OrderID";
        lstOrders.DataTextField = "CustomerID";
        lstOrders.DataBind();
    }
}