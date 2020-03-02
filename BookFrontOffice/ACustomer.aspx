<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text3 {
            width: 150px;
            margin-left: 61px;
        }
        #Text2 {
            width: 150px;
            margin-left: 51px;
        }
        #Text1 {
            width: 150px;
            margin-left: 65px;
        }
        #Text4 {
            width: 150px;
            margin-left: 69px;
        }
        #Password1 {
            width: 150px;
            margin-left: 42px;
        }
        #Checkbox1 {
            margin-left: 15px;
        }
        #Name {
            margin-left: 56px;
        }
        #Address {
            margin-left: 42px;
        }
        #Password {
            margin-left: 33px;
        }
        #Email {
            margin-left: 60px;
        }
        #DoB {
            margin-left: 52px;
        }
        #Cancel {
            margin-left: 19px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name<input id="txtName" type="text" /><br />
            Address<input id="Address" type="text" /><br />
            D.o.B.<input id="DoB" type="text" /><br />
            Email<input id="Email" type="text" /><br />
            Password<input id="Password" type="password" /><br />
            Premium Acc<input id="PremiumAccount" type="checkbox" /><br />
            <input id="btnOK" type="button" value="button" /><input id="Button1" type="button" value="button" /></div>
    </form>
    </body>
</html>
