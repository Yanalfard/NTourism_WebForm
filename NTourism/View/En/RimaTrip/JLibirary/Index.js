//function SliderShow() {

//    var slider1 = document.getElementById('slider1');
//    var slider2 = document.getElementById('slider2');
//    var slider3 = document.getElementById('slider3');
//    var slider4 = document.getElementById('slider4');
//    var slider5 = document.getElementById('slider5');
//    var slider6 = document.getElementById('slider6');
//    var slider7 = document.getElementById('slider7');
//    var slider8 = document.getElementById('slider8');
//    var slider9 = document.getElementById('slider9');

//    setTimeout(function () { slider1.style.opacity = "1"; slider1.style.transition = "2s"; }, 500);
//    setTimeout(function () { slider2.style.opacity = "1"; slider2.style.transition = "2s"; }, 1500);
//    setTimeout(function () { slider7.style.opacity = "1"; slider7.style.transition = "2s"; }, 2000);
//    setTimeout(function () { slider4.style.opacity = "1"; slider4.style.transition = "2s"; }, 2500);
//    setTimeout(function () { slider3.style.opacity = "1"; slider3.style.marginLeft = "81%"; slider3.style.transition = "2s"; }, 3000);
//    setTimeout(function () { slider5.style.opacity = "1"; slider5.style.marginLeft = "46%"; slider5.style.transition = "3s"; }, 3500);
//    setTimeout(function () { slider6.style.opacity = "1"; slider6.style.transition = "0.5s"; }, 4000);
//}


$(document).ready(function () {
    setTimeout(function () {


        $('#SliderIndex1').css({ 'opacity': '1', 'transition': '2s' })
    }, 500);

    setTimeout(function () {


        $('#SliderIndex2').css({ 'opacity': '1', 'transition': '2s' })
    }, 1500);

    setTimeout(function () {


        $('#SliderIndex7').css({ 'opacity': '1', 'transition': '2s' })
    }, 2000);
    setTimeout(function () {


        $('#SliderIndex4').css({ 'opacity': '1', 'transition': '2s' })
    }, 2500);
    setTimeout(function () {


        $('#SliderIndex3').css({ 'opacity': '1', 'transition': '2s', 'margin-left': '81%' })
    }, 3000);

    setTimeout(function () {


        $('#SliderIndex5').css({ 'opacity': '1', 'transition': '3s', 'margin-left': '46%' })
    }, 3500);
    setTimeout(function () {


        $('#SliderIndex6').css({ 'opacity': '1', 'transition': '0.5s' })
    }, 2000);


});