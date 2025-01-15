// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const renderCarWorkshopService = (services, container) => {
    container.empty();

    services.map(service => container.append(`
        <div class="card border-secondary mb-3" style="max-width: 18rem;">
            <div class="card-header">${service.cost}</div>
            <div class="card-body">
                <h5 class="card-title">${service.description}</h5>
            </div>
        </div>
        `));
};

const loadCarWorkshopServices = () => {
    const container = $("#services")
    const carWorkshopEncodeName = container.data("encoded-name");

    $.ajax({
        url: `/CarWorkshop/${carWorkshopEncodeName}/CarWorkshopService`,
        type: 'get',
        success: function (data) {
            console.log(data);
            if (!data.length) {
                container.html("There are no service for this car workshop")
            } else {
                renderCarWorkshopService(data, container)
            }
        },
        error: function () {
            toastr["error"]("Something went wrong")
        }
    });
};