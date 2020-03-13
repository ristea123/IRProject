namespace IRProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedViewModelAllItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ViewModelAllItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ViewModelAllItems");
        }
    }
}
