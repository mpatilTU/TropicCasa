<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeDetail.aspx.cs" Inherits="tropicasa.HomeDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet">
    <title>TropiCasa | HomeDetail</title>
    <link rel="stylesheet" href="./style/style.css" />
</head>
<body id="homeBody">
    <form id="form1" runat="server">
         <h1 class="mainPageHeading">HOME DETAIL</h1>
         <header>
             <asp:Button ID="homeListing" runat="server" Text="HOME LISTING" onClick="homeListing_Click"/>
             <asp:Button ID="home" runat="server" Text="HOME" onClick="home_Click"/>

         </header>

        <div>

            <div class="homedetail">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">

                    <Columns>
                        <asp:BoundField DataField="useremail" HeaderText="Owner Email" />
                        <asp:BoundField DataField="address" HeaderText="Address" />
                        <asp:BoundField DataField="type" HeaderText="Type" />
                        <asp:BoundField DataField="size" HeaderText="Size" />
                        <asp:BoundField DataField="bedrooms" HeaderText="Bedrooms" />
                        <asp:BoundField DataField="bathroom" HeaderText="Bathrooms" />
                        <asp:BoundField DataField="amenities" HeaderText="Amenities" />
                        <asp:BoundField DataField="heatingandcooling" HeaderText="Heating And Cooling" />
                        <asp:BoundField DataField="year" HeaderText="Year" />
                        <asp:BoundField DataField="utilities" HeaderText="Utilities" />
                        <asp:BoundField DataField="description" HeaderText="Description" />
                        <asp:BoundField DataField="price" HeaderText="Price" />
                        <asp:ImageField DataImageUrlField="imageurl" HeaderText="Image"></asp:ImageField> 
                        
                        <asp:BoundField DataField="imagecaption" HeaderText="Imagecaption" />

                    </Columns>


                </asp:GridView>

            </div>


             <div class="homedetail">
                 <h2 class="mainPageHeading">OWNER DETAILS</h2>
                 <asp:ListView ID="ListView1" runat="server">

                     <LayoutTemplate>
                        <table>
                            <tr>
                                <th>User Name</th>
                                <th>Full Name</th>
                                <th>Email</th>
                                <th>Phone</th>
                                <th>Address</th>
                            </tr>
                            <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("username") %></td>
                            <td><%# Eval("fullname") %></td>
                            <td><%# Eval("email") %></td>
                            <td><%# Eval("phone") %></td>
                            <td><%# Eval("address") %></td>
                        </tr>
                    </ItemTemplate>

                 </asp:ListView>
                
            </div>
        </div>
        
        <div class="bidBox">

            <asp:Button ID="updateHome" runat="server" Text="UPDATE HOME" onClick="updateHome_Click"/>
            
            <div class="bidAndFeedback">
                <asp:TextBox ID="bidboxText" placeholder="Enter Price For Bid" runat="server" ></asp:TextBox>
                <asp:TextBox ID="feedbackText" placeholder="Enter Comment" runat="server"></asp:TextBox>


                <div class="qs">
                    <asp:Label class="qspan" ID="Label3" runat="server" Text="How much would you be willing to pay for a comfortable and well-equipped home?"></asp:Label>
                    <asp:TextBox ID="TextBox1" placeholder="Enter Feedback" runat="server"></asp:TextBox>
                </div>

                <div class="qs">
                    <asp:Label class="qspan" ID="Label4" runat="server" Text="Would you consider a higher price for a home in a prime location?"></asp:Label>
                    <asp:TextBox ID="TextBox2" placeholder="Enter Feedback" runat="server"></asp:TextBox>
                </div>

                <div class="qs">
                    <asp:Label class="qspan" ID="Label5" runat="server" Text="What location would you prefer to live in, urban or rural?"></asp:Label>
                    <asp:TextBox ID="TextBox3" placeholder="Enter Feedback" runat="server"></asp:TextBox>
                </div>

                <div class="qs">
                    <asp:Label class="qspan" ID="Label6" runat="server" Text="What features do you consider essential when looking for a new home?"></asp:Label>
                    <asp:TextBox ID="TextBox4" placeholder="Enter Feedback" runat="server"></asp:TextBox>
                </div>

                <div class="qs">
                    <asp:Label class="qspan" ID="Label7" runat="server" Text="How important are ratings and reviews from previous occupants when considering a home?"></asp:Label>
                    <asp:TextBox ID="TextBox5" placeholder="Enter Feedback" runat="server"></asp:TextBox>
                </div>



                <asp:Button ID="bidAndFeed" runat="server" Text="SUBMIT" onclick="bidAndFeed_Click"/>
            </div>

            <div class="bidAndFeedback">
                
                <asp:Button ID="scheduleTour" runat="server" Text="SCHEDULE HOUSE TOUR" onClick="scheduleTour_Click"/>
            </div>

            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
