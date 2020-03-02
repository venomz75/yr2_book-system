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
            <input id="txtName" type="text" /></div>
        <br />
        Date Added:&nbsp;&nbsp;&nbsp; <input id="txtDate" type="text" /><br />
        <br />
        Star Rating:&nbsp;&nbsp;
        <input id="Text1" type="text" /><br />
        <br />
        <br />
        Would Use Again?
        <input id="Text2" type="text" /><br />
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
