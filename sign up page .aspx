<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sign up page .aspx.cs" Inherits="sign_up_page_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('background image.jpeg'); background-size:cover">
    
    <form id="form1" runat="server">
    <div align="center">
        
        <%--<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" style="z-index: 1; left: 764px; top: 93px;  width: 158px; height: 54px" Text="Sign up "></asp:Label>--%>
        <h1>SIGN UP</h1>
    <asp:Label ID="IbIMsg" runat="server" style="z-index: 1; left: 857px; top: 154px;"></asp:Label>
    
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 740px; top: 209px;  width: 126px; position: absolute;" Text="Full Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 912px; top: 206px;  width: 264px; position: absolute; margin-top: 0px;" MaxLength="50"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 729px; top: 244px; position: absolute; width: 126px; height: 33px;" Text="Email id"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 913px; top: 241px;  width: 425px; position: absolute;" MaxLength="50"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 752px; top: 284px; position: absolute;" Text="Phone no"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 914px; top: 280px; position: absolute; width: 220px;" ></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 734px; top: 481px; position: absolute; width: 118px" Text="Address"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 915px; top: 562px; position: absolute; width: 238px; "></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 752px; top: 479px; position: absolute; width: 84px; margin-top: 43px;" Text="City"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 760px; top: 561px; position: absolute; width: 76px" Text="State"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 723px; top: 599px; position: absolute; right: 955px;" Text="Pin Code"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 910px; top: 483px; position: absolute; width: 521px; "></asp:TextBox>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 722px; top: 398px; position: absolute" Text="Create password"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 915px; top: 397px; position: absolute; width: 211px; margin-bottom: 6px; margin-top: 0px;"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 913px; top: 440px; position: absolute;  width: 214px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 912px; top: 523px; position: absolute; width: 287px; "></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 915px; top: 596px; position: absolute;  width: 207px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 860px; top: 647px; position: absolute; width: 117px; " Text="Sign up" OnClick="Button1_Click" />
        
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 741px; top: 326px; position: absolute; height: 39px; width: 100px" Text="Gender"></asp:Label>
        <asp:RadioButton ID="RadioButton1" runat="server" style="z-index: 1; top: 328px; position: absolute; left: 921px" Text="Male" />
        <asp:RadioButton ID="RadioButton2" runat="server" style="z-index: 1; top: 329px; position: absolute; left: 1029px" Text="Female" />
        
            <p style="z-index: 1; left: 13px; top: 61px; position: absolute; height: 27px; width: 1776px">
                &nbsp;</p>
        <p style="z-index: 1; left: 7px; top: 122px; position: absolute; height: 27px; width: 1776px">
        
            <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 698px; position: absolute; width: 192px; height: 29px; top: 317px;" Text="Confirm password"></asp:Label>
        
        
        
        <p style="z-index: 1; left: 10px; top: 61px; position: absolute; height: 27px; width: 1776px">
            &nbsp;</p>
        
        
        
        <p style="z-index: 1; left: 10px; top: 61px; position: absolute; height: 27px; width: 1776px">
        
            
       
        </p>
        
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 751px; top: 357px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server" style="z-index: 1; left: 922px; top: 358px; position: absolute; width: 202px"></asp:TextBox>
        
     </div>   
        
    </form>
</body>
</html>
