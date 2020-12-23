namespace SindCoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountyNotRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Complexes", "County", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Complexes", "County", c => c.String(nullable: false));
        }
    }
}
