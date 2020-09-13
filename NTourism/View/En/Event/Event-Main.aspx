<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="Event-Main.aspx.cs" Inherits="NTourism.View.En.Event.Event_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/StyleScriptsNTourism/Style/Event-Main.css" rel="stylesheet" />
    <script src="/StyleScriptsNTourism/Script/Event-Main.js"></script>
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
