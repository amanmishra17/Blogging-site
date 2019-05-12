namespace Blog_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            AddColumn("dbo.Categories", "UrlSlug", c => c.String());
            AddColumn("dbo.Categories", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Description");
            DropColumn("dbo.Categories", "UrlSlug");
            DropColumn("dbo.Categories", "Name");
        }
    }
}
