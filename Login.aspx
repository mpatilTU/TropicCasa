<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="tropicasa.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet">
    <title>TropiCasa | Login</title>
    <link rel="stylesheet" href="./style/style.css" />
</head>
<body id="loginBody">
    <form id="form1" runat="server">
        <div>

            <div class="loginBox">
                <h1 class="lrHeading">LOGIN</h1>
                <div class="inputsflexbox">
                    <asp:Label ID="emailLabel" runat="server" Text="EMAIL"></asp:Label>
                    <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
                </div>
                <div class="inputsflexbox">
                    <asp:Label ID="passwordLabel" runat="server" Text="PASSWORD"></asp:Label>
                    <asp:TextBox ID="passwordText" TextMode="Password" runat="server"></asp:TextBox>
                </div>
                <div class="checkboxflexbox">
                    <asp:Label ID="checkBoxLabel" runat="server">Remember Me</asp:Label>
                    <asp:CheckBox ID="CheckBox1" runat="server"/>
                </div>
                <asp:Button ID="buttonLogin" runat="server" Text="LOGIN" onClick="buttonLogin_Click"/>
               <div class="orBox">
                   <h3>OR</h3>
                   <a href="Register.aspx" class="link">REGISTER</a>
               </div>
                <asp:Label ID="loginSuccess" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="buttonDeleteCookie" runat="server" Text="DELETE COOKIE" onClick="buttonDeleteCookie_Click"/>
            </div>

        </div>
    </form>
</body>
</html>
