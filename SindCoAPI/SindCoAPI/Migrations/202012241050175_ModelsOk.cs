namespace SindCoAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsOk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Apartments", "CreatedById", c => c.String(nullable: false));
            AlterColumn("dbo.Apartments", "StatusById", c => c.String(nullable: false));
            AlterColumn("dbo.Buildings", "CreatedById", c => c.String(nullable: false));
            AlterColumn("dbo.Buildings", "StatusById", c => c.String(nullable: false));
            AlterColumn("dbo.Buildings", "AddressLine2", c => c.String(nullable: false));
            AlterColumn("dbo.Blocks", "CreatedById", c => c.String(nullable: false));
            AlterColumn("dbo.Blocks", "StatusById", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blocks", "StatusById", c => c.Int(nullable: false));
            AlterColumn("dbo.Blocks", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Buildings", "AddressLine2", c => c.String());
            AlterColumn("dbo.Buildings", "StatusById", c => c.Int(nullable: false));
            AlterColumn("dbo.Buildings", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Apartments", "StatusById", c => c.Int(nullable: false));
            AlterColumn("dbo.Apartments", "CreatedById", c => c.Int(nullable: false));
        }
    }
}
