namespace TauTau.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20181220PostDataCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MTauTaus", "PostData1", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData2", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData3", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData4", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData5", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData6", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData7", c => c.String());
            AddColumn("dbo.MTauTaus", "PostData8", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MTauTaus", "PostData8");
            DropColumn("dbo.MTauTaus", "PostData7");
            DropColumn("dbo.MTauTaus", "PostData6");
            DropColumn("dbo.MTauTaus", "PostData5");
            DropColumn("dbo.MTauTaus", "PostData4");
            DropColumn("dbo.MTauTaus", "PostData3");
            DropColumn("dbo.MTauTaus", "PostData2");
            DropColumn("dbo.MTauTaus", "PostData1");
        }
    }
}
