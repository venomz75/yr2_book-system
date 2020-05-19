<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="OrderLineID"></asp:Label>
            <asp:TextBox ID="txtOrderLineID" runat="server" OnTextChanged="txtOrderLine_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="OrderID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="txtOrderID_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="TotalPrice"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
