<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ABook.aspx.cs" Inherits="ABook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="">
            &nbsp;<asp:Label ID="lblID" runat="server" Text="Book ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            &nbsp;<br />
            <asp:Label ID="lblDatePublished" runat="server" Text="Date Published"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDatePublished" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblStock" runat="server" Text="Stock"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            &nbsp;
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:CheckBox ID="chkAvailableOnline" runat="server" Text="Available Online" />
            <br />
        </div>
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" EnableTheming="True" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
