$(document).ready(function () {

    const renderCarWorkshopService = (services, container) => {
        container.empty();

        services.map(service => container.append(`
        <div class="card border-secondary mb-3" style="max-width: 18rem;">
            <div>${service.cost}</div>
        </div>
        `))
    }

    const loadCarWorkshopServices = () => {
        const container = $("#services")
        const carWorkshopEncodeName = container.data("encodeName");

        $.ajax({
            url: `/CarWorkshop/${carWorkshopEncodeName}/CarWorkshopService`,
            type: 'get',
            success: function (data) {
                if (!data.length) {
                    container.html("There are no service for this car workshop")
                } else {
                    renderCarWorkshopService(data, container)
                }
            },
            error: function () {
                toastr["error"]("Something went wrong")
            }
        })
    }
    




    $("#createCarWorkshopServiceModal form").submit(function (event) {
        event.preventDefault();

        $.ajax({
            url: $(this).attr('action'),
            type: $(this).attr('method'),
            data: $(this).serialize(),
            success: function (data) {
                toastr["success"]("Created carworkshop service")
            },
            error: function () {
                toastr["error"]("Something went wrong")
            }
        })
    });
});

