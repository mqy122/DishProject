namespace Dishes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishMigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Dishtype = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DishTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DishType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishTypes", t => t.DishType_Id)
                .Index(t => t.DishType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DishTypes", "DishType_Id", "dbo.DishTypes");
            DropIndex("dbo.DishTypes", new[] { "DishType_Id" });
            DropTable("dbo.DishTypes");
            DropTable("dbo.Dishes");
        }
    }
}
