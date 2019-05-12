namespace Blog_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ShortDescription = c.String(),
                        Description = c.String(),
                        UrlSlug = c.String(),
                        Published = c.Boolean(nullable: false),
                        PostedOn = c.Int(nullable: false),
                        Modified = c.Int(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.Post_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Posts", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Tags", new[] { "Post_Id" });
            DropIndex("dbo.Posts", new[] { "Category_Id" });
            DropTable("dbo.Tags");
            DropTable("dbo.Categories");
            DropTable("dbo.Posts");
        }
    }
}
