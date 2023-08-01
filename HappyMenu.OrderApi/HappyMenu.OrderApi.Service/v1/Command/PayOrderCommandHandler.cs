using HappyMenu.OrderApi.Data.Repository;
using HappyMenu.OrderApi.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HappyMenu.OrderApi.Service.v1.Command
{
    public class PayOrderCommandHandler : IRequestHandler<PayOrderCommand, Order>
    {
        private readonly IRepository<Order> _repository;

        public PayOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<Order> Handle(PayOrderCommand request, CancellationToken cancellationToken)
        {
            return await _repository.UpdateAsync(request.Order);
        }
    }

}
