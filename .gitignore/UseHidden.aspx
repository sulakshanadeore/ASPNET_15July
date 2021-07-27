<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseHidden.aspx.cs" Inherits="StateMgtDemo.UseHidden" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Enter Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="IBM" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
        </p>
    </form>
</body>
</html>
