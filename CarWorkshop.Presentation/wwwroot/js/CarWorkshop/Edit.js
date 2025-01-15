$(document).ready(function () {

    loadCarWorkshopServices();

    $("#createCarWorkshopServiceModal form").submit(function (event) {
        event.preventDefault();

        $.ajax({
            url: $(this).attr('action'),
            type: $(this).attr('method'),
            data: $(this).serialize(),
            success: function (data) {
                toastr["success"]("Created carworkshop service")
                loadCarWorkshopServices();
                $("#createCarWorkshopServiceModal").modal("hide");
            },
            error: function () {
                toastr["error"]("Something went wrong")
            }
        })
    });
});

