namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedaquestionmarktodatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrashCs", "StartDate", c => c.DateTime());
            AlterColumn("dbo.TrashCs", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCs", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TrashCs", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
