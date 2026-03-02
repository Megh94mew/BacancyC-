using AutoMapper;
using YourProject.Models;
using YourProject.DTOs;

namespace YourProject.Mapping
{
        public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, productReadDto>();
            CreateMap<productCreateDto, Product>();
            CreateMap<ProductUpdateDTo, Product>();
        }
    }
}