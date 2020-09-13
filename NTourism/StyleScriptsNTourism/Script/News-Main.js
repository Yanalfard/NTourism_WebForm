$(document).ready(function () {

    let NewsName;
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
        if (queryString["NewsName"] != null) {

            NewsName = queryString["NewsName"];
            $('<div id="DivAslyNewsMainDynamic"></div>').appendTo('#NewsMainPageDiv');
            var data = SelectNewsByName(NewsName);
            if (data != null) {
                $('<p class="TagPnameNewsTitrStyle text-center" >' + NewsName + '</p>').appendTo('#DivAslyNewsMainDynamic');

                var dataInfo = SelectTextById(data[0].TextId);

                $('<p>' + dataInfo.Text + '</p>').appendTo('#DivAslyNewsMainDynamic');

            }
            else if (data == null) {

            }
        }
        else {
            window.location.href = "/Index.aspx";
        }
    });
});