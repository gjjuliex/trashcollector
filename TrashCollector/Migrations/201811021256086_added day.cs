namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashEs", "Days", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashEs", "Days");
        }
    }
}
