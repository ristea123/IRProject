namespace IRProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameToGame2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Name");
        }
    }
}
