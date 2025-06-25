<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login page.aspx.cs" Inherits="login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(background-image.jpeg)">
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="IbIMsg" runat="server" style="z-index: 1; left: 575px; top: 156px; position: absolute; right: 1204px" Text="Label"></asp:Label>

    </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 589px; top: 101px; position: absolute; width: 194px; height: 47px" Text="Login Page"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 460px; top: 212px; position: absolute; width: 123px; margin-bottom: 137px" Text="Username"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 459px; top: 308px; position: absolute; width: 113px" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 644px; top: 209px; position: absolute; width: 355px; height: 40px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 642px; top: 301px; position: absolute; height: 38px; width: 289px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Medium" style="z-index: 1; left: 570px; top: 389px; position: absolute; width: 218px" Text="login" OnClick="Button2_Click" />
    </form>
</body>
</html>
