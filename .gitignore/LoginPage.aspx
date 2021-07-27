<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="StateMgtDemo.LoginData" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnLogin_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server">
            Enter UserName:
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Password:
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </asp:Panel>
    </form>
</body>
</html>
