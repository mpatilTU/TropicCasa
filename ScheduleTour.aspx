<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScheduleTour.aspx.cs" Inherits="tropicasa.ScheduleTour" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet">
     <title>TropiCasa | Tour Requests</title>
    <link rel="stylesheet" href="./style/style.css" />
</head>
<body id="homeBody">
     <form id="form1" runat="server">
    <h1 class="mainPageHeading">TOUR REQUESTS</h1>

         <header>
             <asp:Button ID="home" runat="server" Text="HOME" onclick="home_Click"/>
             
         </header>


        <div>

            <div class="home">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">

                    <Columns>
                         <asp:BoundField DataField="Id" HeaderText="ID" />
                        <asp:BoundField DataField="buyeremail" HeaderText="Buyers Email" />
                        
                    </Columns>


                </asp:GridView>

            </div>

              <div class="bidAndFeedback">
                
                <asp:Button ID="acceptTours" runat="server" Text="ACCEPT"/>
                <asp:Button ID="rejectTours" runat="server" Text="REJECT"/>

            </div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
