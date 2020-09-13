$(document).ready(function () {

    $('#BtnSearchGallery').click(function () {
        var TextSearchGallery = $('#TextSearchGallery').val();
        var NameChoseradioName = $('input[name=radioNameGallery]:checked', '#RadioBtnGallerychecked').val();
        if (TextSearchGallery == "") {
            alert('please select text search');
        }
        else {
            if (!$("input[name='radioNameGallery']:checked").val()) {
                alert('Nothing is checked!');
                return false;
            }
            else {
                //////Inja Neveshte shavad
                // var SelectImageByname = SelectImagesByName(TextSearchGallery);
                var SelectedImage = SelectImagesByName(TextSearchGallery);
                var videoFlag = false;
                var imageFlag = false;
                $('.divInRow1TheRow2GalleryPageStyle').empty();
                $('#pagination-container').empty();
                if (NameChoseradioName == "SearchVideo") {
                    for (var i = 0; i < SelectedImage.length; i++) {
                        if (SelectedImage[i].Image.includes('aparat')) {
                            // its a video
                            videoFlag = true;
                            $('<div id="divInRow1TheRow2NewsPageZoj' + i + '" class="col-lg-4 ol-md-4 col-sm-6 col-xs-6 divRow2GalleryPageStyle list-item"></div>').appendTo('.divInRow1TheRow2GalleryPageStyle');
                            $(SelectedImage[i].Image).appendTo('#divInRow1TheRow2NewsPageZoj' + i);
                            $('<p class="TagdivRow2GalleryPageStyle">' + data[i].Name.split(":")[0] + '</p>').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
                            ReloadPaging();

                        }
                    }
                    if (!videoFlag) {
                        alert('video mojud nemibashad');
                    }
                }
                else {
                    for (var i = 0; i < SelectedImage.length; i++) {
                        if (!SelectedImage[i].Image.includes('aparat')) {
                            // its a image
                            imageFlag = true;
                            $('<div onclick="ShowBigSizeImgGallery(' + i + ');" id="divInRow1TheRow2NewsPageZoj' + i + '" class="col-lg-4 ol-md-4 col-sm-6 col-xs-6 divRow2GalleryPageStyle list-item"></div > ').appendTo('.divInRow1TheRow2GalleryPageStyle');
                            $('<img  src="/Resources/Imges/' + SelectedImage[i].Image + '" class="ImgdivRow2GalleryPageStyle">').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
                            $('<p class="TagdivRow2GalleryPageStyle">' + SelectedImage[i].Name.split(":")[0] + '</p>').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
                            ReloadPaging();

                        }
                    }
                    if (!imageFlag) {
                        alert('image mojud nemibashad');

                    }
                }
            }
            return false;
        }
    })

    var data = SelectAllImages();
    data.reverse();
    if (data != null) {
        for (var i = 0; i < data.length; i++) {
            if (data[i].Image.includes('aparat')) {
                // its a video
                $('<div id="divInRow1TheRow2NewsPageZoj' + i + '" class="col-lg-4 ol-md-4 col-sm-6 col-xs-6 divRow2GalleryPageStyle list-item"></div>').appendTo('.divInRow1TheRow2GalleryPageStyle');
                $(data[i].Image).appendTo('#divInRow1TheRow2NewsPageZoj' + i);
                $('<p class="TagdivRow2GalleryPageStyle">' + data[i].Name.split(":")[0] + '</p>').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
            }
            else {
                $('<div onclick="ShowBigSizeImgGallery(' + i + ');"  id="divInRow1TheRow2NewsPageZoj' + i + '" class="col-lg-4 ol-md-4 col-sm-6 col-xs-6 divRow2GalleryPageStyle list-item"></div > ').appendTo('.divInRow1TheRow2GalleryPageStyle');
                $('<img src="/Resources/Imges/' + data[i].Image + '" class="ImgdivRow2GalleryPageStyle" alt="' + data[i].Name + '" title="' + data[i].Name + '">').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
                $('<p class="TagdivRow2GalleryPageStyle">' + data[i].Name.split(":")[0] + '</p>').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
            }

        }
    }
    // jQuery Plugin: http://flaviusmatis.github.io/simplePagination.js/
    var items = $(".list-wrapper .list-item");
    var numItems = items.length;
    var perPage = 9;
    items.slice(perPage).hide();
    $('#pagination-container').pagination({
        items: numItems,
        itemsOnPage: perPage,
        prevText: "&laquo;",
        nextText: "&raquo;",
        onPageClick: function (pageNumber) {
            var showFrom = perPage * (pageNumber - 1);
            var showTo = showFrom + perPage;
            items.hide().slice(showFrom, showTo).show();
        }
    });

    function ReloadPaging() {
        var items2 = $(".list-wrapper .list-item");
        var numItems2 = items2.length;
        var perPage2 = 9;
        items2.slice(perPage2).hide();
        $('#pagination-container').pagination({
            items: numItems2,
            itemsOnPage: perPage2,
            prevText: "&laquo;",
            nextText: "&raquo;",
            onPageClick: function (pageNumber) {
                var showFrom = perPage2 * (pageNumber - 1);
                var showTo = showFrom + perPage2;
                items2.hide().slice(showFrom, showTo).show();
            }
        });
    }

    ////FullSizeImage
    var modalGallery = document.getElementById("mymodalGallery");
    var modalGalleryImg = document.getElementById("img01");
    var captionGalleryText = document.getElementById("captionGallery");
    $('.divRow2GalleryPageStyle').click(function () {
        var NameImgGalleryFullSize = $(this).children('img').attr('src');
        var NameImgGalleryFullSize2 = $(this).children('p').text();
        modalGallery.style.display = "block";
        modalGalleryImg.src = NameImgGalleryFullSize;
        captionGalleryText.innerHTML = NameImgGalleryFullSize2;
    })
    function ShowBigSizeImgGallery(e) {
        var NameImgGalleryFullSize = $('#divInRow1TheRow2NewsPageZoj' + e).children('img').attr('src');
        var NameImgGalleryFullSize2 = $('#divInRow1TheRow2NewsPageZoj' + e).children('p').text();
        modalGallery.style.display = "block";
        modalGalleryImg.src = NameImgGalleryFullSize;
        captionGalleryText.innerHTML = NameImgGalleryFullSize2;
    };
    // Get the <span> element that closeGallerys the modalGallery
    var span = document.getElementsByClassName("closeGallery")[0];
    // When the user clicks on <span> (x), closeGallery the modalGallery
    span.onclick = function () {
        modalGallery.style.display = "none";
    }


})