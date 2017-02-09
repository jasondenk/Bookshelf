namespace Bookshelf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PublishedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Books", "PubhlishedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "PubhlishedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Books", "PublishedDate");
        }
    }
}
