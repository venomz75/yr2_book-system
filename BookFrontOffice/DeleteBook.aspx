<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteBook.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?</div>
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Yes" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="No" />
    </form>
</body>
</html>
