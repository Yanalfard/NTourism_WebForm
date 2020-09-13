<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/RimaTrip/Master/Index.master" AutoEventWireup="true" CodeBehind="AbouUs.aspx.cs" Inherits="NTourism.View.En.RimaTrip.About_Us.AbouUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../CssLibirary/AbouUs.css" rel="stylesheet" />
    <script src="../JLibirary/AbouUs.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Panel ID="PanelAbutUs" CssClass="PanelAbutUsStyle" runat="server">

        <div class="container-fluid">

            <div class="row DivSliderImgStyle">

                <img id="SliderAboutUsImg1" src="/Resources/En/RimaTrip/Abou-Us/Slider-About-Us1.png" class="SliderAboutUsImg1Style" alt="Slider-About-Us1" title="Slider-About-Us1" />
                <img id="SliderAboutUsImg2" src="/Resources/En/RimaTrip/Abou-Us/Slider-About-Us2.png" class="SliderAboutUsImg2Style" alt="Slider-About-Us2" title="Slider-About-Us2" />
                <img id="SliderAboutUsImg3" src="/Resources/En/RimaTrip/Abou-Us/Slider-About-Us3.png" class="SliderAboutUsImg3Style" alt="Slider-About-Us3" title="Slider-About-Us3" />
                <img id="SliderAboutUsImg4" src="/Resources/En/RimaTrip/Abou-Us/Slider-About-Us4.png" class="SliderAboutUsImg4Style" alt="Slider-About-Us4" title="Slider-About-Us4" />
                <img id="SliderAboutUsImg5" src="/Resources/En/RimaTrip/Abou-Us/Slider-About-Us5.png" class="SliderAboutUsImg5Style" alt="Slider-About-Us5" title="Slider-About-Us5" />
                <img id="SliderAboutUsImg6" src="/Resources/En/RimaTrip/Abou-Us/Slider-About-Us5.png" class="SliderAboutUsImg6Style" alt="Slider-About-Us6" title="Slider-About-Us6" />

            </div>



            <div class="col-lg-12">
                <div class="col-lg-10 col-md-10 col-sm-10 col-xs-10 SliderDivTextAbutUsStyle">
                    <p title="AbutUs" class="SliderTitrAbutUsStyle">
                        RIMATRIP
                    </p>

                </div>
                <div class="col-lg-10 col-md-10 col-sm-10 col-xs-10 SliderZirDivTextAbutUsStyle">
                    <p title="ZirTitrAbutUs" class="SliderZirTitrAbutUsStyle">
                        MEDICAL TOURISM
                    </p>
                </div>

                <div class="col-lg-10 col-md-10 col-sm-10 col-xs-10 SliderDivDescriptionAbutUsTitrStyle">
                    <%--  <p title="DescriptionAbutUs" class="SliderDescriptionAbutUsTextTitrStyle">
                        INCLUDING Free<br />
                        Trancfer / Hotel / Visa
                    </p>--%>
                </div>
            </div>






            <%-- #Lg --%>

            <div class="row DivRowOneAslyStyle ">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirSliderAboutUsTitrStyle text-center">
                    <p class="ZirSliderTitrAboutUsStyle">
                        ABOUT US  
                    </p>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirSliderAboutUsZirTitrStyle text-justify">
                    <p class="ZirSliderZirTitrAboutUsStyle">
                        Islamic Republic of Iran is of great potential in treatment services in the region and always has been under attention of scientific agencies of the
                          world because of science production in global standards.<br />
                        During recent years, people of the world attempt hard to support their health. They treat themselves in their life place or a little farther and in
                        some cases they pass their geographical boundaries for treating and feeling secure to guarantee their health and take travels without any condition.
                        In this regard there are differents global deffinitions that in Iran we only follow up whatever has happened in Iran. Some regions in our neighborhood,
                        has experienced different political and geographical changes in their structure. For different reasons, Iran is a destination for travelers
                        who are seeking for treatment services. They face markets with no owner. Our treatment structure looked for director to these markets. Briefly
                        speaking, under some pressures we started to think and we concluded that having some problematic rules is better than lacking them. We understood
                        that some authorities attempt to start health tourism in our country.<br />
                        Private sector was basis of this industry. Some criticized the methods of attracting health tourists and some entered the field as mediators to
                        organize this money making profession.<br />
                        The founders of RimaTrip (The apple of Health) understands the sensitivity of the issues and by conducting some studies, applied and scientific
                        research in this field, and using the academic consultations and the consultants in different organizations such as Cultural Heritage, Handcraft
                        and Tourism Organization, provided some plans that mostly was approved by policy makers of this industry.
                        After three years of referring to authorities and passing all legal processes for obtaining the permits finally the company was registered under
                        Reg. No. 47956 before Registration Department of Tabriz.<br />
                        The issue started by advertisements and introducing foreign patients to permitted treatment authorities in Iran, especially Tabriz. The mission of
                        the company based on its global visions and applying it in the region, encouraged us to advertise our capabilities in medical fields for applicants.
                        In this hard path, we could enter the international arena of this industry and selected transparency, honesty, ideal services and logical factors as
                        our main principles for competition and by the helps of Lord Almighty we could fill the gaps during recent years.<br />
                        RimaTrip Company started its activity only with one patient from Republic of Azerbaijan in Valiasr Hospital of Tabriz and nowadays we have
                        the highest number of foreign patients in our region.<br />
                        Our activities is transferred among patients in Azerbaijan, Iraq, and Georgia by our patients and applicants.<br />
                        RimaTrip Company provides following services: Hoteling, Logistics, Informatics, Advertisements, Interpreter, and Leader that do their duties
                        for guests.<br />

                    </p>
                  
                </div>
            </div>
        </div>
    </asp:Panel>


</asp:Content>
