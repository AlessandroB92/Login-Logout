<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Login_Logout.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <div>
                <label>Username:</label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <p></p>
            </div>
            <div>
                <label>Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <p></p>
            </div>
            <div>
                <asp:CheckBox ID="chkRememberMe" runat="server" Text="Ricorda i miei dati" />
            </div>
            <p></p>
            <div>
                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" Width="133px" />
            </div>
        </div>
    </form>
</body>
</html>
