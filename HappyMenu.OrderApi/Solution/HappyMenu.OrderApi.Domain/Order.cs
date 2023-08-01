using System;
using System.Collections.Generic;
using System.Text;

namespace HappyMenu.OrderApi.Domain
{
    public class Order
    {

        public Guid Id { get; set; }
        public int OrderState { get; set; }
        public Guid CustomerGuid { get; set; }
        public string CustomerFullName { get; set; }


    }
}
