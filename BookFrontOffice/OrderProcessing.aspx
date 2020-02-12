<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessing.aspx.cs" Inherits="OrderProcessing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            width: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            OrderID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            CustomerID&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            DatePlaced&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            Completed&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <br />
            OrderStatus&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 26px" Text="Button" />
            <br />
            <br />
            </div>
    </form>
</body>
</html>
