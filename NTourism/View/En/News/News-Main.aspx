<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="News-Main.aspx.cs" Inherits="NTourism.View.En.News.News_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/StyleScriptsNTourism/Script/News-Main.js"></script>
    <link href="/StyleScriptsNTourism/Style/News-Main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <%-- #Row1  --%>
        <div class="divRow1NewsPageStyle">
            <div class="divInRow1TheRow1TextNewsPageStyle text-center">
                <p class="textInRow1TheRow1TextNewsPageStyle"></p>
            </div>

            <div class="divInRow1TheRow2NewsPageStyle">

                <div id="NewsMainPageDiv" class="">
                </div>
            </div>

        </div>
    </div>



</asp:Content>
