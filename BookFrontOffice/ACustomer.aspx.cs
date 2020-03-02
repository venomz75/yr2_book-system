using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomers
        clsCustomers ACustomer = new clsCustomers();
        //get the data from the session object
        ACustomer = (clsCustomers)Session["ACustomer"];
        //display the house number for this entry
        Response.Write(ACustomer.Name);
    }


}