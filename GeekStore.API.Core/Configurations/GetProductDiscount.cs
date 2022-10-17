using AutoMapper;
using GeekStore.API.Core.Data.Models;
using GeekStore.API.Core.DTOs.Product;

namespace GeekStore.API.Core.Configurations
{
    public class GetProductDiscount : IValueResolver<Product, ProductDto, decimal>
    {
        public decimal Resolve(Product source, ProductDto destination, decimal destMember, ResolutionContext context)
        {
            return source.Price - source.Category.CategoryDiscount;
        }
    }
}
