<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormHolaMundo.aspx.cs" Inherits="WebApplication1.WebFormHolaMundo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="ButtonSaludar" runat="server" OnClick="ButtonSaludar_Click" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
