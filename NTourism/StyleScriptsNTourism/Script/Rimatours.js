$(document).ready(function () {
    $('#BtnSearchCodeRimatours').click(function () {
        var TextSearchCodeRimatours = $('#TextSearchCodeRimatours').val();
        if (TextSearchCodeRimatours == "") {
            alert('please select Code search');
            return false;
        }
        else {
            var codeIsValidate = SelectTourGuideById(TextSearchCodeRimatours);
            if (codeIsValidate == "") {
                alert('Not Valid');
            }
            else {
                alert('Valid');
            }
            return false;
        }
    })
    var selectedCities = SelectAllCitys();
    for (var i = 0; i < selectedCities.length; i++) {
        $('<option value="' + selectedCities[i].Name + '"></option>').appendTo('#DataListInRimatours');
    }
    let SelectedTourguidesSearch;
    $('#BtnSearchRimatours').click(function () {
        var TextSearchRimatours = $('#TextSearchRimatours').val();
        //  var TextSearchDateInRimatours = $('#TextSearchRimatoursDateIn').val();
        // var TextSearchDateOutRimatours = $('#TextSearchRimatoursDateOut').val();
        var NameChoseradioName = $('input[name=radioName]:checked', '#RadioBtnRimatourschecked').val();
        // if (TextSearchRimatours == "" || TextSearchDateInRimatours == "" || TextSearchDateOutRimatours == "") {
        if (TextSearchRimatours == "") {
            alert('please select text search');
            return false;
        }
        else {
            if (!$("input[name='radioName']:checked").val()) {
                alert('Nothing is checked!');
                return false;
            }
            else {
                if (NameChoseradioName == "Ascending") {
                    //its ascending
                    SelectedTourguidesSearch = SelectTourGuideByCityId(SelectCityByName(TextSearchRimatours).id);
                    if (SelectedTourguidesSearch != false) {
                        showrimatoursserach();
                    }
                    else {
                        alert("The desired city was not found");
                    }
                    return false;
                }
                else if (NameChoseradioName == "Descending") {
                    //its descending
                    SelectedTourguidesSearch = SelectTourGuideByCityId(SelectCityByName(TextSearchRimatours).id);
                    if (SelectedTourguidesSearch != false) {
                        SelectedTourguidesSearch.reverse();
                        showrimatoursserach();
                    }
                    else {
                        alert("The desired city was not found");
                    }
                    return false;
                }
                else if (NameChoseradioName == "Discount") {
                    //its descending
                    SelectedTourguidesSearch = SelectTourGuideByDiscount(SelectCityByName(TextSearchRimatours).id);
                    if (SelectedTourguidesSearch != false) {
                        showrimatoursserach();
                    }
                    else {
                        alert("The desired city was not found");
                    }
                    return false;
                    return false;
                }
                return false;
            };
            return false;
        };
        return false;
    })
    jQuery(function () {
        $('.ShowDetailsClickRimatours').hide();
    });
    var selectedTourguides = SelectAllTourGuides();
    function showrimatoursserach() {

        $('.divRow1TourguidePageStyleRow3').empty();
        $('#pagination-container').empty();
        selectedTourguides = "";
        selectedTourguides = SelectedTourguidesSearch;
        for (var i = 0; i < selectedTourguides.length; i++) {
            var PriceFinal = selectedTourguides[i].Price - (Math.floor(selectedTourguides[i].Price * selectedTourguides[i].Discount / 100));
            $('<div  onclick="ShowDetailsClickRimatours(' + i + ');" id="divDynamicAllDivRimatours' + i + '"style="padding:0;" class="NumberIChande divInRow1TheRow2TourguidePageStyle row list-item"></div>').appendTo('.divRow1TourguidePageStyleRow3');
            $('<div id="divDynamicCol1Rimatours' + i + '"style="padding:0;min-height:12em;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<div id="divDynamicCol2Rimatours' + i + '"style="padding:0;min-height:13em;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<div id="divDynamicCol3Rimatours' + i + '"style="padding:0;min-height:13em;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<div id="divDynamicCol4Rimatours' + i + '"style="padding:0;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<div id="divDynamicCol5Rimatours' + i + '"style="padding:0;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<div id="divDynamicCol6Rimatours' + i + '"style="padding:0;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
            ///Col1 Img
            $('<img src="/Resources/Imges/' + selectedTourguides[i].MainImage + '" class="ImgDynamicBigImgTourguidestyle" />').appendTo('#divDynamicCol1Rimatours' + i);
            /////col2
            $('<p class="TitrDynamicRimatours">Code: </p>').appendTo('#divDynamicCol2Rimatours' + i);
            $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].id + '</p>').appendTo('#divDynamicCol2Rimatours' + i);
            //////col3
            $('<p class="TitrDynamicRimatours">Name: </p>').appendTo('#divDynamicCol3Rimatours' + i);
            $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].FirstName + " " + selectedTourguides[i].LastName + '</p>').appendTo('#divDynamicCol3Rimatours' + i);
            //////col4
            $('<p class="TitrDynamicRimatours">Tour Detail: </p>').appendTo('#divDynamicCol4Rimatours' + i);
            $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Description + '</p>').appendTo('#divDynamicCol4Rimatours' + i);
            //////col5
            $('<p class="TitrDynamicRimatours">Price €: </p>').appendTo('#divDynamicCol5Rimatours' + i);
            if (selectedTourguides[i].Discount == 0) {
                $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Price + '</p>').appendTo('#divDynamicCol5Rimatours' + i);
            }
            else {
                $('<p class="ZirTitrDynamicRimatours"><span style="text-decoration:line-through;text-decoration-color: red">' + selectedTourguides[i].Price + '</span>' + PriceFinal + '</p>').appendTo('#divDynamicCol5Rimatours' + i);
            }
            //////col5
            $('<p class="TitrDynamicRimatours">Discount: </p>').appendTo('#divDynamicCol5Rimatours' + i);
            $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Discount + '%</p>').appendTo('#divDynamicCol5Rimatours' + i);
            //////col6
            $('<p class="TitrDynamicRimatours">Rate: </p>').appendTo('#divDynamicCol6Rimatours' + i);
            $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Rate + '</p>').appendTo('#divDynamicCol6Rimatours' + i);

            //////col6
            $('<p class="TitrDynamicRimatours">City: </p>').appendTo('#divDynamicCol6Rimatours' + i);
            $('<p class="ZirTitrDynamicRimatours">' + SelectCityById(selectedTourguides[i].CityId).Name + '</p>').appendTo('#divDynamicCol6Rimatours' + i);
            ////All Input
            $('<input type="hidden" name="Code" value="' + selectedTourguides[i].id + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<input type="hidden" name="NumberIChande" value="' + i + '" class=""/>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<input type="hidden" name="Name" value="' + selectedTourguides[i].FirstName + " " + selectedTourguides[i].LastName + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<input type="hidden" name="TourDetail" value="' + selectedTourguides[i].Description + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<input type="hidden" name="Price" value="' + selectedTourguides[i].Price + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<input type="hidden" name="Rate" value="' + selectedTourguides[i].Rate + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<input type="hidden" name="City" value="' + SelectCityById(selectedTourguides[i].CityId).Name + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
            $('<input type="hidden" name="Discount" value="' + selectedTourguides[i].Discount + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);

        }
        ReloadPaging();

        return false;
    }

    for (var i = 0; i < selectedTourguides.length; i++) {

        var PriceFinal = selectedTourguides[i].Price - (Math.floor(selectedTourguides[i].Price * selectedTourguides[i].Discount / 100));
        $('<div  onclick="ShowDetailsClickRimatours(' + i + ');"  id="divDynamicAllDivRimatours' + i + '"style="padding:0;" class="NumberIChande divInRow1TheRow2TourguidePageStyle row list-item"></div>').appendTo('.divRow1TourguidePageStyleRow3');
        $('<div id="divDynamicCol1Rimatours' + i + '"style="padding:0;min-height:12em;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<div id="divDynamicCol2Rimatours' + i + '"style="padding:0;min-height:13em;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<div id="divDynamicCol3Rimatours' + i + '"style="padding:0;min-height:13em;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<div id="divDynamicCol4Rimatours' + i + '"style="padding:0;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<div id="divDynamicCol5Rimatours' + i + '"style="padding:0;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<div id="divDynamicCol6Rimatours' + i + '"style="padding:0;" class="col-lg-2 col-md-2 col-sm-4 col-xs-4"></div>').appendTo('#divDynamicAllDivRimatours' + i);
        ///Col1 Img
        $('<img src="/Resources/Imges/' + selectedTourguides[i].MainImage + '" class="ImgDynamicBigImgTourguidestyle" />').appendTo('#divDynamicCol1Rimatours' + i);
        /////col2
        $('<p class="TitrDynamicRimatours">Code: </p>').appendTo('#divDynamicCol2Rimatours' + i);
        $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].id + '</p>').appendTo('#divDynamicCol2Rimatours' + i);
        //////col3
        $('<p class="TitrDynamicRimatours">Name: </p>').appendTo('#divDynamicCol3Rimatours' + i);
        $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].FirstName + " " + selectedTourguides[i].LastName + '</p>').appendTo('#divDynamicCol3Rimatours' + i);
        //////col4
        $('<p class="TitrDynamicRimatours">Tour Detail: </p>').appendTo('#divDynamicCol4Rimatours' + i);
        $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Description + '</p>').appendTo('#divDynamicCol4Rimatours' + i);
        //////col5
        $('<p class="TitrDynamicRimatours">Price €: </p>').appendTo('#divDynamicCol5Rimatours' + i);
        if (selectedTourguides[i].Discount == 0) {
            $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Price + '</p>').appendTo('#divDynamicCol5Rimatours' + i);
        }
        else {
            $('<p class="ZirTitrDynamicRimatours"><span style="text-decoration:line-through;text-decoration-color: red">' + selectedTourguides[i].Price + '</span>' + PriceFinal + '</p>').appendTo('#divDynamicCol5Rimatours' + i);
        }
        //////col5
        $('<p class="TitrDynamicRimatours">Discount: </p>').appendTo('#divDynamicCol5Rimatours' + i);
        $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Discount + '%</p>').appendTo('#divDynamicCol5Rimatours' + i);
        //////col6
        $('<p class="TitrDynamicRimatours">Rate: </p>').appendTo('#divDynamicCol6Rimatours' + i);
        $('<p class="ZirTitrDynamicRimatours">' + selectedTourguides[i].Rate + '</p>').appendTo('#divDynamicCol6Rimatours' + i);
        //////col6
        $('<p class="TitrDynamicRimatours">City: </p>').appendTo('#divDynamicCol6Rimatours' + i);
        $('<p class="ZirTitrDynamicRimatours">' + SelectCityById(selectedTourguides[i].CityId).Name + '</p>').appendTo('#divDynamicCol6Rimatours' + i);
        ////All Input
        $('<input type="hidden" name="Code" value="' + selectedTourguides[i].id + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<input type="hidden" name="NumberIChande" value="' + i + '" class=""/>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<input type="hidden" name="Name" value="' + selectedTourguides[i].FirstName + " " + selectedTourguides[i].LastName + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<input type="hidden" name="TourDetail" value="' + selectedTourguides[i].Description + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<input type="hidden" name="Price" value="' + selectedTourguides[i].Price + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<input type="hidden" name="Rate" value="' + selectedTourguides[i].Rate + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<input type="hidden" name="City" value="' + SelectCityById(selectedTourguides[i].CityId).Name + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
        $('<input type="hidden" name="Discount" value="' + selectedTourguides[i].Discount + '" class="ss"/>').appendTo('#divDynamicAllDivRimatours' + i);
    }

    let CodeRimatours;
    let NameRimatours;
    let TourDetailRimatours;
    let PriceRimatours;
    let RateRimatours;
    let CityRimatours;
    let DiscountRimatours;
    let ImgRimatours;
    $('<div id="ShowDetailsClickRimatours"style="padding:0;" class="ShowDetailsClickRimatours DivRemoveImg row"></div>').appendTo('.ShowDynamicDatalisRimatours');

    $('<a class="remImage"><i class="fa fa-close"></i></a>').appendTo('#ShowDetailsClickRimatours');
    // $('<input type="hidden" name="name" value="' + data[i].Name + '" />').appendTo('#divInRow1TheRow2DestinationsPageDivRow1Col2Zoj' + i);
    $('.NumberIChande').click(function () {
        var i = $(this).children("input[name='NumberIChande']").val();
        $('#BtnSearchRimatours').prop('disabled', true);
        // $('.divInRow1TheRow2TourguidePageStyle').click(function () {
        $('.divInRow1TheRow2TourguidePageStyle').hide();
        $('#pagination-container').hide();
        $('.ShowDetailsClickRimatours').show();
        CodeRimatours = $('#divDynamicAllDivRimatours' + i).children("input[name='Code']").val();
        NameRimatours = $('#divDynamicAllDivRimatours' + i).children("input[name='Name']").val();
        TourDetailRimatours = $('#divDynamicAllDivRimatours' + i).children("input[name='TourDetail']").val();
        PriceRimatours = $('#divDynamicAllDivRimatours' + i).children("input[name='Price']").val();
        RateRimatours = $('#divDynamicAllDivRimatours' + i).children("input[name='Rate']").val();
        CityRimatours = $('#divDynamicAllDivRimatours' + i).children("input[name='City']").val();
        DiscountRimatours = $('#divDynamicAllDivRimatours' + i).children("input[name='Discount']").val();
        ImgRimatours = $('#divDynamicAllDivRimatours' + i).children("div").children("img").attr('src');
        var PriceFinal = PriceRimatours - (Math.floor(PriceRimatours * DiscountRimatours / 100));

        ///////ClickAndShow This
        $('<div id="InShowDetailsClickRimatours"style="padding:0;" class="row InShowDetailsClickRimatours"></div>').appendTo('.ShowDetailsClickRimatours');
        $('<div id="ShowDetailsCol1Rimatours"style="margin:0;padding:0;" class="col-lg-6 col-md-6 col-sm-12 col-xs-12"></div>').appendTo('#InShowDetailsClickRimatours');
        $('<div id="ShowDetailsCol2Rimatours" class="col-lg-6 col-md-6 col-sm-12 col-xs-12"></div>').appendTo('#InShowDetailsClickRimatours');

        ///Samte chap Row1
        $('<div id="ShowrowDetailsCol1DivCol1Rimatours"style="margin:0;padding:0;" class="row"></div>').appendTo('#ShowDetailsCol1Rimatours');
        ///Samte chap Row1 Col1
        $('<div id="ShowDetailsCol1DivCol1Rimatours"style="margin:0;padding:0;" class="col-lg-6 col-md-6 col-sm-6 col-xs-6"></div>').appendTo('#ShowrowDetailsCol1DivCol1Rimatours');
        ///Samte chap Row1 Col2
        $('<div id="ShowDetailsCol1DivCol2Rimatours"style="margin:0;padding:0;" class="col-lg-6 col-md-6 col-sm-6 col-xs-6"></div>').appendTo('#ShowrowDetailsCol1DivCol1Rimatours');
        ///Samte chap Row1 Col1 img
        $('<img src="' + ImgRimatours + '" class="ImgShowDetailsCol2Rimatours" />').appendTo('#ShowDetailsCol1DivCol1Rimatours');
        ///Samte chap Row1 Col2 Text
        $('<p class="TitrDynamicRimatours">Code: </p>').appendTo('#ShowDetailsCol1DivCol2Rimatours');
        $('<p class="ZirTitrDynamicRimatours">' + CodeRimatours + '</p>').appendTo('#ShowDetailsCol1DivCol2Rimatours');
        $('<p class="TitrDynamicRimatours">Name: </p>').appendTo('#ShowDetailsCol1DivCol2Rimatours');
        $('<p class="ZirTitrDynamicRimatours">' + NameRimatours + '</p>').appendTo('#ShowDetailsCol1DivCol2Rimatours')
        $('<p class="TitrDynamicRimatours">Discount: </p>').appendTo('#ShowDetailsCol1DivCol2Rimatours');
        $('<p class="ZirTitrDynamicRimatours">' + DiscountRimatours + '%</p>').appendTo('#ShowDetailsCol1DivCol2Rimatours');
        ///Samte chap Row2
        $('<div id="Showrow2DetailsCol1DivCol1Rimatours"style="margin:0;padding:0;" class="row"></div>').appendTo('#ShowDetailsCol1Rimatours');
        ///Samte chap Row2 Text

        $('<p class="TitrDynamicRimatours">Price €: </p>').appendTo('#Showrow2DetailsCol1DivCol1Rimatours');
        if (PriceFinal == 0) {
            $('<p class="ZirTitrDynamicRimatours">' + PriceRimatours + '</p>').appendTo('#Showrow2DetailsCol1DivCol1Rimatours');
        }
        else {
            $('<p class="ZirTitrDynamicRimatours"><span style="text-decoration:line-through;text-decoration-color: red">' + PriceRimatours + '</span>' + PriceFinal + '</p>').appendTo('#Showrow2DetailsCol1DivCol1Rimatours');
        }
        $('<p class="TitrDynamicRimatours">Rate: </p>').appendTo('#Showrow2DetailsCol1DivCol1Rimatours');
        $('<p class="ZirTitrDynamicRimatours">' + RateRimatours + '</p>').appendTo('#Showrow2DetailsCol1DivCol1Rimatours');
        $('<p class="TitrDynamicRimatours">City: </p>').appendTo('#Showrow2DetailsCol1DivCol1Rimatours');
        $('<p class="ZirTitrDynamicRimatours">' + CityRimatours + '</p>').appendTo('#Showrow2DetailsCol1DivCol1Rimatours');
        ///Samte Rast Row1
        $('<p class="TitrDynamicRimatours">Tour Details: </p>').appendTo('#ShowDetailsCol2Rimatours');
        $('<p class="ZirTitrDynamicRimatours">' + TourDetailRimatours + '</p>').appendTo('#ShowDetailsCol2Rimatours');

    })

    $('.remImage').click(function () {
        location.reload();
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
    function ReloadPaging() {
        var items2 = $(".list-wrapper .list-item");
        var numItems2 = items2.length;
        var perPage2 = 2;
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
    };



})