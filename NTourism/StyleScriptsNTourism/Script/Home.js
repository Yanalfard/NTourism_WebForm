$(document).ready(function () {


    var buttonsData = SelectAllFirstPages();
    if (buttonsData[0].Sign == 1) {
        //DynamicHomeImageAndText1
        var ImageHome1 = buttonsData[0].Image;
        var LinkImageHome1 = buttonsData[0].Text;
        $("<div><a class='TagAImageHome1 hoverImg' href=" + LinkImageHome1 + " target='_blank' title='" + LinkImageHome1 + "'><img class='ImageHome1' src='/Resources/Imges/" + ImageHome1 + "' alt='" + LinkImageHome1 + "' title='" + LinkImageHome1 + "' /></a></div>").appendTo('#DynamicHomeImageAndText1');
    }
    if (buttonsData[1].Sign == 2) {
        //DynamicHomeImageAndText2
        var ImageHome2 = buttonsData[1].Image;
        var LinkImageHome2 = buttonsData[1].Text;
        $("<div><a class='TagAImageHome2 hoverImg' href=" + LinkImageHome2 + " target='_blank' title='" + LinkImageHome2 + "'><img class='ImageHome2' src='/Resources/Imges/" + ImageHome2 + "' alt='" + LinkImageHome2 + "' title='" + LinkImageHome2 + "' /></a></div>").appendTo('#DynamicHomeImageAndText2');
    }
    if (buttonsData[3].Sign == 4) {
        //DynamicHomeImageAndText4
        var ImageHome4 = buttonsData[3].Image;
        var LinkImageHome4 = buttonsData[3].Text;
        $("<div><a class='TagAImageHome4 hoverImg' href=" + LinkImageHome4 + " target='_blank' title='" + LinkImageHome4 + "'><img class='ImageHome4' src='/Resources/Imges/" + ImageHome4 + "' alt='" + LinkImageHome4 + "' title='" + LinkImageHome4 + "'/></a></div>").appendTo('#DynamicHomeImageAndText4');
    }
    if (buttonsData[4].Sign == 5) {
        //DynamicHomeImageAndText5
        var ImageHome5 = buttonsData[4].Image;
        var LinkImageHome5 = buttonsData[4].Text; title='" + LinkImageHome1 + "'
        $("<div><a class='TagAImageHome5 hoverImg' href=" + LinkImageHome5 + " target='_blank' title='" + LinkImageHome5 + "'><img class='ImageHome5' src='/Resources/Imges/" + ImageHome5 + "' alt='" + LinkImageHome5 + "' title='" + LinkImageHome5 + "'/></a></div>").appendTo('#DynamicHomeImageAndText5');
    }
    if (buttonsData[5].Sign == 6) {
        //DynamicHomeImageAndText6
        var ImageHome6 = buttonsData[5].Image;
        var LinkImageHome6 = buttonsData[5].Text;
        $("<div><a class='TagAImageHome6 hoverImg' href=" + LinkImageHome6 + " target='_blank' title='" + LinkImageHome6 + "'><img class='ImageHome6' src='/Resources/Imges/" + ImageHome6 + "' alt='" + LinkImageHome6 + "' title='" + LinkImageHome6 + "'/></a></div>").appendTo('#DynamicHomeImageAndText6');
    }
    if (buttonsData[6].Sign == 7) {
        //DynamicHomeImageAndText7
        var ImageHome7 = buttonsData[6].Image;
        var LinkImageHome7 = buttonsData[6].Text;
        $("<div><a class='TagAImageHome6 hoverImg' href=" + LinkImageHome7 + " target='_blank' title='" + LinkImageHome7 + "'><img class='ImageHome6' src='/Resources/Imges/" + ImageHome7 + "'  alt='" + LinkImageHome7 + "' title='" + LinkImageHome7 + "'/></a></div>").appendTo('#DynamicHomeImageAndText7');
    }
    if (buttonsData[7].Sign == 8) {
        //DynamicHomeImageAndText8
        var ImageHome8 = buttonsData[7].Image;
        var LinkImageHome8 = buttonsData[7].Text;
        $("<div><a class='TagAImageHome8 hoverImg' href=" + LinkImageHome8 + " target='_blank' title='" +
            LinkImageHome8 + "'><img class='ImageHome8' src='/Resources/Imges/" + ImageHome8 + "'  alt='" + LinkImageHome8 + "'  title='" + LinkImageHome8 + "'/></a></div>").appendTo('#DynamicHomeImageAndText8');
    }
    if (buttonsData[8].Sign == 9) {
        //DynamicHomeImageAndText9
        var ImageHome9 = buttonsData[8].Image;
        var LinkImageHome9 = buttonsData[8].Text;
        $("<div><a class='TagAImageHome9 hoverImg' href=" + LinkImageHome9 + " target='_blank' title='" + LinkImageHome9 + "'><img class='ImageHome9' src='/Resources/Imges/" + ImageHome9 + "'alt='" + LinkImageHome9 + "' title='" + LinkImageHome8 + "'/></a></div>").appendTo('#DynamicHomeImageAndText9');
    }
    if (buttonsData[8].Sign == 9) {
        //DynamicHomeImageAndText10
        var ImageHome10 = buttonsData[9].Image;
        var LinkImageHome10 = buttonsData[9].Text;
        $("<div><a class='TagAImageHome9 hoverImg' href=" + LinkImageHome10 + " target='_blank' title='" + LinkImageHome10 + "'><img class='ImageHome9' src='/Resources/Imges/" + ImageHome10 + "' alt='" + LinkImageHome9 + "' title='" + LinkImageHome9 + "'/></a></div>").appendTo('#DynamicHomeImageAndText10');
    }



   ///////////////////Services
    var rimatripservices = SelectAll4Services();
    $('#TitrServices1').text(rimatripservices[0].Title);
    $('#TitrServices2').text(rimatripservices[1].Title);
    $('#TitrServices3').text(rimatripservices[2].Title);
    $('#TitrServices4').text(rimatripservices[3].Title);


    $('.ShowComplateServices').click(function () {
        var Team2ShowCol3 = $(this).children("input[type='hidden']").val();
        var ServicesId = Team2ShowCol3;
        window.open(
            "/View/En/Services/Services.aspx?ServicesId=" + ServicesId
        );
    });






});