<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Login_Logout.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome</h2>
            <p></p>
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
            <br />
            <p></p>
            <asp:Button ID="BtnLogout" runat="server" Text="Logout" OnClick="BtnLogout_Click" />
        </div>
    </form>
</body>
</html>
