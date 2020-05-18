using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookClasses;

public partial class BookList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayBooks();
        }
    }

    void DisplayBooks()
    {
        clsBookCollection Books = new clsBookCollection();
        lstBookList.DataSource = Books.BookList;
        lstBookList.DataValueField = "BookID";
        lstBookList.DataTextField = "Title";
        lstBookList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["BookID"] = -1;
        Response.Redirect("ABook.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        lblError.Text = "Delete event fired";
        int BookID;
        if (lstBookList.SelectedIndex != -1)
        {
            BookID = Convert.ToInt32(lstBookList.SelectedValue);
            Session["BookID"] = BookID;
            Response.Redirect("DeleteBook.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list.";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int BookID;
        if (lstBookList.SelectedIndex != -1)
        {
            BookID = Convert.ToInt32(lstBookList.SelectedValue);
            Session["BookID"] = BookID;
            Response.Redirect("ABook.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsBookCollection Books = new clsBookCollection();
        Books.FilterByTitle(txtFilter.Text);
        lstBookList.DataSource = Books.BookList;
        lstBookList.DataValueField = "BookID";
        lstBookList.DataTextField = "Title";
        lstBookList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsBookCollection Books = new clsBookCollection();
        Books.FilterByTitle("");
        txtFilter.Text = "";
        lstBookList.DataSource = Books.BookList;
        lstBookList.DataValueField = "BookID";
        lstBookList.DataTextField = "Title";
        lstBookList.DataBind();
    }
}