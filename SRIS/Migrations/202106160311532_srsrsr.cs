namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class srsrsr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServiceRequests", "OfficeDepartmentSr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ServiceRequests", "OfficeDepartmentSr");
        }
    }
}
