$(document).ready(function () {


    let DestinationsName;
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
        if (queryString["DestinationsName"] != null) {
            DestinationsName = queryString["DestinationsName"];
            $('<div id="DivAslyNewsMainDynamic"></div>').appendTo('.ShowCitySeletOne');
            var dataCity = SelectAttractionById(DestinationsName);
            if (dataCity != null) {
                if (dataCity.Name != null) {
                    $('<h1 class="text-center">' + dataCity.Name + '</h1>').appendTo('#DivAslyNewsMainDynamic');
                }
                if (dataCity.ImageId != null) {
                    var selectImageById = SelectImagesById(dataCity.ImageId)
                    $('<div  class="row"><img src="/Resources/Imges/' + selectImageById.Image + '" alt="' + dataCity.Name + '" title="' + dataCity.Name + '" class="ImageShowCituTittr"/></div>').appendTo('#DivAslyNewsMainDynamic');
                }
                if (dataCity.TextId != null) {
                    var selectTextById = SelectTextById(dataCity.TextId)
                    $('<div class="FontCitySelect">' + selectTextById.Text + '</div>').appendTo('#DivAslyNewsMainDynamic');
                }



            }
            else if (data == null) {
                window.location.href = "/Index.aspx";
            }
        }


    });

});