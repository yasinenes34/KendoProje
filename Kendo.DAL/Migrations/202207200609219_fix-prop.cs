namespace Kendo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "StudentNo", c => c.String());
            DropColumn("dbo.Students", "StudnetNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "StudnetNo", c => c.String());
            DropColumn("dbo.Students", "StudentNo");
        }
    }
}
