using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class ABook : System.Web.UI.Page
{
    int BookID;

    protected void Page_Load(object sender, EventArgs e)
    {
        BookID = Convert.ToInt32(Session["ABook"]);
        if (IsPostBack == false)
        {
            if (BookID != 1)
            {
                DisplayBook();
            }
        }
    }

    void DisplayBook()
    {
        clsBookCollection BookList = new clsBookCollection();
        BookList.ThisBook.Find(BookID);
        txtBookID.Text = BookList.ThisBook.BookID.ToString();
        txtTitle.Text = BookList.ThisBook.Title;
        txtDatePublished.Text = BookList.ThisBook.DatePublished.ToString();
        txtStock.Text = BookList.ThisBook.Stock.ToString();
        txtPrice.Text = BookList.ThisBook.Price.ToString();
        chkAvailableOnline.Checked = BookList.ThisBook.AvailableOnline;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsBook ABook = new clsBook();
        string Title = txtTitle.Text;
        DateTime DatePublished = Convert.ToDateTime(txtDatePublished.Text);
        int Stock = Convert.ToInt32(txtStock.Text);
        float Price = Convert.ToSingle(txtPrice.Text);
        bool AvailableOnline = chkAvailableOnline.Checked;
        string Error = "";
        Error = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
        if (Error == "")
        {
            ABook.BookID = BookID;
            ABook.Title = Title;
            ABook.DatePublished = DatePublished;
            ABook.Stock = Stock;
            ABook.Price = Price;
            ABook.AvailableOnline = AvailableOnline;
            clsBookCollection BookList = new clsBookCollection();

            if (BookID == -1)
            {
                BookList.ThisBook = ABook;
                BookList.Add();
            }
            else
            {
                BookList.ThisBook.Find(BookID);
                BookList.ThisBook = ABook;
                BookList.Update();
            }
            BookList.ThisBook = ABook;
            BookList.Add();
            Response.Redirect("BookList.aspx");
        }
        else
        {
            lblError.Text = "ERROR: Book ID must be an integer.";
        }
    }

        protected void btnFind_Click(object sender, EventArgs e)
    {
        clsBook ABook = new clsBook();
        int BookID;
        bool found = false;
        if (int.TryParse(txtBookID.Text, out BookID))
        {
            BookID = Convert.ToInt32(txtBookID.Text);
            found = ABook.Find(BookID);
            if (found)
            {
                txtBookID.Text = Convert.ToString(ABook.BookID);
                txtTitle.Text = ABook.Title;
                txtDatePublished.Text = Convert.ToString(ABook.DatePublished);
                txtStock.Text = Convert.ToString(ABook.Stock);
                txtPrice.Text = Convert.ToString(ABook.Price);
                chkAvailableOnline.Checked = ABook.AvailableOnline;
            }
            else
            {
                lblError.Text = "ERROR: Record not found with ID: " + BookID + ".";
            }
        }
        else
        {
            lblError.Text = "ERROR: Book ID must be an integer.";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookList.aspx");
    }
}