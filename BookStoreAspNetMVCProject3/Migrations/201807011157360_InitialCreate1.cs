namespace ProjektKsiegarniBCity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItems",
                c => new
                {
                    OrderItemId = c.Int(nullable: false, identity: true),
                    OrderId = c.Int(nullable: false),
                    ArticleId = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Product_CategoryId = c.Int(),
                })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Product_CategoryId)
                .Index(t => t.OrderId)
                .Index(t => t.Product_CategoryId);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderId = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 100),
                    LastName = c.String(nullable: false, maxLength: 150),
                    Address = c.String(nullable: false, maxLength: 150),
                    CodeAndCity = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(nullable: false, maxLength: 20),
                    Email = c.String(nullable: false),
                    Comment = c.String(),
                    DateCreated = c.DateTime(nullable: false),
                    OrderState = c.Int(nullable: false),
                    TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.OrderId);
        }
        
        public override void Down()
        {
        }
    }
}
