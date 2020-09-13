<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/RimaTrip/Master/Index.master" AutoEventWireup="true" CodeBehind="Hospitals.aspx.cs" Inherits="NTourism.View.En.RimaTrip.Hospitals.Hospitals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="../JLibirary/Hospitals.js"></script>
    <link href="../CssLibirary/Hospitals.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid DivAslyHospitilsStyle">
        <div id="PanelImgSliderHospitils" class="row">
            <div class="row SliderDivTextHealthHospitilsStyle">
                <p title="HEALTH" class="SliderTitrHealthHospitilsStyle">
                    RIMATRIP
                </p>

            </div>
            <div class="row SliderZirDivTextHealthHospitilsStyle">
                <p title="TOURISM-CENTER" class="SliderZirTitrHealthHospitilsStyle">
                    MEDICAL TOURISM
                </p>
            </div>
            <div class="row SliderDivIncludinTextTitrHospitilsStyle">
                <p title="INCLUDIN-Free" class="SliderIncludinTextTitrHospitilsStyle">
                    <%--INCLUDIN FREE--%>
                </p>
            </div>
            <div class="row SliderDivIncludinTextZirTitrHospitilsStyle">
                <p title="INCLUDIN-Free-Transfer" class="SliderIncludinTextZirTitrHospitilsStyle">
                    <%--Transfer / Hotel--%> 
                </p>
            </div>
            <div id="SliderHospitils5" class="SliderBtnRegisterHospitilsStyle">
                <a href="/View/En/RimaTrip/Singup/Singup.aspx" title="SingIn" class="btn SliderBtnRegisterTextHospitilsStyle">Register</a>
            </div>
            <img id="SliderHospitils1" src="/Resources/En/RimaTrip/Hospitals/Hospitals/SliderHospitils1.png" class="SliderHospitilsStyle1" alt="Hospitals-Sibe-Salamat1" title="Hospitals-Sibe-Salamat" />
            <img id="SliderHospitils2" src="/Resources/En/RimaTrip/Hospitals/Hospitals/SliderHospitils2.png" class="SliderHospitilsStyle2" alt="Hospitals-Sibe-Salamat1" title="Hospitals-Sibe-Salamat" />
            <img id="SliderHospitils3" src="/Resources/En/RimaTrip/Hospitals/Hospitals/SliderHospitils3.png" class="SliderHospitilsStyle3" alt="Hospitals-Sibe-Salamat1" title="Hospitals-Sibe-Salamat" />
            <img id="SliderHospitils4" src="/Resources/En/RimaTrip/Hospitals/Hospitals/SliderHospitils4.png" class="SliderHospitilsStyle4" alt="Hospitals-Sibe-Salamat1" title="Hospitals-Sibe-Salamat" />
        </div>
        <%-- #RowTwo --%>
        <%-- #Lg --%>
        <div class="row DivRow2HospitilsStyle hidden-md hidden-sm hidden-xs">
            <%-- #Titr Hospitils --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                <p class="TitrNameHospitilsRow2TwoStyle">
                    HOSPITALS
                </p>
            </div>
            <%-- #ImgHospitilOne --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Valiasr.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneStyle">
                            Valiasr International Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneStyle">
                            The Valiasr International Hospital of Tabriz has been<br />
                            constructed on 45000 square meters of land in<br />
                            Zafraniyeh, with a building of 4600 square meters,
                            <br />
                            with the capacity of 300 beds, the largest private
                            <br />
                            hospital in the country... <a href="/View/En/RimaTrip/Hospitals/Hospital-Valiasr.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>
                        </p>
                    </div>
                </div>
            </div>
            <%-- #ImgHospitilTwo --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Shams.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneStyle">
                            Shams Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneStyle">
                            A general introduction of the hospital
                            <br />
                            Shams Medical Group specialty and subspecialty<br />
                            hospital is one of the biggest and most equipped
                            <br />
                            hospitals of the country and one of the most active
                            <br />
                            hospitals in North and Northwest of country and
                            <br />
                            among the 10 superior hospitals of Ministry of
                            <br />
                            Health that is active in the field of tourism and tourism
                            <br />
                            and medical tourism... <a href="/View/En/RimaTrip/Hospitals/Hospital-Shams.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>
                        </p>
                    </div>

                </div>

            </div>
   


            
            <%-- #ImgHospitilThree --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals-Amiralmomenin/SliderHospital-AmialmomeninImg.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneStyle">
                            Amir al-Momenin Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneStyle">

                            Ali ibn Abitaleb Charity Hospital ,As a MEDICAL TOURISM   
                            <br />
                            With the goalDiagnostic services Presentation,Therapy,<br />
                            RehabilitationAnd safe , With their preservation 
                            <br />
                            and human dignityAnd preferences At the 
                            <br />
                             reception of patients covered by the Nobar Charity 
                            <br />
                            And patients in the northwestern region of the country                      
                            <br />
                            In accordance with national and...<a href="/View/En/RimaTrip/Hospitals/Hospital-Amialmomenin.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>
                        </p>
                    </div>

                </div>

            </div>
     



            <%--  --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivOthersHospitilsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersHospitilsBorderStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 text-center">
                        <div class="row text-center DivOthersHospitilsInBorderStyle"></div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DiuvTitrHospitilsStyle">

                    <p class="TitrNameOthersHospitilsStyle">
                        HOSPITALS
                    </p>

                </div>


                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsTextStyle">
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Valiasr International</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Amiral Momenin</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sina</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shohada</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shafa</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shams</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Noor Nejat</a></p>
                    </div>

                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Razi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Emam Reza</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alavi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alzahra</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nikoo Kari</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Taleghani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Bababaghi</a></p>

                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Asad Abadi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">29 Bahman</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Mahalati</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">522 Artesh</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahriyar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Professor Alinasab</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Zakariya</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Behbood </a></p>

                    </div>
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">

                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alghadir Area</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Fajr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sajad</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Aban</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Mehr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Hakiman Noor</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nabarvari Madar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Jahad Medical Center</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Kids Medical Center </a></p>
                    </div>
                </div>
            </div>
        </div>
        <%-- #Md --%>
     
        <div class="row DivRow2HospitilsStyle  hidden-lg hidden-sm hidden-xs">
            <%-- #Titr Hospitils --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                <p class="TitrNameHospitilsRow2TwoStyle">
                    HOSPITALS
                </p>

            </div>
            <%-- #ImgHospitilOne --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Valiasr.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneMdStyle">
                            Valiasr International Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneMdStyle">
                            The Valiasr International Hospital of Tabriz has been constructed<br />
                            on 45000 square meters of land in Zafraniyeh, with a building<br />
                            of 4600 square meters,with the capacity of 300 beds,<br />
                            the largest private hospital in the country... <a  href="/View/En/RimaTrip/Hospitals/Hospital-Valiasr.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>


                        </p>
                    </div>

                </div>

            </div>

            <%-- #ImgHospitilTwo --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Shams.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneMdStyle">
                            Shams Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneMdStyle">
                            A general introduction of the hospital
                            <br />
                            Shams Medical Group specialty and subspecialty hospital is 
                            <br />
                            one of the biggest and most equippedhospitals of the country
                            <br />
                            and one of the most active hospitals in North and Northwest
                            <br />
                            of country and among the 10 superior hospitals of Ministry of
                            <br />
                            Health that is active in the field of tourism and tourism and medical tourism... <a href="/View/En/RimaTrip/Hospitals/Hospital-Shams.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>


                        </p>
                    </div>

                </div>

            </div>


            <%-- #ImgHospitilThree --%>
              <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Shams.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneMdStyle">
                            Shams Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneMdStyle">
                            Ali ibn Abitaleb Charity Hospital ,As a MEDICAL TOURISM   
                            <br />
                            With the goalDiagnostic services Presentation,Therapy,<br />
                            RehabilitationAnd safe , With their preservation 
                            <br />
                            and human dignityAnd preferences At the 
                            <br />
                             reception of patients covered by the Nobar Charity 
                            <br />
                            And patients in the northwestern region of the country                      
                            <br />
                            In accordance with national and...<a href="/View/En/RimaTrip/Hospitals/Hospital-Amialmomenin.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>


                        </p>
                    </div>

                </div>

            </div>

            <%--  --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivOthersHospitilsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersHospitilsBorderStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 text-center">
                        <div class="row text-center DivOthersHospitilsInBorderStyle"></div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DiuvTitrHospitilsStyle">

                    <p class="TitrNameOthersHospitilsStyle">
                        HOSPITALS
                    </p>

                </div>


                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsTextStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Valiasr International</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Amiral Momenin</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sina</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shohada</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shafa</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shams</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Noor Nejat</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Razi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Emam Reza</a></p>
                    </div>

                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alavi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alzahra</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nikoo Kari</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Taleghani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Bababaghi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Asad Abadi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">29 Bahman</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Mahalati</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">522 Artesh</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahriyar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Professor Alinasab</a></p>

                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Zakariya</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Behbood </a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alghadir Area</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Fajr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sajad</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Aban</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Mehr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Hakiman Noor</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nabarvari Madar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Jahad Medical Center</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Kids Medical Center </a></p>

                    </div>

                </div>

            </div>


        </div>




        <%-- #Sm --%>
  
        <div class="row DivRow2HospitilsStyle  hidden-lg hidden-md hidden-xs">
            <%-- #Titr Hospitils --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                <p class="TitrNameHospitilsRow2TwoStyle">
                    HOSPITALS
                </p>

            </div>
            <%-- #ImgHospitilOne --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Valiasr.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneSmStyle">
                            Valiasr International Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneSmStyle">
                            The Valiasr International Hospital of Tabriz has been constructed<br />
                            on 45000 square meters of land in Zafraniyeh, with a building<br />
                            of 4600 square meters,with the capacity of 300 beds,<br />
                            the largest private hospital in the country... <a href="/View/En/RimaTrip/Hospitals/Hospital-Valiasr.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>


                        </p>
                    </div>

                </div>

            </div>

            <%-- #ImgHospitilTwo --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Shams.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneSmStyle">
                            Shams Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneSmStyle">
                            A general introduction of the hospital Shams Medical Group specialty and subspecialty 
                            <br />
                            hospital is one of the biggest and most equippedhospitals of the country and one of the
                            <br />
                            most active hospitals in North and Northwest of country and among the 10 superior hospitals of
                            <br />
                            Ministry of Health that is active in the field of
                            <br />
                            tourism and tourism and medical tourism... <a href="/View/En/RimaTrip/Hospitals/Hospital-Shams.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>


                        </p>
                    </div>

                </div>

            </div>


             <%-- #ImgHospitilThree --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Shams.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneSmStyle">
                            Shams Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneSmStyle">
                            Ali ibn Abitaleb Charity Hospital ,As a MEDICAL TOURISM  With the goalDiagnostic 
                            <br />
                             services Presentation,Therapy, RehabilitationAnd safe , With their preservation<br />
                             and human dignityAnd preferences  At the reception of patients covered by the
                            <br />
                             Nobar Charity And patients in the northwestern region of the country
                            <br />
                            In accordance with national and... <a href="/View/En/RimaTrip/Hospitals/Hospital-Amialmomenin.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>
                        </p>
                    </div>

                </div>

            </div>

            <%--  --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivOthersHospitilsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersHospitilsBorderStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 text-center">
                        <div class="row text-center DivOthersHospitilsInBorderStyle"></div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DiuvTitrHospitilsStyle">

                    <p class="TitrNameOthersHospitilsStyle">
                        HOSPITALS
                    </p>

                </div>


                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsTextStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Valiasr International</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Amiral Momenin</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sina</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shohada</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shafa</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shams</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Noor Nejat</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Razi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Emam Reza</a></p>
                    </div>

                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alavi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alzahra</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nikoo Kari</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Taleghani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Bababaghi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Asad Abadi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">29 Bahman</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Mahalati</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">522 Artesh</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahriyar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Professor Alinasab</a></p>

                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Zakariya</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Behbood </a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alghadir Area</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Fajr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sajad</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Aban</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Mehr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Hakiman Noor</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nabarvari Madar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Jahad Medical Center</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Kids Medical Center </a></p>

                    </div>

                </div>

            </div>


        </div>






        <%-- #Xs --%>
     
        <div class="row DivRow2HospitilsStyle  hidden-lg hidden-md hidden-sm">
            <%-- #Titr Hospitils --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                <p class="TitrNameHospitilsRow2TwoStyle">
                    HOSPITALS
                </p>

            </div>
            <%-- #ImgHospitilOne --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Valiasr.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneXsStyle">
                            Valiasr International Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneXsStyle">
                            The Valiasr International Hospital of Tabriz has been constructed on
                            <br />
                            45000 square meters of land in Zafraniyeh, with a building of 4600<br />
                            square meters,with the capacity of 300 beds, the largest private hospital<br />
                            in the country... <a href="/View/En/RimaTrip/Hospitals/Hospital-Valiasr.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>


                        </p>
                    </div>

                </div>

            </div>
            
            <%-- #ImgHospitilTwo --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Shams.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneXsStyle">
                            Shams Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneXsStyle">
                            A general introduction of the hospital Shams Medical Group specialty and  
                            <br />
                            subspecialty hospital is one of the biggest and most equippedhospitals of 
                            <br />
                            the country and one of the most active hospitals in North and Northwest of 
                            <br />
                            country and among the 10 superior hospitals of Ministry of Health that is 
                            <br />
                            active in the field of tourism and tourism and 
                            medical tourism... <a href="/View/En/RimaTrip/Hospitals/Hospital-Shams.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>

                        </p>
                    </div>

                </div>

            </div>
          

              <%-- #ImgHospitilTwo --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivImgAndTextImgHospitilTwoStyle">

                <img src="/Resources/En/RimaTrip/Hospitals/Hospitals/Hospitil-Shams.png" class="HospitilValiasrOneStyle" alt="Hospitil-Valiasr-One" title="Hospitil-Valiasr-One" />

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivAllTextHospitilValiasrStyle">
                    <div class="row text-left DivHospitilValiasrTitrOneStyle">
                        <p class="InDivTextHospitilValiasrTitrOneXsStyle">
                            Shams Hospital
                        </p>
                    </div>

                    <div class="row  text-left DivHospitilValiasrZirTitrOneStyle">
                        <p class="InDivTextHospitilValiasrZirTitrOneXsStyle">
                            A general introduction of the hospital Shams Medical Group specialty and  
                            <br />
                            subspecialty hospital is one of the biggest and most equippedhospitals of 
                            <br />
                            the country and one of the most active hospitals in North and Northwest of 
                            <br />
                            country and among the 10 superior hospitals of Ministry of Health that is 
                            <br />
                            active in the field of tourism and tourism and 
                            medical tourism... <a href="/View/En/RimaTrip/Hospitals/Hospital-Shams.aspx" class="LinkHospitilsReadmoreStyle">Read more</a>

                        </p>
                    </div>

                </div>

            </div>
          
            <%--  --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivOthersHospitilsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersHospitilsBorderStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 text-center">
                        <div class="row text-center DivOthersHospitilsInBorderStyle"></div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">

                    <p class="TitrNameOthersHospitilsStyle">
                        HOSPITALS
                    </p>

                </div>


                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsTextStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Valiasr International</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Amiral Momenin</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sina</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shohada</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shafa</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shams</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Noor Nejat</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Razi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Madani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Emam Reza</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alavi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alzahra</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nikoo Kari</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Taleghani</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Bababaghi</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Asad Abadi</a></p>
                    </div>

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">


                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">29 Bahman</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahid Mahalati</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">522 Artesh</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Shahriyar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Professor Alinasab</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Zakariya</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Behbood </a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Alghadir Area</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Fajr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Sajad</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Aban</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Mehr</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Hakiman Noor</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Nabarvari Madar</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Jahad Medical Center</a></p>
                        <p class="LinkOthersHospitilsStyle"><a href="#" target="_blank" class="MatnLinkOthersHospitilsStyle">Kids Medical Center </a></p>
                    </div>


                </div>

            </div>


        </div>

    </div>

</asp:Content>
