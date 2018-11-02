namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCs", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TrashCs", "Status");
        }
    }
}
