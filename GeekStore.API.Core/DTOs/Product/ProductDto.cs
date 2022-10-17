namespace GeekStore.API.Core.DTOs.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}
