namespace TauTau.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MTauTaus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ViewsTimeLine = c.String(),
                        ViewsTimeLine_Right = c.String(),
                        CreateView = c.String(),
                        MusicItem = c.String(),
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MTauTaus");
        }
    }
}
