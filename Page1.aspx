<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="CachingDemo.Page1" %>
<%@ OutputCache Duration="15" 
        VaryByControl="DropDownList1;Button1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;Time :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Large" ForeColor="#009900"></asp:Label>
            <br />
            <hr />
            <br />
            Enter Product ID:
            <asp:TextBox ID="txtprodid" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go to the next page" />
            <br />
            <br />
            Select Product:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select </asp:ListItem>
                <asp:ListItem>Mobile</asp:ListItem>
                <asp:ListItem>Watch</asp:ListItem>
                <asp:ListItem>Laptop</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Select Qty:
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>Select Qty</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
