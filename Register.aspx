<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="tropicasa.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet">
    <title>TropiCasa | Register</title>
    <link rel="stylesheet" href="./style/style.css" />
</head>
<body id="registerBody">
    <form id="form1" runat="server">
        <div>

             <div class="registerBox">
                <h1 class="lrHeading">REGISTER</h1>
                <div class="inputsflexbox">
                    <asp:Label ID="usernameLabel" runat="server" Text="USERNAME"></asp:Label>
                    <asp:TextBox ID="usernameText" runat="server"></asp:TextBox>
                </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="fullnameLabel" runat="server" Text="FULLNAME"></asp:Label>
                    <asp:TextBox ID="fullnameText" runat="server"></asp:TextBox>
                </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="emailLabel" runat="server" Text="EMAIL"></asp:Label>
                    <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
                </div>

                <div class="inputsflexbox">
                    <asp:Label ID="passwordLabel" runat="server" Text="PASSWORD"></asp:Label>
                    <asp:TextBox ID="passwordText" TextMode="Password" runat="server"></asp:TextBox>
                </div>

                <div class="inputsflexbox">
                    <asp:Label ID="phoneLabel" runat="server" Text="PHONE"></asp:Label>
                    <asp:TextBox ID="phoneText" runat="server"></asp:TextBox>
                </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="addressLabel" runat="server" Text="ADDRESS"></asp:Label>
                    <asp:TextBox ID="addressText" runat="server"></asp:TextBox>
                </div>
                <div class="inputsflexbox">
                     <asp:Label ID="srole" runat="server" Text="ROLES"></asp:Label>
                     <asp:DropDownList ID="roles" runat="server">
                        <asp:ListItem Value="buyers" Text="Home Buyers"></asp:ListItem>
                        <asp:ListItem Value="sellers" Text="Home Sellers"></asp:ListItem>
                        <asp:ListItem Value="agents" Text="Real Estate Agents "></asp:ListItem>
                     </asp:DropDownList>
                </div>
                 <div class="inputsflexbox">
                    <asp:Label ID="questiononeLabel" runat="server" Text="FAVOURITE PET?"></asp:Label>
                    <asp:TextBox ID="questiononeText" runat="server"></asp:TextBox>
                 </div>
                
                 <div class="inputsflexbox">
                    <asp:Label ID="questiontwoLabel" runat="server" Text="NICK NAME?"></asp:Label>
                    <asp:TextBox ID="questiontwoText" runat="server"></asp:TextBox>
                 </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="questionthreeLabel" runat="server" Text="FAVOURITE SUPERHERO?"></asp:Label>
                    <asp:TextBox ID="questionthreeText" runat="server"></asp:TextBox>
                 </div>
               

                 <asp:Button ID="buttonRegister" runat="server" Text="REGISTER" onClick="buttonRegister_Click"/>
                 <div class="orBox">
                    <h3>Already Have an Account?</h3>
                    <a href="Login.aspx" class="link">LOGIN</a>
                 </div>
                <asp:Label ID="registerSuccess" runat="server" Text="Label"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>
