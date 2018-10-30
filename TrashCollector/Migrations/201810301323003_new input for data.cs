namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newinputfordata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCs", "City", c => c.String());
            AddColumn("dbo.TrashCs", "ExtraPickUp", c => c.DateTime(nullable: false));
            DropColumn("dbo.TrashCs", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrashCs", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.TrashCs", "ExtraPickUp");
            DropColumn("dbo.TrashCs", "City");
        }
    }
}
