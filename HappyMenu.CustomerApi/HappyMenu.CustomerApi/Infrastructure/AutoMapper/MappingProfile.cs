using AutoMapper;
using HappyMenu.CustomerApi.Domain.Entities;
using HappyMenu.CustomerApi.Models.v1;

namespace HappyMenu.CustomerApi.Infrastructure.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerModel, Customer>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<UpdateCustomerModel, Customer>();
        }
    }
}