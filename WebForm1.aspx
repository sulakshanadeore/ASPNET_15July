<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServerSideStateMgtDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/About.aspx">AboutUs</asp:HyperLink>
        <p>
            Enter Product ID:
            <asp:TextBox ID="txtprodid" runat="server"></asp:TextBox>
&nbsp;</p>
        <p>
            Enter Product Name:
            <asp:TextBox ID="txtprodname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buy" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show My Shopping" />
        </p>
    </form>
</body>
</html>
