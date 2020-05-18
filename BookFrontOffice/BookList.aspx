<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookList.aspx.cs" Inherits="BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstBookList" runat="server" Height="235px" Width="247px"></asp:ListBox>
            <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="lblFilter" runat="server" Text="Enter a title"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </form>
</body>
</html>
