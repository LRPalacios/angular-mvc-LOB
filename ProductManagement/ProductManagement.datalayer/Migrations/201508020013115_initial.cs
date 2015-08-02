namespace ProductManagement.datalayer.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 60),
                        ProductCode = c.String(nullable: false, maxLength: 10,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "Unique",
                                    new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { Name: ProductCode_Index, IsUnique: True }")
                                },
                            }),
                        Description = c.String(nullable: false, maxLength: 100),
                        ReleaseDate = c.DateTime(nullable: false, storeType: "date"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "ProductCode",
                        new Dictionary<string, object>
                        {
                            { "Unique", "IndexAnnotation: { Name: ProductCode_Index, IsUnique: True }" },
                        }
                    },
                });
        }
    }
}
