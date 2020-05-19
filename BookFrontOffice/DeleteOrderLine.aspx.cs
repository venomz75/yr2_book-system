using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class DeleteOrderLine : System.Web.UI.Page
{
    Int32 OrderLineID;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderBook = new clsOrderLineCollection();
        OrderBook.ThisOrderLine.Find(OrderLineID);
        OrderBook.Delete();
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderBook = new clsOrderLineCollection();
        Response.Redirect("OrderLineList.aspx");
    }
}

