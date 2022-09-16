using AutoMapper;
using entity_framework_automapper.Models;

namespace entity_framework_automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductApiModel>();
            CreateMap<ProductApiModel, Product>();

            CreateMap<Order, Product>()
                .ForMember(member1 => member1.RecordDate, member2 => member2.MapFrom(x => x.product.RecordDate))
                .ForMember(member1 => member1.ID, member2 => member2.MapFrom(x => x.product.ID))
                .ForMember(member1 => member1.Name, member2 => member2.MapFrom(x => x.product.Name))
                .ForMember(member1 => member1.Count, member2 => member2.MapFrom(x => x.product.Count));

            CreateMap<Order, Customer>()
                .ForMember(member1 => member1.CustomerName, member2 => member2.MapFrom(x => x.customer.CustomerName));

            //CreateMap<Product, Order>()
            //    .ForMember(member1 => member1.product.Name, member2 => member2.MapFrom(x => x.Name))
            //    .ForMember(member1 => member1.product.Count, member2 => member2.MapFrom(x => x.Count))
            //    .ForMember(member1 => member1.product.ID, member2 => member2.MapFrom(x => x.ID))
            //    .ForMember(member1 => member1.product.RecordDate, member2 => member2.MapFrom(x => x.RecordDate));
            //
            //CreateMap<Customer, Order>()
            //    .ForMember(member1 => member1.customer.CustomerName, member2 => member2.MapFrom(x => x.CustomerName));
        }
    }
}
