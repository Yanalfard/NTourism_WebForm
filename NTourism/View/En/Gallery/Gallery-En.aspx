<%@ Page Title="" Language="C#" MasterPageFile="~/View/En/Master/Index/NTourism.Master" AutoEventWireup="true" CodeBehind="Gallery-En.aspx.cs" Inherits="NTourism.View.En.Gallery.Gallery_En" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/StyleScriptsNTourism/Script/Gallery.js"></script>
    <link href="/StyleScriptsNTourism/Style/Gallery.css" rel="stylesheet" />

  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <%-- #Row1  --%>
        <div class="divRow1GalleryPageStyle">
            <div class="divInRow1TheRow1TextGalleryPageStyle text-center">
                <p class="textInRow1TheRow1TextGalleryPageStyle">GALLERY</p>
            </div>

            <div class="SearchdivGallery">
   
                <script src="https://kit.fontawesome.com/57456f662e.js" crossorigin="anonymous"></script>
                <center><h1>Search box by Image Or Video</h1></center>
                <!--Search content -->
                <div class="searchinput">
                    <input id="TextSearchGallery" type="text" name="q" placeholder=" search..." class="textGallery" required>
                    <button id="BtnSearchGallery" type="submit" class="submitGallery"><i class="fas fa-search"></i></button>
                    <div class="text-center" id="RadioBtnGallerychecked">
                        <label>
                            <input type="radio" name="radioNameGallery" value="SearchVideo" />
                            Video
                        </label>
                        <label>
                            <input type="radio" name="radioNameGallery" value="SearchImage" />
                            Image
                        </label>
                    </div>
                </div>

            </div>

            <div class="divInRow1TheRow2GalleryPageStyle container-fluid list-wrapper">
            </div>
            <div id="pagination-container"></div>
        </div>
        <%-- Ads 5 --%>
        <script>
            var Number1Ads = 1041;
            var Number2Ads = 1042;
            var Number3Ads = 1043;
            var Number4Ads = 1044;
            var Number5Ads = 1045;
        </script>
        <div class="divAdd5upinfooter">
        </div>



        <%-- Image SizeFull --%>
        <div id="mymodalGallery" class="modalGallery">
            <span class="closeGallery">&times;</span>
            <img class="modalGallery-content" id="img01">
            <div id="captionGallery"></div>
        </div>
    </div>




</asp:Content>
