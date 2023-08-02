using HappyMenu.OrderApi.Domain;
using MediatR;
using System.Collections.Generic;

namespace HappyMenu.OrderApi.Service.v1.Command
{
    public class UpdateOrderCommand : IRequest
    {
        public List<Order> Orders { get; set; }
    }
}
