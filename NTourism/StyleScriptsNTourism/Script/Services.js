$(document).ready(function () {
    let ServicesId;
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
        if (queryString["ServicesId"] != null) {
            ServicesId = queryString["ServicesId"];
            $('<div id="DivAslyNewsMainDynamic"></div>').appendTo('#ShowTextAndImageServices');
            var rimatripservices = SelectAll4Services();
            if (rimatripservices != null) {
                for (var i = 0; i < rimatripservices.length; i++) {
                    if (ServicesId == 1) {

                        $('<a href="/View/En/Ticket/Ticket-En.aspx">' +
                            '<img src = "/Resources/En/Home/Servises/Servises2.png" class="ImgServisesIndexStyle" alt="' + rimatripservices[0].Title + '" title="' + rimatripservices[0].Title + '" />' +
                            ' <p class="TitrServicesStyle text-center">' + rimatripservices[0].Title + '</p>' +
                            ' <p class="ZirTitrServicesStyle">' + rimatripservices[0].Text + '</p></a >').appendTo('.ShowTextAndImageServices');
                    }
                    else if (ServicesId == 3) {
                        $('<a href="/View/En/Ticket/Ticket-En.aspx">' +
                            '<img src = "/Resources/En/Home/Servises/Servises1.png" class="ImgServisesIndexStyle"alt="' + rimatripservices[1].Title + '" title="' + rimatripservices[1].Title + '" />' +
                            ' <p class="TitrServicesStyle text-center">' + rimatripservices[1].Title + '</p>' +
                            ' <p class="ZirTitrServicesStyle">' + rimatripservices[1].Text + '</p></a >').appendTo('.ShowTextAndImageServices');
                    }
                    else if (ServicesId == 4) {
                        $('<a href="/View/En/RimaTrip/Index.aspx">' +
                            '<img src = "/Resources/En/Home/Servises/Servises4.png" class="ImgServisesIndexStyle"alt="' + rimatripservices[2].Title + '" title="' + rimatripservices[2].Title + '" />' +
                            ' <p class="TitrServicesStyle text-center">' + rimatripservices[2].Title + '</p>' +
                            ' <p class="ZirTitrServicesStyle">' + rimatripservices[2].Text + '</p></a >').appendTo('.ShowTextAndImageServices');
                    }
                    else if (ServicesId == 5) {
                        $('<a href="/View/En/Ticket/Ticket-En.aspx">' +
                            '<img src = "/Resources/En/Home/Servises/Servises3.png" class="ImgServisesIndexStyle"alt="' + rimatripservices[3].Title + '" title="' + rimatripservices[3].Title + '" />' +
                            ' <p class="TitrServicesStyle text-center">' + rimatripservices[3].Title + '</p>' +
                            ' <p class="ZirTitrServicesStyle">' + rimatripservices[3].Text + '</p></a >').appendTo('.ShowTextAndImageServices');
                    }
                    break;
                }

            }
            else if (data == null) {
            }
        }
        else {
            window.location.href = "/Index.aspx";
        }
    });
});