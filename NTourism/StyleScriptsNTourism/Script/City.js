$(document).ready(function () {


    let CityName;
    var queryString = new Array();
    $(function () {

        if (queryString.length == 0) {
            if (window.location.search.split('?').length > 1) {
                var params = window.location.search.split('?')[1].split('&');
                for (var i = 0; i < params.length; i++) {
                    var key = params[i].split('=')[0];
                    var value = decodeURIComponent(params[i].split('=')[1]);
                    queryString[key] = value;
                }
            }
        }
        if (queryString["CityName"] != null) {
            CityName = queryString["CityName"];
            $('<div id="DivAslyNewsMainDynamic"></div>').appendTo('.ShowCitySeletOne');
            var dataCity = SelectCityByName(CityName);
            if (dataCity != null) {
                if (dataCity.Name != null) {
                    $('<h1 class="text-center">' + dataCity.Name + '</h1>').appendTo('#DivAslyNewsMainDynamic');
                }
                if (dataCity.MainImage != null) {
                    $('<div  class="row"><img src="/Resources/Imges/' + dataCity.MainImage + '" alt="' + dataCity.Name + '" title="' + dataCity.Name + '" class="ImageShowCituTittr"/></div>').appendTo('#DivAslyNewsMainDynamic');
                }
                if (dataCity.MapLink != null) {
                    $('<div  class="mapouter"><div class= "gmap_canvas"><iframe class= "gmap_iframe" id="gmap_canvas" src="' + dataCity.MapLink + '" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe><a href="https://www.couponflat.com"></a> </div ></div >').appendTo('#DivAslyNewsMainDynamic');
                }
                if (dataCity.Data != null) {
                    $('<div class="FontCitySelect">' + dataCity.Data + '</div>').appendTo('#DivAslyNewsMainDynamic');
                }



                //////////////////
                //var a1 = SelectCityByName(dataCity.Name);
                var dataRow1 = SelectAttractionByCityId(dataCity.id);
                if (dataRow1 != false) {
                    $('<h2 class="text-center">Destinations</h2><div id="OwlCityDestinationsOwl1" class="owl-carousel owl-theme text-center OwlCityDestinationsOwl1"></div>').appendTo('.OwlCityDestinationsOwl1');
                    for (var i = 0; i < dataRow1.length; i++) {
                        $('<div  href="#"  class="text-center DivClickJqueryDestinations" id="divTagImgOwlCityDestinationsOwl1' + i + '"></div>').appendTo('#OwlCityDestinationsOwl1');
                        $('<img src="/Resources/Imges/' + SelectImagesById(dataRow1[i].ImageId).Image + '" alt="' + dataRow1[i].Title + '" title="' + dataRow1[i].Title + '" class="ImgOwlCityDestinationsOwl1"/>').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                        $('<a target="_blank" class="LinkOwlCityDestinationsOwl1" title="' + dataRow1[i].Title + '">' + dataRow1[i].Title + '</a>').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                        $('<input type="hidden" name="name" value="' + dataRow1[i].id + '" />').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                    }
                }
                var dataRow2 = SelectEventsByCityId(dataCity.id);
                if (dataRow2 != false) {
                    $('<h2 class="text-center">Events</h2><div id="OwlCityDestinationsOwl2" class="owl-carousel owl-theme text-center OwlCityDestinationsOwl1"></div>').appendTo('.OwlCityDestinationsOwl2');
                    for (var i = 0; i < dataRow2.length; i++) {
                        $('<div  href="#"  class="text-center DivClickJqueryEvent" id="divTagImgOwlCityDestinationsOwl2' + i + '"></div>').appendTo('#OwlCityDestinationsOwl2');
                        $('<img src="/Resources/Imges/' + SelectImagesById(dataRow2[i].ImageId).Image + '" class="ImgOwlCityDestinationsOwl1"/>').appendTo('#divTagImgOwlCityDestinationsOwl2' + i);
                        $('<a target="_blank" class="LinkOwlCityDestinationsOwl1" title="' + dataRow2[i].Title + '">' + dataRow2[i].Title + '</a>').appendTo('#divTagImgOwlCityDestinationsOwl2' + i);
                        $('<input type="hidden" name="name" value="' + dataRow2[i].id + '" />').appendTo('#divTagImgOwlCityDestinationsOwl2' + i);

                    }
                }

                $('.DivClickJqueryDestinations').click(function () {
                    var Team2ShowCol3 = $(this).children("input[type='hidden']").val();
                    var DestinationsName = Team2ShowCol3;
                    window.localStorage.setItem("DestinationsName", DestinationsName);
                    window.location.href = "/View/En/Destinations/Destinations-Main.aspx?DestinationsName=" + DestinationsName;

                });
                $('.DivClickJqueryEvent').click(function () {
                    var Team2ShowCol3 = $(this).children("input[type='hidden']").val();
                    var EventName = Team2ShowCol3;
                    window.localStorage.setItem("EventName", EventName);
                    window.location.href = "/View/En/Event/Event-Main.aspx?EventName=" + EventName;
                });
                jQuery("#OwlCityDestinationsOwl1").owlCarousel({
                    autoplayHoverPause: true,
                    autoplay: true,
                    lazyLoad: true,
                    loop: true,
                    margin: 20,
                    responsiveClass: true,
                    autoHeight: true,
                    autoplayTimeout: 3000,
                    smartSpeed: 800,
                    nav: true,
                    responsive: {
                        0: {
                            items: 1
                        },
                        600: {
                            items: 2
                        },
                        1024: {
                            items: 3
                        },
                        1366: {
                            items: 4
                        }
                    }
                });
                jQuery("#OwlCityDestinationsOwl2").owlCarousel({
                    autoplayHoverPause: true,
                    autoplay: true,
                    lazyLoad: true,
                    loop: true,
                    margin: 20,
                    responsiveClass: true,
                    autoHeight: true,
                    autoplayTimeout: 3000,
                    smartSpeed: 800,
                    nav: true,
                    responsive: {
                        0: {
                            items: 1
                        },
                        600: {
                            items: 2
                        },
                        1024: {
                            items: 3
                        },
                        1366: {
                            items: 4
                        }
                    }
                });


            }
            else if (data == null) {

            }
        }


        else {
            window.location.href = "/Index.aspx";
        }

    });

});