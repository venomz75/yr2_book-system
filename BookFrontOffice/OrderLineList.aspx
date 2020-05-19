<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderLineList" runat="server" Height="388px" Width="490px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click1" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="Button2_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click1" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
