namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Name1", c => c.String());
            AddColumn("dbo.Todoes", "Name2", c => c.String());
            AddColumn("dbo.Todoes", "Name3", c => c.String());
            AddColumn("dbo.Todoes", "Name4", c => c.String());
            AddColumn("dbo.Todoes", "Name5", c => c.String());
            AddColumn("dbo.Todoes", "Name6", c => c.String());
            AddColumn("dbo.Todoes", "Name7", c => c.String());
            DropColumn("dbo.Todoes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Name", c => c.String());
            DropColumn("dbo.Todoes", "Name7");
            DropColumn("dbo.Todoes", "Name6");
            DropColumn("dbo.Todoes", "Name5");
            DropColumn("dbo.Todoes", "Name4");
            DropColumn("dbo.Todoes", "Name3");
            DropColumn("dbo.Todoes", "Name2");
            DropColumn("dbo.Todoes", "Name1");
        }
    }
}
