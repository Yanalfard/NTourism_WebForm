<%@ Page Title="Profile Rimatours" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="ProfileRimatours.aspx.cs" Inherits="NTourism.View.En.Profile.ProfileRimatours" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/StyleScriptsNTourism/Script/ProfileRimatours.js"></script>
    <link href="/StyleScriptsNTourism/Style/ProfileRimatours.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container-fluid">
        <%-- #Page1 --%>
        <div id="DivPage1OurServices" class="row DivPage1OurServices">
            <div class="col-lg-4 col-md-6 col-sm-12 col-xs-12">
                <div class="divcol1style">
                    <div id="ParentUserImg" class="groupcol1amnstyle">
                    </div>
                    <div class="groupcol1amnstyle">
                        <label id="FNameAmn">First Name</label>
                        <label id="LNameAmn">Last  Name</label>
                    </div>
                    <div class="groupcol1amnstyle">
                        <label id="UserNameAmn">User Name</label>
                    </div>
                    <div class="groupcol1amnstyle">
                        <label id="TellNo">TellNo</label>
                    </div>
                    <div class="groupcol1amnstyle">
                        <label id="ShoeEmail">Email</label>
                    </div>
                    <div class="groupcol1amnstyle">
                        <a id="EditeProfileAmn" onclick="ShowEditeProfileOurServices();">Edite Profile</a>
                    </div>
                </div>
                <%-- ---------- --%>
                <div class="divcol1row2style">
                    <div>
                        <label>Gallery</label>
                    </div>
                    <div class="DivAslyInGallery">
                        <div class="LblAddImageStyle DivRemoveImg" id="fileDisplayArea1">
                            <div id="DivuploadOurServices1">
                                <input type="hidden" id="hiddenInputFullImgEmpty1" value="0" />
                                <input type="hidden" class="removeImgInData" id="removeImgInData1" value="0" />
                                <input type="hidden" id="hiddenIdImage1" value="" />
                                <input type="file" id="file-upload1" />
                                <label for="file-upload1"><i style="font-size: 7em; color: #B2B2B2; margin-top: 30%;" class="fa fa-plus"></i></label>
                            </div>
                            <a class="remImage" href="#">
                                <i class="fa fa-close"></i>
                            </a>
                        </div>
                        <div style="margin-left: 0.5em;" id="fileDisplayArea2" class="LblAddImageStyle DivRemoveImg">
                            <div id="DivuploadOurServices2">
                                <input type="hidden" id="hiddenInputFullImgEmpty2" value="0" />
                                <input type="hidden" class="removeImgInData" id="removeImgInData2" value="0" />
                                <input type="hidden" id="hiddenIdImage2" value="" />
                                <input type="file" id="file-upload2" />
                                <label for="file-upload2"><i style="font-size: 7em; color: #B2B2B2; margin-top: 30%;" class="fa fa-plus"></i></label>
                            </div>
                            <a class="remImage" href="#">
                                <i class="fa fa-close"></i>
                            </a>
                        </div>
                        <div style="margin-left: 0.5em;" id="fileDisplayArea3" class="LblAddImageStyle DivRemoveImg">
                            <div id="DivuploadOurServices3">
                                <input type="hidden" id="hiddenInputFullImgEmpty3" value="0" />
                                <input type="hidden" class="removeImgInData" id="removeImgInData3" value="0" />
                                <input type="hidden" id="hiddenIdImage3" value="" />
                                <input type="file" id="file-upload3" />
                                <label for="file-upload3"><i style="font-size: 7em; color: #B2B2B2; margin-top: 30%;" class="fa fa-plus"></i></label>
                            </div>
                            <a class="remImage" href="#">
                                <i class="fa fa-close"></i>
                            </a>
                        </div>
                    </div>
                    <div class="DivAslyInGallery">
                        <div style="margin-top: 0.5em;" id="fileDisplayArea4" class="LblAddImageStyle DivRemoveImg">
                            <div id="DivuploadOurServices4">
                                <input type="hidden" id="hiddenInputFullImgEmpty4" value="0" />
                                <input type="hidden" class="removeImgInData" id="removeImgInData4" value="0" />
                                <input type="hidden" id="hiddenIdImage4" value="" />
                                <input type="file" id="file-upload4" />
                                <label for="file-upload4"><i style="font-size: 7em; color: #B2B2B2; margin-top: 30%;" class="fa fa-plus"></i></label>
                            </div>
                            <a class="remImage" href="#">
                                <i class="fa fa-close"></i>
                            </a>
                        </div>
                        <div style="margin-left: 0.5em; margin-top: 0.5em;" id="fileDisplayArea5" class="LblAddImageStyle DivRemoveImg">
                            <div id="DivuploadOurServices5">
                                <input type="hidden" id="hiddenInputFullImgEmpty5" value="0" />
                                <input type="hidden" class="removeImgInData" id="removeImgInData5" value="0" />
                                <input type="hidden" id="hiddenIdImage5" value="" />
                                <input type="file" id="file-upload5" />
                                <label for="file-upload5"><i style="font-size: 7em; color: #B2B2B2; margin-top: 30%;" class="fa fa-plus"></i></label>
                            </div>
                            <a class="remImage" href="#">
                                <i class="fa fa-close"></i>
                            </a>
                        </div>
                        <div style="margin-left: 0.5em; margin-top: 0.5em;" id="fileDisplayArea6" class="LblAddImageStyle DivRemoveImg">
                            <div id="DivuploadOurServices6">
                                <input type="hidden" id="hiddenInputFullImgEmpty6" value="0" />
                                <input type="hidden" class="removeImgInData" id="removeImgInData6" value="0" />
                                <input type="hidden" id="hiddenIdImage6" value="" />
                                <input type="file" id="file-upload6" />
                                <label for="file-upload6"><i style="font-size: 7em; color: #B2B2B2; margin-top: 30%;" class="fa fa-plus"></i></label>
                            </div>
                            <a class="remImage" href="#">
                                <i class="fa fa-close"></i>
                            </a>
                        </div>
                    </div>

                    <div class="DivAslyInGallery text-center">
                        <a class="btn" id="SendImageTodataSave">Save Image</a>
                    </div>
                </div>
           
            </div>
            <%-- #Col2 --%>
            <div class="col-lg-4 col-md-6 col-sm-12 col-xs-12">

            </div>
        </div>

        <%-- #Page2 --%>
        <div id="DivPage2OurServices" class="DivPage2OurServices">
            <div class="col-lg-8 col-md-12 col-sm-12 col-xs-12" id="form_container">
                <div class="groupcol1amnstyle">
                    <a id="CancelEditeProfileAmn" onclick="CancelEditeProfileOurServices();">Cancel</a>
                </div>
                <form id="EditeProfileOurServices" method="post">

                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">

                        <label></label>
                        <div class="group">
                            <input id="ChosePhoto" type="file" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="ChosePhoto">Chose Photo</label>
                        </div>
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
                            <label for="PhonNumber">Phone Number</label>
                        </div>

                    </div>


                    <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                        <label></label>

                        <div class="group">
                            <input id="City" type="hidden" onblur="CheckEmptyInput(this)">
                            City:
                            <select id="cityNames" name="cityNames" class="form-control">
                            </select>



                        </div>

                        <div class="group">
                            <input id="Description" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Description">Description</label>
                        </div>
                        <div class="group">
                            <input id="Rate" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Rate">Rate</label>
                        </div>
                        <div class="group">
                            <input id="dolar" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="dolar">$</label>
                        </div>

                        <div class="group">
                            <input id="Discount" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="Discount">$Discount</label>
                        </div>
                        <ul class="errorMessages"></ul>

                        <input id="btnsubmit" type="submit" value="CONTINUE" />
                    </div>
                </form>
            </div>
        </div>
    </section>
</asp:Content>
