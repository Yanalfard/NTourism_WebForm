$(document).ready(function () {
    $(function () {
        if (localStorage.getItem("UserName") === null) {
            window.location.href = "../../404/Index.html";
        }
        else {
            var userTourist = getCookie("CodeProConnect");
            if (userTourist != "") {
                if (userTourist == 1) {
                    window.location.href = "../../404/Index.html";
                }
                if (userTourist == 2) {
                    window.location.href = "../../404/Index.html";
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
            setCookie("CodeProConnect", "3", 365);

            //Rate
            //Discount
            //Price
            var Username = window.localStorage.getItem("UserName");
            var selectedClient = SelectClientByUsername(Username);
            $('#FNameAmn').text(selectedClient.FirstName);
            $('#LNameAmn').text(selectedClient.LastName);
            $('#TellNo').text(selectedClient.TellNo);


            $('#Fname').val(selectedClient.FirstName);
            $('#Lname').val(selectedClient.LastName);
            $('#PhonNumber').val(selectedClient.TellNo);



            var imageAddress = false;
            if (imageAddress == true) {
                $('#UserImg').remove();
                $('<img style="width:100px;" src="/4545.jpg" />').appendTo('#ParentUserImg');
            }
            else {
                $('<i id="UserImg" class="fa fa-user-circle-o"></i>').appendTo('#ParentUserImg');
            }



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

                    if (FirstName != "" && LastName != "" && TellNo != "") {

                        var dataClient = {
                            FirstName: FirstName,
                            LastName: LastName,
                            Email: selectedClient.Email,
                            Username: selectedClient.Username,
                            Password: selectedClient.Password,
                            TellNo: TellNo,
                            Status: 0
                        };
                        var updateClient = UpdateClient(dataClient, selectedClient.id);
                        location.reload();
                    }
                    else {
                        btn.prop('disabled', false);
                    }
                }, 10);
            });


        }
    });

});

function SingOut() {
    window.localStorage.removeItem("UserName");
    document.location.reload(true);
    window.location.href = "../../SingIn/SingIn.aspx";

}

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


function ShowEditeProfileTourGide() {
    $('#DivPage1TourGide').removeClass('DivPage1TourGide');
    $('#DivPage1TourGide').addClass('DivPage2TourGide');

    $('#DivPage2TourGide').removeClass('DivPage2TourGide');
    $('#DivPage2TourGide').addClass('DivPage1TourGide');
    ShowInInputInformationTourGide();

}
function CancelShowEditeProfileTourGide() {
    $('#DivPage1TourGide').removeClass('DivPage2TourGide');
    $('#DivPage1TourGide').addClass('DivPage1TourGide');

    $('#DivPage2TourGide').removeClass('DivPage1TourGide');
    $('#DivPage2TourGide').addClass('DivPage2TourGide');

}

function ShowInInputInformationTourGide() {

}