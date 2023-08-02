using HappyMenu.OrderApi.Domain;
using MediatR;

namespace HappyMenu.OrderApi.Service.v1.Command
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public Order Order { get; set; }
    }
}
