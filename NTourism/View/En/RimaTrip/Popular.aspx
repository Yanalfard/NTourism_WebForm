<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/RimaTrip/Master/Index.master" AutoEventWireup="true" CodeBehind="Popular.aspx.cs" Inherits="NTourism.View.En.RimaTrip.Popular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <script src="JLibirary/Pobular.js"></script>
    <link href="CssLibirary/Pobular.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="PanelPagePopularTreatments" class="container-fluid PanelPagePopularTreatmentsStyle">
        
        <%--#Image Panel --%>
        <div id="PanelSliderPopular" class="row">

            <img id="SliderImgPopularTreatments1" src="/Resources/En/RimaTrip/PagePopularTreatments/Slider/SliderPopularTreatments1.png" class="SliderImgPopularTreatments1Style" />
            <img id="SliderImgPopularTreatments2" src="/Resources/En/RimaTrip/PagePopularTreatments/Slider/SliderPopularTreatments2.png" class="SliderImgPopularTreatments2Style" />
            <img id="SliderImgPopularTreatments3" src="/Resources/En/RimaTrip/PagePopularTreatments/Slider/SliderPopularTreatments3.png" class="SliderImgPopularTreatments3Style" />
            <img id="SliderImgPopularTreatments5" src="/Resources/En/RimaTrip/PagePopularTreatments/Slider/SliderPopularTreatments5.png" class="SliderImgPopularTreatments5Style" />
            <img id="SliderImgPopularTreatments4" src="/Resources/En/RimaTrip/PagePopularTreatments/Slider/SliderPopularTreatments4.png" class="SliderImgPopularTreatments4Style" />

        </div>

        <%-- #Lg --%>
        <div class="row hidden-sm hidden-xs">

            <%-- Cosmeticprocedures panel--%>
            <div id="PanelCosmeticProcedures" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelCosmeticProceduresStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <p class="NameInCosmeticproceduresStyle">
                        COSMETIC PROCEDURES
                    </p>
                </div>
                <%-- #Row One --%>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowOneCosmeticproceduresStyle">
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="Cosmeticprocedures1" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures1.png" class="ImagePopularTreatments1Style" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxStyle">
                                    Cosmetic Dentistry
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle1" class="row DivZirTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxStyle">
                                    Repairs and improve your dental beauty and health, give you a bright white and attractive smiles
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="Cosmeticprocedures2" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures2.png" class="ImagePopularTreatments1Style" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxStyle">
                                    Nose Job (Rhinoplasty)
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle2" class="row DivZirTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxStyle">
                                    Primary Rhinoplasty (Nose Surgery), Secondary Rhinoplasty (Revision rhinoplasty)
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/NoseJobsPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresStyle" />

                                </a>
                            </div>

                        </div>


                    </div>




                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="Cosmeticprocedures3" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures3.png" class="ImagePopularTreatments1Style" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxStyle">
                                    Hair Transplant
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle3" class="row DivZirTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxStyle">
                                    Both men and women for restoring hair. For men bread, mustache or other signs of balding and hair loss
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/HairTransplantPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresStyle" />

                                </a>
                            </div>

                        </div>


                    </div>





                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="Cosmeticprocedures4" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures4.png" class="ImagePopularTreatments1Style" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxStyle">
                                    Weight Loss
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle4" class="row DivZirTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxStyle">
                                    Obesity and weight loss treatment for people who are more than 30 kg until 200 kg overweight
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/WeightLossPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresStyle" />

                                </a>
                            </div>

                        </div>


                    </div>





                </div>




                <%-- Row2 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowTwoCosmeticproceduresStyle">
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                        </div>


                    </div>


                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="Cosmeticprocedures5" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures5.png" class="ImagePopularTreatments1Style" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxStyle">
                                    Plastic Surgery
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle5" class="row DivZirTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxStyle">
                                    Brow Lift, Cheek surgery, Ear Surgery, blepharoplasty, Facelift, Lip Implant, Breast Lift, Liposuction …
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/PlasticSurgeryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresStyle" />
                                </a>
                            </div>
                        </div>
                    </div>




                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="Cosmeticprocedures6" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures6.png" class="ImagePopularTreatments1Style" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxStyle">
                                    Non-Surgical Plastic
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle6" class="row DivZirTitrInCosmeticproceduresBoxStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxStyle">
                                    Botox, Cheek Fillers, Fat Injection, Laser Hair Removal, Acne Scar Removal, Laser Skin Resurfacing
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/NonSurgryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresStyle" />
                                </a>
                            </div>

                        </div>


                    </div>





                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                        </div>


                    </div>





                </div>
            </div>


            <%-- MedicalTreatments panel--%>
            <div id="PanelMedicalTreatments" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelMedicalTreatmentsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <p class="NameInMedicalTreatmentsStyle">
                        MEDICAL TREATMENTS
                    </p>
                </div>
                <%-- #RowOne --%>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowOneMedicalTreatmentsStyle">
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments1" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobMedicalTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments1.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    General Surgery
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle1" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    Related to stomach, gall bladder, liver, varices, thyroid gland, lungs, mammography procedures and...
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/GeneralSurgeryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments2" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments2.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    ENT (Ear, Nose and Throat)
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle2" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    ENT (otolaryngology) deals with conditions of the ear, nose, and throat and related structures of the head...
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/EntPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>

                        </div>


                    </div>




                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments3" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments3.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    Orthopedics
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle3" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    Orthopedic care services such as knee, Hip, Foot and Ankle, Shoulder, Elbow, Wrist and Hand, Spine surgeries
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/OrthopedicPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>

                        </div>


                    </div>





                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments4" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments4.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    Eye Care
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle4" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    The best surgeons and eye care services with advanced technologies for ophthalmological procedures.
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/EyeCarePopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>

                        </div>


                    </div>





                </div>




                <%-- Row2 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowTwoMedicalTreatmentsStyle">
                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments5" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments5.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    Medical Dentistry
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle5" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    Gum disease as well as tooth decay, dental enamel erosion, toothaches or chronic bad breath …
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>
                        </div>


                    </div>


                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments6" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments6.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    Fertility / IVF
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle6" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    Large number of fertility procedures, achieving the goal of having a baby and becoming parents
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/FertilityPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>

                        </div>


                    </div>




                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments7" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments7.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    Cardiology
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle7" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    Heart surgeries (cardiac or cardiothoracic surgery) correct various conditions, heart attack, strokes…
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/HeartPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>

                        </div>


                    </div>





                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3 ">

                        <div id="MedicalTreatments8" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments8.png" class="ImageMedicalTreatments1Style" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxStyle">
                                    Cancer
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle8" class="row DivZirTitrInMedicalTreatmentsBoxStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxStyle">
                                    Bone Cancer, Brain Cancer, Breast Cancer, Colon Cancer, Kidney Cancer, Liver Cancer, Lung Cancer …
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxStyle">
                                <a href="/View/En/RimaTrip/PopularPages/CanserPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsStyle" />

                                </a>
                            </div>

                        </div>


                    </div>





                </div>


            </div>



            <%-- #Others Treatments--%>
            <div id="PanelOthersTreatments" class="PanelOthersTreatmentsStyle col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsBorderStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 text-center">
                        <div class="row text-center DivOthersTreatmentsInBorderStyle"></div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsTextStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Heart Treatment  </a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Neurology and Psychiatry</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Internal Neurology</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Neurology Surgery</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Infectious</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Diabetes</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Physiotherapy</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Nuclear Medicine</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Lung Treatment</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Kidney Surger</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Kidney Treatment</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Liver Surgery</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Liver Treatment</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Glands Treatment</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Chemotherapy </a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Oncology</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Orthopedic</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Knee and Joint Specialist</a></p>

                    </div>

                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Rheumatology</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Otolaryngology </a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Rhinoplasty</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Blood Medicine</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">General Surgery</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Thorax Surgery</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Angioplasty </a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Varicose Veins</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Plastic surgery:</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Genioplasty</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Rhinoplasty</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Tummy tuck</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Breast augmentation</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Weight loss surgery</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Butt lift</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Non-Surgical Plastic</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">botox injection</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Liposuction</a></p>

                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Face lift</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Lip augmentation</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Dermal fillers </a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Beauty Specialist</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Hair Transplant</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Dentistry</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Dental implant</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Dental veneers</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Eye surgery</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Eye lift</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">ENT (Ear, Nose and Throat)</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Ivf</a></p>
                        <p class="LinkOthersTreatmentsStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsStyle">Fertility treatments</a></p>

                    </div>
                </div>




            </div>




        </div>
        <%-- #Nd --%>
        <div class="row hidden-lg hidden-md hidden-xs">

            <%-- Cosmeticprocedures panel--%>
            <div id="PanelCosmeticProceduresMd" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelCosmeticProceduresMdStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <p class="NameInCosmeticproceduresMdStyle">
                        COSMETIC PROCEDURES
                    </p>
                </div>
                <%-- #Row One --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowOneCosmeticproceduresMdStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="Cosmeticprocedures1Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures1.png" class="ImagePopularTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxMdStyle">
                                    Cosmetic Dentistry
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle1Md" class="row DivZirTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxMdStyle">
                                    Repairs and improve your dental beauty and health, give you a bright white and attractive smiles
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="Cosmeticprocedures2Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures2.png" class="ImagePopularTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxMdStyle">
                                    Nose Job (Rhinoplasty)
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle2Md" class="row DivZirTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxMdStyle">
                                    Primary Rhinoplasty (Nose Surgery), Secondary Rhinoplasty (Revision rhinoplasty)
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/NoseJobsPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>




                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="Cosmeticprocedures3Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures3.png" class="ImagePopularTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxMdStyle">
                                    Hair Transplant
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle3Md" class="row DivZirTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxMdStyle">
                                    Both men and women for restoring hair. For men bread, mustache or other signs of balding and hair loss
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/HairTransplantPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>










                </div>




                <%-- Row2 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowTwoCosmeticproceduresMdStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="Cosmeticprocedures4Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures4.png" class="ImagePopularTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxMdStyle">
                                    Weight Loss
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle4Md" class="row DivZirTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxMdStyle">
                                    Obesity and weight loss treatment for people who are more than 30 kg until 200 kg overweight
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/WeightLossPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>



                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="Cosmeticprocedures5Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures5.png" class="ImagePopularTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxMdStyle">
                                    Plastic Surgery
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle5Md" class="row DivZirTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxMdStyle">
                                    Brow Lift, Cheek surgery, Ear Surgery, blepharoplasty, Facelift, Lip Implant, Breast Lift, Liposuction …
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/PlasticSurgeryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>




                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ">

                        <div id="Cosmeticprocedures6Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures6.png" class="ImagePopularTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxMdStyle">
                                    Non-Surgical Plastic
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle6Md" class="row DivZirTitrInCosmeticproceduresBoxMdStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxMdStyle">
                                    Botox, Cheek Fillers, Fat Injection, Laser Hair Removal, Acne Scar Removal, Laser Skin Resurfacing
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/NonSurgryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>











                </div>
            </div>



            <%-- MedicalTreatments panel--%>
            <div id="PanelMedicalTreatmentsMd" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelMedicalTreatmentsMdStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <p class="NameInMedicalTreatmentsMdStyle">
                        MEDICAL TREATMENTS
                    </p>
                </div>
                <%-- #RowOne --%>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowOneMedicalTreatmentsMdStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="MedicalTreatments1Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobMedicalTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments1.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    General Surgery
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle1Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    Related to stomach, gall bladder, liver, varices, thyroid gland, lungs, mammography procedures and...
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/GeneralSurgeryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 ">

                        <div id="MedicalTreatments2Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments2.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    ENT (Ear, Nose and Throat)
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle2Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    ENT (otolaryngology) deals with conditions of the ear, nose, and throat and related structures of the head...
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/EntPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>




                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="MedicalTreatments3Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments3.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    Orthopedics
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle3Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    Orthopedic care services such as knee, Hip, Foot and Ankle, Shoulder, Elbow, Wrist and Hand, Spine surgeries
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/OrthopedicPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>










                </div>




                <%-- Row2 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowTwoMedicalTreatmentsMdStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="MedicalTreatments5Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments5.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    Medical Dentistry
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle5Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    Gum disease as well as tooth decay, dental enamel erosion, toothaches or chronic bad breath …
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />
                                </a>
                            </div>
                        </div>


                    </div>


                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="MedicalTreatments6Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments6.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    Fertility / IVF
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle6Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    Large number of fertility procedures, achieving the goal of having a baby and becoming parents
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/FertilityPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>




                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="MedicalTreatments7Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments7.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    Cardiology
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle7Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    Heart surgeries (cardiac or cardiothoracic surgery) correct various conditions, heart attack, strokes…
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/HeartPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>






                </div>


                <%-- Row3 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowThreeMedicalTreatmentsMdStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="MedicalTreatments4Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsMdStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments4.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    Eye Care
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle4Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    The best surgeons and eye care services with advanced technologies for ophthalmological procedures.
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/EyeCarePopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>

                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">

                        <div id="MedicalTreatments8Md" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments8.png" class="ImageMedicalTreatments1MdStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxMdStyle">
                                    Cancer
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle8Md" class="row DivZirTitrInMedicalTreatmentsBoxMdStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxMdStyle">
                                    Bone Cancer, Brain Cancer, Breast Cancer, Colon Cancer, Kidney Cancer, Liver Cancer, Lung Cancer …
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxMdStyle">
                                <a href="/View/En/RimaTrip/PopularPages/CanserPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsMdStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                </div>
            </div>


            <%-- #Others Treatments--%>
            <div id="PanelOthersTreatmentsMd" class="PanelOthersTreatmentsMdStyle col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsBorderMdStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 text-center">
                        <div class="row text-center DivOthersTreatmentsInBorderMdStyle"></div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsTextMdStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Heart Treatment  </a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Neurology and Psychiatry</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Internal Neurology</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Neurology Surgery</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Infectious</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Diabetes</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Physiotherapy</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Nuclear Medicine</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Lung Treatment</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Kidney Surger</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Kidney Treatment</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Liver Surgery</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Liver Treatment</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Glands Treatment</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Chemotherapy </a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Oncology</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Orthopedic</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Knee and Joint Specialist</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Rheumatology</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Otolaryngology </a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Rhinoplasty</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Blood Medicine</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">General Surgery</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Thorax Surgery</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Angioplasty </a></p>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Varicose Veins</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Plastic surgery:</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Genioplasty</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Rhinoplasty</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Tummy tuck</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Breast augmentation</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Weight loss surgery</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Butt lift</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Non-Surgical Plastic</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">botox injection</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Liposuction</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Face lift</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Lip augmentation</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Dermal fillers </a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Beauty Specialist</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Hair Transplant</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Dentistry</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Dental implant</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Dental veneers</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Eye surgery</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Eye lift</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">ENT (Ear, Nose and Throat)</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Ivf</a></p>
                        <p class="LinkOthersTreatmentsMdStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsMdStyle">Fertility treatments</a></p>

                    </div>


                </div>




            </div>




        </div>




        <%-- #Sm --%>

        <div class="row hidden-lg hidden-md hidden-sm">


            <%-- Cosmeticprocedures panel--%>
            <div id="PanelCosmeticProceduresSm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelCosmeticProceduresSmStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <p class="NameInCosmeticproceduresSmStyle">
                        COSMETIC PROCEDURES
                    </p>
                </div>
                <%-- #Row One --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowOneCosmeticproceduresSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="Cosmeticprocedures1Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures1.png" class="ImagePopularTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxSmStyle">
                                    Cosmetic Dentistry
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle1Sm" class="row DivZirTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxSmStyle">
                                    Repairs and improve your dental beauty and health, give you a bright white and attractive smiles
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="Cosmeticprocedures2Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures2.png" class="ImagePopularTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxSmStyle">
                                    Nose Job (Rhinoplasty)
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle2Sm" class="row DivZirTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxSmStyle">
                                    Primary Rhinoplasty (Nose Surgery), Secondary Rhinoplasty (Revision rhinoplasty)
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/NoseJobsPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>
                </div>
                <%-- Row2 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowTwoCosmeticproceduresSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="Cosmeticprocedures3Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures3.png" class="ImagePopularTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxSmStyle">
                                    Hair Transplant
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle3Sm" class="row DivZirTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxSmStyle">
                                    Both men and women for restoring hair. For men bread, mustache or other signs of balding and hair loss
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/HairTransplantPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="Cosmeticprocedures4Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures4.png" class="ImagePopularTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxSmStyle">
                                    Weight Loss
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle4Sm" class="row DivZirTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxSmStyle">
                                    Obesity and weight loss treatment for people who are more than 30 kg until 200 kg overweight
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/WeightLossPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                </div>


                <%-- #Row3 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowThreeCosmeticproceduresSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="Cosmeticprocedures5Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures5.png" class="ImagePopularTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxSmStyle">
                                    Plastic Surgery
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle5Sm" class="row DivZirTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxSmStyle">
                                    Brow Lift, Cheek surgery, Ear Surgery, blepharoplasty, Facelift, Lip Implant, Breast Lift, Liposuction …
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/PlasticSurgeryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="Cosmeticprocedures6Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/Cosmeticprocedures6.png" class="ImagePopularTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkTitrInCosmeticproceduresBoxSmStyle">
                                    Non-Surgical Plastic
                                </p>
                            </div>
                            <div id="DivZirTitrInCosmeticproceduresBoxStyle6Sm" class="row DivZirTitrInCosmeticproceduresBoxSmStyle">
                                <p class="text-center LinkZirTitrInCosmeticproceduresBoxSmStyle">
                                    Botox, Cheek Fillers, Fat Injection, Laser Hair Removal, Acne Scar Removal, Laser Skin Resurfacing
                                </p>
                            </div>
                            <div class="row text-center BtnInCosmeticproceduresBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/NonSurgryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgCosmeticproceduresSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>
                </div>

            </div>



            <%-- MedicalTreatments panel--%>
            <div id="PanelMedicalTreatmentsSm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 PanelMedicalTreatmentsSmStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                    <p class="NameInMedicalTreatmentsSmStyle">
                        MEDICAL TREATMENTS
                    </p>
                </div>
                <%-- #RowOne --%>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowOneMedicalTreatmentsSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments1Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobMedicalTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments1.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    General Surgery
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle1Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    Related to stomach, gall bladder, liver, varices, thyroid gland, lungs, mammography procedures and...
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/GeneralSurgeryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments2Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments2.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    ENT (Ear, Nose and Throat)
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle2Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    ENT (otolaryngology) deals with conditions of the ear, nose, and throat and related structures of the head...
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/EntPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>





                </div>

                <%-- Row2 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowTwoMedicalTreatmentsSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments5Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments5.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    Medical Dentistry
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle5Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    Gum disease as well as tooth decay, dental enamel erosion, toothaches or chronic bad breath …
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/DentistryPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>
                        </div>


                    </div>


                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments6Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments6.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    Fertility / IVF
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle6Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    Large number of fertility procedures, achieving the goal of having a baby and becoming parents
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/FertilityPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>










                </div>


                <%-- Row3 --%>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowThreeMedicalTreatmentsSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments4Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments4.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    Eye Care
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle4Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    The best surgeons and eye care services with advanced technologies for ophthalmological procedures.
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/EyeCarePopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>

                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments8Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments8.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    Cancer
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle8Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    Bone Cancer, Brain Cancer, Breast Cancer, Colon Cancer, Kidney Cancer, Liver Cancer, Lung Cancer …
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/CanserPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>


                </div>

                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 RowFourMedicalTreatmentsSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments3Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments3.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    Orthopedics
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle3Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    Orthopedic care services such as knee, Hip, Foot and Ankle, Shoulder, Elbow, Wrist and Hand, Spine surgeries
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/OrthopedicPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">

                        <div id="MedicalTreatments7Sm" class="col-lg-12 col-md-12 col-sm-12 col-xs-12 BoxShadobPopularTreatmentsSmStyle">
                            <div class="row">
                                <img src="/Resources/En/RimaTrip/PagePopularTreatments/MedicalTreatments/MedicalTreatments7.png" class="ImageMedicalTreatments1SmStyle" />
                            </div>
                            <div class="row DivTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkTitrInMedicalTreatmentsBoxSmStyle">
                                    Cardiology
                                </p>
                            </div>
                            <div id="DivZirTitrInMedicalTreatmentsBoxStyle7Sm" class="row DivZirTitrInMedicalTreatmentsBoxSmStyle">
                                <p class="text-center LinkZirTitrInMedicalTreatmentsBoxSmStyle">
                                    Heart surgeries (cardiac or cardiothoracic surgery) correct various conditions, heart attack, strokes…
                                </p>
                            </div>
                            <div class="row text-center BtnInMedicalTreatmentsBoxSmStyle">
                                <a href="/View/En/RimaTrip/PopularPages/HeartPopular.aspx" target="_blank">
                                    <img src="/Resources/En/RimaTrip/PagePopularTreatments/Cosmeticprocedures/BtnCosmeticprocedures.png" class="BtnImgMedicalTreatmentsSmStyle" />

                                </a>
                            </div>

                        </div>


                    </div>

                </div>
            </div>



            <%-- #Others Treatments--%>
            <div id="PanelOthersTreatmentsSm" class="PanelOthersTreatmentsSmStyle col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsBorderSmStyle">
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4 text-center">
                        <div class="row text-center DivOthersTreatmentsInBorderSmStyle"></div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4"></div>
                </div>
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center DivOthersTreatmentsTextSmStyle">
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Heart Treatment  </a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Neurology and Psychiatry</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Internal Neurology</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Neurology Surgery</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Infectious</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Diabetes</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Physiotherapy</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Nuclear Medicine</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Lung Treatment</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Kidney Surger</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Kidney Treatment</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Liver Surgery</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Liver Treatment</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Glands Treatment</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Chemotherapy </a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Oncology</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Orthopedic</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Knee and Joint Specialist</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Rheumatology</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Otolaryngology </a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Rhinoplasty</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Blood Medicine</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">General Surgery</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Thorax Surgery</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Angioplasty </a></p>

                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6">
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Varicose Veins</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Plastic surgery:</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Genioplasty</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Rhinoplasty</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Tummy tuck</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Breast augmentation</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Weight loss surgery</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Butt lift</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Non-Surgical Plastic</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">botox injection</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Liposuction</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Face lift</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Lip augmentation</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Dermal fillers </a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Beauty Specialist</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Hair Transplant</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Dentistry</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Dental implant</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Dental veneers</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Eye surgery</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Eye lift</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">ENT (Ear, Nose and Throat)</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Ivf</a></p>
                        <p class="LinkOthersTreatmentsSmStyle"><a href="#" target="_blank" class="MatnLinkOthersTreatmentsSmStyle">Fertility treatments</a></p>

                    </div>

                </div>




            </div>




        </div>


    </div>

</asp:Content>
