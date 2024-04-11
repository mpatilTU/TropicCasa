<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="tropicasa.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet">

    <title>TropiCasa | Home</title>

    <link rel="stylesheet" href="./style/style.css" />
</head>
<body id="homeBody">
    <form id="form1" runat="server">
        <h1 class="mainPageHeading">HOME</h1>

        <header>
            <a id="homePageLanding" href="LandingPage.aspx">Home</a>
            <asp:Button ID="homeListing" runat="server" Text="HOME LISTING" OnClick="homeListing_Click" />
            <asp:Button ID="bidsfeedbacks" runat="server" Text="BIDS/FEEDBACKS" OnClick="bidsfeedbacks_Click" />
            <asp:Button ID="st" runat="server" Text="TOUR REQUESTS" OnClick="st_Click" />
        </header>

        <div class="homeSearchBox">
            <h2>Tropicasa Search</h2>
            <div class="searchFlexBox">
                <div class="searchItems">
                    <div class="inputsflexbox">
                        <asp:Label ID="locationLabel1" runat="server" Text="LOCATION"></asp:Label>
                        <asp:TextBox ID="locationText1" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="priceLabel1" runat="server" Text="PRICE (include commas)"></asp:Label>
                        <asp:TextBox ID="priceText1" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="search1" CssClass="homeSearchBtn" runat="server" Text="SEARCH" OnClick="search1_Click" />
                </div>

                <div class="searchItems">
                    <div class="inputsflexbox">
                        <asp:Label ID="locationLabel2" runat="server" Text="LOCATION"></asp:Label>
                        <asp:TextBox ID="locationText2" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="priceLabel2" runat="server" Text="PRICE (include commas)"></asp:Label>
                        <asp:TextBox ID="priceText2" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="typeLabel2" runat="server" Text="TYPE"></asp:Label>
                        <asp:TextBox ID="typeText2" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="search2" CssClass="homeSearchBtn" runat="server" Text="SEARCH" OnClick="search2_Click" />
                </div>

                <div class="searchItems">
                    <div class="inputsflexbox">
                        <asp:Label ID="locationLabel3" runat="server" Text="LOCATION"></asp:Label>
                        <asp:TextBox ID="locationText3" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="Label3" runat="server" Text="PRICE (include commas)"></asp:Label>
                        <asp:TextBox ID="priceText3" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="Label4" runat="server" Text="TYPE"></asp:Label>
                        <asp:TextBox ID="typeText3" runat="server"></asp:TextBox>
                    </div>

                    <div class="inputsflexbox">
                        <asp:Label ID="Label2" runat="server" Text="Number of Bedrooms"></asp:Label>
                        <asp:TextBox ID="bedroomText3" runat="server"></asp:TextBox>
                    </div>

                    <div class="inputsflexbox">
                        <asp:Label ID="Label5" runat="server" Text="Number of Bathrooms"></asp:Label>
                        <asp:TextBox ID="bathroomText3" runat="server"></asp:TextBox>
                    </div>

                    <asp:Button ID="search3" CssClass="homeSearchBtn" runat="server" Text="SEARCH" OnClick="search3_Click" />
                </div>

                <div class="searchItems">
                    <div class="inputsflexbox">
                        <asp:Label ID="Label6" runat="server" Text="LOCATION"></asp:Label>
                        <asp:TextBox ID="locationText4" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="Label7" runat="server" Text="PRICE (include commas)"></asp:Label>
                        <asp:TextBox ID="priceText4" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="Label8" runat="server" Text="TYPE"></asp:Label>
                        <asp:TextBox ID="typeText4" runat="server"></asp:TextBox>
                    </div>

                    <div class="inputsflexbox">
                        <asp:Label ID="Label9" runat="server" Text="Number of Bedrooms"></asp:Label>
                        <asp:TextBox ID="bedroomText4" runat="server"></asp:TextBox>
                    </div>

                    <div class="inputsflexbox">
                        <asp:Label ID="Label10" runat="server" Text="Number of Bathrooms"></asp:Label>
                        <asp:TextBox ID="bathroomText4" runat="server"></asp:TextBox>
                    </div>

                    <div class="inputsflexbox">
                        <asp:Label ID="Label11" runat="server" Text="Amenities"></asp:Label>
                        <asp:TextBox ID="amenitiesText4" runat="server"></asp:TextBox>
                    </div>

                    <asp:Button ID="search4" CssClass="homeSearchBtn" runat="server" Text="SEARCH" OnClick="search4_Click" />
                </div>

                <div class="searchItems">

                    <div class="inputsflexbox">
                        <asp:Label ID="Label13" runat="server" Text="PRICE (include commas)"></asp:Label>
                        <asp:TextBox ID="priceText5" runat="server"></asp:TextBox>
                    </div>
                    <div class="inputsflexbox">
                        <asp:Label ID="Label14" runat="server" Text="TYPE"></asp:Label>
                        <asp:TextBox ID="typeText5" runat="server"></asp:TextBox>
                    </div>

                    <asp:Button ID="search5" CssClass="homeSearchBtn" runat="server" Text="SEARCH" OnClick="search5_Click" />
                </div>

                <div class="searchItems">
                    <div class="inputsflexbox">
                        <asp:Label ID="Label15" runat="server" Text="TYPE"></asp:Label>
                        <asp:TextBox ID="typeText6" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="search6" CssClass="homeSearchBtn" runat="server" Text="SEARCH" OnClick="search6_Click" />
                </div>
            </div>
        </div>

        <div>

            <div class="home">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">

                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Home Id" />
                        <asp:BoundField DataField="address" HeaderText="Address" />
                        <asp:BoundField DataField="type" HeaderText="Type" />
                        <asp:BoundField DataField="size" HeaderText="Size" />
                        <asp:BoundField DataField="bedrooms" HeaderText="Bedrooms" />
                        <asp:BoundField DataField="bathroom" HeaderText="Bathrooms" />
                        <asp:BoundField DataField="useremail" HeaderText="Owner Email" />
                        <asp:BoundField DataField="price" HeaderText="Price" />

                        <asp:ImageField DataImageUrlField="imageurl" HeaderText="Image"></asp:ImageField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="viewFullHome" runat="server" OnClick="viewFullHome_Click" CommandArgument='<%# Eval("Id") + "," + Eval("useremail") %>'>VIEW HOME</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>