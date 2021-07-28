<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WholeStateMgtDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 888px;
        }
        .auto-style3 {
            width: 116px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <table style="background-color:pink;border:10px solid green" class="auto-style2">
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label1" runat="server" Text="Enter User Name:"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtusname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label2" runat="server" Text="Enter Password"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
