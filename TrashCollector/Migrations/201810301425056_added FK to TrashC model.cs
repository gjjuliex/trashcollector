namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFKtoTrashCmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCs", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.TrashCs", "ApplicationUserId");
            AddForeignKey("dbo.TrashCs", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrashCs", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.TrashCs", new[] { "ApplicationUserId" });
            DropColumn("dbo.TrashCs", "ApplicationUserId");
        }
    }
}
