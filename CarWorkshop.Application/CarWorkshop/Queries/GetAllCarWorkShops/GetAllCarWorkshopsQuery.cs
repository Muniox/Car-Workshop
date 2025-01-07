using MediatR;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetAllCarWorkShops
{
    public class GetAllCarWorkshopsQuery : IRequest<IEnumerable<CarWorkshopDto>>
    {
    }
}
