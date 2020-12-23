namespace SindCoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addresline2NotRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Complexes", "AddressLine2", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Complexes", "AddressLine2", c => c.String(nullable: false));
        }
    }
}
