<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessing.aspx.cs" Inherits="OrderProcessing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            OrderID<asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        </div>
        CustomerID<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <p>
            DatePlaced<asp:TextBox ID="txtDatePlaced" runat="server"></asp:TextBox>
        </p>
        Completed<asp:TextBox ID="txtCompleted" runat="server"></asp:TextBox>
        <p>
            OrderStatus<asp:TextBox ID="txtOrderStatus" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
