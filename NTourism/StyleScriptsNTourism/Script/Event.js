$(document).ready(function () {
    var data = SelectAttractionByStatus('4');
    data.reverse();
    for (var i = 0; i < data.length; i++) {
        $('<div id="divInRow1TheRow2EventPage' + i + '" class="list-item divInRow1TheRow2EventPageStyle"></div>').appendTo('.divRow1EventPageStyle');
        $('<div id="divInRow1TheRow2EventPageDivRow1' + i + '" class="row"></div>').appendTo('#divInRow1TheRow2EventPage' + i);
        $('<div id="divInRow1TheRow2EventPageDivRow2' + i + '" class="row" style="padding:1em;"></div>').appendTo('#divInRow1TheRow2EventPage' + i);
        $('<div id="divInRow1TheRow2EventPageDivRow3' + i + '" class="row"></div>').appendTo('#divInRow1TheRow2EventPage' + i);
        //Row1
        /////col1
        var dataMainImage = SelectImagesById(data[i].ImageId);
        var dataDetalisCore = SelectTextById(data[i].TextId);

        //var timeOfEvent = data[i].Let;
        //var placeOfEvent = data[i].Lun;
        $('<div id="divInRow1TheRow2EventPageDivRow1Col1' + i + '" class="col-lg-6 col-md-6 col-sm-7 col-xs-12"></div>').appendTo('#divInRow1TheRow2EventPageDivRow1' + i);

        $('<img src="/Resources/Imges/' + dataMainImage.Image + '" class="ImgDynamicBigImgEventstyle">').appendTo('#divInRow1TheRow2EventPageDivRow1Col1' + i);
        ////Col2
        $('<div id="divInRow1TheRow2EventPageDivRow1Col2' + i + '"  class="DivClickJqueryEvent col-lg-6 col-md-6 col-sm-5 col-xs-12"></div>').appendTo('#divInRow1TheRow2EventPageDivRow1' + i);
        $('<p class="pEquipmentes">City</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<p class="linkNameTextEventstyle">' + SelectCityById(data[i].CityId).Name + '</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<p class="pEquipmentes">Title</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<p class="linkNameTextEventstyle">' + data[i].Title.split(';')[0] + '</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<p class="pEquipmentes">From</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<p class="linkNameTextEventstyle">' + data[i].Title.split(';')[1] + '</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<p class="pEquipmentes">To</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<p class="linkNameTextEventstyle">' + data[i].Title.split(';')[2] + '</p>').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);
        $('<input type="hidden" name="name" value="' + data[i].id + '" />').appendTo('#divInRow1TheRow2EventPageDivRow1Col2' + i);

        ///Row2
        /////////////////////////////
        //$('<p class="pEquipmentes">Detalis</p>').appendTo('#divInRow1TheRow2EventPageDivRow2' + i);
        //$('<p class="linkNameTextEventstyle">' + dataDetalisCore.Text + '</p>').appendTo('#divInRow1TheRow2EventPageDivRow2' + i);
        $('.DivClickJqueryEvent').click(function () {
            var Team2ShowCol3 = $(this).children("input[type='hidden']").val();
            var EventName = Team2ShowCol3;
            window.localStorage.setItem("EventName", EventName);
            window.location.href = "/View/En/Event/Event-Main.aspx?EventName=" + EventName;
        });
    }
    // jQuery paging Plugin: http://flaviusmatis.github.io/simplePagination.js/
    var items = $(".list-wrapper .list-item");
    var numItems = items.length;
    var perPage = 2;
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