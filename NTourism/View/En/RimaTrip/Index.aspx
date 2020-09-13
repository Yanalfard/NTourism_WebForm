<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/RimaTrip/Master/Index.master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="NTourism.View.En.RimaTrip.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="yall.min.js"></script>
    <link href="CssLibirary/Index.css" rel="stylesheet" />
    <script src="/View/En/RimaTrip/Master/JLibirary/Index.js"></script>
    <link href="/View/En/RimaTrip/Master/CssLibirary/Index.css" rel="stylesheet" />

    <script src="JLibirary/Index.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="PanelContentHome" class="container-fluid ">
        <div id="PanelImgSlider" class="col-lg-12">
            <div class="row SliderDivTextHealthStyle">
                <p title="HEALTH" class="SliderTitrHealthStyle">
                    RIMATRIP
                </p>
            </div>
            <div class="row SliderZirDivTextHealthStyle">
                <p title="TOURISM-CENTER" class="SliderZirTitrHealthStyle">
                    MEDICAL TOURISM
                </p>
            </div>

            <div class="row SliderDivIncludinTextTitrStyle">
                <p title="INCLUDIN-Free" class="SliderIncludinTextTitrStyle">
                    <%--INCLUDIN FREE--%>
                </p>
            </div>

            <div class="row SliderDivIncludinTextZirTitrStyle">
                <p title="INCLUDIN-Free-Transfer" class="SliderIncludinTextZirTitrStyle">
                    <%--Transfer / Hotel--%>
                </p>
            </div>

            <div id="SliderIndex6" class="SliderBtnRegisterStyle">
                <a href="/View/En/RimaTrip/Singup/Singup.aspx" title="SingIn" class="btn SliderBtnRegisterTextStyle">Register</a>
            </div>
            <img id="SliderIndex1" src="/Resources/En/RimaTrip/Index/Slide/slider1.png" data-src="/Resources/En/RimaTrip/Index/Slide/slider1.png" class="Slider1Style " alt="Sibe-Salamat1" title="Sibe-Salamat" />
            <img id="SliderIndex2" src="/Resources/En/RimaTrip/Index/Slide/slide2.png" class="Slider2Style" alt="Sibe-Salamat1" title="Sibe-Salamat" />
            <img id="SliderIndex7" src="/Resources/En/RimaTrip/Index/Slide/slide7.png" class="Slider7Style" alt="Sibe-Salamat1" title="Sibe-Salamat" />
            <img id="SliderIndex4" src="/Resources/En/RimaTrip/Index/Slide/slide4.png" class="Slider4Style" alt="Sibe-Salamat1" title="Sibe-Salamat" />
            <img id="SliderIndex3" src="/Resources/En/RimaTrip/Index/Slide/slide3.png" class="Slider3Style" alt="Sibe-Salamat1" title="Sibe-Salamat" />
            <img id="SliderIndex5" src="/Resources/En/RimaTrip/Index/Slide/slide5.png" class="Slider5Style" alt="Sibe-Salamat1" title="Sibe-Salamat" />

        </div>



        <%-- #Lg --%>

        <div id="PanelPpularTreatmentsBox" class="PanelPopularTreatmentsBoxStyle row hidden-sm hidden-xs">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelLblPopularTreatmentsStyle text-center">
                    <p id="LblPopularTreatments" class="LblPopularTreatmentsStyle text-center">POPULAR TREATMENTS</p>

                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle MarginLeftBoxShadobPopularTreatmentsStyle">

                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments1.png" class="ImagePopularTreatments1Style" />

                            <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments1-1.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>


                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">



                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments2.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/NoseJobsPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments2-2.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle MarginMLeftBoxShadobPopularTreatmentsStyle">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments3.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/HairTransplantPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments3-3.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle MarginLeftBoxShadobPopularTreatmentsStyle">
                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments4.png" class="ImagePopularTreatments1Style" />
                            <a href="#" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments4-4.png" class="ImagePopularTreatments2Style" />
                            </a>
                        </div>

                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments5.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/PlasticSurgeryPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments5-5.png" class="ImagePopularTreatments2Style" />
                            </a>
                        </div>

                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle MarginMLeftBoxShadobPopularTreatmentsStyle">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments6.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/WeightLossPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments6-6.png" class="ImagePopularTreatments2Style" />
                            </a>
                        </div>
                    </div>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivBtnSeeMoreStyle">
                        <a href="/View/En/RimaTrip/Popular.aspx" target="_blank" class="btn BtnSeeMoreStyle">See more Treatments</a>
                    </div>
                </div>
            </div>



            <%-- #VIDEOS --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivVideos">

                <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideoTabriz.png" class="VideobackgroundStyle" />
                </div>

                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4" style="margin-top: -1.5%;">
                    <div class="row">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9">

                            <a id="LblTextVideo" class="LblTextVideoStyle">VIDEOS</a>
                        </div>
                    </div>

                    <div class="row DivVideoTextImgLgStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg11.png" class="VideosImgLgStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularLgStyle">
                            <a href="#" target="_blank" class="TextVideoPubularLgStyle">
                                <p>
                                    Cosmetic Dentistry videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgLgStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg22.png" class="VideosImgLgStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularLgStyle">
                            <a href="#" target="_blank" class="TextVideoPubularLgStyle">
                                <p>
                                    Nose Surgery videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgLgStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg33.png" class="VideosImgLgStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularLgStyle">
                            <a href="#" target="_blank" class="TextVideoPubularLgStyle">
                                <p>
                                    Hiar Transplant Videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgLgStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg44.png" class="VideosImgLgStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularLgStyle">
                            <a href="#" target="_blank" class="TextVideoPubularLgStyle">
                                <p>
                                    Fertility Treatments Videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgLgStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg55.png" class="VideosImgLgStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularLgStyle">
                            <a href="#" target="_blank" class="TextVideoPubularLgStyle">
                                <p>
                                    Plastic Surgery Videos
                                </p>
                            </a>
                        </div>

                    </div>
                    <div class="row DivVideoTextImgLgStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg66.png" class="VideosImgLgStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularLgStyle">
                            <a href="#" target="_blank" class="TextVideoPubularLgStyle">
                                <p>
                                    Weeight Loss Surgery Videos
                                </p>
                            </a>
                        </div>

                    </div>
                </div>

              
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <p class="text-center FontWellcomeTabrizVideoLgStyle">Welcome to Tabriz</p>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <p class="text-justify ZirFontWellcomeTabrizVideoLgStyle">Biblical clues point to the Ajichay River flowing out of the Garden of Eden, which places Tabriz at the gates of paradise. Long a buffer between empires, Tabriz' historical heritage and Silk Road pedigree is no more evident than in its thriving bazaar, one of the world's best. This sprawling city, rich in Azeri culture, with its famous carpets, teahouse hammams, love of music and excellent transport links, makes a perfect introduction to Iran. Situated on a high plateau between Lake Orumiyeh and lofty Mt Sahand, and bounded by stark, eroded hills, Tabriz has milder summers than cities further east, though its winters can be formidable.</p>
                </div>


            </div>
            <%-- #About Us --%>


            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAboutLgStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirSliderAboutUsTitrLgStyle text-center">
                    <p class="TitrAboutUsLgStyle">
                        ABOUT US  
                    </p>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirAboutUsZirTitrLgStyle text-justify">

                    <p class="ZirTitrAboutUsLgStyle">
                        Islamic Republic of Iran is of great potential in treatment services in the region and always has been under attention of scientic agencies of the
                         world because of science production in global standards.<br />
                        During recent years, people of the world attempt hard to support their health. They treat themselves in their life place or a little farther and in
                        some cases they pass their geographical boundaries for treating and feeling secure to guarantee their health and take travels without any condition.
                        In this regard there are dierent global denitions that in Iran we only follow up whatever has happened in Iran. Some regions in our neighborhood,
                        has experienced different political and geographical changes in their structure. For different reasons, Iran is a destination for travelers
                        who are seeking for treatment services. They face markets with no owner. Our treatment structure looked for director to these markets. Briefly
                        speaking, under some pressures we started to think and we concluded that having some problematic rules is better than lacking them. We understood
                        that some authorities attempt to start health tourism in our country...<a target="_blank" href="/View/En/RimaTrip/About-Us/AbouUs.aspx" title="Arvateb-About">Read More</a>
                    </p>
                </div>

            </div>






            <%-- #Arvateb --%>

            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivArvatebServicesStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <a id="LblArvatebServices" class="LblPopularTreatmentsStyle text-center">MEDICAL TOURISM SERVICES</a>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="col-lg-1 col-md-1 col-sm-1 col-xs-1"></div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices1.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">Online Support</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">Find your treatment (medical / cosmetic), ask for information online</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices2.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">Medical consultation</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">expert medical consultation provided for free</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: 8%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices3.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">24 Hours assistant</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">We accompany you during your medical trip to your departure</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -8%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices4.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">Follow-up</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">Long-term follow-up by phone, video call, WhatsApp, etc</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices5.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a id="LblNameLogoArvatebServices5" class="LblNameLogoArvatebServicesStyle">Trip planning</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a id="LblZirNameLogoArvatebServices5" class="LblZirNameLogoArvatebServicesStyle">Have your flight and hotel organized by us after treatment confirmation</a>

                        </div>
                    </div>
                    <div class="col-lg-1 col-md-1 col-sm-1 col-xs-1"></div>
                </div>


                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">
                    <div class="col-lg-1 col-md-1 col-sm-1 col-xs-1"></div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices6.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">OurServicess</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center ">
                            <a class="LblZirNameLogoArvatebServicesStyle">Providing you OurServicess at affordable prices</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices7.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">VIP hospital services</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">VIP services in hospitals and clinics</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices8.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">Better with us</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">We offer the best treatments for you to become better both physically and mentally</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices9.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">Recovery</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">Proper nursing care for proper post-op recovery</a>

                        </div>
                    </div>
                    <div class="col-lg-2 col-md-2 col-sm-2 col-xs-2">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices10.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesStyle">Keep contact with doctor</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesStyle">Keep in touch with your doctor after treatment</a>

                        </div>
                    </div>
                    <div class="col-lg-1 col-md-1 col-sm-1 col-xs-1"></div>
                </div>

            </div>




        </div>

        <%-- #Sm --%>

        <div id="PanelPopularTreatmentsBoxSm" class="PanelPopularTreatmentsBoxStyle row hidden-lg hidden-md hidden-xs">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelLblPopularTreatmentsStyle text-center">
                    <p id="LblPopularTreatmentsSm" class="LblPopularTreatmentsStyle text-center">POPULAR TREATMENTS</p>

                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">

                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments1.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments1-1.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>


                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments2.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/NoseJobsPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments2-2.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments3.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/HairTransplantPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments3-3.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">

                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments4.png" class="ImagePopularTreatments1Style" />
                            <a href="#" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments4-4.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>


                    </div>


                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments5.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/PlasticSurgeryPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments5-5.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments6.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/WeightLossPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments6-6.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivBtnSeeMoreSmStyle">
                    <a href="/View/En/RimaTrip/Popular.aspx" target="_blank" class="btn BtnSeeMoreSmStyle">See more Treatments</a>
                </div>
            </div>


            <%-- #VIDEOS --%>
            <div class="col-Sm-12 col-md-12 col-sm-12 col-xs-12 DivVideos">

                <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideoTabriz.png" class="VideobackgroundStyle" />
                </div>

                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4" style="margin-top: -2%;">
                    <div class="row">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9">

                            <a id="LblTextVideoSm" class="LblTextVideoStyle">VIDEOS</a>
                        </div>
                    </div>

                    <div class="row DivVideoTextImgSmStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg11.png" class="VideosImgSmStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularSmStyle">
                            <a href="#" target="_blank" class="TextVideoPubularSmStyle">
                                <p>
                                    Cosmetic Dentistry videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgSmStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg22.png" class="VideosImgSmStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularSmStyle">
                            <a href="#" target="_blank" class="TextVideoPubularSmStyle">
                                <p>
                                    Nose Surgery videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgSmStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg33.png" class="VideosImgSmStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularSmStyle">
                            <a href="#" target="_blank" class="TextVideoPubularSmStyle">
                                <p>
                                    Hiar Transplant Videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgSmStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg44.png" class="VideosImgSmStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularSmStyle">
                            <a href="#" target="_blank" class="TextVideoPubularSmStyle">
                                <p>
                                    Fertility Treatments Videos
                                </p>
                            </a>
                        </div>

                    </div>

                    <div class="row DivVideoTextImgSmStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg55.png" class="VideosImgSmStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularSmStyle">
                            <a href="#" target="_blank" class="TextVideoPubularSmStyle">
                                <p>
                                    Plastic Surgery Videos
                                </p>
                            </a>
                        </div>

                    </div>
                    <div class="row DivVideoTextImgSmStyle">
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                            <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg66.png" class="VideosImgSmStyle" />

                        </div>
                        <div class="col-lg-9 col-md-9 col-sm-9 col-xs-9 DivTextVideoPubularSmStyle">
                            <a href="#" target="_blank" class="TextVideoPubularSmStyle">
                                <p>
                                    Weeight Loss Surgery Videos
                                </p>
                            </a>
                        </div>

                    </div>
                </div>





                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <p class="text-center FontWellcomeTabrizVideoSmStyle">Welcome to Tabriz</p>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <p class="text-justify ZirFontWellcomeTabrizVideoSmStyle">Biblical clues point to the Ajichay River flowing out of the Garden of Eden, which places Tabriz at the gates of paradise. Long a buffer between empires, Tabriz' historical heritage and Silk Road pedigree is no more evident than in its thriving bazaar, one of the world's best. This sprawling city, rich in Azeri culture, with its famous carpets, teahouse hammams, love of music and excellent transport links, makes a perfect introduction to Iran. Situated on a high plateau between Lake Orumiyeh and lofty Mt Sahand, and bounded by stark, eroded hills, Tabriz has milder summers than cities further east, though its winters can be formidable.</p>
                </div>


            </div>

            <%-- #About Us --%>

            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAboutSmStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirSliderAboutUsTitrSmStyle text-center">
                    <p class="TitrAboutUsSmStyle">
                        ABOUT US  
                    </p>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirAboutUsZirTitrSmStyle text-justify">

                    <p class="ZirTitrAboutUsSmStyle">
                        Islamic Republic of Iran is of great potential in treatment services in the region and always has been under attention of scientic agencies of the
                         world because of science production in global standards.<br />
                        During recent years, people of the world attempt hard to support their health. They treat themselves in their life place or a little farther and in
                        some cases they pass their geographical boundaries for treating and feeling secure to guarantee their health and take travels without any condition.
                        In this regard there are dierent global denitions that in Iran we only follow up whatever has happened in Iran. Some regions in our neighborhood,
                        has experienced different political and geographical changes in their structure. For different reasons, Iran is a destination for travelers
                        who are seeking for treatment services. They face markets with no owner. Our treatment structure looked for director to these markets. Briefly
                        speaking, under some pressures we started to think and we concluded that having some problematic rules is better than lacking them. We understood
                        that some authorities attempt to start health tourism in our country...<a target="_blank" href="/View/En/RimaTrip/About-Us/AbouUs.aspx" title="Arvateb-About">Read More</a>
                    </p>
                </div>

            </div>




            <%-- #Arvateb --%>

            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivArvatebServicesSmStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <a id="LblArvatebServicesSm" class="LblPopularTreatmentsStyle text-center">MEDICAL TOURISM SERVICES</a>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices1.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">Online Support</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">Find your treatment (medical / cosmetic), ask for information online</a>

                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices2.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">Medical consultation</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">expert medical consultation provided for free</a>

                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: 8%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices3.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">24 Hours assistant</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">We accompany you during your medical trip to your departure</a>

                        </div>
                    </div>

                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">

                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -8%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices4.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">Follow-up</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">Long-term follow-up by phone, video call, WhatsApp, etc</a>

                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices5.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a id="LblNameLogoArvatebServices5Sm" class="LblNameLogoArvatebServicesSmStyle">Trip planning</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a id="LblZirNameLogoArvatebServices5Sm" class="LblZirNameLogoArvatebServicesSmStyle">Have your flight and hotel organized by us after treatment confirmation</a>

                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices7.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">VIP hospital services</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">VIP services in hospitals and clinics</a>

                        </div>
                    </div>


                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">

                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices6.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">OurServicess</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">Providing you OurServicess at affordable prices</a>

                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices8.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">Better with us</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">We offer the best treatments for you to become better both physically and mentally</a>

                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices9.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">Recovery</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">Proper nursing care for proper post-op recovery</a>

                        </div>
                    </div>
                </div>


                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">


                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices10.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesSmStyle">Keep contact with doctor</a>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirNameLogoArvatebServices text-center">
                            <a class="LblZirNameLogoArvatebServicesSmStyle">Keep in touch with your doctor after treatment</a>

                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>
            </div>




        </div>


      



        <%-- #Xs --%>


        <div id="PanelPopularTreatmentsBoxXs" class="PanelPopularTreatmentsBoxStyle row hidden-lg hidden-md hidden-sm">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelLblPopularTreatmentsStyle text-center">
                    <p id="LblPopularTreatmentsXs" class="LblPopularTreatmentsStyle text-center">POPULAR TREATMENTS</p>

                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">

                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments1.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments1-1.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>


                    </div>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments2.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/NoseJobsPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments2-2.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>

                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments3.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/HairTransplantPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments3-3.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>



                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">

                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments4.png" class="ImagePopularTreatments1Style" />
                            <a href="#" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments4-4.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>


                    </div>

                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments5.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/PlasticSurgeryPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments5-5.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>

                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 ">

                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle ">


                            <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments6.png" class="ImagePopularTreatments1Style" />
                            <a href="/View/En/RimaTrip/PopularPages/WeightLossPopular.aspx" target="_blank">
                                <img src="/Resources/En/RimaTrip/Index/ImagePopularTreatments/ImagePopularTreatments6-6.png" class="ImagePopularTreatments2Style" />

                            </a>
                        </div>

                    </div>
                </div>




                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivBtnSeeMoreSmStyle">
                    <a href="/View/En/RimaTrip/Popular.aspx" target="_blank" class="btn BtnSeeMoreSmStyle">See more Treatments</a>

                </div>
            </div>



            <%-- #VIDEOS --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivVideos">

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideoTabriz.png" class="VideobackgroundStyle" />
                </div>

                <div class="col-lg-12 col-md-12 col-Xs-12 col-xs-12" style="margin-top: -2%;">


                    <div class="row" style="margin-top: 3%; padding-left: 5%;">
                        <div class="row DivVideoTextImgXsStyle">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg11.png" class="VideosImgXsStyle" />

                                </div>
                                <div class="col-lg-8 col-md-8 col-sm8 col-xs-8 DivTextVideoPubularXsStyle">
                                    <a href="#" target="_blank" class="TextVideoPubularXsStyle">
                                        <p>
                                            CoXsetic Dentistry videos
                                        </p>
                                    </a>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg22.png" class="VideosImgXsStyle" />

                                </div>
                                <div class="col-lg-8 col-md-8 col-sm8 col-xs-8 DivTextVideoPubularXsStyle">
                                    <a href="#" target="_blank" class="TextVideoPubularXsStyle">
                                        <p>
                                            Nose Surgery videos
                                        </p>
                                    </a>
                                </div>
                            </div>

                        </div>


                        <div class="row DivVideoTextImgXsStyle">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg33.png" class="VideosImgXsStyle" />

                                </div>
                                <div class="col-lg-8 col-md-8 col-sm8 col-xs-8 DivTextVideoPubularXsStyle">
                                    <a href="#" target="_blank" class="TextVideoPubularXsStyle">
                                        <p>
                                            Hiar Transplant Videos
                                        </p>
                                    </a>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg44.png" class="VideosImgXsStyle" />

                                </div>
                                <div class="col-lg-8 col-md-8 col-sm8 col-xs-8 DivTextVideoPubularXsStyle">
                                    <a href="#" target="_blank" class="TextVideoPubularXsStyle">
                                        <p>
                                            Fertility Treatments Videos
                                        </p>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="row DivVideoTextImgXsStyle">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg55.png" class="VideosImgXsStyle" />

                                </div>
                                <div class="col-lg-8 col-md-8 col-sm8 col-xs-8 DivTextVideoPubularXsStyle">
                                    <a href="#" target="_blank" class="TextVideoPubularXsStyle">
                                        <p>
                                            Plastic Surgery Videos
                                        </p>
                                    </a>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                                <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                                    <img src="/Resources/En/RimaTrip/Index/VideoBackground/VideosImg66.png" class="VideosImgXsStyle" />

                                </div>
                                <div class="col-lg-8 col-md-8 col-sm8 col-xs-8 DivTextVideoPubularXsStyle">
                                    <a href="#" target="_blank" class="TextVideoPubularXsStyle">
                                        <p>
                                            Weeight Loss Surgery Videos
                                        </p>
                                    </a>
                                </div>

                            </div>
                        </div>
                    </div>


                </div>



                <div class="col-Xs-12 col-md-12 col-Xs-12 col-xs-12 ">
                    <p class="text-center FontWellcomeTabrizVideoXsStyle">Welcome to Tabriz</p>
                </div>
                <div class="col-Xs-12 col-md-12 col-Xs-12 col-xs-12 ">
                    <p class="text-justify ZirFontWellcomeTabrizVideoXsStyle">Biblical clues point to the Ajichay River flowing out of the Garden of Eden, which places Tabriz at the gates of paradise. Long a buffer between empires, Tabriz' historical heritage and Silk Road pedigree is no more evident than in its thriving bazaar, one of the world's best. This sprawling city, rich in Azeri culture, with its famous carpets, teahouse hammams, love of music and excellent transport links, makes a perfect introduction to Iran. Situated on a high plateau between Lake Orumiyeh and lofty Mt Sahand, and bounded by stark, eroded hills, Tabriz has milder summers than cities further east, though its winters can be formidable.</p>
                </div>


            </div>


            <%-- #About Us --%>


            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAboutXsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirSliderAboutUsTitrXsStyle text-center">
                    <p class="TitrAboutUsXsStyle">
                        ABOUT US  
                    </p>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirAboutUsZirTitrXsStyle text-justify">

                    <p class="ZirTitrAboutUsXsStyle">
                        Islamic Republic of Iran is of great potential in treatment services in the region and always has been under attention of scientic agencies of the
                         world because of science production in global standards.<br />
                        During recent years, people of the world attempt hard to support their health. They treat themselves in their life place or a little farther and in
                        some cases they pass their geographical boundaries for treating and feeling secure to guarantee their health and take travels without any condition.
                        In this regard there are dierent global denitions that in Iran we only follow up whatever has happened in Iran. Some regions in our neighborhood,
                        has experienced different political and geographical changes in their structure. For different reasons, Iran is a destination for travelers
                        who are seeking for treatment services. They face markets with no owner. Our treatment structure looked for director to these markets. Briefly
                        speaking, under some pressures we started to think and we concluded that having some problematic rules is better than lacking them. We understood
                        that some authorities attempt to start health tourism in our country...<a target="_blank" href="/View/En/RimaTrip/About-Us/AbouUs.aspx" title="Arvateb-About">Read More</a>
                    </p>
                </div>

            </div>




            <%-- #Arvateb --%>

            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivArvatebServicesXsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <a id="LblArvatebServicesXs" class="LblPopularTreatmentsStyle text-center">MEDICAL TOURISM SERVICES</a>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices1.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">Online Support</a>
                        </div>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices2.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">Medical consultation</a>
                        </div>

                    </div>

                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: 8%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices3.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">24 Hours assistant</a>
                        </div>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -8%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices4.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">Follow-up</a>
                        </div>

                    </div>

                </div>




                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">


                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices5.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">Trip planning</a>
                        </div>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices7.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">VIP hospital services</a>
                        </div>

                    </div>


                </div>


                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices6.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">OurServicess</a>
                        </div>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices8.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">Better with us</a>
                        </div>

                    </div>


                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ArvatebBoxImgTextStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices10.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">Keep contact with doctor</a>
                        </div>

                    </div>

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" style="margin-left: -3%;">
                            <img src="/Resources/En/RimaTrip/Index/ArvatebServices/ArvatebServices9.png" class="ArvatebServicesImgStyle" />
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivNameLogoArvatebServices text-center">
                            <a class="LblNameLogoArvatebServicesXsStyle">Recovery</a>
                        </div>

                    </div>

                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 Row2ArvatebBoxImgTextStyle">
                </div>
            </div>




        </div>


     





    </div>





</asp:Content>
