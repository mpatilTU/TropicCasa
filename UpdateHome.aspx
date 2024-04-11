<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateHome.aspx.cs" Inherits="tropicasa.UpdateHome" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet">
    <title>TropiCasa | Home Update</title>
    <link rel="stylesheet" href="./style/style.css" />
</head>
<body id="homeBody">
     <form id="form1" runat="server">
         <header>
             <asp:Button ID="home" runat="server" Text="HOME" onclick="home_Click"/>
            
        </header>
        <div>
            
             <div class="listingBox">
                <h1 class="lrHeading">HOME UPDATE</h1>
               
                 <div class="inputsflexbox">
                    <asp:Label ID="emailLabel" runat="server" Text="EMAIL"></asp:Label>
                    <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
                </div>

                <div class="inputsflexbox">
                    <asp:Label ID="addressLabel" runat="server" Text="HOME ADDRESS"></asp:Label>
                    <asp:TextBox ID="addressText" runat="server"></asp:TextBox>
                </div>

                <div class="inputsflexbox">
                    <asp:Label ID="typeLabel" runat="server" Text="HOME TYPE"></asp:Label>
                    <asp:DropDownList ID="types" runat="server">
                        <asp:ListItem Value="singlefamily" Text="Single Family"></asp:ListItem>
                        <asp:ListItem Value="multifamily" Text="Multi Family"></asp:ListItem>
                        <asp:ListItem Value="townhouse" Text="Townhouse"></asp:ListItem>
                        <asp:ListItem Value="condo" Text="Condo"></asp:ListItem>
                     </asp:DropDownList>
                </div>

                <div class="inputsflexbox">
                     <asp:Label ID="sizeLabel" runat="server" Text="HOME SIZE"></asp:Label>
                     <asp:TextBox ID="sizeText" runat="server"></asp:TextBox>
                </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="bedroomsLabel" runat="server" Text="Number of Bedrooms"></asp:Label>
                    <asp:TextBox ID="bedroomsText" runat="server"></asp:TextBox>
                 </div>
                
                 <div class="inputsflexbox">
                    <asp:Label ID="bathroomsLabel" runat="server" Text="Number of Bathrooms"></asp:Label>
                    <asp:TextBox ID="bathroomsText" runat="server"></asp:TextBox>
                 </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="amenitiesLabel" runat="server" Text="Amenities"></asp:Label>
                    <asp:TextBox ID="amenitiesText" runat="server"></asp:TextBox>
                 </div>
               
                 <div class="inputsflexbox">
                    <asp:Label ID="hsLabel" runat="server" Text="Heating & Cooling System"></asp:Label>
                    <asp:TextBox ID="hsText" runat="server"></asp:TextBox>
                 </div>

                  <div class="inputsflexbox">
                    <asp:Label ID="yearLabel" runat="server" Text="YEAR"></asp:Label>
                    <asp:TextBox ID="yearText" runat="server"></asp:TextBox>
                 </div>


                 <div class="inputsflexbox">
                    <asp:Label ID="garageLabel" runat="server" Text="GARAGE"></asp:Label>
                    <asp:DropDownList ID="garageDropDownList" runat="server">
                        <asp:ListItem Value="none" Text="None"></asp:ListItem>
                        <asp:ListItem Value="2cars" Text="2 Cars"></asp:ListItem>
                        <asp:ListItem Value="3cars" Text="3 Cars"></asp:ListItem>
                        <asp:ListItem Value="4cars" Text="4 Cars"></asp:ListItem>
                     </asp:DropDownList>
                </div>

                  <div class="inputsflexbox">
                    <asp:Label ID="utilitiesLabel" runat="server" Text="UTILITIES"></asp:Label>
                    <asp:TextBox ID="utilitiesText" runat="server"></asp:TextBox>
                 </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="descriptionLabel" runat="server" Text="DESCRIPTION"></asp:Label>
                    <asp:TextBox ID="descriptionText" runat="server"></asp:TextBox>
                 </div>

                 <div class="inputsflexbox">
                    <asp:Label ID="priceLabel" runat="server" Text="PRICE"></asp:Label>
                    <asp:TextBox ID="priceText" runat="server"></asp:TextBox>
                 </div>

                 <asp:FileUpload ID="FileUpload1" runat="server" />

                  <div class="inputsflexbox">
                    <asp:Label ID="imagecaptionLabel" runat="server" Text="IMAGE CAPTION"></asp:Label>
                    <asp:TextBox ID="imagecaptionText" runat="server"></asp:TextBox>
                 </div>

                 <div class="updateAndDelete">
                     <asp:Button ID="updateHomeBtn" runat="server" Text="UPDATE HOME" onClick="updateHomeBtn_Click"/>
                 
                      <asp:Button ID="deleteBtn" runat="server" Text="DELETE" onclick="deleteBtn_Click"/>
                 </div>
                 

                <asp:Label ID="listSuccess" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
