$(document).ready(function () {

    var attractionsAbout = SelectAttractionByStatus('5');
    for (var i = 0; i < attractionsAbout.length; i++) {
        var aboutsImage = SelectImagesById(attractionsAbout[i].ImageId);
        var numberi = i + 1;
        $('<div id="DivDynamicInImageAboutUs' + i + '" class="row DivDynamicInImageAboutUs"></div>').appendTo('.aboutUsPageShowDynamicImage' + numberi);
        $('<img src="/Resources/Imges/' + aboutsImage.Image + '" class="ImgDivDynamicInImageAboutUs' + i + '">').appendTo('#DivDynamicInImageAboutUs' + i);
        //$('#TextAddAboutUnderImg' + numberi).val(attractionsAbout[i].Title);
        //$('#hiddenIdImage' + numberi).val(attractionsAbout[i].id);
        //$('#hiddenInputFullImgEmpty' + numberi).val("1");
        //$('#hiddenImageId' + numberi).val(attractionsAbout[i].ImageId);

        $('<input type="file" id="file-uploadImgAbout' + numberi + '" class="file-uploadImgAbout" />').appendTo('#DivDynamicInImageAboutUs' + i);
        $('<label for="file-uploadImgAbout' + numberi + '">Browse</label>').appendTo('#DivDynamicInImageAboutUs' + i);
        $('<input type="button" class="BtnSaveAboutSaveStyle" value="SAVE" /><br />').appendTo('#DivDynamicInImageAboutUs' + i);
        $('<input class="TextAddAboutUnderImg" value="' + attractionsAbout[i].Title + '" id="TextAddAboutUnderImg' + numberi + '" type="text" placeholder="Link Image" />').appendTo('#DivDynamicInImageAboutUs' + i);
        $('<input class="hiddenIdImage" id="hiddenIdImage' + numberi + '" type="hidden" value="' + attractionsAbout[i].id + '" />').appendTo('#DivDynamicInImageAboutUs' + i);
        if (aboutsImage.Image != null) {
            $('<input class="hiddenInputFullImgEmpty" id="hiddenInputFullImgEmpty' + numberi + '" type="hidden" value="1" />').appendTo('#DivDynamicInImageAboutUs' + i);
            $('<input class="hiddenImageId" id="hiddenImageId' + numberi + '" type="hidden" value="' + attractionsAbout[i].ImageId + '" />').appendTo('#DivDynamicInImageAboutUs' + i);
        }
        else {
            $('<input class="hiddenInputFullImgEmpty" id="hiddenInputFullImgEmpty' + numberi + '" type="hidden" value="0" />').appendTo('#DivDynamicInImageAboutUs' + i);
        }
    }
    var ImageAddressInData = "";
    $('.BtnSaveAboutSaveStyle').click(function () {
        var ImageUploadAddress = $(this).parent().children('.file-uploadImgAbout');
        var NameImageUpload = $(this).parent().children('.TextAddAboutUnderImg').val();
        var HiddenIdImage = $(this).parent().children('.hiddenIdImage').val();
        var HiddenInputFullImgEmpty = $(this).parent().children('.hiddenInputFullImgEmpty').val();
        var hiddenImageId = $(this).parent().children('.hiddenImageId').val();
        if (NameImageUpload == '') {
            alert('Please Name Image');
            return;
        }
        if (ImageUploadAddress.val() == '' && HiddenInputFullImgEmpty == "0") {
            alert('Please select file');
            return;
        }
        else {
            if (ImageUploadAddress.val() != '') {
                var formdata = new FormData();
                var file = ImageUploadAddress[0];
                formdata.append('file', file.files[0]);
                $.ajax({
                    url: '/api/upload/uploadfile',
                    type: 'POST',
                    data: formdata,
                    contentType: false,
                    processData: false,
                }).done(function (imageName) {
                    ImageAddressInData = imageName;
                    SendDataImageAndText(ImageAddressInData, NameImageUpload, HiddenIdImage, hiddenImageId);
                }).fail(function (imageName) {
                })
            }
            else {
                SendDataImageAndText(ImageAddressInData, NameImageUpload, HiddenIdImage, hiddenImageId);
            }
        }
    });
    function SendDataImageAndText(AddressImg, NameImg, IdAtt, ImageId) {
        var selectedImage = SelectImagesById(ImageId);
        if (AddressImg != "") {
            if (selectedImage.Image = !null) {
                var employee = new Object();
                employee.Name = selectedImage.Image;
                $.ajax({
                    type: "POST",
                    url: "/Admin/Home/AjaxPostCall",
                    data: JSON.stringify(employee),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                    },
                    failure: function (response) {
                        alert(response.responseText);
                    },
                    error: function (response) {
                        alert(response.responseText);
                    }
                });
            };
            var UpImg = {
                id: ImageId,
                Image: AddressImg[0],
                Name: NameImg
            };
            UpdateImages(UpImg, ImageId);

        }
        else {
            var UpImg = {
                id: ImageId,
                Image: selectedImage.Image,
                Name: NameImg
            };
            UpdateImages(UpImg, ImageId);
        }
        var UpAbout = {
            id: 1,
            Name: NameImg,
            Title: NameImg,
            TextId: 3068,
            ImageId: ImageId,
            IsText: 1,
            CityId: 2023,
            Score: 1,
            OrderId: 1,
            Status: 5,
            IsSelected: 1
        };
        UpdateAttraction(UpAbout, IdAtt);
        location.reload();
    };

});