namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madezipcodeanint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TrashCs", "Zipcode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCs", "Zipcode", c => c.String());
        }
    }
}
