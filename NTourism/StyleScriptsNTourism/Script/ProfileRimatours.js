$(document).ready(function () {
    $(function () {
        if (localStorage.getItem("UserName") === null) {
            window.location.href = "/404/Index.html";
        }
        else {
            var userRimatours = getCookie("CodeProConnect");
            if (userRimatours != "") {
                if (userRimatours == 3) {
                    window.location.href = "/404/Index.html";
                }
                if (userRimatours == 1) {
                    window.location.href = "/404/Index.html";
                }
            }
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
            setCookie("CodeProConnect", "2", 365);

            //Rate
            //Discount
            //Price
            var Username = window.localStorage.getItem("UserName");
            var selectedClient = SelectTourGuideByUsername(Username);
            $('#FNameAmn').text(selectedClient.FirstName);
            $('#LNameAmn').text(selectedClient.LastName);
            $('#ShoeEmail').text(selectedClient.Email);
            $('#TellNo').text(selectedClient.TellNo);
            $('#UserNameAmn').text(selectedClient.Username);


            $('#Fname').val(selectedClient.FirstName);
            $('#Lname').val(selectedClient.LastName);
            $('#PhonNumber').val(selectedClient.TellNo);


            var selectedCity = SelectCityById(selectedClient.CityId);

            $('#City').val(selectedCity.Name);
            $('#dolar').val(selectedClient.Price);
            $('#Discount').val(selectedClient.Discount);
            $('#Description').val(selectedClient.Description);
            $('#Rate').val(selectedClient.Rate);
            $("#cityNames").val(selectedCity.Name);

            var imageAddress = false;
            if (imageAddress == true) {
                $('#UserImg').remove();
                $('<img style="width:100px;" src="/4545.jpg" />').appendTo('#ParentUserImg');
            }
            else {
                $('<i id="UserImg" class="fa fa-user-circle-o"></i>').appendTo('#ParentUserImg');
            }




            $('#btnsubmit').on("click", function () {
                var btn = $(this);
                btn.prop('disabled', true);

                window.setTimeout(function () {
                    var FirstName = $('#Fname').val();
                    var LastName = $('#Lname').val();
                    var TellNo = $('#PhonNumber').val();
                    var City = $('#City').val();
                    var dolar = $('#dolar').val();
                    var Description = $('#Description').val();
                    var Rate = $('#Rate').val();
                    var Discount = $('#Discount').val();
                    var TellNo = $('#PhonNumber').val();
                    var Password = selectedClient.Password;
                    var Username = selectedClient.Username;
                    var MainImage = selectedClient.MainImage;
                    //ChosePhoto
                    var SerachCity = SelectCityByName(City).id;
                    if (FirstName != "" && LastName != "" && TellNo != "") {
                        //if (MainImage != "") {
                        //    var AddresImage = $('#ChosePhoto');
                        //    var formdata = new FormData();
                        //    var file = AddresImage[0];
                        //    formdata.append('file', file.files[0]);
                        //    var inputObj = {
                        //        UploadeImg: ""
                        //    };
                        //    $.ajax({
                        //        url: '/api/upload/uploadfile',
                        //        type: 'POST',
                        //        data: formdata,
                        //        contentType: false,
                        //        processData: false,
                        //    }).done(function (imageName) {
                        //        tmp = imageName;
                        //        inputObj.UploadeImg = imageName;
                        //    }).fail(function (imageName) {
                        //    })

                        //}
                        //else {

                        //}

                        var dataRoom = {

                            id: selectedClient.id,
                            FirstName: FirstName,
                            LastName: LastName,
                            TellNo: TellNo,
                            Email: selectedClient.Email,
                            MainImage: Username,
                            CityId: SerachCity,
                            Username: selectedClient.Username,
                            Password: Password,
                            Rate: Rate,
                            Discount: Discount,
                            Price: dolar,
                            Description: Description
                        };
                        var updateRoom = UpdateTourGuide(dataRoom, selectedClient.id);
                        location.reload();
                    }
                    else {
                        alert('Not Save');
                        btn.prop('disabled', false);
                        var errorList = $("ul.errorMessages");
                        errorList.empty();
                        errorList
                            .show()
                            .append("<li><span>" + "" + "</span> " + "</li>");
                    }
                }, 10);


            });




            var dataImg = SelectImagesByTourGuide(selectedClient.id);
            var count = dataImg.length;
            if (count > 6) {

                count = 6;
            }
            for (var i = 0; i < count; i++) {
                if (!dataImg[i].Image.includes('aparat')) {
                    //  alert(dataImg[i].id);
                    var j = i + 1;
                    $('#hiddenInputFullImgEmpty' + j).val('1');
                    $('#removeImgInData' + j).val('0');
                    $('#hiddenIdImage' + j).val(dataImg[i].id);
                    $('#DivuploadOurServices' + j).hide();
                    $('#fileDisplayArea' + j + ' a').show();
                    $('<img src="/Resources/Imges/' + dataImg[i].Image + '" class="imgload" />').appendTo('#fileDisplayArea' + j);
                }
            }

            $('#SendImageTodataSave').click(function () {
                var ImageAddressInData = "";
                var ImageUploadAddress = $('#file-upload1');
                var HiddenIdImage = $('#hiddenIdImage1').val();
                var HiddenInputFullImgEmpty = $('#hiddenInputFullImgEmpty1').val();
                var removeImgInData = $('#removeImgInData1').val();

                var ImageAddressInData2 = "";
                var ImageUploadAddress2 = $('#file-upload2');
                var HiddenIdImage2 = $('#hiddenIdImage2').val();
                var HiddenInputFullImgEmpty2 = $('#hiddenInputFullImgEmpty2').val();
                var removeImgInData2 = $('#removeImgInData2').val();

                var ImageAddressInData3 = "";
                var ImageUploadAddress3 = $('#file-upload3');
                var HiddenIdImage3 = $('#hiddenIdImage3').val();
                var HiddenInputFullImgEmpty3 = $('#hiddenInputFullImgEmpty3').val();
                var removeImgInData3 = $('#removeImgInData3').val();

                var ImageAddressInData4 = "";
                var ImageUploadAddress4 = $('#file-upload4');
                var HiddenIdImage4 = $('#hiddenIdImage4').val();
                var HiddenInputFullImgEmpty4 = $('#hiddenInputFullImgEmpty4').val();
                var removeImgInData4 = $('#removeImgInData4').val();



                var ImageAddressInData5 = "";
                var ImageUploadAddress5 = $('#file-upload5');
                var HiddenIdImage5 = $('#hiddenIdImage5').val();
                var HiddenInputFullImgEmpty5 = $('#hiddenInputFullImgEmpty5').val();
                var removeImgInData5 = $('#removeImgInData5').val();

                var ImageAddressInData6 = "";
                var ImageUploadAddress6 = $('#file-upload6');
                var HiddenIdImage6 = $('#hiddenIdImage6').val();
                var HiddenInputFullImgEmpty6 = $('#hiddenInputFullImgEmpty6').val();
                var removeImgInData6 = $('#removeImgInData6').val();
                if (ImageUploadAddress.val() == '' && HiddenInputFullImgEmpty == "0" && ImageUploadAddress2.val() == '' && HiddenInputFullImgEmpty2 == "0" && ImageUploadAddress3.val() == '' && HiddenInputFullImgEmpty3 == "0" && ImageUploadAddress4.val() == '' && HiddenInputFullImgEmpty4 == "0" && ImageUploadAddress5.val() == '' && HiddenInputFullImgEmpty5 == "0" && ImageUploadAddress6.val() == '' && HiddenInputFullImgEmpty6 == "0") {
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
                            SendImageNAme(ImageAddressInData, HiddenIdImage, removeImgInData);
                        }).fail(function (imageName) {
                        })
                    }
                    else {

                        SendImageNAme(ImageAddressInData, HiddenIdImage, removeImgInData);
                    }


                    /////////////2

                    if (ImageUploadAddress2.val() != '') {
                        var formdata = new FormData();
                        var file = ImageUploadAddress2[0];
                        formdata.append('file', file.files[0]);
                        $.ajax({
                            url: '/api/upload/uploadfile',
                            type: 'POST',
                            data: formdata,
                            contentType: false,
                            processData: false,
                        }).done(function (imageName2) {
                            ImageAddressInData2 = imageName2;
                            SendImageNAme(ImageAddressInData2, HiddenIdImage2, removeImgInData2);
                        }).fail(function (imageName2) {
                        })
                    }
                    else {
                        SendImageNAme(ImageAddressInData2, HiddenIdImage2, removeImgInData2);
                    }


                    /////////////3


                    if (ImageUploadAddress3.val() != '') {
                        var formdata = new FormData();
                        var file = ImageUploadAddress3[0];
                        formdata.append('file', file.files[0]);
                        $.ajax({
                            url: '/api/upload/uploadfile',
                            type: 'POST',
                            data: formdata,
                            contentType: false,
                            processData: false,
                        }).done(function (imageName3) {
                            ImageAddressInData3 = imageName3;
                            SendImageNAme(ImageAddressInData3, HiddenIdImage3, removeImgInData3);
                        }).fail(function (imageName3) {
                        })
                    }
                    else {
                        SendImageNAme(ImageAddressInData3, HiddenIdImage3, removeImgInData3);
                    }


                    /////////////4


                    if (ImageUploadAddress4.val() != '') {
                        var formdata = new FormData();
                        var file = ImageUploadAddress4[0];
                        formdata.append('file', file.files[0]);
                        $.ajax({
                            url: '/api/upload/uploadfile',
                            type: 'POST',
                            data: formdata,
                            contentType: false,
                            processData: false,
                        }).done(function (imageName4) {
                            ImageAddressInData4 = imageName4;
                            SendImageNAme(ImageAddressInData4, HiddenIdImage4, removeImgInData4);
                        }).fail(function (imageName4) {
                        })
                    }
                    else {
                        SendImageNAme(ImageAddressInData4, HiddenIdImage4, removeImgInData4);
                    }


                    /////////////5



                    if (ImageUploadAddress5.val() != '') {
                        var formdata = new FormData();
                        var file = ImageUploadAddress5[0];
                        formdata.append('file', file.files[0]);
                        $.ajax({
                            url: '/api/upload/uploadfile',
                            type: 'POST',
                            data: formdata,
                            contentType: false,
                            processData: false,
                        }).done(function (imageName5) {
                            ImageAddressInData5 = imageName5;
                            SendImageNAme(ImageAddressInData5, HiddenIdImage5, removeImgInData5);
                        }).fail(function (imageName5) {
                        })
                    }
                    else {
                        SendImageNAme(ImageAddressInData5, HiddenIdImage5, removeImgInData5);
                    }


                    /////////////6



                    if (ImageUploadAddress6.val() != '') {
                        var formdata = new FormData();
                        var file = ImageUploadAddress6[0];
                        formdata.append('file', file.files[0]);
                        $.ajax({
                            url: '/api/upload/uploadfile',
                            type: 'POST',
                            data: formdata,
                            contentType: false,
                            processData: false,
                        }).done(function (imageName6) {
                            ImageAddressInData6 = imageName6;
                            SendImageNAme(ImageAddressInData6, HiddenIdImage6, removeImgInData6);
                        }).fail(function (imageName6) {
                        })
                    }
                    else {
                        SendImageNAme(ImageAddressInData6, HiddenIdImage6, removeImgInData6);
                    }
                }

            });

            function SendImageNAme(ImageAddressInData, HiddenIdImage, removeImgInData) {
                //alert(ImageAddressInData);
                //alert(HiddenIdImage);
                //alert(removeImgInData);
                if (removeImgInData == 1) {
                    var selectedImage = SelectImagesById(HiddenIdImage);
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
                        },
                        error: function (response) {
                        }
                    });
                    DeleteImages(HiddenIdImage);
                }
                let AddImg;
                let UpImg;
                if (ImageAddressInData != "") {
                    if (HiddenIdImage == "") {
                        AddImg = {
                            Image: ImageAddressInData[0],
                            Name: "M" + new Date().toLocaleString(),
                        };
                        var IdImg = AddImages(AddImg);

                        AddRoomImg = {
                            TourGuideId: selectedClient.id,
                            ImageId: IdImg.id
                        };
                        var AddHome = AddTourGuideImagesRel(AddRoomImg);

                    }
                    else {
                        UpImg = {
                            Image: ImageAddressInData[0],
                            Name: "M" + new Date().toLocaleString(),
                        };
                        UpdateImages(UpImg, HiddenIdImage);
                    }
                };
                location.reload();
            }

        }
    });




    $('.remImage').hide();
    $('.remImage').click(function () {
        $(this).parent().children('a').hide();
        $(this).parent().children().children('input[type="file"]').val("");
        $(this).parent().children().children('input[class="removeImgInData"]').val("1");
        //$(this).parent().children().children('input[type="file"]').wrap('<form>').closest('form').get(0).reset();
        $(this).parent().children('img').remove();
        $(this).parent().children('div').show();
    });

});




