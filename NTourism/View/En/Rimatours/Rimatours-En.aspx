<%@ Page Title="Tourguide-En" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="Rimatours-En.aspx.cs" Inherits="NTourismWeb.View.En.Tourguide.Tourguide_En" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/StyleScriptsNTourism/Script/Rimatours.js"></script>
    <link href="/StyleScriptsNTourism/Style/Rimatours.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <%-- #Row1  --%>
        <div class="divRow1TourguidePageStyle  container-fluid">
            <div class="divInRow1TheRow1TextTourguidePageStyle text-center">
                <p class="textInRow1TheRow1TextTourguidePageStyle">RIMATOURS</p>
            </div>
            <div>
                <script src="https://kit.fontawesome.com/57456f662e.js" crossorigin="anonymous"></script>
                <center><h1>Search Code Rimatours</h1></center>
                <!--Search content -->
                <div class="searchinput">
                    <label class="labelNameRimatours">Code</label>
                    <input id="TextSearchCodeRimatours" type="number" name="q" class="textCodeRimatours" autocomplete="off" onkeypress="if(this.value.length==6) return false;">
                    <button id="BtnSearchCodeRimatours" type="submit" class="submitRimatours"><i class="fas fa-search"></i></button>
                </div>
            </div>
            <div class="SearchdivRimatours">
                <script src="https://kit.fontawesome.com/57456f662e.js" crossorigin="anonymous"></script>
                <center><h1>Search box by Rimatours</h1></center>
                <!--Search content -->
                <div class="searchinput">
                    <div>
                        <label class="labelNameRimatours">City</label>
                        <input list="DataListInRimatours" id="TextSearchRimatours" type="text" name="q" placeholder=" search..." class="textRimatours" autocomplete="off">
                    </div>
                    <%--   <div style="margin-top: 10px;">
                        <label class="labelNameRimatours">Date In</label>
                        <input id="TextSearchRimatoursDateIn" type="date" name="q" class="textRimatours" >
                    </div>
                    <div style="margin-top: 10px;">
                        <label class="labelNameRimatours">DateOut</label>
                        <input id="TextSearchRimatoursDateOut" type="date" name="q" class="textRimatours" >
                    </div>--%>
                    <div>
                    </div>
                    <div class="text-center" style="margin-top: 20px;" id="RadioBtnRimatourschecked">
                        <label>
                            <input type="radio" name="radioName" value="Ascending" checked />
                            Ascending
                        </label>
                        <label>
                            <input type="radio" name="radioName" value="Descending" />
                            Descending
                        </label>
                        <label>
                            <input type="radio" name="radioName" value="Discount" />
                            Discount
                        </label>
                    </div>
                    <button id="BtnSearchRimatours" type="submit" class="submitRimatours"><i class="fas fa-search"></i></button>
                    <%--<a id="BtnSearchRimatours"  class="submitRimatours btn"><i class="fas fa-search"></i></a>--%>
                </div>
                <datalist id="DataListInRimatours">
                </datalist>
            </div>
            <div class="divRow1TourguidePageStyleRow3 list-wrapper">
            </div>
        </div>
        <div id="pagination-container"></div>

        <div class="ShowDynamicDatalisRimatours container-fluid">
        </div>
        <%-- Ads 5 --%>
        <script>
            var Number1Ads = 1026;
            var Number2Ads = 1027;
            var Number3Ads = 1028;
            var Number4Ads = 1029;
            var Number5Ads = 1030;
        </script>

        <div class="divAdd5upinfooter" style=" clear: both;">
        </div>

    </section>
</asp:Content>
