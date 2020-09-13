<%@ Page Title="Profile OurServices" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="ProfileOurServices.aspx.cs" Inherits="NTourism.View.En.Profile.ProfileOurServices1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/StyleScriptsNTourism/Script/ProfileOurServices.js"></script>
    <link href="/StyleScriptsNTourism/Style/ProfileOurServices.css" rel="stylesheet" />



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

                <div class="divcol2style">
                    <div class="divcol2rw1style">
                        <p>
                            FACILITIES
                        </p>
                    </div>
                    <div class="formProfileOurServices">
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Rooms.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Rooms:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Rooms" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Bed.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Bed:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Bed" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Balcon.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Balcony:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Balcony" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/TV.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">TV:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1TV" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Wifi.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Wifi:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Wifi" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/BathRoom.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Bathroom:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Bathroom" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Safe.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Safe:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Safe" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Kitchen.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Kitchen:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Kitchen" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Refrigator.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Refrigerator:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Refrigerator" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Oven.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Oven:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Oven" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/WashMachine.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Wash Machine:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1WashMachine" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/PetLower.png" class="Imgfagroupinformstyle" />
                            <label class="Lblgroupinformstyle">Pet Lower:</label>
                            <i id="FaTruwOrFalseFACILITIESInPage1Pets" class="fa fatruegroupinformstyle fa-close"></i>
                        </div>
                    </div>

                </div>

            </div>
            <%-- #Col3 --%>
            <div class="col-lg-4 col-md-6 col-sm-12 col-xs-12">
                <div class="divcol2style">
                    <div class="divcol3rw1style">
                        <p>
                            OurServices NEWS
                        </p>
                    </div>
                    <div id="divallinformProfileOurServices" class="formProfileOurServices">
                    </div>

                </div>
            </div>

            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                <div class="divrow2style">
                    <div class="divRow2rw1style">
                        <p>
                            <i class="fa fa-comment-o" aria-hidden="true"></i>
                            COMMENTS
                        </p>
                    </div>
                    <div class="formProfileCommentsStyle2">
                        <div class="formProfileCommentsStyle" id="formProfileCommentsStyle">
                        </div>
                    </div>
                </div>
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
                            <input id="dolar" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="dolar">$</label>
                        </div>
                        <div class="group">
                            <input id="dolarWeekend" type="text" maxlength="50" autocomplete="off" onblur="CheckEmptyInput(this)" required>
                            <span class="highlight"></span>
                            <span class="bar"></span>
                            <label for="dolarWeekend">$dolarweekend</label>
                        </div>
                        <ul class="errorMessages"></ul>

                        <input id="btnsubmit" type="submit" value="CONTINUE" />
                    </div>
                </form>
            </div>
            <div class="col-lg-4 col-md-6 col-sm-12 col-xs-12">
                <div class="divcol2style">
                    <div class="divcol2rw1style">
                        <p>
                            FACILITIES
                        </p>
                    </div>
                    <div class="formProfileOurServices">
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Rooms.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesRooms" type="checkbox" />
                            <label for="CheckOurServicesRooms" class="lbl Lblgroupinformstyle">Rooms:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Bed.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesBed" type="checkbox" />
                            <label for="CheckOurServicesBed" class="lbl Lblgroupinformstyle">Bed:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Balcon.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesBalcony" type="checkbox" />
                            <label for="CheckOurServicesBalcony" class="lbl Lblgroupinformstyle">Balcony:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/TV.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesTV" type="checkbox" />
                            <label for="CheckOurServicesTV" class="lbl Lblgroupinformstyle">TV:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Wifi.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesWifi" type="checkbox" />
                            <label for="CheckOurServicesWifi" class="lbl Lblgroupinformstyle">Wifi:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/BathRoom.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesBathroom" type="checkbox" />
                            <label for="CheckOurServicesBathroom" class="lbl Lblgroupinformstyle">Bathroom:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Safe.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesSafe" type="checkbox" />
                            <label for="CheckOurServicesSafe" class="lbl Lblgroupinformstyle">Safe:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Kitchen.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesKitchen" type="checkbox" />
                            <label for="CheckOurServicesKitchen" class="lbl Lblgroupinformstyle">Kitchen:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Refrigator.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesRefrigerator" type="checkbox" />
                            <label for="CheckOurServicesRefrigerator" class="lbl Lblgroupinformstyle">Refrigerator:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/Oven.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesOven" type="checkbox" />
                            <label for="CheckOurServicesOven" class="lbl Lblgroupinformstyle">Oven:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/WashMachine.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesWashMachine" type="checkbox" />
                            <label for="CheckOurServicesWashMachine" class="lbl Lblgroupinformstyle">Wash Machine:</label>
                        </div>
                        <div class="groupinformProfileOurServicesstyle">
                            <img src="/Resources/En/OurServices/IconFacilities/PetLower.png" class="Imgfagroupinformstyle" />
                            <input class="CheckOurServicesStyle" id="CheckOurServicesPetLower" type="checkbox" />
                            <label for="CheckOurServicesPetLower" class="lbl Lblgroupinformstyle">Pet Lower:</label>
                        </div>
                        <input id="btnsubmitChckOurServices" type="button" value="Done" />

                    </div>
                </div>
            </div>
        </div>

    </section>
</asp:Content>
