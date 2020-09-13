$(document).ready(function () {

  
    //var data = SelectRoomHomeByName('mehdiabad');
    var data = SelectAllRoomHomes();
    data.reverse();
    for (var j = 0; j < data.length; j++) {
        if (data != null) {
            $('<div  id="divInRow1TheRow2OurServicesPage' + j + '" class="divInRow1TheRow2OurServicesPageStyle list-item row"></div>').appendTo('.divRow1OurServicesPageStyle');
            $('<div class="row" id="divInRow1TheRow2OurServicesPageDivRow1' + j + '"></div>').appendTo('#divInRow1TheRow2OurServicesPage' + j);
            $('<div class="row" id="divInRow1TheRow2OurServicesPageDivRow2' + j + '"></div>').appendTo('#divInRow1TheRow2OurServicesPage' + j);
            $('<div class="row" id="divInRow1TheRow2OurServicesPageDivRow3' + j + '" style="padding:0 1em;"></div>').appendTo('#divInRow1TheRow2OurServicesPage' + j);
            $('<div class="row" id="divInRow1TheRow2OurServicesPageDivRow1in2' + j + '" style="padding-right:1em;padding-top:1em;"></div>').appendTo('#divInRow1TheRow2OurServicesPage' + j);


            $('<div id="divInRow1TheRow2OurServicesPageDivRow1Col1' + j + '" class="col-lg-6 col-md-12 col-sm-12 col-xs-12"></div>').appendTo('#divInRow1TheRow2OurServicesPageDivRow1' + j);
            /////col2
            $('<div id="divInRow1TheRow2OurServicesPageDivRow1Col2' + j + '"  class="col-lg-6 col-md-12 col-sm-12 col-xs-12"></div>').appendTo('#divInRow1TheRow2OurServicesPageDivRow1' + j);



            var ImgDynamicBigImgAccomodatio = $('<img />', {
                src: "/Resources/Imges/" + data[j].MainImage,
                class: 'ImgDynamicBigImgOurServicesstyle'
            });
            $(ImgDynamicBigImgAccomodatio).appendTo('#divInRow1TheRow2OurServicesPageDivRow1Col1' + j);

            ////
            $('<p class="pFacilities">Facilities</p>').appendTo('#divInRow1TheRow2OurServicesPageDivRow1Col2' + j);
            $('<div id="divFacilitiesOurServicesStyle' + j + '" class="divFacilitiesOurServicesStyle row"></div>').appendTo('#divInRow1TheRow2OurServicesPageDivRow1Col2' + j);

            var dataFacilities = SelectFacilitiesByRoomHome(data[j].id);
            if (dataFacilities != null) {
                for (var i = 0; i < dataFacilities.length; i++) {
                    if (dataFacilities[i].Name == "Wifi") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Wifi.png" />' +
                            '<p>Wifi</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Room") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Room.png" />' +
                            '<p>Room</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Refrigurator") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Refrigator.png" />' +
                            '<p>Refrig</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Balcon") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Balcon.png" />' +
                            '<p>Balcon</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Safe") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Safe.png" />' +
                            '<p>Safe</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Wash machine") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/WashMachine.png" />' +
                            '<p>Wash Machine</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Bed") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Bed.png" />' +
                            '<p>Bed</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "TV") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/TV.png" />' +
                            '<p>TV</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Bath Room") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/BathRoom.png" />' +
                            '<p>Bath Room</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Kitchen") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Kitchen.png" />' +
                            '<p>Kitchen</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Oven") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/Oven.png" />' +
                            '<p>Oven</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }
                    if (dataFacilities[i].Name == "Pet Lover") {
                        $('<div class="col-lg-2 col-md-2 col-sm-2 col-xs-2" >' +
                            ' <img style="width:100%;" src="/Resources/En/OurServices/IconFacilities/PetLower.png" />' +
                            '<p>Pet Lover</p></div > ').appendTo('#divFacilitiesOurServicesStyle' + j);
                    }


                }
            }



            //////
            $('<div id="DivDolarandweekend' + j + '" style="clear: left"></div>').appendTo('#divInRow1TheRow2OurServicesPageDivRow1Col2' + j);
            ///////////////////////
            //////DivDolarandweekend
            $('<div class="DivDolarandweekend" ><span class="fa fa-usd"></span><span class="DayDolarandweekend1">' + data[j].PriceNormal + '$</span><span class="DayDolarandweekend2"> Day</span>' +
                '<span class="WeekendDolarandweekend1">' + data[j].PriceWeekend + '$</span><span class="WeekendDolarandweekend2"> Weekend</span></div>').appendTo('#DivDolarandweekend' + j);



            $('<div class="DynamicTextOurServicesstyle" id="DynamicTextOurServicesstyle' + j + '"></div>').appendTo('#divInRow1TheRow2OurServicesPageDivRow1Col2' + j);
            //////////Row1 Samte Rast Text
            var linkName = $("<p />");
            linkName.attr("title", data[j].Description);
            linkName.text(data[j].Description);
            linkName.addClass("linkNameTextOurServicesstyle");
            $(linkName).appendTo('#DynamicTextOurServicesstyle' + j);



            //Row2
            $('<input id="Btnbooking" type="button" value="BOOKING" />').appendTo('#divInRow1TheRow2OurServicesPageDivRow1in2' + j);
            $('<div class="DynamicRow2OurServicesstyle" id="DynamicRow2OurServicesstyle' + j + '"></div>').appendTo('#divInRow1TheRow2OurServicesPageDivRow2' + j);
            ////Imgha Row2
            $('<div class="DivAllImgRow2DynamicBigImgOurServicesStyle" id="DivAllImgRow2DynamicBigImgOurServices' + j + '"></div>').appendTo('#DynamicRow2OurServicesstyle' + j);
            var dataImg = SelectImagesByRoomHome(data[j].id);

            var count = dataImg.length;
            if (count > 5) {
                count = 5;
            }
            for (var i = 0; i < count; i++) {
                if (!dataImg[i].Image.includes('aparat')) {
                    $('<div class="col-lg-3 col-md-4 col-sm-5 col-xs-6"><img class="ImgRow2DynamicBigImgOurServicesStyle" src="/Resources/Imges/' + dataImg[i].Image + '"></div>').appendTo('#DynamicRow2OurServicesstyle' + j);
                }
            }
            /////////////////////////////
            /////////Row3 comment
            $('<div id="DivRow3Comments' + j + '" class="DivRow3Comments"></div>').appendTo('#divInRow1TheRow2OurServicesPageDivRow3' + j);
            $('<div id="DivInRow3Row1Comments' + j + '" class="DivInRow3Row1Comments"></div>').appendTo('#DivRow3Comments' + j);
            $('<p><i class="fa fa-comment-o" aria-hidden="true"></i>COMMENTS</p>').appendTo('#DivInRow3Row1Comments' + j);
            $('<div id="DivInRow3Row2Comments' + j + '" class="DivInRow3Row2Comments list-wrapper2"></div>').appendTo('#DivRow3Comments' + j);
            $('<div id="DivInRow3Row3Comments' + j + '" class="DivInRow3Row3Comments"></div>').appendTo('#DivRow3Comments' + j);
            $('<a onclick="BtnDivInRow3Row3Comments(' + j + ')" id="BtnDivInRow3Row3Comments" class="BtnDivInRow3Row3Comments">+</a>').appendTo('#DivInRow3Row3Comments' + j);
            $('<input class="TypeComment" id="TypeComment' + j + '" type="text"  placeholder="Add your comment" autocomplete="off" />').appendTo('#DivInRow3Row3Comments' + j);

            var dataComment = SelectCommentsByRoomHome(data[j].id);
            if (dataComment != null) {
                for (var i = 0; i < dataComment.length; i++) {
                    var linkdataComment = $("<p>");
                    linkdataComment.attr("title", dataComment[i].Text);
                    linkdataComment.text(dataComment[i].Text);
                    linkdataComment.addClass("linkdataComment ");
                    $(linkdataComment).appendTo('#DivInRow3Row2Comments' + j);

                }
            }
            // $('<div id="pagination-container2"></div>').appendTo('#DivInRow3Row2Comments' + j);



            function BtnDivInRow3Row3Comments(id) {

                var textcommnetname = $('#TypeComment' + id).val();
                if (textcommnetname == "") {
                    alert('Enter Comment');
                } else {
                    var CommentText = {
                        Text: textcommnetname,
                        ClientId: 1,//constant data must be changed at future
                        IsValid: false
                    }
                    $.ajax({
                        url: '/api/CommentsCore/AddComment',
                        method: 'Post',
                        data: CommentText,
                        contenttype: 'application/json',
                        datatype: 'json',
                        success: function (dataComment) {
                            $('#TypeComment' + id).val("");
                            alert('Send Comment');
                        },
                        error: function (dataImg) {
                        }
                    });
                }

            }


            // jQuery Plugin: http://flaviusmatis.github.io/simplePagination.js/

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



            ////////////
            var items2 = $(".list-wrapper2 .list-item2");
            var numItems2 = items.length;
            var perPage2 = 2;

            items2.slice(perPage2).hide();

            $('#pagination-container2').pagination({
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
    }




})