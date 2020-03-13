namespace IRProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedKeyboardModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Keyboards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        ShortDescription = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Keyboards");
        }
    }
}
