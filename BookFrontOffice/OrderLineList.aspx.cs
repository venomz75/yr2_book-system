using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
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
        BookClasses.clsOrderLineCollection Orders = new BookClasses.clsOrderLineCollection();
        lstOrderLineList.DataSource = Orders.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineID";
        lstOrderLineList.DataTextField = "OrderLineID";
        lstOrderLineList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderLineID"] = -1;
        Response.Redirect("AnOrderLine.aspx");
    }

    

    

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("AnOrderLine.aspx");


        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        Session["OrderLineID"] = -1;
        Response.Redirect("AnOrderLine.aspx");
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("DeleteOrderLine.aspx");


        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    
        {
            Int32 OrderLineID;
            if (lstOrderLineList.SelectedIndex != -1)
            {
                OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
                Session["OrderLineID"] = OrderLineID;
                Response.Redirect("AnOrderLine.aspx");


            }
            else
            {
                lblError.Text = "Please select a record to delete from the list";
            }
        }
    }

