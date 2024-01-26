namespace Prcatice24_2PM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entitesses",
                c => new
                    {
                        EnId = c.Int(nullable: false, identity: true),
                        EnName = c.String(nullable: false, maxLength: 50),
                        EnAddress = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.EnId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entitesses");
        }
    }
}
