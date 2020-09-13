$(document).ready(function () {


    //Home
    setTimeout(function () {
        $('#Img2SliderPageHome').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-40.5%' })
    }, 500);

    setTimeout(function () {
        $('#Img3SliderPageHome').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-46%' })
    }, 1000);
    setTimeout(function () {
        // $('#Img4SliderPageHome').css({ 'opacity': '1', 'transition': '1s'})
        $('#Img4SliderPageHome').animate({ opacity: '1' }, 1000, Img4SliderPageHomeFunction);
    }, 1000);

    function Img4SliderPageHomeFunction() {

        $('#Img4SliderPageHome').css({ 'margin-top': '10%', 'transition': '3s' })

    }

    //AboutUs
    setTimeout(function () {
        $('#Img2SliderPageAboutUs').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-59%' })
    }, 500)

    setTimeout(function () {
        $('#Img3SliderPageAboutUs').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-38%' })
    }, 1500)
    setTimeout(function () {
        $('#Img4SliderPageAboutUs').css({ 'opacity': '1', 'transition': '1s' })
    }, 2500)
    setTimeout(function () {
        $('#Img5SliderPageAboutUs').css({ 'opacity': '1', 'transition': '1s' })
    }, 2500)
    setTimeout(function () {
        $('#Img6SliderPageAboutUs').css({ 'opacity': '1', 'transition': '1s' })
    }, 3500)
    setTimeout(function () {
        $('#Img7SliderPageAboutUs').css({ 'opacity': '1', 'transition': '1s' })
    }, 4000)



    //Destinations
    setTimeout(function () {
        $('#Img2SliderPageDestinations').css({ 'opacity': '1', 'transition': '1s' })
    }, 500)
    setTimeout(function () {
        $('#Img3SliderPageDestinations').css({ 'opacity': '1', 'transition': '1s' })
    }, 1500)
    setTimeout(function () {
        $('#Img4SliderPageDestinations').css({ 'opacity': '1', 'transition': '1s' })
    }, 2000)


    //ContactUs
    setTimeout(function () {
        $('#Img2SliderPageContactUs').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-60%' })
    }, 500)

    setTimeout(function () {
        $('#Img3SliderPageContactUs').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-48%' })
    }, 1500)
    setTimeout(function () {
        $('#Img4SliderPageContactUs').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '0%' })
    }, 2000)
    setTimeout(function () {
        $('#Img5SliderPageContactUs').css({ 'opacity': '1', 'transition': '1s', 'z-index': '-1' })
    }, 2500)
    setTimeout(function () {
        $('#Img6SliderPageContactUs').css({ 'opacity': '1', 'transition': '1s', 'z-index': '-5' })
    }, 3000)
    setTimeout(function () {
        $('#Img7SliderPageContactUs').css({ 'opacity': '1', 'transition': '1s', 'z-index': '-5' })
    }, 3500)
    setTimeout(function () {
        $('#Img8SliderPageContactUs').css({ 'opacity': '1', 'transition': '1s', 'z-index': '-5' })
    }, 4000)




    //OurServices
    setTimeout(function () {
        $('#Img3SliderPageOurServices').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-34%' })
    }, 500)

    setTimeout(function () {
        $('#Img5SliderPageOurServices').css({ 'opacity': '1', 'transition': '1s' })
    }, 1500)
    setTimeout(function () {
        $('#Img6SliderPageOurServices').css({ 'opacity': '1', 'transition': '1s', 'transform': 'rotateZ(360deg)' })
    }, 2000)


    //News
    setTimeout(function () {
        $('#Img2SliderPageNews').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-22%' })
    }, 500)

    setTimeout(function () {
        $('#Img3SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 1500)
    setTimeout(function () {
        $('#Img4SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 2000)
    setTimeout(function () {
        $('#Img5SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 2500)
    setTimeout(function () {
        $('#Img6SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 3000)
    setTimeout(function () {
        $('#Img7SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 3500)
    setTimeout(function () {
        $('#Img8SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 4000)
    setTimeout(function () {
        $('#Img9SliderPageNews').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-33%' })
    }, 4500)
    setTimeout(function () {
        $('#Img10SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 5000)
    setTimeout(function () {
        $('#Img11SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 5500)
    setTimeout(function () {
        $('#Img12SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 6000)
    setTimeout(function () {
        $('#Img13SliderPageNews').css({ 'opacity': '1', 'transition': '1s' })
    }, 6500)



    //Tourguide
    setTimeout(function () {
        $('#Img2SliderPageTourguide').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-12%' })
    }, 1000)

    setTimeout(function () {
        $('#Img3SliderPageTourguide').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-35%' })
    }, 1500)
    setTimeout(function () {
        $('#Img4SliderPageTourguide').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-25%' })
    }, 2000)




})


$(document).ready(function () {
    $(window).resize(function () {
        if (window.matchMedia('(min-width: 900px)').matches) {

            $('#MenuHeaderLeftLg').removeClass('MenuHeaderLeftLgStyle123')
            $('#MenuHeaderLeftLg').addClass('MenuHeaderLeftLgStyle')
        }
        else {


        }
    });

    $('#Button12').click(function () {
        $('#MenuHeaderLeftLg').removeClass('MenuHeaderLeftLgStyle')
        $('#MenuHeaderLeftLg').addClass('MenuHeaderLeftLgStyle123')
    });
    $('#MainColRightLg').click(function () {
        $('#MenuHeaderLeftLg').removeClass('MenuHeaderLeftLgStyle123')
        $('#MenuHeaderLeftLg').addClass('MenuHeaderLeftLgStyle')
    });

})


function searchToggle(obj, evt) {
    var container = $(obj).closest('.search-wrapper');

    if (!container.hasClass('active')) {
        container.addClass('active');
        evt.preventDefault();
    }
    else if (container.hasClass('active') && $(obj).closest('.input-holder').length == 0) {
        container.removeClass('active');
        container.find('.search-input').val('');
        container.find('.result-container').fadeOut(100, function () { $(this).empty(); });
    }
}

function openSearch() {
    document.getElementById("MySearchMenu").style.display = "block";
}

function closeSearch() {
    document.getElementById("MySearchMenu").style.display = "none";
}


$(document).ready(function () {

    //Event
    setTimeout(function () {
        $('#Img2SliderPageEvent').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-42%' })
    }, 500)

    setTimeout(function () {
        $('#Img3SliderPageEvent').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-44.5%' })
    }, 1500)
    setTimeout(function () {
        $('#Img4SliderPageEvent').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '31%' })
    }, 2000)
    setTimeout(function () {
        $('#Img5SliderPageEvent').css({ 'opacity': '1', 'transition': '1s', 'margin-top': '-27%' })
    }, 3000)

})


$(document).ready(function () {

    //Gallery
    setTimeout(function () {
        $('#Img2SliderPageGallery').css({ 'opacity': '1', 'transition': '1s', 'margin-left': '-25%' })
    }, 500)



})




$(document).ready(function () {
    $('.BtnBookingHomeStyle').click(function () {
        window.location.href = "/View/En/SingIn/SingIn.aspx"
    });


    $('input[type="button"][value="BOOKING"]').click(function () {
        window.location.href = "/View/En/SingIn/SingIn.aspx";
    })
})


////News Ajax
$(document).ready(function () {
    $.ajax({
        url: '/api/NewsCore/SelectTopRandomNews?count=20',
        method: 'Post',
        contenttype: 'application/json',
        datatype: 'json',
        success: function (data) {
            data.reverse();
            if (data != null) {
                for (var i = 0; i < data.length; i++) {
                    var LinkAllNewsIndex = $('<a />', {
                        text: data[i].Title,
                        alt: data[i].Title,
                        title: data[i].Title,
                        class: 'LinkAllNewsIndex'
                    });
                    $('<div id="DynamicLinkAllNewsIndex1' + i + '" class="DivLinkAllNewsIndex "  onclick="ClickNews(' + i + ');"></div>').appendTo('#DivaslyDynamicLinkAllNewsIndex');
                    $('<input type="hidden" name="name" id="HiddenNews' + i + '" value="' + data[i].Name + '" />').appendTo('#DynamicLinkAllNewsIndex1' + i);
                    $(LinkAllNewsIndex).appendTo('#DynamicLinkAllNewsIndex1' + i);
                }
            }
            else {

            }
        },
        error: function () {


        }

    });
});
function ClickNews(data1) {
    var Team2ShowCol3 = $('#HiddenNews' + data1).val();
    var NewsName = Team2ShowCol3;
    window.open(
        "/View/En/News/News-Main.aspx?NewsName=" + NewsName
    );
}



function GoDashboard() {

    function setCookie(cname, cvalue, exdays) {
        var d = new Date();
        d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
        var expires = "expires=" + d.toUTCString();
        document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
    }

    function getCookie(cname) {
        var name = cname + "=";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    }
    var user = getCookie("CodeProConnect");
    if (user != "") {
        if (user == 3) {
            window.location.href = "/View/En/Profile/ProfileTourist.aspx";
        }
        else if (user == 2) {
            window.location.href = "/View/En/Profile/ProfileRimatours.aspx";

        }
        else if (user == 1) {
            window.location.href = "/View/En/Profile/ProfileOurServices.aspx";
        }
    } else {

    }


};

$(document).ready(function () {

    if (localStorage.getItem("UserName") != null) {
        $('#DivBtnMenuHeaderLeftLg').removeClass('ShowSingout');
        $('#DivBtnMenuHeaderLeftLg').addClass('HideSingout');
        $('#DivBtnSingout').removeClass('HideSingout');
        $('#DivBtnSingout').addClass('ShowSingout');
    }
    $('#BtnSingout').click(function () {
        window.localStorage.removeItem("UserName");
        document.location.reload(true);
        document.cookie = "CodeProConnect=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
        $('#DivBtnMenuHeaderLeftLg').removeClass('HideSingout');
        $('#DivBtnSingout').removeClass('ShowSingout');
        $('#DivBtnSingout').addClass('HideSingout');
        window.location.href = "/View/En/SingIn/SingIn.aspx";
    })
 
})


$(document).ready(function () {

    var ad1p1 = SelectAdById(Number1Ads);
    var ad1p2 = SelectAdById(Number2Ads);
    var ad1p3 = SelectAdById(Number3Ads);
    var ad1p4 = SelectAdById(Number4Ads);
    var ad1p5 = SelectAdById(Number5Ads);

    if (ad1p1 != null) {
        if (ad1p1.IsAvailable == true) {
            var Img1AdsIndex = $('<img />', {
                src: "/Resources/Imges/" + ad1p1.Image,
                alt: ad1p1.Link,
                title: ad1p1.Link,
                class: 'Img1AdsIndexstyle'
            });
            $('<a target="_blank" href="' + ad1p1.Link + '"  id="DynamicLinkAdsIndex1" class="DivImg1AdsIndexstyle"></a>').appendTo('#DynamicAdsImg1');
            $('<span  class="DivImg1AdsIndexstyle" id="DynamicLinkAdsIndex11"></span>').appendTo('#DynamicLinkAdsIndex1');
            $(Img1AdsIndex).appendTo('#DynamicLinkAdsIndex11');
        }


    }



    //
    if (ad1p3 != null) {
        if (ad1p3.IsAvailable == true) {
            var Img3AdsIndex = $('<img />', {

                src: "/Resources/Imges/" + ad1p3.Image,
                alt: ad1p3.Link,
                title: ad1p3.Link,
                class: 'Img3AdsIndexstyle'
            });
            $('<a target="_blank" href="' + ad1p3.Link + '"  id="DynamicLinkAdsIndex3" class="DivImg3AdsIndexstyle"></a>').appendTo('#DynamicAdsImg3');
            $('<div  style="margin-top:1em;"  class="DivImg3AdsIndexstyle" id="DynamicLinkAdsIndex33"></div>').appendTo('#DynamicLinkAdsIndex3');
            $(Img3AdsIndex).appendTo('#DynamicLinkAdsIndex33');
        }
    }
    ////
    if (ad1p4 != null) {
        if (ad1p4.IsAvailable == true) {
            var Img4AdsIndex = $('<img />', {
                src: "/Resources/Imges/" + ad1p4.Image,
                alt: ad1p4.Link,
                title: ad1p4.Link,
                class: 'Img3AdsIndexstyle'
            });
            $('<a target="_blank"  href="' + ad1p4.Link + '" id="DynamicLinkAdsIndex4" class="DivImg3AdsIndexstyle"></a>').appendTo('#DynamicAdsImg4');
            $('<div  style="margin-top:1em;"  class="DivImg3AdsIndexstyle" id="DynamicLinkAdsIndex44"></div>').appendTo('#DynamicLinkAdsIndex4');
            $(Img4AdsIndex).appendTo('#DynamicLinkAdsIndex44');
        }


    }
    ////
    if (ad1p5 != null) {
        if (ad1p5.IsAvailable == true) {
            var Img5AdsIndex = $('<img />', {
                src: "/Resources/Imges/" + ad1p5.Image,
                alt: ad1p5.Link,
                title: ad1p5.Link,
                class: 'Img5AdsIndexstyle'
            });
            $('<a target="_blank"  href="' + ad1p5.Link + '"  id="DynamicLinkAdsIndex5" class="DivImg5AdsIndexstyle"></a>').appendTo('.divAdd5upinfooter');
            $('<span  class="DivImg5AdsIndexstyle" id="DynamicLinkAdsIndex55"></span>').appendTo('#DynamicLinkAdsIndex5');
            $(Img5AdsIndex).appendTo('#DynamicLinkAdsIndex55');
        }


    }








});

window.onscroll = function () { scrollFunction() };
function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.getElementById("myBtn").style.display = "block";
    } else {
        document.getElementById("myBtn").style.display = "none";
    }
}
$(document).ready(function () {
    $('#myBtn').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 'slow');
        return false;
    });
});