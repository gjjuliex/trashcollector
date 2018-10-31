namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTrashEforemployees : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrashCs", "ExtraPickUp", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCs", "ExtraPickUp", c => c.DateTime(nullable: false));
        }
    }
}
