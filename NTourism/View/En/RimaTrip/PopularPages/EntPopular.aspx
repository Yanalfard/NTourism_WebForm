<%@ Page Title="Ent" Language="C#" MasterPageFile="~/View/En/RimaTrip/Master/Index.master" AutoEventWireup="true" CodeBehind="EntPopular.aspx.cs" Inherits="RimaTrip.View.PopularPages.EntPopular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CssLibirary/EntPopular.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="PanelEnt" class="PanelEntStyle" >


        <%-- #Lg --%>

        <div class="container-fluid hidden-sm hidden-xs">




            <%-- #Header Image --%>

            <div class="row">

                <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/HeaderImgEnt1.png" alt="Ent" class="ImgHeaderEntStyle" />
            </div>

            <%-- #HeaderText --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="row SliderDivTextEntStyle">
                    <p title="Ent" class="SliderTitrEntStyle">
                        ENT
                    </p>

                </div>
                <div class="row SliderZirDivTextEntStyle">
                    <p title="Ent" class="SliderZirTitrEntStyle">
                        TREATMENTS
                    </p>
                </div>

                <div class="row SliderDivDescriptionEntTitrStyle">
                    <p title="DescriptionEnt" class="SliderDescriptionEntTextTitrStyle">
                        Experienced doctors, modern hospitals, and<br />
                        reasonable costs for otorhinolaryngological<br />
                        treatmEnts in Iran within your reach with our<br />
                        medical tourism services.
                        
                    </p>
                </div>

                <div class="row DivBtnEntSingInStyle">
                    <a href="/View/En/RimaTrip/Singup/Singup.aspx" title="SingIn" class="TextBtnEntStyle btn">&nbsp;&nbsp;Register&nbsp;&nbsp; </a>
                </div>
            </div>



            <%-- #ZirHeadersImgText --%>


            <div class="row text-cEnter DivZirHeadersImgTextEntStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <p class="ZirHeadersImgTextEntStyle text-justify">
                        Iran possesses a rich resource of specialists armed with the most up-to-date knowledge of the Ent specialty. With its developed medical infrastructure, reasonable costs of healthcare services, and highly qualifiedotolaryngologists, Iran is a perfect destination for foreign people who want to get a high-quality and affordable Ent treatment.
                    </p>
                </div>


            </div>


            <%-- #Video and Text--%>

            <%--<div class="row text-cEnter DivVideoAndTextEntStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8">
                        <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/VideoEnt.png" alt="VideoEnt" class="VideoEntStyle" />
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-4 col-xs-4">
                        <div class="row">
                            <p class="TitrTextVideoEntStyle text-left">
                            </p>
                        </div>
                        <div class="row DivZirTextVideoEntStyle">
                            <p class="ZirTextVideoEntStyle text-justify">

                            </p>
                        </div>

                    </div>
                </div>

            </div>--%>


            <%-- #Descaptirion --%>
            <div class="row DescaptirionOrginalEntStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                    <%-- #row one --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowOneEntStyle">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify">
                                <p class="TitrTextRowOneEntStyle text-justify">
                                    Otolaryngology
                                </p>
                            </div>
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRowOneEntStyle">
                                <p class="ZirTitrTextRowOneEntStyle">
                                    Commonly known as Ent (Ear, Nose, and Throat) is a branch of medicine that specializes in diagnosis and treatmEnt of disorders of Ear, Nose, and Throat. In a broader view, it specializes in head and neck diseases, providing comprehensive services for all ages, from newborns to adults. Iranian otolaryngology specialists are among the best in the Middle East, offering Ent services using the latest approaches and technologies. Coping with chronic ear infection, tonsillitis, sinus problems, impaired sense of hearing, problems in eating, breathing and speech, malignant and benign tumors in ears, nose, throat, head, and neck, acid reflux (GERD), and cancers such as oral, salivary gland, and skin cancer affcting the head, neck, and nose, are some common examples within key areas of concern in Ent.
                                </p>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 text-cEnter">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/Pic3Ent.png" class="Pic3EntRowOneStyle" alt="Pic3Ent" />
                        </div>
                    </div>




                    <%-- #row Two --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowTwoEntStyle">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 text-cEnter">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/ImgMapIran.png" class="Pic1EntRowTwoStyle" alt="Pic1Ent" />
                        </div>

                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify">
                                <p class="TitrTextRowTwoEntStyle text-justify">
                                    Why Iran?
                                </p>
                            </div>
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRowTwoEntStyle">
                                <p class="ZirTitrTextRowTwoEntStyle">
                                    Ear is the subject for hearing sounds and body balance. nose is the subject to smell and breathing.pharynx is the subject to sounds and breathing.ENT is a branch of medicine that specializes in the diagnosis and treatment of ENT. Treatment of hearing disorders such as hearing loss and for the treatment of middle ear infections and tinnitus repair, treatment of nasal polyps, as well as rhinoplasty. The treatment of laryngeal lesions and head and neck tumors are an ENT specialist's responsibility.
                                </p>
                            </div>
                        </div>
                    </div>



                    <%-- #row Three --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowThreeEntStyle">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 ">
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify">
                                <p class="TitrTextRowThreeEntStyle text-justify">
                                    Why RimaTrip?
                                </p>
                            </div>
                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRoThreeEntStyle">
                                <p class="ZirTitrTextRowThreeEntStyle">
                                    Arranging a hair transplant abroad will cause you some inconvenience, such as arranging for a hotel, city transfer, language barrier, and more. We will eliminate all this hassle.
                                </p>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-6 text-cEnter ">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/ImgSibSalamat.png" class="Pic2EntRowThreeStyle" alt="Pic1Ent" />
                        </div>
                    </div>

                </div>


            </div>

        </div>







        <%-- #Sm --%>

        <div class="container-fluid hidden-lg hidden-md hidden-xs">



            <%-- #Header Image --%>

            <div class="row">
                <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/HeaderImgEnt1.png" alt="Ent" class="ImgHeaderEntSmStyle" />
            </div>

            <%-- #HeaderText --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="row SliderDivTextEntSmStyle">
                    <p title="Ent" class="SliderTitrEntSmStyle">
                        ENT
                    </p>

                </div>
                <div class="row SliderZirDivTextEntSmStyle">
                    <p title="TREATMEntS" class="SliderZirTitrEntSmStyle">
                        TREATMENTS
                    </p>
                </div>

                <div class="row SliderDivDescriptionEntTitrSmStyle">
                    <p title="DescriptionEnt" class="SliderDescriptionEntTextTitrSmStyle">
                        Experienced doctors, modern hospitals, and<br />
                        reasonable costs for otorhinolaryngological<br />
                        treatmEnts in Iran within your reach with our<br />
                        medical tourism services.
                    </p>
                </div>

                <div class="row DivBtnEntSingInSmStyle">
                    <a href="/View/En/RimaTrip/Singup/Singup.aspx" title="SingIn" class="TextBtnEntSmStyle btn">&nbsp;&nbsp;Register&nbsp;&nbsp; </a>
                </div>
            </div>



            <%-- #ZirHeadersImgText --%>


            <div class="row text-cEnter DivZirHeadersImgTextEntSmStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <p class="ZirHeadersImgTextEntSmStyle text-justify">
                        Iran possesses a rich resource of specialists armed with the most up-to-date knowledge of the Ent specialty. With its developed medical infrastructure, reasonable costs of healthcare services, and highly qualifiedotolaryngologists, Iran is a perfect destination for foreign people who want to get a high-quality and affordable  Ent treatment.                   
                    </p>
                </div>


            </div>


            <%-- #Video and Text--%>
            <%--    
            <div class="row text-cEnter DivVideoAndTextEntSmStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/VideoEnt.png" alt="VideoEnt" class="VideoEntSmStyle" />
                    </div>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirVideoEntSmStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <p class="TitrTextVideoEntSmStyle text-left">
                               
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <p class="ZirTextVideoEntSmStyle text-justify">
                            </p>
                        </div>

                    </div>
                </div>

            </div>--%>


            <%-- #Descaptirion --%>
            <div class="row DescaptirionOrginalEntSmStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">

                    <%-- #row one --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowOneEntSmStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-cEnter">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/Pic3Ent.png" class="Pic3EntRowOneTransplantSmStyle" alt="Pic3Ent" />
                        </div>

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify DivTitrRowOneEntSmStyle">
                            <p class="TitrTextRowOneEntSmStyle text-justify">
                                Otolaryngology
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRowOneEntSmStyle">
                            <p class="ZirTitrTextRowOneEntSmStyle">
                                Commonly known as Ent (Ear, Nose, and Throat) is a branch of medicine that specializes in diagnosis and treatmEnt of disorders of Ear, Nose, and Throat. In a broader view, it specializes in head and neck diseases, providing comprehensive services for all ages, from newborns to adults. Iranian otolaryngology specialists are among the best in the Middle East, offering Ent services using the latest approaches and technologies. Coping with chronic ear infection, tonsillitis, sinus problems, impaired sense of hearing, problems in eating, breathing and speech, malignant and benign tumors in ears, nose, throat, head, and neck, acid reflux (GERD), and cancers such as oral, salivary gland, and skin cancer affcting the head, neck, and nose, are some common examples within key areas of concern in Ent.

                            </p>
                        </div>


                    </div>




                    <%-- #row Two --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowTwoEntSmStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-cEnter">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/ImgMapIran.png" class="Pic1EntRowTwoTransplantSmStyle" alt="Pic1Ent" />
                        </div>


                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify DivTitrRowTwoEntSmStyle">
                            <p class="TitrTextRowTwoEntSmStyle text-justify">
                                Why Iran?
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRowTwoEntSmStyle">
                            <p class="ZirTitrTextRowTwoEntSmStyle">
                                    Ear is the subject for hearing sounds and body balance. nose is the subject to smell and breathing.pharynx is the subject to sounds and breathing.ENT is a branch of medicine that specializes in the diagnosis and treatment of ENT. Treatment of hearing disorders such as hearing loss and for the treatment of middle ear infections and tinnitus repair, treatment of nasal polyps, as well as rhinoplasty. The treatment of laryngeal lesions and head and neck tumors are an ENT specialist's responsibility.
                            </p>
                        </div>

                    </div>


                    <%-- #row Three --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowThreeEntSmStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-cEnter ">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/ImgSibSalamat.png" class="Pic2EntRowThreeTransplantSmStyle" alt="Pic1Ent" />
                        </div>


                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify DivTitrRowThreeEntSmStyle">
                            <p class="TitrTextRowThreeEntSmStyle text-justify">
                                Why RimaTrip?
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRoThreeEntSmStyle">
                            <p class="ZirTitrTextRowThreeEntSmStyle">
                                Arranging a hair transplant abroad will cause you some inconvenience, such as arranging for a hotel, city transfer, language barrier, and more. We will eliminate all this hassle.
                            </p>
                        </div>


                    </div>

                </div>


            </div>

        </div>









        <%-- #Xs --%>

        <div class="container-fluid hidden-lg hidden-md hidden-sm">


            <%-- #Header Image --%>

            <div class="row">
                <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/HeaderImgEnt1.png" alt="Ent" class="ImgHeaderEntXsStyle" />
            </div>

            <%-- #HeaderText --%>
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="row SliderDivTextEntXsStyle">
                    <p title="Ent" class="SliderTitrEntXsStyle">
                        ENT
                    </p>

                </div>
                <div class="row SliderZirDivTextEntXsStyle">
                    <p title="TREATMEntS" class="SliderZirTitrEntXsStyle">
                        TREATMENTS
                    </p>
                </div>

                <div class="row SliderDivDescriptionEntTitrXsStyle">
                    <p title="DescriptionEnt" class="SliderDescriptionEntTextTitrXsStyle">
                        Experienced doctors, modern hospitals, and<br />
                        reasonable costs for otorhinolaryngological<br />
                        treatmEnts in Iran within your reach with our<br />
                        medical tourism services.
                    </p>
                </div>

                <div class="row DivBtnEntSingInXsStyle">
                    <a href="/View/En/RimaTrip/Singup/Singup.aspx" title="SingIn" class="TextBtnEntXsStyle btn">&nbsp;&nbsp;Register&nbsp;&nbsp; </a>
                </div>
            </div>



            <%-- #ZirHeadersImgText --%>


            <div class="row  text-cEnter DivZirHeadersImgTextEntXsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <p class="ZirHeadersImgTextEntXsStyle text-justify">
                        Iran possesses a rich resource of specialists armed with the most up-to-date knowledge of the Ent specialty. With its developed medical infrastructure, reasonable costs of healthcare services, and highly qualifiedotolaryngologists, Iran is a perfect destination for foreign people who want to get a high-quality and affordable  Ent treatment.
                    </p>
                </div>

            </div>

            <%-- #Video and Text--%>
            <%--  
            <div class="row text-cEnter DivVideoAndTextEntXsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/VideoEnt.png" alt="VideoEnt" class="VideoEntXsStyle" />
                    </div>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirVideoEntXsStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <p class="TitrTextVideoEntXsStyle text-left">
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                            <p class="ZirTextVideoEntXsStyle text-justify">
                            </p>
                        </div>

                    </div>
                </div>

            </div>--%>


            <%-- #Descaptirion --%>
            <div class="row DescaptirionOrginalEntXsStyle">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">


                    <%-- #row one --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowOneEntXsStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-cEnter">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/EntPopular/Pic3Ent.png" class="Pic3EntTransplantRowOneTransplantXsStyle" alt="Pic3Ent" />
                        </div>

                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify DivTitrRowOneEntXsStyle">
                            <p class="TitrTextRowOneEntXsStyle text-justify">
                                Otolaryngology
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRowOneEntXsStyle">
                            <p class="ZirTitrTextRowOneEntXsStyle">
                                Commonly known as Ent (Ear, Nose, and Throat) is a branch of medicine that specializes in diagnosis and treatmEnt of disorders of Ear, Nose, and Throat. In a broader view, it specializes in head and neck diseases, providing comprehensive services for all ages, from newborns to adults. Iranian otolaryngology specialists are among the best in the Middle East, offering Ent services using the latest approaches and technologies. Coping with chronic ear infection, tonsillitis, sinus problems, impaired sense of hearing, problems in eating, breathing and speech, malignant and benign tumors in ears, nose, throat, head, and neck, acid reflux (GERD), and cancers such as oral, salivary gland, and skin cancer affcting the head, neck, and nose, are some common examples within key areas of concern in Ent.
                            </p>
                        </div>

                    </div>



                    <%-- #row Two --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowTwoEntXsStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-cEnter">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/ImgMapIran.png" class="Pic1EntRowTwoTransplantXsStyle" alt="Pic1Ent" />
                        </div>


                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify DivTitrRowTwoEntXsStyle">
                            <p class="TitrTextRowTwoEntXsStyle text-justify">
                                Why Iran?
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRowTwoEntXsStyle">
                            <p class="ZirTitrTextRowTwoEntXsStyle">
                                    Ear is the subject for hearing sounds and body balance. nose is the subject to smell and breathing.pharynx is the subject to sounds and breathing.ENT is a branch of medicine that specializes in the diagnosis and treatment of ENT. Treatment of hearing disorders such as hearing loss and for the treatment of middle ear infections and tinnitus repair, treatment of nasal polyps, as well as rhinoplasty. The treatment of laryngeal lesions and head and neck tumors are an ENT specialist's responsibility.
                            </p>
                        </div>

                    </div>

                    <%-- #row Three --%>
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DescaptirionRowThreeEntXsStyle">
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-cEnter ">
                            <img src="/Resources/En/RimaTrip/PagePopularTreatmEnts/ImgSibSalamat.png" class="Pic2EntRowThreeTransplantXsStyle" alt="Pic1Ent" />
                        </div>


                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 text-justify DivTitrRowThreeEntXsStyle">
                            <p class="TitrTextRowThreeEntXsStyle text-justify">
                                Why RimaTrip?
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12 DivZirTitrTextRoThreeEntXsStyle">
                            <p class="ZirTitrTextRowThreeEntXsStyle">
                                Arranging a hair transplant abroad will cause you some inconvenience, such as arranging for a hotel, city transfer, language barrier, and more. We will eliminate all this hassle.
                            </p>
                        </div>
                    </div>

                </div>


            </div>

        </div>







    </div>







</asp:Content>
