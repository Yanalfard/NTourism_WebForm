
var flagshowmenu = 0;
function openNav() {
    flagshowmenu++;
    if (flagshowmenu == 1) {
        document.getElementById("mySidenav").style.height = "100%";
        document.getElementById("mySidenav").style.zIndex = "3";
        document.getElementById("mySidenav").style.transition = "1s";
        document.getElementById("form1").className = "fixedPosition";
    }
    else if (flagshowmenu == 2) {
        document.getElementById("mySidenav").style.height = "0";
        document.getElementById("form1").className = "fixedPositionDisabel";
        flagshowmenu = 0;
    }

}

function myFunction(x) {
    x.classList.toggle("change");
}

// When the user scrolls down 20px from the top of the document, show the button
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


var flagshowmenu = 0;
function openNav() {
    flagshowmenu++;
    if (flagshowmenu == 1) {
        document.getElementById("mySidenav").style.height = "100%";
        document.getElementById("mySidenav").style.zIndex = "3";
        document.getElementById("mySidenav").style.transition = "1s";
        document.getElementById("form1").className = "fixedPosition";
    }
    else if (flagshowmenu == 2) {
        document.getElementById("mySidenav").style.height = "0";
        document.getElementById("form1").className = "fixedPositionDisabel";
        flagshowmenu = 0;
    }

}

function myFunction(x) {
    x.classList.toggle("change");
}