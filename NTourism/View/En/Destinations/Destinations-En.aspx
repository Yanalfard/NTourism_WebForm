<%@ Page Title="Destinations-En" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="Destinations-En.aspx.cs" Inherits="NTourismWeb.View.En.Destinations.Destinations_En" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="/OwlCarousel2-2.3.4/dist/assets/owl.carousel.min.css" rel="stylesheet" />
    <link href="/OwlCarousel2-2.3.4/dist/assets/owl.theme.default.min.css" rel="stylesheet" />
    <script src="/OwlCarousel2-2.3.4/dist/owl.carousel.min.js"></script>


    <script src="/StyleScriptsNTourism/Script/Destinations.js"></script>
    <link href="/StyleScriptsNTourism/Style/Destinations.css" rel="stylesheet" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <%-- #Row1  --%>
        <div class="divRow1DestinationsPageStyle list-wrapper">
            <div class="divInRow1TheRow1TextDestinationsPageStyle text-center">
                <p class="textInRow1TheRow1TextDestinationsPageStyle">Destinations</p>
            </div>

            <div class="SearchdivDestinations">


                <script src="https://kit.fontawesome.com/57456f662e.js" crossorigin="anonymous"></script>
                <center><h1>Search box by Destinations</h1></center>
                <!--Search content -->
                <div class="searchinput">
                    <input list="DataListInDestinations" id="TextSearchDestinations" type="text" name="q" placeholder=" search..." class="textDestinations" required>
                    <button id="BtnSearchDestinations" type="submit" class="submitDestinations"><i class="fas fa-search"></i></button>
                </div>
            </div>
        </div>

        <%-- Ads 5 --%>
        <script>
            var Number1Ads = 1011;
            var Number2Ads = 1012;
            var Number3Ads = 1013;
            var Number4Ads = 1014;
            var Number5Ads = 1015;
        </script>
        <%--<div id="pagination-container"></div>--%>
        <div class="ShowAllCitiesInSlider">
        </div>
        <div class="ShowCitySeletOne">
        </div>
        <div class="divAdd5upinfooter">
        </div>

    </section>
    <datalist id="DataListInDestinations">
    </datalist>




</asp:Content>
