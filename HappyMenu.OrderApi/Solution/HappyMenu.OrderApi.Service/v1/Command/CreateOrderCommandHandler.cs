using HappyMenu.OrderApi.Data.Repository;
using HappyMenu.OrderApi.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HappyMenu.OrderApi.Service.v1.Command
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
    {
        private readonly IRepository<Order> _repository;

        public CreateOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AddAsync(request.Order);
        }
    }
}
