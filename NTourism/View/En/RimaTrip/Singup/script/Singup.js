$(document).ready(function () {

    ///////////////////////////
    var createAllErrors = function () {
        var form = $(this),
            errorList = $("ul.errorMessages", form);

        var showAllErrorMessages = function () {
            errorList.empty();

            var invalidFields = form.find(":invalid").each(function (index, node) {

                var label = $("label[for=" + node.id + "] "),
                    message = node.validationMessage || 'Invalid value.';

                errorList
                    .show()
                    .append("<li><span>" + label.html() + "</span> " + message + "</li>");


            });
        };

        $("input[type=submit], button:not([type=button])", form)
            .on("click", showAllErrorMessages);

        $("input", form).on("keypress", function (event) {
            var type = $(this).attr("type");
            if (/date|email|month|number|search|tel|text|time|url|week/.test(type)
                && event.keyCode == 13) {
                showAllErrorMessages();

            }
        });
    };

    $("form").each(createAllErrors);


    $('#btnsubmit').on("click", function () {

        var btn = $(this);
        btn.prop('disabled', true);
        window.setTimeout(function () {
            var FnameRimaTrip = $('#FnameRimaTrip').val();
            var LnameRimaTrip = $('#LnameRimaTrip').val();
            var SicknessNameRimaTrip = $('#SicknessNameRimaTrip').val();
            var SicknessDescRimaTrip = $('#SicknessDescRimaTrip').val();
            var PassNoRimaTrip = $('#PassNoRimaTrip').val();
            var fileuploadRimaTrip = $('#fileuploadRimaTrip').val();



            if (FnameRimaTrip != "" && LnameRimaTrip != "" && SicknessNameRimaTrip != "" && SicknessDescRimaTrip != "" && SicknessDescRimaTrip != "" && PassNoRimaTrip != "" && fileuploadRimaTrip != "") {

                if (/^\d+$/.test(PassNoRimaTrip)) {




               
                            var formdata = new FormData();
                            var file = $('#fileuploadRimaTrip')[0];
                            formdata.append('file', file.files[0]);
                            $.ajax({
                                url: '/api/upload/uploadfile',
                                type: 'POST',
                                data: formdata,
                                contentType: false,
                                processData: false,
                                success: function (imageName) {

                                    var image = {
                                        Image: imageName,
                                        Name: '_' + imageName.toString().split('_')[1] + imageName.toString().split('_')[2]
                                    };
                                    $.ajax({
                                        url: '/api/ImagesCore/AddImage',
                                        type: 'POST',
                                        data: image,
                                        success: function () {
                                            $.ajax({
                                                url: '/api/ImagesCore/SelectImagesByName?name=' + image.Name,
                                                type: 'POST',
                                                data: fileuploadRimaTrip,
                                                success: function (imageActual) {
                                                    var DataRimaTrip = {
                                                        FirstName: FnameRimaTrip,
                                                        LastName: LnameRimaTrip,
                                                        SicknessName: SicknessNameRimaTrip,
                                                        SicknessDesc: SicknessDescRimaTrip,
                                                        PassNo: PassNoRimaTrip,
                                                        PassportImageId: imageActual[0].id
                                                    };
                                                    $.ajax({
                                                        url: '/api/MedicalServiceCore/AddMedicalService',
                                                        method: 'Post',
                                                        contenttype: 'application/json',
                                                        datatype: 'json',
                                                        data: DataRimaTrip,
                                                        success: function (success) {
                                                            ///////////
                                                            alert('we will contacted you soon');
                                                            $('input').val('');
                                                            btn.prop('disabled', false);
                                                        },
                                                        error: function () {
                                                            btn.prop('disabled', false);
                                                            alert('Error Send');
                                                            var errorList = $("ul.errorMessages");
                                                            errorList.empty();
                                                            errorList
                                                                .show()
                                                                .append("<li><span>" + "Error Send" + "</span> " + "</li>");
                                                        }
                                                    });
                                                },
                                                error: function () {
                                                    btn.prop('disabled', false);
                                                }
                                            });
                                        },
                                        error: function () {
                                            btn.prop('disabled', false);
                                        }
                                    });
                                },
                                error: function () {
                                    btn.prop('disabled', false);
                                }
                            });
                     
                  




                }
                else {
                    btn.prop('disabled', false);
                    alert('Phone is NOT correct');
                    var errorList = $("ul.errorMessages");
                    errorList.empty();
                    errorList
                        .show()
                        .append("<li><span>" + "PassNoRimaTrip is NOT correct" + "</span> " + "</li>");
                }



            }
            else {
                btn.prop('disabled', false);
            }
        }, 10);
    });

});


function CheckEmptyInput(input) {
    if (input.value.length < 1) {
        //  رنگ قرمز  بعد عدم  ثبت عدد
        input.style.borderColor = "#e74c3c";

    }

    else {
        // رنگ سبز  بعد ثبت
        input.style.borderColor = "#2ecc71";
    }
}