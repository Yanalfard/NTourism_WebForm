$(document).ready(function () {
    $(function () {
        if (localStorage.getItem("AdminUserName") === null) {
            window.location.href = "/View/404/Index.html";
        }
        else {



        }
    });



});

function SingOut() {
    window.localStorage.removeItem("AdminUserName");
    document.location.reload(true);
    window.location.href = "/Index.aspx";
};

// jQuery Plugin: http://flaviusmatis.github.io/simplePagination.js/
var items = $(".list-wrapper .list-item");
var numItems = items.length;
var perPage = 10;
items.slice(perPage).hide();
$('.pagination-container').pagination({
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
