namespace Blog_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagModelAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tags", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Tags", new[] { "Post_Id" });
            CreateTable(
                "dbo.TagPosts",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        Post_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Post_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.Post_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Post_Id);
            
            AddColumn("dbo.Tags", "Name", c => c.String());
            AddColumn("dbo.Tags", "UrlSlug", c => c.String());
            AddColumn("dbo.Tags", "Description", c => c.String());
            DropColumn("dbo.Tags", "Post_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "Post_Id", c => c.Int());
            DropForeignKey("dbo.TagPosts", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.TagPosts", "Tag_Id", "dbo.Tags");
            DropIndex("dbo.TagPosts", new[] { "Post_Id" });
            DropIndex("dbo.TagPosts", new[] { "Tag_Id" });
            DropColumn("dbo.Tags", "Description");
            DropColumn("dbo.Tags", "UrlSlug");
            DropColumn("dbo.Tags", "Name");
            DropTable("dbo.TagPosts");
            CreateIndex("dbo.Tags", "Post_Id");
            AddForeignKey("dbo.Tags", "Post_Id", "dbo.Posts", "Id");
        }
    }
}
