using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;



public partial class OrderProcessing : System.Web.UI.Page
{
    private TextBox txtStatus;

    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderID);
         

    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.OrderStatus = txtStatus.Text;
        Session["AnOrderStatus"] = AnOrder;
        Response.Redirect("OrderStatus.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void txtOderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}