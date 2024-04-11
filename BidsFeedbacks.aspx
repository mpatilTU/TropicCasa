<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BidsFeedbacks.aspx.cs" Inherits="tropicasa.BidsFeedbacks" %>

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
    <h1 class="mainPageHeading">BIDS/FEEDBACK</h1>

         <header>
             <asp:Button ID="home" runat="server" Text="HOME" onClick="home_Click"/>
             
         </header>


        <div>

            <div class="home">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">

                    <Columns>
                        <asp:BoundField DataField="buyeremail" HeaderText="Buyers Email" />
                        <asp:BoundField DataField="bid" HeaderText="Bid" />
                        <asp:BoundField DataField="feedback" HeaderText="Comment" />

                        <asp:BoundField DataField="questionone" HeaderText="question one" />
                        <asp:BoundField DataField="questiontwo" HeaderText="question two" />
                        <asp:BoundField DataField="questionthree" HeaderText="question three" />
                        <asp:BoundField DataField="questionfour" HeaderText="question four" />
                        <asp:BoundField DataField="questionfive" HeaderText="question five" />

                    </Columns>


                </asp:GridView>

            </div>


        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
