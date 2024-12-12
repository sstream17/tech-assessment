using AutoMapper;
using Orders.Core.Contracts;
using Orders.Infrastructure.EntityFramework.Models;

namespace Orders.Infrastructure.Mapping
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderBody, Order>().ReverseMap();

            CreateMap<CustomerBody, Customer>().ReverseMap();

            CreateMap<ItemBody, Item>().ReverseMap();
        }
    }
}
