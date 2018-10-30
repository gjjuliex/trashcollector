namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TrashCs", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrashCs", "Date", c => c.DateTime(nullable: false));
        }
    }
}
