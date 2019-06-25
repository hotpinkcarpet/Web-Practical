<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="FormProject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <p><b>User Info</b></p>
            First Name:
            <b>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </b>
            <br />
            SecondName:
            <b>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </b>
            <br />
            Last Name:
            <b>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </b>
            <br />
            Address <br />
              &nbsp;&nbsp;&nbsp;
              Location:
            <b>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </b>
            <br />
              &nbsp;&nbsp;&nbsp;
              Postal:
            <b>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </b>
            <br />
              &nbsp;&nbsp;&nbsp;
              Phone:
            <b>
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </b>
            <br />
        </div>
    </form>
</body>
</html>
