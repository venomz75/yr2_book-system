using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class AnOrderLine : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
      //  Response.Write(AnOrderLine.OrderID);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        string OrderID = txtOrderID.Text;
        string Quantity = txtQuantity.Text;
        string TotalPrice = txtTotalPrice.Text;
        string Error = "";
        Error = AnOrderLine.Valid(OrderID, Quantity, TotalPrice);
        if (Error == "")
        {
            AnOrderLine.OrderLineID = Convert.ToInt32(OrderLineID);

            AnOrderLine.OrderID = Convert.ToInt32(OrderID);

            AnOrderLine.Quantity = Convert.ToInt32(Quantity);

            AnOrderLine.TotalPrice = Convert.ToInt32(TotalPrice);

            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            if (OrderLineID == -1)
            {
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Add();
            }
            else
            {
                OrderLineList.ThisOrderLine.Find(OrderLineID);
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Update();
            }
            Response.Redirect("OrderLineList.aspx");


            
            
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void txtOrderLine_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderID_TextCh(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        Int32 OrderLineID;
        Boolean Found = false;
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        Found = AnOrderLine.Find(OrderLineID);
        if (Found == true)
        {
            txtOrderLineID.Text = Convert.ToString(AnOrderLine.OrderLineID);
            txtOrderID.Text = Convert.ToString(AnOrderLine.OrderID);
            txtQuantity.Text = Convert.ToString(AnOrderLine.Quantity);
            txtTotalPrice.Text = Convert.ToString(AnOrderLine.TotalPrice);
           

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}