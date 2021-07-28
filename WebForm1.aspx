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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Value in the Session" />
    </form>
</body>
</html>
