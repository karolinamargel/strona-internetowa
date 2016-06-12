<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My photography</title>
    <link rel="stylesheet" href="StyleSheet1.css" />
</head>
<body>
    <h1 style="text-align:center;color:hotpink">Photography</h1>
    <form id="form1" runat="server">
    <div id="menu">
        <a href ="WebForm1.aspx">Home</a>
        <a href="WebForm2.aspx">Views</a>
        <a href="WebForm3.aspx">Animals</a>
        <a href="WebForm4.aspx">Architecture</a>
    </div>

    <div id="main">

        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="img_views">Views</asp:ListItem>
            <asp:ListItem Value="img_animals">Animals</asp:ListItem>
            <asp:ListItem Value="img_architecture">Architecture</asp:ListItem>
        </asp:DropDownList>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add image" />

    </div>

    </form>
</body>
</html>
