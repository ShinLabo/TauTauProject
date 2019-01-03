namespace TauTau.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MTauTaus", "ViewsTimeLine_Right");
            DropColumn("dbo.MTauTaus", "CreateView");
            DropColumn("dbo.MTauTaus", "MusicItem");
            DropColumn("dbo.MTauTaus", "PostData1");
            DropColumn("dbo.MTauTaus", "PostData2");
            DropColumn("dbo.MTauTaus", "PostData3");
            DropColumn("dbo.MTauTaus", "PostData4");
            DropColumn("dbo.MTauTaus", "PostData5");
            DropColumn("dbo.MTauTaus", "PostData6");
            DropColumn("dbo.MTauTaus", "PostData7");
            DropColumn("dbo.MTauTaus", "PostData8");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MTauTaus", "PostData8", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData7", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData6", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData5", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData4", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData3", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData2", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData1", c => c.String());
            AddColumn("dbo.MTauTaus", "MusicItem", c => c.String());
            AddColumn("dbo.MTauTaus", "CreateView", c => c.String());
            AddColumn("dbo.MTauTaus", "ViewsTimeLine_Right", c => c.String());
        }
    }
}
