$(document).ready(function () {

    $(document).ready(function () {
        var rimatripservices = SelectAll4Services();
        $('.textInRow1TheRow1TextContactUsPageStyle').text(rimatripservices[4].Title);
        $('<p>' + rimatripservices[4].Text + '</p>').appendTo('.ShowAllEditorText');

    });


    let IsValidSize = false;
    $('#Fileinput').bind('change', function () {

        if (this.files[0].size > 2000000) {
            IsValidSize = false;
        }
        else {
            IsValidSize = true;
        }
    });
    $('#sendFile').click(function () {
        var inputcheck = $('#Fileinput').val();
        if (inputcheck != "") {
            if (IsValidSize == true) {
                var formdata = new FormData();
                var file = $('#Fileinput')[0];
                formdata.append('file', file.files[0]);
                $.ajax({
                    url: '/api/uploadPdfFCooperation/uploadfile',
                    type: 'POST',
                    data: formdata,
                    contentType: false,
                    processData: false,
                    success: function (imageName) {
                        alert('File Send')
                        location.reload()
                    },

                    error: function () {
                        alert('Error Send')

                    }

                });
            }
            else {
                alert('Filse Size Error');
            }
        }
        else {
            alert('Filse Empty');

        }

    });

})
