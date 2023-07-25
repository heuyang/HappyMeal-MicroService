using HappyMenu.CustomerApi.Domain.Entities;
using MediatR;

namespace HappyMenu.CustomerApi.Service.v1.Command
{
    public class UpdateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
