<%@ Page Title="Profile Tourist" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="ProfileTourist.aspx.cs" Inherits="NTourism.View.En.Profile.ProfileTourist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/StyleScriptsNTourism/Style/ProfileTourist.css" rel="stylesheet" />
    <script src="/StyleScriptsNTourism/Script/ProfileTourist.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container-fluid">
        <%-- #Page1 --%>
        <div id="DivPage1TourGide" class="row DivPage1TourGide">
            <div class="col-lg-4 col-md-12 col-sm-12 col-xs-12">
                <div class="divcol1style">
                    <div class="groupcol1amnstyle">
                        <i id="UserImg" class="fa fa-user-circle-o"></i>
                    </div>
                    <div class="groupcol1amnstyle">
                        <label id="FNameAmn">First Name</label>
                        <label id="LNameAmn">Last  Name</label>
                    </div>

                    <div class="groupcol1amnstyle">
                        <label id="TellNo">Tell</label>
                    </div>
                    <div class="groupcol1amnstyle">
                        <a id="EditeProfileAmn" onclick="ShowEditeProfileTourGide();">Edite Profile</a>
                    </div>
                </div>
            </div>
        </div>
        <%-- #Page2 --%>
        <div id="DivPage2TourGide" class="DivPage2TourGide">

            <div class="col-lg-8 col-md-12 col-sm-12 col-xs-12" id="form_container">
                 <div class="groupcol1amnstyle">
                    <a id="CancelEditeProfileAmn" onclick="CancelShowEditeProfileTourGide();">Cancel</a>
                </div>
                <form id="EditeProfileTourGide" method="post">

                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <label></label>
                        <div class="group">
                            <input id="Fname" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Fname">First Name</label>
                        </div>
                        <div class="group">
                            <input id="Lname" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Lname">Last Name</label>
                        </div>
                        <div class="group">
                            <input id="PhonNumber" type="tel" maxlength="15" oninput="maxLengthCheck(this)" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="PhonNumber">Phon Number</label>
                        </div>
                        <input id="btnsubmit" type="submit" value="CONTINUE" />
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <ul class="errorMessages"></ul>
                    </div>
                </form>
            </div>

            <div class="col-lg-4 col-md-12 col-sm-12 col-xs-12">
            </div>
        </div>


    </section>
</asp:Content>
