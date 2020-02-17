<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnReview.aspx.cs" Inherits="AnReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Reviewer Name:
            <input id="txtReviewName" type="text" /></div>
        <br />
        Date Added:&nbsp;&nbsp;&nbsp; <input id="Text2" type="text" /><br />
        <br />
        Star Rating:&nbsp;&nbsp;
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>1 Star</asp:ListItem>
            <asp:ListItem>2 Star</asp:ListItem>
            <asp:ListItem>3 Star</asp:ListItem>
            <asp:ListItem>4Star</asp:ListItem>
            <asp:ListItem>5 Star</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        Would Use Again?
        <asp:RadioButtonList ID="txtWouldUse" runat="server" OnSelectedIndexChanged="txtWouldUse_SelectedIndexChanged">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <p>
            <asp:RadioButton ID="Active" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" />
        </p>
        <p>
            <asp:Button ID="Ok_button" runat="server" OnClick="Button1_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cancel_button" runat="server" Text="Cancel" OnClick="Button2_Click" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
