<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="City.aspx.cs" Inherits="NTourism.View.En.City.City" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/StyleScriptsNTourism/Style/City.css" rel="stylesheet" />
    <script src="/StyleScriptsNTourism/Script/City.js"></script>
    <link href="/OwlCarousel2-2.3.4/dist/assets/owl.carousel.min.css" rel="stylesheet" />
    <link href="/OwlCarousel2-2.3.4/dist/assets/owl.theme.default.min.css" rel="stylesheet" />
    <script src="/OwlCarousel2-2.3.4/dist/owl.carousel.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section>
        <%-- #Row1  --%>
        <div class="divRow1NewsPageStyle">
            <div class="divInRow1TheRow1TextNewsPageStyle text-center">
                <p class="textInRow1TheRow1TextNewsPageStyle"></p>
            </div>
            <div class="divInRow1TheRow2NewsPageStyle">
                <div class="ShowCitySeletOne">
                </div>
            </div>
            <%--Owl1--%>
            <div class="OwlCityDestinationsOwl1">
            </div>
            <%--Owl2--%>
            <div class="OwlCityDestinationsOwl2">
            </div>
            <%--Owl3--%>
            <div class="OwlCityDestinationsOwl3">
            </div>
        </div>
    </section>
</asp:Content>
