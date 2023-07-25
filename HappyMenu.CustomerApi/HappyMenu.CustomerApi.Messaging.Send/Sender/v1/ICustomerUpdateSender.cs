using HappyMenu.CustomerApi.Domain.Entities;

namespace HappyMenu.CustomerApi.Messaging.Send.Sender.v1
{
    public interface ICustomerUpdateSender
    {

        void SendCustomer(Customer customer);

    }
}
