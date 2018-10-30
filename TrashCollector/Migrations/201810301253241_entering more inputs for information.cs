namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enteringmoreinputsforinformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrashCs", "State", c => c.String());
            AlterColumn("dbo.TrashCs", "Zipcode", c => c.String());
            AlterColumn("dbo.TrashCs", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TrashCs", "Address", c => c.Int(nullable: false));
            AlterColumn("dbo.TrashCs", "Zipcode", c => c.Int(nullable: false));
            DropColumn("dbo.TrashCs", "State");
        }
    }
}
