namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCs", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashCs", "Date");
        }
    }
}
