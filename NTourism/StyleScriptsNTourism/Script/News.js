$(document).ready(function () {

    var allNews = SelectAllNewss();
    allNews.reverse();
    for (var i = 0; i < allNews.length; i++) {
        var image = SelectImagesById(allNews[i].ImageId);
        var text = SelectTextById(allNews[i].TextId);
        if (i % 2 == 0) {
            ////--------------
            ////--------------
            ////--------------
            //Aks samte rast text samte chap
            $('<div style="overflow-y:auto;"  id="divInRow1TheRow2NewsPage' + i + '" class="list-item divInRow1TheRow2NewsPageStyle"></div>').appendTo('.divRow1NewsPageStyle');
            $('<div id="divInRow1TheRow2NewsPageDivRow1Col1' + i + '" class="col-lg-6 col-md-7 col-sm-12 col-xs-12"></div>').appendTo('#divInRow1TheRow2NewsPage' + i);
            /////col2
            $('<div  style="overflow-y:auto;" id="divInRow1TheRow2NewsPageDivRow1Col2' + i + '"  class="col-lg-6 col-md-5 col-sm-12 col-xs-12"></div>').appendTo('#divInRow1TheRow2NewsPage' + i);
            ///TextCore
            $('<div class="DivTagJquery" style="overflow-y:auto;" id="DivInfoNews' + i + '" ></div>').appendTo('#divInRow1TheRow2NewsPageDivRow1Col2' + i);
            var ImgDynamicBigImgNews = $('<img />', {
                src: '/Resources/Imges/' + image.Image,
                class: 'ImgDynamicBigImgNewsstyle'
            });
            $(ImgDynamicBigImgNews).appendTo('#divInRow1TheRow2NewsPageDivRow1Col1' + i);
            $('<input type="hidden" name="name" value="' + allNews[i].Name + '" />').appendTo('#DivInfoNews' + i);
            $('<p style="overflow-y:auto;" class="linkNameTextNewsstyle">' + allNews[i].Title + '</p>').appendTo('#DivInfoNews' + i);
        }
        else if (i % 2 == 1) {
            //---------///////
            //---------///////
            //---------///////
            //Aks samte rast text samte chap
            $('<div style="overflow-y:auto;"  id="divInRow1TheRow2NewsPageZoj' + i + '" class="list-item divInRow1TheRow2NewsPageStyle"></div>').appendTo('.divRow1NewsPageStyle');
            $('<div style="float:right;" id="divInRow1TheRow2NewsPageDivRow1Col1Zoj' + i + '" class="col-lg-6 col-md-7 col-sm-12 col-xs-12"></div>').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
            /////col2
            $('<div  style="overflow-y:auto;" id="divInRow1TheRow2NewsPageDivRow1Col2Zoj' + i + '"  class="col-lg-6 col-md-5 col-sm-12 col-xs-12"></div>').appendTo('#divInRow1TheRow2NewsPageZoj' + i);
            ///TextCore
            $('<div class="DivTagJquery" style="overflow-y:auto;" id="DivInfoNewsZoj' + i + '" ></div>').appendTo('#divInRow1TheRow2NewsPageDivRow1Col2Zoj' + i);
            var ImgDynamicBigImgNews = $('<img />', {
                src: '/Resources/Imges/' + image.Image,
                class: 'ImgDynamicBigImgNewsstyle'
            });
            $(ImgDynamicBigImgNews).appendTo('#divInRow1TheRow2NewsPageDivRow1Col1Zoj' + i);
            $('<input type="hidden" name="name" value="' + allNews[i].Name + '" />').appendTo('#DivInfoNewsZoj' + i);
            $('<p style="overflow-y:auto;" class="linkNameTextNewsstyle">' + allNews[i].Title + '</p>').appendTo('#DivInfoNewsZoj' + i);
        }
    }
    $('.DivTagJquery').click(function () {
        var Team2ShowCol3 = $(this).children("input[type='hidden']").val();
        var NewsName = Team2ShowCol3;
        //window.localStorage.setItem("NewsName", NewsName);
        //window.location.href = "/View/En/Destinations/Destinations-Main.aspx";
        window.open(
            "/View/En/News/News-Main.aspx?NewsName=" + NewsName
        );
        //var url = "/Index.aspx?UserName=" + txtLoginUsername;
        //window.location.href = url;
    });

    // jQuery Plugin: http://flaviusmatis.github.io/simplePagination.js/

    var items = $(".list-wrapper .list-item");
    var numItems = items.length;
    var perPage = 4;

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

})