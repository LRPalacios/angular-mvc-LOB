using System;

namespace ProductManagement.domain
{
    public class Product:BaseEntity
    {
        public string  ProductName { get; set; }

        public string ProductCode { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
