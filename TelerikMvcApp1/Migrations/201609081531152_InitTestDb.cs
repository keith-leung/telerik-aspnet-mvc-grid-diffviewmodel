namespace TelerikMvcApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitTestDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestEntities",
                c => new
                    {
                        TestEntityId = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Title = c.String(maxLength: 100),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.TestEntityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestEntities");
        }
    }
}
