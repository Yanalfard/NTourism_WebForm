$(document).ready(function () {
    $(document).ready(function () {
        var rimatripservices = SelectAll4Services();
        $('.textInRow1TheRow1TextHomePageStyle').text(rimatripservices[6].Title);
        $('<p>' + rimatripservices[6].Text + '</p>').appendTo('.divInRow1TheRow2HomePageStyle');

    });

    var attractionsAbout = SelectAttractionByStatus('5');
    for (var i = 0; i < attractionsAbout.length; i++) {
        var aboutsImage = SelectImagesById(attractionsAbout[i].ImageId);
        var numberi = i + 1;
        $('<div id="DivDynamicInImageAboutUs' + i + '" class="row DivDynamicInImageAboutUs"></div>').appendTo('.aboutUsPageShowDynamicImage' + numberi);
        $('<img src="/Resources/Imges/' + aboutsImage.Image + '" alt="' + attractionsAbout[i].Title + '" title="' + attractionsAbout[i].Title + '" class="ImgDivDynamicInImageAboutUs' + i + '">').appendTo('#DivDynamicInImageAboutUs' + i);
        $('<p class="TagDivDynamicInImageAboutUs">' + attractionsAbout[i].Title + '</p>').appendTo('#DivDynamicInImageAboutUs' + i);
    }

    ////Paging
    var modalAboutUs = document.getElementById("mymodalAboutUs");
    var modalAboutUsImg = document.getElementById("img01");
    var captionAboutUsText = document.getElementById("captionAboutUs");
    $('.DivDynamicInImageAboutUs').click(function () {
        var NameImgAboutUsFullSize = $(this).children('img').attr('src');
        var NameImgAboutUsFullSize2 = $(this).children('p').text();
        modalAboutUs.style.display = "block";
        modalAboutUsImg.src = NameImgAboutUsFullSize;
        captionAboutUsText.innerHTML = NameImgAboutUsFullSize2;
    })
    // Get the <span> element that closeAboutUss the modalAboutUs
    var span = document.getElementsByClassName("closeAboutUs")[0];
    // When the user clicks on <span> (x), closeAboutUs the modalAboutUs
    span.onclick = function () {
        modalAboutUs.style.display = "none";
    }
})

