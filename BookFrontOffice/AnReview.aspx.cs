using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class AnReview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsReview
        clsReview AnReview = new clsReview();
        //get the data from the session object
        AnReview = (clsReview)Session["AnReview"];
        //display the Reviewer name for this entry
        Response.Write(AnReview.ReviewerName);
   
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsReview
        clsReview AnReview = new clsReview();
        //capture the review name
        AnReview.ReviewerName = Ok_button.Text;
        //capture the date
        AnReview.DateAdded = Convert.ToDateTime(Ok_button.Text);
        //capture star rating 
       
        //store the review in the session object
        Session["AnReview"] = AnReview;
        //redirect to the viewer page
        Response.Redirect("ReviewViewer.aspx");

    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        //create a new instance of clsReview
        clsReview AnReview = new clsReview();
        //capture the review name
        AnReview.ReviewerName = Cancel_button.Text;
        //store the review in the session object
        Session["AnReview"] = AnReview;
        //redirect to the viewer page
        Response.Redirect("ReviewViewer.aspx");
    }


}