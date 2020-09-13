$(document).ready(function () {
    //tourist//Clint 0 , tourguide/Rimatours 1 ,Destinations2, event 4 , tripstory 3  OurServices 6    About5-- #STATUS DEAL

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
            var FirstName = $('#Fname').val();
            var LastName = $('#Lname').val();
            var TellNo = $('#PhonNumber').val();
            var Email = $('#Email').val();
            var Username = $('#UserName').val();
            var Password = $('#Password').val();
            var ConfrimPassword = $('#ConfrimPassword').val();
            if (FirstName != "" && LastName != "" && TellNo != "" && Email != "" && Username != "" && Password != "" && ConfrimPassword != "") {
                var testEmail = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
                if (testEmail.test(Email)) {
                    if (/^\d+$/.test(TellNo)) {
                        if (Password == ConfrimPassword) {
                            var dataClient = {
                                FirstName: FirstName,
                                LastName: LastName,
                                TellNo: TellNo,
                                Email: Email,
                                Username: Username,
                                Password: Password,
                                Status: 0
                            };
                            var addedUser = AddClient(dataClient);
                            if (addedUser.id == -1) {
                                btn.prop('disabled', false);
                                alert('Email Or Username is duplicate');
                                var errorList = $("ul.errorMessages");
                                errorList.empty();
                                errorList
                                    .show()
                                    .append("<li><span>" + "Email Or Username is duplicate" + "</span> " + "</li>");
                            }
                            else {
                                alert('Your information has been registered');
                                btn.prop('disabled', false);
                                window.location.href = "../SingIn/SingIn.aspx";
                                $("#btnsubmit")[0].reset();
                            }
                        }
                        else {
                            btn.prop('disabled', false);
                            alert('Passwords are not equal');
                            var errorList = $("ul.errorMessages");
                            errorList.empty();
                            errorList
                                .show()
                                .append("<li><span>" + "Passwords are not equal" + "</span> " + "</li>");
                        }
                    }
                    else {
                        btn.prop('disabled', false);
                        alert('Phone is NOT correct');
                        var errorList = $("ul.errorMessages");
                        errorList.empty();
                        errorList
                            .show()
                            .append("<li><span>" + "Phone is NOT correct" + "</span> " + "</li>");
                    }


                }
                else {

                    btn.prop('disabled', false);
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