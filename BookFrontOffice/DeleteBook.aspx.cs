using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class Delete : System.Web.UI.Page
{
    int BookID;

    protected void Page_Load(object sender, EventArgs e)
    {
        BookID = Convert.ToInt32(Session["BookID"]);
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        clsBookCollection ABook = new clsBookCollection();
        ABook.ThisBook.Find(BookID);
        ABook.Delete();
        Response.Redirect("BookList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookList.aspx");
    }
}