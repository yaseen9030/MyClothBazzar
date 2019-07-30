namespace MyClothBazzar.DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Innitilize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoreys",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Size = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        CategoreysTB_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categoreys", t => t.CategoreysTB_id)
                .Index(t => t.CategoreysTB_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoreysTB_id", "dbo.Categoreys");
            DropIndex("dbo.Products", new[] { "CategoreysTB_id" });
            DropTable("dbo.Products");
            DropTable("dbo.Categoreys");
        }
    }
}
