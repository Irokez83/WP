namespace WishApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Preferences",
                c => new
                    {
                        PreferenceId = c.Int(nullable: false, identity: true),
                        Occasions = c.Int(nullable: false),
                        UserPreference = c.String(maxLength: 50),
                        Flowers = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PreferenceId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Preferences", "UserId", "dbo.Users");
            DropIndex("dbo.Preferences", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Preferences");
        }
    }
}
