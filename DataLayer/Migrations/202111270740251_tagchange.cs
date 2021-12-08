namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tagchange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pages", "Tags", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "Tags", c => c.String());
        }
    }
}
