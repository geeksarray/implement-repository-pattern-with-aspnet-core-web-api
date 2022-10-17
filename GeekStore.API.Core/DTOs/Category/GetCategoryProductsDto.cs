using GeekStore.API.Core.DTOs.Product;
using Microsoft.EntityFrameworkCore.Query;
using GeekStore.API.Core.Data.Models;

namespace GeekStore.API.Core.DTOs.Category
{
    public class GetCategoryProductsDto
    {
        public int Id { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public int CategoryDiscount { get; set; }

        public List<ProductDto> Products {  get; set; }                  
        
    }
}
