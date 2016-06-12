<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet"href="StyleSheet1.css" />
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
    <div>
    
    </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="PREVIOUS" Width="150px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="NEXT" Width="150px" />
        <p>
        <asp:Image ID="Image1" runat="server" Height="480px" Width="640px" />
        </p>
    </form>
</body>
</html>
