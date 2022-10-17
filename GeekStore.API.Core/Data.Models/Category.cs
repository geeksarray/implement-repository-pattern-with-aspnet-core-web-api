using System;
using System.Collections.Generic;

namespace GeekStore.API.Core.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CategoryDiscount { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
