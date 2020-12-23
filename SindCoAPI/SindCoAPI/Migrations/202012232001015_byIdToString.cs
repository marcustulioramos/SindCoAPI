namespace SindCoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class byIdToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Complexes", "CreatedById", c => c.String(nullable: false));
            AlterColumn("dbo.Complexes", "StatusById", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Complexes", "StatusById", c => c.Int(nullable: false));
            AlterColumn("dbo.Complexes", "CreatedById", c => c.Int(nullable: false));
        }
    }
}
