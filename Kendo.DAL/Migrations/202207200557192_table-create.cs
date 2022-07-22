namespace Kendo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablecreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StudentSurname = c.String(),
                        StudnetUniversity = c.String(),
                        StudnetNo = c.String(),
                        ExcamScore = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Students");
        }
    }
}
