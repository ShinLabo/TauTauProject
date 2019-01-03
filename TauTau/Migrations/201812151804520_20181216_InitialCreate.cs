namespace TauTau.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20181216_InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MTauTaus", "MusicItem", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MTauTaus", "MusicItem");
        }
    }
}
