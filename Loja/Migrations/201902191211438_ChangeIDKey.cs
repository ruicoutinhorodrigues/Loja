namespace Loja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIDKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Products", "ProductID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "ProductID");
            DropColumn("dbo.Products", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "ProductID");
            AddPrimaryKey("dbo.Products", "ID");
        }
    }
}
