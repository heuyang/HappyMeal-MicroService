using AutoMapper;
using HappyMenu.OrderApi.Domain;
using HappyMenu.OrderApi.Models;

namespace HappyMenu.OrderApi.Infrastructure.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderModel, Order>()
                .ForMember(x => x.OrderState, opt => opt.MapFrom(src => 1));
        }
    }
}
