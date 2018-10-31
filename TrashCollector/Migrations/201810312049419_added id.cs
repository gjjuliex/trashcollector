namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TrashEs");
            AddColumn("dbo.TrashEs", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TrashEs", "Name", c => c.String());
            AddPrimaryKey("dbo.TrashEs", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TrashEs");
            AlterColumn("dbo.TrashEs", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.TrashEs", "ID");
            AddPrimaryKey("dbo.TrashEs", "Name");
        }
    }
}
