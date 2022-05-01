namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "UserImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "UserImage");
        }
    }
}
