using AutoMapper;
using SklepMai.Core.Functions.Products.Commands.CreateProduct;
using SklepMai.Core.Functions.Products.Queries.GetProductDetail;
using SklepMai.Core.Functions.Products.Queries.GetProductsList;
using SklepMai.Domain.Models;

namespace SklepMai.Core.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, ProductInList>();
            CreateMap<ProductDto, ProductDetail>().ReverseMap();

            //CreateMap<CreateProductCommand, ProductDto>()
            //    .ForMember(des => des.CreatedBy, 
            //        opt => opt.MapFrom(src => src.CreatorId))
            //    .ReverseMap();

            //CreateMap<UpdateProductCommand, ProductDto>()
            //    .ForMember(des => des.CreatedBy, 
            //        opt => opt.MapFrom(src => src.CreatorId))
            //    .ReverseMap();
        }
    }
}