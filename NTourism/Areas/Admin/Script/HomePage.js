$(document).ready(function () {

    //$("<div><img  src='/Resources/Imges/12.jpg'/></div>").appendTo('.ImageHome122222');
    var buttonsData = SelectAllFirstPages();
    if (buttonsData[0].Sign == 1) {
        //DynamicHomeImageAndText1
        var ImageHome1 = buttonsData[0].Image;
        // var ImageHome1 = buttonsData[0].Image;
        var LinkImageHome1 = buttonsData[0].Text;
        $("<div><a class='TagAImageHome1 hoverImg' href=" + LinkImageHome1 + " target='_blank' title='" + LinkImageHome1 + "'><img class='ImageHome1' src='/Resources/Imges/" + ImageHome1 + "' alt='" + LinkImageHome1 + "'/></a></div>").appendTo('#DynamicHomeImageAndText1');
        if (buttonsData[0].Image != null) {
            $('#hiddenInputFullImgEmpty1').val("1");
        }
        $('#hiddenIdImage1').val(buttonsData[0].id);
        $('#TextAddHomePageUnderImg1').val(buttonsData[0].Text);
        $('#hiddenInputSign1').val(buttonsData[0].Sign);
    }
    if (buttonsData[1].Sign == 2) {
        var ImageHome2 = buttonsData[1].Image;
        var LinkImageHome2 = buttonsData[1].Text;
        $("<div><a class='TagAImageHome2 hoverImg' href=" + LinkImageHome2 + " target='_blank' title='" + LinkImageHome2 + "'><img class='ImageHome2' src='/Resources/Imges/" + ImageHome2 + "' alt='" + LinkImageHome2 + "' /></a></div>").appendTo('#DynamicHomeImageAndText2');
        if (buttonsData[1].Image != null) {
            $('#hiddenInputFullImgEmpty2').val("1");
        }
        $('#hiddenIdImage2').val(buttonsData[1].id);
        $('#TextAddHomePageUnderImg2').val(buttonsData[1].Text);
        $('#hiddenInputSign2').val(buttonsData[1].Sign);
    }
    if (buttonsData[3].Sign == 4) {
        //DynamicHomeImageAndText4
        var ImageHome4 = buttonsData[3].Image;
        var LinkImageHome4 = buttonsData[3].Text;
        $("<div><a class='TagAImageHome4 hoverImg' href=" + LinkImageHome4 + " target='_blank' title='" + LinkImageHome4 + "'><img class='ImageHome4' src='/Resources/Imges/" + ImageHome4 + "' alt='" + LinkImageHome4 + "'/></a></div>").appendTo('#DynamicHomeImageAndText4');
        if (buttonsData[3].Image != null) {
            $('#hiddenInputFullImgEmpty4').val("1");
        }
        $('#hiddenIdImage4').val(buttonsData[3].id);
        $('#TextAddHomePageUnderImg4').val(buttonsData[3].Text);
        $('#hiddenInputSign4').val(buttonsData[3].Sign);
    }
    if (buttonsData[4].Sign == 5) {
        //DynamicHomeImageAndText5
        var ImageHome5 = buttonsData[4].Image;
        var LinkImageHome5 = buttonsData[4].Text;
        $("<div><a class='TagAImageHome5 hoverImg' href=" + LinkImageHome5 + " target='_blank' title='" + LinkImageHome5 + "'><img class='ImageHome5' src='/Resources/Imges/" + ImageHome5 + "' alt='" + LinkImageHome5 + "'/></a></div>").appendTo('#DynamicHomeImageAndText5');
        if (buttonsData[4].Image != null) {
            $('#hiddenInputFullImgEmpty5').val("1");
        }
        $('#hiddenIdImage5').val(buttonsData[4].id);
        $('#TextAddHomePageUnderImg5').val(buttonsData[4].Text);
        $('#hiddenInputSign5').val(buttonsData[4].Sign);
    }
    if (buttonsData[5].Sign == 6) {
        //DynamicHomeImageAndText6
        var ImageHome6 = buttonsData[5].Image;
        var LinkImageHome6 = buttonsData[5].Text;
        $("<div><a class='TagAImageHome6 hoverImg' href=" + LinkImageHome6 + " target='_blank' title='" + LinkImageHome6 + "'><img class='ImageHome6' src='/Resources/Imges/" + ImageHome6 + "' alt='" + LinkImageHome6 + "'/></a></div>").appendTo('#DynamicHomeImageAndText6');
        if (buttonsData[5].Image != null) {
            $('#hiddenInputFullImgEmpty6').val("1");
        }
        $('#hiddenIdImage6').val(buttonsData[5].id);
        $('#TextAddHomePageUnderImg6').val(buttonsData[5].Text);
        $('#hiddenInputSign6').val(buttonsData[5].Sign);
    }
    if (buttonsData[6].Sign == 7) {
        //DynamicHomeImageAndText7
        var ImageHome7 = buttonsData[6].Image;
        var LinkImageHome7 = buttonsData[6].Text;
        $("<div><a class='TagAImageHome6 hoverImg' href=" + LinkImageHome7 + " target='_blank' title='" + LinkImageHome7 + "'><img class='ImageHome6' src='/Resources/Imges/" + ImageHome7 + "'  alt='" + LinkImageHome7 + "'/></a></div>").appendTo('#DynamicHomeImageAndText7');
        if (buttonsData[6].Image != null) {
            $('#hiddenInputFullImgEmpty7').val("1");
        }
        $('#hiddenIdImage7').val(buttonsData[6].id);
        $('#TextAddHomePageUnderImg7').val(buttonsData[6].Text);
        $('#hiddenInputSign7').val(buttonsData[6].Sign);
    }
    if (buttonsData[7].Sign == 8) {
        //DynamicHomeImageAndText8
        var ImageHome8 = buttonsData[7].Image;
        var LinkImageHome8 = buttonsData[7].Text;
        $("<div><a class='TagAImageHome8 hoverImg' href=" + LinkImageHome8 + " target='_blank' title='" + LinkImageHome8 + "'><img class='ImageHome8' src='/Resources/Imges/" + ImageHome8 + "'  alt='" + LinkImageHome8 + "'//></a></div>").appendTo('#DynamicHomeImageAndText8');
        if (buttonsData[7].Image != null) {
            $('#hiddenInputFullImgEmpty8').val("1");
        }
        $('#hiddenIdImage8').val(buttonsData[7].id);
        $('#TextAddHomePageUnderImg8').val(buttonsData[7].Text);
        $('#hiddenInputSign8').val(buttonsData[7].Sign);
    }
    if (buttonsData[8].Sign == 9) {
        //DynamicHomeImageAndText9
        var ImageHome9 = buttonsData[8].Image;
        var LinkImageHome9 = buttonsData[8].Text;
        $("<div><a class='TagAImageHome9 hoverImg' href=" + LinkImageHome9 + " target='_blank' title='" + LinkImageHome9 + "'><img class='ImageHome9' src='/Resources/Imges/" + ImageHome9 + "'alt='" + LinkImageHome9 + "'/></a></div>").appendTo('#DynamicHomeImageAndText9');
        if (buttonsData[8].Image != null) {
            $('#hiddenInputFullImgEmpty9').val("1");
        }
        $('#hiddenIdImage9').val(buttonsData[8].id);
        $('#TextAddHomePageUnderImg9').val(buttonsData[8].Text);
        $('#hiddenInputSign9').val(buttonsData[8].Sign);
    }
    if (buttonsData[8].Sign == 9) {
        //DynamicHomeImageAndText10
        var ImageHome10 = buttonsData[9].Image;
        var LinkImageHome10 = buttonsData[9].Text;
        $("<div><a class='TagAImageHome9 hoverImg' href=" + LinkImageHome10 + " target='_blank' title='" + LinkImageHome10 + "'><img class='ImageHome9' src='/Resources/Imges/" + ImageHome10 + "' alt='" + LinkImageHome9 + "'/></a></div>").appendTo('#DynamicHomeImageAndText10');
        if (buttonsData[9].Image != null) {
            $('#hiddenInputFullImgEmpty10').val("1");
        }
        $('#hiddenIdImage10').val(buttonsData[9].id);
        $('#TextAddHomePageUnderImg10').val(buttonsData[9].Text);
        $('#hiddenInputSign10').val(buttonsData[9].Sign);
    }

    $(function () {
        var ImageAddressInData = "";
        $('.BtnSaveHomePageSaveStyle').click(function () {
            var ImageUploadAddress = $(this).parent().children('.file-uploadImgHomePage');
            var NameImageUpload = $(this).parent().children('.TextAddHomePageUnderImg').val();
            var HiddenIdImage = $(this).parent().children('.hiddenIdImage').val();
            var HiddenInputFullImgEmpty = $(this).parent().children('.hiddenInputFullImgEmpty').val();
            var hiddenInputSign = $(this).parent().children('.hiddenInputSign').val();
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
                        SendDataImageAndText(ImageAddressInData, NameImageUpload, HiddenIdImage, hiddenInputSign);
                    }).fail(function (imageName) {
                    })
                }
                else {
                    SendDataImageAndText(ImageAddressInData, NameImageUpload, HiddenIdImage, hiddenInputSign);
                }
            }
        });

        function SendDataImageAndText(AddressImg, NameImg, IdImg, Sign) {
            var selectedPage = SelectFirstPageById(IdImg);
            let UpFirst;
            if (AddressImg != "") {
                if (selectedPage.Image = !null) {
                    var employee = new Object();
                    employee.Name = selectedPage.Image;
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
                UpFirst = {
                    Image: AddressImg[0],
                    Text: NameImg,
                    Sign: Sign,
                    IsText: 0
                };

            }
            else {
                AddressImg = selectedPage.Image;
                UpFirst = {
                    Image: AddressImg,
                    Text: NameImg,
                    Sign: Sign,
                    IsText: 0
                };
            }
            UpdateFirstPage(UpFirst, IdImg);
            location.reload();
        };
    });

});

