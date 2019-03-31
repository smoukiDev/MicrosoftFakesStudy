namespace MSFakesStudy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShobDbInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NAME = c.String(),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Goods");
        }
    }
}
