<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="SingIn.aspx.cs" Inherits="NTourism.View.En.SingIn.SingIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Script/Singin.js"></script>
    <link href="Style/Singin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row DivAslySinIn">
            <div class="col-lg-7 col-md-12 col-sm-12 col-xs-12">
                <img src="/Resources/En/SingUp/Signup-01.png" class="ImgSignupStyle" alt="Signup-OurServices" title="Signup-OurServices" />
            </div>
            <div class="col-lg-5 col-md-12 col-sm-12 col-xs-12">
                <div id="form_container">
                    <form id="signup" method="post">
                        <label>SINGIN</label>
                        <div class="group">
                            <input id="UserName" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="UserName">User Name</label>
                        </div>
                        <div class="group">
                            <input id="Password" type="password" maxlength="15" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Password">Password</label>
                        </div>
                        <div id="myForm">
                            <label>
                                <input type="radio" name="radioName" value="Tourist" />
                                Tourist
                            </label>
                            <label>
                                <input type="radio" name="radioName" value="Rimatours" />
                                Rimatours
                            </label>
                            <label>
                                <input type="radio" name="radioName" value="OurServices" />
                                OurServices
                            </label>
                        </div>
                        <p class="CreateSininStyle">Create Account</p>
                        <p id="ErrorTextPageLogin"></p>
                        <ul class="errorMessages"></ul>
                        <input id="btnsubmit" type="submit" value="CONTINUE" />
                    </form>
                </div>
            </div>
        </div>
    </div>
    <%-- modal --%>
    <div id="MyModal" class="modal fade " role="dialog">
        <div class="modal-dialog">
            <div class="modal-content row">
                <div class="modal-body text-center col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="row">
                        <a class="LinkTextToSingupPagestyle  btn btn-block" href="../SingUp/SingUpOurServices.aspx">OurServices</a>
                    </div>
                    <div class="row">
                        <a class="LinkTextToSingupPagestyle  btn btn-block" href="../SingUp/SingUpRimatours.aspx">Rimatours</a>
                    </div>
                    <div class="row">
                        <a class="LinkTextToSingupPagestyle  btn btn-block" href="../SingUp/SingUpTourist.aspx">Tourist</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
