using MediatR;

namespace CarWorkshop.Application.CarWorkshopService.Commands
{
    public class CreateCarWorkshopServiceCommand : CarWorkshopServiceDto, IRequest
    {
        public string CarWorkshopEndodedName { get; set; } = default!;
    }
}
