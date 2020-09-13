
$(document).ready(function () {

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
            var Name = $('#Name').val();
            var Title = $('#Title').val();
            var Email = $('#Email').val();
            var Writeyourmessage = $('#Writeyourmessage').val();
            var DateSended = new Date();

            if (Name != "" && Title != "" && Email != "" && Writeyourmessage != "") {
                var testEmail = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
                if (testEmail.test(Email)) {

                    var dataClient = {
                        Name: Name,
                        Title: Title,
                        Email: Email,
                        Text: Writeyourmessage,
                        ReciverId: 1,
                        DateSended: DateSended
                    };

                    $.ajax({
                        url: '/api/TicketCore/AddTicket',
                        method: 'Post',
                        contenttype: 'application/json',
                        datatype: 'json',
                        data: dataClient,
                        success: function () {
                            alert('Ticket has been sent');
                            btn.prop('disabled', false);
                            $("#Ticket")[0].reset();
                            location.reload(true);
                        },
                        error: function () {
                            alert('Error In Connection');
                            btn.prop('disabled', false);

                        }
                    });


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