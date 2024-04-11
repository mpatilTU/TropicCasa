<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="tropicasa.LandingPage" %>

<%@ Register Src="~/WebUserControl2.ascx" TagPrefix="uc1" TagName="WebUserControl2" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;700;900&display=swap" rel="stylesheet" />
    <title>TropiCasa | Landing</title>
    <link rel="stylesheet" href="./style/style.css" />
</head>
<body class="container">

    <div class="navBox">
        <div>
            <img src="./assets/TROPICASA.png" alt="TROPICASA" class="header__logo" />
        </div>
        <nav>
            <ul>
                <li><a href="LandingPage.aspx">Home</a></li>
                <li><a href="Login.aspx">Login</a></li>
                <li><a href="Register.aspx">Register</a></li>
            </ul>
        </nav>
    </div>

    <header class="header">
        <h1 class="heading-1">NEED A HOME? WELCOME TO TROPICASA.</h1>
        <!-- <button class="btn btn-banner">View our properties</button> -->
        <div class="header__seenon-text">Seen on</div>
        <div class="header__seenon-logos">
            <img src="https://i.imgur.com/kUQTjOP.png" alt="Seen on logo 1" />
            <img src="https://i.imgur.com/43Dlfz3.png" alt="Seen on logo 2" />
            <img src="https://i.imgur.com/OfW6dpb.png" alt="Seen on logo 3" />
            <img src="https://i.imgur.com/Wq6LLek.png" alt="Seen on logo 4" />
        </div>
    </header>

    <div class="storyBox">

        <div class="story__pictures">
            <img src="https://i.imgur.com/kApzN2q.jpg" alt="Couple with new house" class="story__img--1" />
            <img src="https://i.imgur.com/SHargTt.jpg" alt="New house" class="story__img--2" />
        </div>

        <div class="story__content">
            <h3 class="heading-3 mb-sm">Happy Customers</h3>
            <h2 class="heading-2 heading-2--dark mb-md">&ldquo;The best decision of our lives&rdquo;</h2>
            <p class="story__text">
                Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tenetur distinctio necessitatibus pariatur voluptatibus. Quidem consequatur harum volupta!
            </p>
            <!-- <button class="btn">Find your own home</button> -->
        </div>
    </div>

    <h1 class="heading-12">OUR HOMES</h1>

    <section class="homes">

        <uc1:WebUserControl2 runat="server" ID="WebUserControl2" />
    </section>

    <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />

    <footer class="footer">

        <p class="copyright">
            &copy; Copyright 2023. CIS 3342. Term Project. Roberto Luna and Mrunalini Patil.
        </p>
    </footer>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <script src="./js/App.js"></script>
</body>
</html>