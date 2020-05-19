using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class AnOrderLIneViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        Response.Write(AnOrderLine.OrderID);
    }
}