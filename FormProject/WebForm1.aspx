<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="FormProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name:
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 21px"></asp:TextBox>
            <br /><br />
            Second Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br /><br />
            Last Name:<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 23px"></asp:TextBox>
            <br /><br />
            Location :
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 29px"></asp:TextBox>
            <br /><br />
            Postal   :
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 45px"></asp:TextBox>
            <br /><br />
            Phone Num:
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 15px"></asp:TextBox>
            <br /><br />
            <a href="C:\Users\Junn\source\repos\FormProject\FormProject\WebForm2.aspx.vb"><asp:Button ID="Button1" runat="server" Text="Submit"  /></a> 
            <br />

        </div>
    </form>
</body>
</html>
