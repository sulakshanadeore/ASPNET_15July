<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="CachingDemo.WebUserControl1" %>
<%@ OutputCache Duration="1" 
    VaryByControl="TextBox1;TextBox2;Button1" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp; +&nbsp;
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
=<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate" />


