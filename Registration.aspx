<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ValidationDemo.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name:&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="This is a compulsory field" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Enter Age
            <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtage" ErrorMessage="*age is compulsory" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" ErrorMessage="Age must be in the range of 18 to 60" ForeColor="Red" MaximumValue="60" MinimumValue="18"></asp:RangeValidator>
            <br />
            <br />
            Enter Email<asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Pls enter valid email id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            Enter UserID<asp:TextBox ID="txtuserid" runat="server" MaxLength="30"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtuserid" ErrorMessage="User id is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<br />
            <br />
            Enter Password<asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
            Confirm Password<asp:TextBox ID="txtconfirmpwd" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtconfirmpwd" ErrorMessage="Passwords donot match" ForeColor="Red"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
