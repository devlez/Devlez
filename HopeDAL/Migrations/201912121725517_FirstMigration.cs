namespace HopeDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        NewsName = c.String(),
                        NewsDescription = c.String(),
                        NewsTitle = c.String(),
                        NewsSubTitle = c.String(),
                        Content = c.String(),
                        ImagePath = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NewsId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "CategoryId", "dbo.Categories");
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropTable("dbo.News");
            DropTable("dbo.Categories");
        }
    }
}
