using AutoMapper;
using SklepMai.Core.Functions.Products.Queries;
using SklepMai.Domain.Models;

namespace SklepMai.Core.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductInList, ProductDto>().ReverseMap();
        }
    }
}