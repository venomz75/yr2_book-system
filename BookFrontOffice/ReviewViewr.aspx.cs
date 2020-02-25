using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class ReviewViewr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsReview
        clsReview AnReview = new clsReview();
        //get the data from the session object
        AnReview = (clsReview)Session["AnReview"];
        //display the Reviewer name for this entry
        Response.Write(AnReview.ReviewerName);
    }

  
}