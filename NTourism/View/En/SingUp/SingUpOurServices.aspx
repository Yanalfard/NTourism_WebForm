<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="SingUpOurServices.aspx.cs" Inherits="NTourism.View.En.SingUp.SingUpOurServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scipt/SingUpOurServices.js"></script>
    <link href="Style/SingUpOurServices.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-7 col-md-12 col-sm-12 col-xs-12">
                <img src="/Resources/En/SingUp/Signup-01.png" class="ImgSignupStyle" alt="Signup-OurServices" title="Signup-OurServices" />
            </div>
            <div class="col-lg-5 col-md-12 col-sm-12 col-xs-12">

                <div id="form_container">

                    <form id="signup" method="post">
                        <label>OurServices</label>
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
                            <input id="Email" type="email" maxlength="50" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Email">Email</label>
                        </div>
                        <div class="group">
                            <input id="PhonNumber" type="tel" maxlength="15" oninput="maxLengthCheck(this)" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="PhonNumber">Phon Number</label>
                        </div>
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
                        <div class="group">
                            <input id="ConfrimPassword" type="password" maxlength="15" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="ConfrimPassword">Confrim Password</label>
                        </div>

                        <ul class="errorMessages"></ul>

                        <input id="btnsubmit" type="submit" value="CONTINUE" />
                    </form>


                </div>
            </div>
        </div>
    </div>


</asp:Content>
