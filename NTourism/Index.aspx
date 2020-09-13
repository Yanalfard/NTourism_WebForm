﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="NTourism.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/StyleScriptsNTourism/Script/Home.js"></script>
    <link href="/StyleScriptsNTourism/Style/Home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container-fluid IndexDynamicImage" style="margin-top: 50px;">
            <div class="row">
                <div class="col-lg-7 col-md-7 col-sm-12 col-xs-12">
                    <div class="row">
                        <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8 HomeRow1Col1Style">
                            <div style="padding: 0; padding-right: 0.5em;" class=" col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <div id="DynamicHomeImageAndText1" class="HomeRow1Col1Row1Style Box_ShadowEddect">
                                </div>
                            </div>
                            <div class="HomeRow1Col1Row2Style col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <div id="DynamicHomeImageAndText2" class="HomeRow1Col1Row2Col1Style Box_ShadowEddect">
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                            <div id="DynamicHomeImageAndText4" class="row  HomeRow1Col2Style Box_ShadowEddect"></div>
                        </div>
                    </div>
                    <div class="row " style="padding: 0 0 0 1em;">
                        <div id="DynamicHomeImageAndText5" class="HomeRow2Col1Style Box_ShadowEddect">
                        </div>
                    </div>
                </div>
                <div class="col-lg-5 col-md-5 col-sm-12 col-xs-12 HomeRow1AslyDivCol2Row1Style">
                    <div class="HomeRow1AslyDivCol2Row1Style">
                        <div id="DynamicHomeImageAndText6" class="HomeRow1DivCol2Row1Style Box_ShadowEddect">
                        </div>
                        <div id="DynamicHomeImageAndText7" class="HomeRow1DivCol2Row2Style Box_ShadowEddect">
                        </div>
                    </div>
                </div>
            </div>
            <div class="row" style="padding: 0 0 0 1em;">
                <div id="DynamicHomeImageAndText8" class="HomeRow2Col2Style Box_ShadowEddect">
                </div>
            </div>
            <div class="row" style="padding: 0 0 0 1em;">
                <div class="HomeRow3Style">
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <div id="DynamicHomeImageAndText9" class="row  HomeRow3Col1Style Box_ShadowEddect">
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <div id="DynamicHomeImageAndText10" class="row  HomeRow3Col2Style Box_ShadowEddect">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <%-- #Row5  --%>
        <div class="divRow5HomePageStyle">
            <div class="divInRow5TheRow1TextHomePageStyle text-center">
                <p class="textInRow5TheRow1TextHomePageStyle">RIMA TRIP SERVICES</p>
            </div>
            <div class="divInRow5TheRow2HomePageStyle ">
                <div class="container-fluid text-center">
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <a href="#" class="ShowComplateServices">
                            <input type="hidden" name="name" value="1" />
                            <img src="/Resources/En/Home/Servises/Servises2.png" class="ImgServisesIndexStyle" alt="RIMA TRIP SERVICES" title="RIMA TRIP SERVICES" />
                            <p class="TitrServicesStyle" id="TitrServices1">
                            </p>
                        </a>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <a href="#" class="ShowComplateServices">
                            <input type="hidden" name="name" value="3" />
                            <img src="/Resources/En/Home/Servises/Servises1.png" class="ImgServisesIndexStyle" alt="RIMA TRIP SERVICES" title="RIMA TRIP SERVICES" />
                            <p class="TitrServicesStyle" id="TitrServices2">
                            </p>
                        </a>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <a href="#" class="ShowComplateServices">
                            <input type="hidden" name="name" value="4" />
                            <img src="/Resources/En/Home/Servises/Servises4.png" class="ImgServisesIndexStyle" alt="RIMA TRIP SERVICES" title="RIMA TRIP SERVICES" />
                            <p class="TitrServicesStyle" id="TitrServices3">
                            </p>
                        </a>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <a href="#" class="ShowComplateServices">
                            <input type="hidden" name="name" value="5" />
                            <img src="/Resources/En/Home/Servises/Servises3.png" class="ImgServisesIndexStyle" alt="RIMA TRIP SERVICES" title="RIMA TRIP SERVICES" />
                            <p class="TitrServicesStyle" id="TitrServices4">
                            </p>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <%-- Ads 5 --%>
        <script>
            var Number1Ads = 1006;
            var Number2Ads = 1007;
            var Number3Ads = 1008;
            var Number4Ads = 1009;
            var Number5Ads = 1010;
        </script>
        <div class="divAdd5upinfooter">
        </div>

    </section>
</asp:Content>







