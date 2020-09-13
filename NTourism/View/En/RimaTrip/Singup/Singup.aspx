<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/RimaTrip/Master/Index.master" AutoEventWireup="true" CodeBehind="Singup.aspx.cs" Inherits="NTourism.View.En.RimaTrip.Singup.Singup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/View/En/RimaTrip/Singup/style/Singup.css" rel="stylesheet" />
    <script src="/View/En/RimaTrip/Singup/script/Singup.js"></script>
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
                        <label>Tell us about your sickness</label>
                        <div class="group">
                            <input id="FnameRimaTrip" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="FnameRimaTrip">First Name</label>
                        </div>

                        <div class="group">
                            <input id="LnameRimaTrip" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="LnameRimaTrip">Last Name</label>
                        </div>
                        <div class="group">
                            <input id="SicknessNameRimaTrip" type="text" maxlength="50" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="SicknessNameRimaTrip">SicknessName</label>
                        </div>
                        <div class="group">
                            <input id="SicknessDescRimaTrip" type="text" maxlength="50" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="SicknessDescRimaTrip">SicknessDesc</label>
                        </div>
                        <div class="group">
                            <input id="PassNoRimaTrip" type="tel" maxlength="15" oninput="maxLengthCheck(this)" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="PassNoRimaTrip">PassNo</label>
                        </div>
                        <div class="group">
                            <input type="file" id="fileuploadRimaTrip"  onblur="CheckEmptyInput(this)" required/>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="fileuploadRimaTrip"></label>
                        </div>
                        <ul class="errorMessages"></ul>
                        <input id="btnsubmit" type="submit" value="Send" />
                    </form>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
