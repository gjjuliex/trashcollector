namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtrashemodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashEs", "ZipCode", c => c.Int(nullable: false));
            DropColumn("dbo.TrashEs", "CustomerBill");
            DropColumn("dbo.TrashEs", "TrashPickUpStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TrashEs", "TrashPickUpStatus", c => c.String());
            AddColumn("dbo.TrashEs", "CustomerBill", c => c.Double(nullable: false));
            DropColumn("dbo.TrashEs", "ZipCode");
        }
    }
}
