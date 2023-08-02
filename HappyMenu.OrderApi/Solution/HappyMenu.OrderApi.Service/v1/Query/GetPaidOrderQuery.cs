using HappyMenu.OrderApi.Domain;
using MediatR;
using System.Collections.Generic;

namespace HappyMenu.OrderApi.Service.v1.Query
{
    public class GetPaidOrderQuery : IRequest<List<Order>>
    {
    }
}
