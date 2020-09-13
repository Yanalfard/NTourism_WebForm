$(document).ready(function () {
    let Country;
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
        if (queryString["Country"] != null) {
            Country = queryString["Country"];
            $('<div id="DivAslyNewsMainDynamic"></div>').appendTo('.ShowCitySeletOne');
            var selectedCountry = SelectCountryByName(Country);

            var selectedCities = SelectCityByCountryId(selectedCountry.id);
            $('<div id="OwlCityDestinationsOwl1" class="owl-carousel owl-theme text-center OwlCityDestinationsOwl1"></div>').appendTo('.ShowAllCitiesInSlider');
            for (var i = 0; i < selectedCities.length; i++) {
                if (selectedCities[i].IsValid) {
                    $('<option value="' + selectedCities[i].Name + '"></option>').appendTo('#DataListInDestinations');
                    $('<div  href="#" style="cursor:pointer; display:block;"  class="text-center DivClickJquery" id="divTagImgOwlCityDestinationsOwl1' + i + '"></div>').appendTo('#OwlCityDestinationsOwl1');
                    $('<img src="/Resources/Imges/' + selectedCities[i].MainImage + '" class="ImgOwlCityDestinationsOwl1" alt="' + selectedCities[i].Name + '" title="' + selectedCities[i].Name + '"/>').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                    $(' <a class="LinkOwlCityDestinationsOwl1">' + selectedCities[i].Name + '</a>').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                    $('<input type="hidden" name="name" value="' + selectedCities[i].Name + '" />').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                }
            };
            $('.DivClickJquery').click(function () {
                alert('3');
                var Team2ShowCol3 = $(this).children("input[type='hidden']").val();
                var CityName = Team2ShowCol3;
                window.localStorage.setItem("CityName", CityName);
                window.location.href = "/View/En/City/City.aspx?CityName=" + CityName;
                //window.open(
                //    "/View/En/City/City.aspx?CityName=" + CityName
                //);
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
        }
        else {
            var selectedCountry = SelectCountryByName("Iran");
            var selectedCities = SelectCityByCountryId(selectedCountry.id);
            $('<div id="OwlCityDestinationsOwl1" class="owl-carousel owl-theme text-center OwlCityDestinationsOwl1"></div>').appendTo('.ShowAllCitiesInSlider');

            for (var i = 0; i < selectedCities.length; i++) {
                if (selectedCities[i].IsValid) {
                    $('<option value="' + selectedCities[i].Name + '"></option>').appendTo('#DataListInDestinations');
                    $('<div  href="#" style="cursor:pointer; display:block;"  class="text-center DivClickJquery" id="divTagImgOwlCityDestinationsOwl1' + i + '"></div>').appendTo('#OwlCityDestinationsOwl1');
                    $('<img src="/Resources/Imges/' + selectedCities[i].MainImage + '" class="ImgOwlCityDestinationsOwl1" alt="' + selectedCities[i].Name + '" title="' + selectedCities[i].Name + '"/>').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                    $(' <a class="LinkOwlCityDestinationsOwl1">' + selectedCities[i].Name + '</a>').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                    $('<input type="hidden" name="name" value="' + selectedCities[i].Name + '" />').appendTo('#divTagImgOwlCityDestinationsOwl1' + i);
                }
            };
            $('.DivClickJquery').click(function () {
                var Team2ShowCol3 = $(this).children("input[type='hidden']").val();
                var CityName = Team2ShowCol3;
                window.localStorage.setItem("CityName", CityName);
                window.location.href = "/View/En/City/City.aspx?CityName=" + CityName;
                //window.open(
                //    "/View/En/City/City.aspx?CityName=" + CityName
                //);
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

        }

    });



    $('#BtnSearchDestinations').click(function () {
        var TextSearchDestinations = $('#TextSearchDestinations').val();
        if (TextSearchDestinations == "") {
            alert('please select text search');
        }
        else {
            //var destinations = SelectAttractionByCityId(SelectCityByName(TextSearchDestinations));
            var destinations = SelectCityByName(TextSearchDestinations);
            var CityName = destinations.Name;
            window.localStorage.setItem("CityName", CityName);
            window.location.href = "/View/En/City/City.aspx?CityName=" + CityName;
            //window.open(
            //    "/View/En/Destinations/Destinations-En.aspx?CityName=" + CityName
            //);
            return false;
        }
    })






});