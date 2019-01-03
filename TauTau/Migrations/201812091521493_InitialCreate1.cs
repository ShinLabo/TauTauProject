namespace TauTau.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MTauTaus", "Main_View_TimeLine", c => c.String());
            DropColumn("dbo.MTauTaus", "ViewsTimeLine");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MTauTaus", "ViewsTimeLine", c => c.String());
            DropColumn("dbo.MTauTaus", "Main_View_TimeLine");
        }
    }
}
