<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="tropicasa.Verify" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TropiCasa | Verify</title>
    <link rel="stylesheet" href="./style/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="verifyBox">
           <h1>VERIFY</h1>
             <div class="inputsflexbox">
                    <asp:Label ID="emailLabel" runat="server" Text="EMAIL"></asp:Label>
                    <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
             </div>
            <asp:Button ID="buttonVerify" runat="server" Text="VERIFY" onClick="buttonVerify_Click"/>
            <asp:Label ID="Label1" runat="server" Text="Verify"></asp:Label>

        </div>
    </form>
</body>
</html>
