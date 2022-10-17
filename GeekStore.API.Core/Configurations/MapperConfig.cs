using AutoMapper;
using GeekStore.API.Core.Data.Models;
using GeekStore.API.Core.DTOs.Category;
using GeekStore.API.Core.DTOs.Product;
using Microsoft.EntityFrameworkCore.Query;

namespace GeekStore.API.Core.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {   
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDetailsDto>().ReverseMap();
            CreateMap<Category, DeleteCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDiscountDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryProductsDto>();


            //CreateMap<Category, GetCategoryProductsDto>()
            //    .AfterMap((src, dest) =>
            //    {
            //        dest.Products.ForEach(x => x.Price -= src.CategoryDiscount);
            //    });

            //CreateMap<Product, ProductDto>()
            //    .ForMember(
            //        dest => dest.Price,
            //        opt => opt.MapFrom((src, dest, member, context) => src.Price - src.Category.CategoryDiscount));


            //CreateMap<Category, GetCategoryProductsDto>()
            //    .ConvertUsing<CategoryProductsMapper>();
            //CreateMap<Category, List<ProductDto>>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();

            //CreateMap<Product, ProductDto>()
            //    .ForMember(dest => dest.Price, source => source.MapFrom<GetProductDiscount>())
            //    .ForMember(dest => dest.CategoryName, source => source.MapFrom(s => s.Category.CategoryName));


        }
    }
}
