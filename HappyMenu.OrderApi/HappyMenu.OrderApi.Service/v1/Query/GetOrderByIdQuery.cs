using HappyMenu.OrderApi.Domain;
using MediatR;
using System;

namespace HappyMenu.OrderApi.Service.v1.Query
{
    public class GetOrderByIdQuery : IRequest<Order>
    {
        public Guid Id { get; set; }
    }
}
