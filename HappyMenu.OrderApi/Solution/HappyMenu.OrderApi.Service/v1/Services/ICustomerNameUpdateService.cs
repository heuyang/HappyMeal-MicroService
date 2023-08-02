using HappyMenu.OrderApi.Service.v1.Models;

namespace HappyMenu.OrderApi.Service.v1.Services
{
    public interface ICustomerNameUpdateService
    {
        void UpdateCustomerNameInOrders(UpdateCustomerFullNameModel updateCustomerFullNameModel);
    }
}
