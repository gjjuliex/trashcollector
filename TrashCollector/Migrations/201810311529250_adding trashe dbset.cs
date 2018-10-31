namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingtrashedbset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrashEs",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        CustomerBill = c.Double(nullable: false),
                        TrashPickUpStatus = c.String(),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrashEs", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.TrashEs", new[] { "ApplicationUserId" });
            DropTable("dbo.TrashEs");
        }
    }
}
