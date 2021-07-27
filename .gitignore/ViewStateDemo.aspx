<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateDemo.aspx.cs" Inherits="StateMgtDemo.ViewStateDemo" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnacceptdata_Click(object sender, EventArgs e)
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
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" BackColor="#66FFFF" BorderColor="#33CC33" BorderStyle="Solid" Width="289px">
                Enter Name:
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:Button ID="btnacceptdata" runat="server" Text="Accept" OnClick="btnacceptdata_Click" />
                &nbsp;&nbsp;
            </asp:Panel>
            <br />
            <br />
            <br />
        </div>
        <asp:Panel ID="Panel1" runat="server" BorderColor="#3366FF" BorderStyle="Dotted" Width="308px">
            WELCOME,&nbsp;&nbsp;<asp:TextBox ID="txtdisplay" runat="server" Enabled="False"></asp:TextBox>
            &nbsp;<asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
            &nbsp;&nbsp;&nbsp;
        </asp:Panel>
        <hr />
        Number of htis to this page =&nbsp;&nbsp;
        <asp:Label ID="txthits" runat="server"></asp:Label>
    </form>
</body>
</html>
