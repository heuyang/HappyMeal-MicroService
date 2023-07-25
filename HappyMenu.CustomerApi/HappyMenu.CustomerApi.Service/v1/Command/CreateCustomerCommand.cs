using HappyMenu.CustomerApi.Domain.Entities;
using MediatR;

namespace HappyMenu.CustomerApi.Service.v1.Command
{
    public class CreateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
