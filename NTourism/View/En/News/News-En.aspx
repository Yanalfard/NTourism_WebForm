<%@ Page Title="News-En" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="News-En.aspx.cs" Inherits="NTourismWeb.View.En.News.News_En" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="/StyleScriptsNTourism/Script/News.js"></script>
    <link href="/StyleScriptsNTourism/Style/News.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="1111">
        </div>
        <%-- #Row1  --%>
        <div class="divRow1NewsPageStyle list-wrapper">
            <div class="divInRow1TheRow1TextNewsPageStyle text-center">
                <p class="textInRow1TheRow1TextNewsPageStyle">NEWS</p>
            </div>
        </div>
        <%-- Ads 5 --%>
        <script>
            var Number1Ads = 1021;
            var Number2Ads = 1022;
            var Number3Ads = 1023;
            var Number4Ads = 1024;
            var Number5Ads = 1025;
        </script>
        <div id="pagination-container"></div>
        <div class="divAdd5upinfooter">
        </div>
    </div>

</asp:Content>
