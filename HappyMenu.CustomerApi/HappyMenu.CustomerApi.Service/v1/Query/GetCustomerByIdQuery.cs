using HappyMenu.CustomerApi.Domain.Entities;
using MediatR;
using System;

namespace HappyMenu.CustomerApi.Service.v1.Query
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
