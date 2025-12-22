using Spectra.Models;
using Spectra.Models.DTOs;
using AutoMapper;
using Product = Spectra.Models.Product;

namespace Spectra.Mappings
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            // CreateMap<Source, Destination>();
            // Example:
            // CreateMap<Spectra.Models.Users, Spectra.Models.DTOs.UserDto>();
            // CreateMap<Spectra.Models.DTOs.UserDto, Spectra.Models.Users>();

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
