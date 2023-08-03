using System.ComponentModel.DataAnnotations;
using System;

namespace HappyMenu.OrderApi.Models
{
    public class OrderModel
    {
        [Required] public Guid CustomerGuid { get; set; }

        [Required] public string CustomerFullName { get; set; }
    }
}
