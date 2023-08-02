using HappyMenu.OrderApi.Domain;
using MediatR;
using System;
using System.Collections.Generic;

namespace HappyMenu.OrderApi.Service.v1.Query
{
    public class GetOrderByCustomerGuidQuery : IRequest<List<Order>>
    {
        public Guid CustomerCuid { get; set; }
    }
}
