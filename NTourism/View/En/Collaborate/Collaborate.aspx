<%@ Page Title="Contact-Us-En" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="Collaborate.aspx.cs" Inherits="NTourismWeb.View.En.ContactUs.ContactUs_En" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/StyleScriptsNTourism/Script/Collaborate.js"></script>
    <link href="/StyleScriptsNTourism/Style/Collaborate.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <%-- #Row1  --%>
        <div class="divRow1ContactUsPageStyle">
            <div class="divInRow1TheRow1TextContactUsPageStyle text-center">
                <p class="textInRow1TheRow1TextContactUsPageStyle"></p>
            </div>
            <div class="divInRow1TheRow2ContactUsPageStyle">
                <div class="ShowAllEditorText">

                </div>
                <div class="row" style="padding: 2em 5em;">
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        آپلود فرم
                    <input type="file" name="Fileinput" id="Fileinput" value="" accept=".pdf,.doc" />
                        <a id="sendFile" class="btn btn-info">Send File </a>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        دانلود فرم
                    <a class="btn btn-success" href="/Resources/Collaborate/Form/Collaborate.zip" download>
                        <i class="glyphicon glyphicon-download"></i>
                    </a>
                    </div>

                </div>
            </div>
        </div>
     
        <%-- Ads 5 --%>
        <script>
            var Number1Ads = 1046;
            var Number2Ads = 1047;
            var Number3Ads = 1048;
            var Number4Ads = 1049;
            var Number5Ads = 1050;
        </script>

        <div class="divAdd5upinfooter">
        </div>
    </section>
</asp:Content>
