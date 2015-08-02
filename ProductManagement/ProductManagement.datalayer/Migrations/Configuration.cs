namespace ProductManagement.datalayer.Migrations
{
    using domain;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductManagement.datalayer.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductManagement.datalayer.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Products.AddOrUpdate(
                p => p.ProductCode,
                new Product
                {
                    ProductCode = "GDC-0011",
                    Description = "a Leaf Rake",
                    ProductName = "Leaf Rake",
                    Price = 20,
                    ReleaseDate = new DateTime(2012, 8, 12),
                    ImageUrl = "http://www.bulldogtools.co.uk/gen/thumbs/23k42boczfbxpm25cufr4ybgk4-7w6ta3ag2qvrnvjd7c2ogb44diqtnqju-large.jpg"
                },
                new Product
                {
                    ProductCode = "GDC-0012",
                    Description = "a Hammer",
                    ProductName = "Hammer",
                    Price = 25,
                    ReleaseDate = new DateTime(2013, 9, 12),
                    ImageUrl = "http://s.hswstatic.com/gif/hammer-1.jpg"
                }
                );
        }
    }
}
