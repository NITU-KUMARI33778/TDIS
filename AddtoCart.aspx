<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddtoCart.aspx.cs" Inherits="TDIS_PurchaseDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SHOW" />
        <asp:Label ID="Label1" runat="server" Text="ADD TO CART"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 864px; top: 385px; position: absolute; margin-top: 0px"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="316px" Width="1031px">
            <Columns>
                <asp:BoundField DataField="Item_name" HeaderText="ITEM NAME" />
                <asp:BoundField DataField="Rate" HeaderText="RATE" />
                <asp:BoundField DataField="Qty" HeaderText="QTY" />
                <asp:BoundField DataField="Amount" HeaderText="AMOUNT" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
