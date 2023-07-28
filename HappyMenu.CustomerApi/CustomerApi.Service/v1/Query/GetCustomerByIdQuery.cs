using CustomerApi.Data.Entities;
using MediatR;
using System;

namespace CustomerApi.Service.v1.Query
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
