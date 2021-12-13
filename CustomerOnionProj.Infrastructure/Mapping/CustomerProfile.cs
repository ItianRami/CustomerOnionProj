using AutoMapper;
using CustomerOnionProj.Domain.Entities;
using CustomerOnionProj.Infrastructure.ViewModel;

namespace CustomerOnionProj.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
