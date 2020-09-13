$(document).ready(function () {

    $('.CreateSininStyle').click(function () {
        $('#MyModal').modal('show');

    });


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
    $('#btnsubmit').on('click', function () {
        var btn = $(this);
        btn.prop('disabled', true);
        window.setTimeout(function () {
            var UserName = $('#UserName').val();
            var Password = $('#Password').val();
            if (UserName == "" || Password == "") {
                btn.prop('disabled', false);

            }
            else if (UserName != "" || Password != "") {
                $.ajax({
                    url: '/api/ClientCore/SelectClientByUsername?username=' + UserName,
                    method: 'Post',
                    contenttype: 'application/json',
                    datatype: 'json',
                    success: function (data) {
                        if (Password == data.Password && data.Status == 10) {
                            var Username = UserName;
                            window.location.href = "/Admin/Home/";
                            window.localStorage.setItem("AdminUserName", Username);
                            //setCookie("username", Username, 365);
                        }
                        else {
                            btn.prop('disabled', false);
                            var errorList = $("ul.errorMessages");
                            errorList.empty();
                            errorList
                                .show()
                                .append("<li><span>" + "Error  Username or Pass or chose" + "</span> " + "</li>");
                            return false;
                        }
                    },
                    error: function () {
                        btn.prop('disabled', false);
                        var errorList = $("ul.errorMessages");
                        errorList.empty();
                        errorList
                            .show()
                            .append("<li><span>" + "Error  Username or Pass or chose" + "</span> " + "</li>");
                        return false;

                    }
                });


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