window.onload = function () {
    ///OurServicesImg1
    var fileInput = document.getElementById('file-upload1');
    var fileDisplayArea = document.getElementById('fileDisplayArea1');
    fileInput.addEventListener('change', function (e) {
        var file = fileInput.files[0];
        var imageType = /image.*/;
        if (file.type.match(imageType)) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var img = new Image();
                img.src = reader.result;
                img.className = "imgload";
                fileDisplayArea.appendChild(img);
                $('#DivuploadOurServices1').hide();
                $('#fileDisplayArea1 a').show();
                $('#removeImgInData1').val('0');
            }
            reader.readAsDataURL(file);
        }
        else {
        }
    });
    ///OurServicesImg2
    var fileInput2 = document.getElementById('file-upload2');
    var fileDisplayArea2 = document.getElementById('fileDisplayArea2');
    fileInput2.addEventListener('change', function (e) {
        var file = fileInput2.files[0];
        var imageType = /image.*/;
        if (file.type.match(imageType)) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var img = new Image();
                img.src = reader.result;
                img.className = "imgload";
                fileDisplayArea2.appendChild(img);
                $('#DivuploadOurServices2').hide();
                $('#fileDisplayArea2 a').show();
                $('#removeImgInData2').val('0');

            }
            reader.readAsDataURL(file);
        }
        else {
        }
    });
    ///OurServicesImg3
    var fileInput3 = document.getElementById('file-upload3');
    var fileDisplayArea3 = document.getElementById('fileDisplayArea3');
    fileInput3.addEventListener('change', function (e) {
        var file = fileInput3.files[0];
        var imageType = /image.*/;
        if (file.type.match(imageType)) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var img = new Image();
                img.src = reader.result;
                img.className = "imgload";
                fileDisplayArea3.appendChild(img);
                $('#DivuploadOurServices3').hide();
                $('#fileDisplayArea3 a').show();
                $('#removeImgInData3').val('0');

            }
            reader.readAsDataURL(file);
        }
        else {
        }
    });
    ///OurServicesImg4
    var fileInput4 = document.getElementById('file-upload4');
    var fileDisplayArea4 = document.getElementById('fileDisplayArea4');
    fileInput4.addEventListener('change', function (e) {
        var file = fileInput4.files[0];
        var imageType = /image.*/;
        if (file.type.match(imageType)) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var img = new Image();
                img.src = reader.result;
                img.className = "imgload";
                fileDisplayArea4.appendChild(img);
                $('#DivuploadOurServices4').hide();
                $('#fileDisplayArea4 a').show();
                $('#removeImgInData4').val('0');

            }
            reader.readAsDataURL(file);
        }
        else {
        }
    });
    ///OurServicesImg5
    var fileInput5 = document.getElementById('file-upload5');
    var fileDisplayArea5 = document.getElementById('fileDisplayArea5');
    fileInput5.addEventListener('change', function (e) {
        var file = fileInput5.files[0];
        var imageType = /image.*/;
        if (file.type.match(imageType)) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var img = new Image();
                img.src = reader.result;
                img.className = "imgload";
                fileDisplayArea5.appendChild(img);
                $('#DivuploadOurServices5').hide();
                $('#fileDisplayArea5 a').show();
                $('#removeImgInData5').val('0');

            }
            reader.readAsDataURL(file);
        }
        else {
        }
    });
    ///OurServicesImg6
    var fileInput6 = document.getElementById('file-upload6');
    var fileDisplayArea6 = document.getElementById('fileDisplayArea6');
    fileInput6.addEventListener('change', function (e) {
        var file = fileInput6.files[0];
        var imageType = /image.*/;
        if (file.type.match(imageType)) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var img = new Image();
                img.src = reader.result;
                img.className = "imgload";
                fileDisplayArea6.appendChild(img);
                $('#DivuploadOurServices6').hide();
                $('#fileDisplayArea6 a').show();
                $('#removeImgInData6').val('0');

            }
            reader.readAsDataURL(file);
        }
        else {
        }
    });

}






var selectedCities = SelectAllCitys();
for (var i = 0; i < selectedCities.length; i++) {
    $('<option value="' + selectedCities[i].Name + '">' + selectedCities[i].Name + '</option>').appendTo('#cityNames');
}
//var selectedCountry = $("#cityNames option:selected").val('Qeshm');
$("#cityNames").change(function () {
    $("#City").val($('#cityNames').val());
});
$(function () {
    $("#cityNames").val($('#CityNameEdite').val());
});


function ShowEditeProfileOurServices() {
    $('#DivPage1OurServices').removeClass('DivPage1OurServices');
    $('#DivPage1OurServices').addClass('DivPage2OurServices');

    $('#DivPage2OurServices').removeClass('DivPage2OurServices');
    $('#DivPage2OurServices').addClass('DivPage1OurServices');
}
function CancelEditeProfileOurServices() {
    $('#DivPage1OurServices').removeClass('DivPage2OurServices');
    $('#DivPage1OurServices').addClass('DivPage1OurServices');

    $('#DivPage2OurServices').removeClass('DivPage1OurServices');
    $('#DivPage2OurServices').addClass('DivPage2OurServices');
}
function ShowInInputInformationOurServices() {

}